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
    public partial class MENU_ADM_WAITER : Form
    {
        employee emp;
        public MENU_ADM_WAITER(int a, employee emp)
        {

            InitializeComponent();
            this.emp = emp;
            if (emp.lastname == null) { emp.lastname = ""; }
            label1.Text = $"  {emp.surname.ToUpper()} {emp.name.ToUpper()} {emp.lastname.ToUpper()}" ;
            switch (a) 
            {
                case 1: { dish.Visible = true; stock.Visible = true; employee.Visible = true;} break;
                case 2: { selcheq.Visible = true; addord.Visible = true; } break;
               
            }
        }


        SELECT_LIST list;
        private void employee_Click(object sender, EventArgs e)
        {
            list = new SELECT_LIST(0, emp);
            list.Location = this.Location;
            list.Size = this.Size;
            list.Show();
            this.Hide();
        }

        private void dish_Click(object sender, EventArgs e)
        {
            list = new SELECT_LIST(1, emp);
            list.Location = this.Location;
            list.Size = this.Size;
            list.Show();
            this.Hide();
        }

        private void stock_Click(object sender, EventArgs e)
        {
            list = new SELECT_LIST(2, emp);
            list.Location = this.Location;
            list.Size = this.Size;
            list.Show();
            this.Hide();
        }

        private void exist_Click(object sender, EventArgs e)
        {
            INPUT input = new INPUT();
            input.Location = this.Location;
            input.Size = this.Size;
            input.Show();
            this.Hide();
            
        }

        private void MENU_ADM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addord_Click(object sender, EventArgs e)
        {
            orders ord = new orders();
            ORDER_ADD addOrd = new ORDER_ADD(emp);
            addOrd.Location = this.Location;
            addOrd.Size = this.Size;
            addOrd.Show();
            this.Hide();
        }

        private void selcheq_Click(object sender, EventArgs e)
        {
            CHEQUE check = new CHEQUE(emp);
            check.Location = this.Location;
            check.Size = this.Size;
            check.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
