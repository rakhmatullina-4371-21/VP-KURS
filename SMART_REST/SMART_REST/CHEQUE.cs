using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_REST
{
    public partial class CHEQUE : Form
    {
        employee emp = new employee();
        orders ord = new orders();

        public CHEQUE( employee emp )
        {
            InitializeComponent();
            this.emp = emp;
            var comboList = ord.SelectOrder(emp);
            foreach (int i in comboList)
            {
                comboBoxOrd.Items.Add(i);
            }
            update.Visible = false;
        }

        private void CHEQUE_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void close_Click(object sender, EventArgs e)
        {
            MENU_ADM_WAITER waiter = new MENU_ADM_WAITER(2, emp);
            waiter.Location = this.Location;
            waiter.Size = this.Size; waiter.Show(); this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectList.DataSource = ord.SelectOrder(int.Parse(comboBoxOrd.SelectedItem.ToString()));
                selectList.Columns[0].Visible = false;
                selectList.Columns[1].HeaderText = "ЗАКАЗ №";
                selectList.Columns[2].Visible = false;
                selectList.Columns[3].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
                selectList.Columns[4].HeaderText = "  КОЛИЧЕСТВО";
                selectList.Columns[5].HeaderText = "  ЦЕНА";
                buttonOut.Visible = true;
                textBoxInf.Text = ord.SelectInformOrd(int.Parse(comboBoxOrd.SelectedItem.ToString()));
                update.Visible = true;
            }
            catch
            {
                MessageForm f = new MessageForm(" З А К А З  Н Е  Н А Й Д Е Н");
                f.ShowDialog();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ord.DeleteOrd(int.Parse(comboBoxOrd.SelectedItem.ToString()));
                MessageForm f = new MessageForm("У С П Е Ш Н О !");
                f.ShowDialog();
                MENU_ADM_WAITER waiter = new MENU_ADM_WAITER(2, emp);
                waiter.Location = this.Location;
                waiter.Size = this.Size; waiter.Show(); this.Hide();

            }
            catch { MessageForm f = new MessageForm("З А К А З  Н Е  У Д А Л Е Н"); f.ShowDialog(); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ORDER_SELECT ordEdit = new ORDER_SELECT(ord.SelectOrder(int.Parse(comboBoxOrd.SelectedItem.ToString())),emp);
            ordEdit.Show();
            this.Hide();
        }
    }
}
