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
                comboBox1.Items.Add(i);
            }
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
           selectList.DataSource= ord.SelectOrder(int.Parse(comboBox1.SelectedItem.ToString()));
            selectList.Columns[0].HeaderText ="ЗАКАЗ №";
            selectList.Columns[1].Visible = false;
            selectList.Columns[2].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
            selectList.Columns[3].HeaderText = "  КОЛИЧЕСТВО";
            selectList.Columns[4].HeaderText = "  СКИДКА";
            selectList.Columns[5].HeaderText = "  ЦЕНА";
            selectList.Columns[6].HeaderText = "  ВРЕМЯ";
        }
    }
}
