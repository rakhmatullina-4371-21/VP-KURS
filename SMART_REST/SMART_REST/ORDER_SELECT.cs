using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_REST
{
    public partial class ORDER_SELECT : Form
    {
        employee emp;
        public ORDER_SELECT(List<dynamic> listOrder,employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            this.button1.Visible = true;
            selectList.DataSource = listOrder;
            selectList.Columns[0].Visible = false;
            selectList.Columns[1].HeaderText = "ЗАКАЗ №";
            selectList.Columns[2].Visible = false;
            selectList.Columns[3].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
            selectList.Columns[4].HeaderText = "  КОЛИЧЕСТВО";
            selectList.Columns[5].HeaderText = "  ЦЕНА";
        }
        public ORDER_SELECT()
        {
            InitializeComponent();
            save.Visible = true;
            selectList.DataSource = content_orders.list.ToArray();
            selectList.Columns[0].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
            selectList.Columns[1].HeaderText = "  КОЛИЧЕСТВО";
            button1.Visible=false;
        }
        private void ORDER_EDIT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CHEQUE check = new CHEQUE(emp);
            check.Location = this.Location;
            check.Size = this.Size;
            check.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cont.count_dish = int.Parse(comboBox1.SelectedItem.ToString());
            if (selectList.RowCount != 1 && cont.count_dish!=0 ) 
            {
                selectList.Visible = true;
                label1.Visible = false;
                comboBox1.Visible = false;
                cont.EditContOrd(cont.id_content_order, cont.count_dish);
            }
            else { MessageForm f = new MessageForm("В   З А К А З Е   Д О Л Ж Н О  Б Ы Т Ь \r\nХ О Т Я   Б Ы   О Д Н О   Б Л Ю Д О"); f.ShowDialog(); }
        }
        content_orders cont = new content_orders();
        private void selectList_MouseClick(object sender, MouseEventArgs e)
        {
           
           cont.id_content_order = (int)selectList.SelectedCells[0].OwningRow.Cells[0].Value;
            selectList.Visible = false;
            label1.Visible = true;
            comboBox1.Visible = true;
        }
    }
}
