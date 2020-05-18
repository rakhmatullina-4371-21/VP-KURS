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
    public partial class INPUT : Form
    {
        
        public INPUT()
        {
            InitializeComponent();
        }

        private void INPUT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void inputt_Click(object sender, EventArgs e)
        {
            try
            {
                employee emp = new employee(login.Text, password.Text);
                switch (emp.id_position.ToString())
                {
                    case "1":
                        MENU_ADM_WAITER admin = new MENU_ADM_WAITER(1,emp);
                        admin.Location = this.Location;
                        admin.Size = this.Size; admin.Show(); this.Hide();
                        break;
                    case "2":
                        
                        MENU_ADM_WAITER waiter = new MENU_ADM_WAITER(2, emp);
                        waiter.Location = this.Location;
                        waiter.Size = this.Size; waiter.Show(); this.Hide();
                        break;
                    default:
                        NoInput.Visible = true; NoInput2.Visible = true;
                        break;
                }
        }
            catch { MessageForm f = new MessageForm(); f.ShowDialog(); }


}

    }
}
