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
        public CHEQUE( employee emp )
        {
            InitializeComponent();
            this.emp = emp;
            orders ord = new orders();
            var comboList =ord.SelOrd(emp);
            foreach (orders i in comboList)
            {
                comboBox1.Items.Add(i.id_order);
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
    }
}
