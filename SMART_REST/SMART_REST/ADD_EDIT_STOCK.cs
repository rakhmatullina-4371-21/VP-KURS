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
    public partial class ADD_EDIT_STOCK : Form
    {
        stocks stock;
        employee emp;
        public ADD_EDIT_STOCK(employee emp,stocks stock)
        {
            this.emp = emp;
            this.stock = stock;
            InitializeComponent();
            maskedStart.Text = $"{stock.start_time}";
            maskedEnd.Text =$"{ stock.end_time}";
            maskedDiscount.Text = stock.discount.ToString();
        }
        public ADD_EDIT_STOCK(employee emp, int id)
        {
            stock = new stocks();
            this.emp = emp;
            stock.id_stock = id;
            InitializeComponent();
        }
        private void ADD_EDIT_STOCK_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                    switch (stock.SaveStock(stock.id_stock, maskedStart.Text, maskedEnd.Text, int.Parse(maskedDiscount.Text))) 
                    {
                        case 0:labelEr.Visible = true; break;
                        case 1: labelEr1.Visible = true; break;
                        case 2: labelEr.Visible = true; labelEr1.Visible = true; break;
                        case 3: label6.Visible = true; break;
                        default:
                            SELECT_LIST selList = new SELECT_LIST(2, emp);
                            selList.Location = this.Location;
                            selList.Show();
                            this.Hide();
                            break;

                    }
            }
            catch { labelEr.Visible = true;labelEr1.Visible = true; }
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            SELECT_LIST selList = new SELECT_LIST(2, emp);
            selList.Location = this.Location;
            selList.Size = this.Size;
            selList.Show();
            this.Hide();
        }
    }
}
