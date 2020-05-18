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
        //orders ord = new orders();
        //employee emp;
        //list_of_table table = new list_of_table();
        //public ORDER_EDIT(int id_ord, List<int> id_dish, employee emp, int id_table)
        //{
        //    this.emp = emp;
        //    InitializeComponent();
        //    table.id_table = id_table;
        //    ord.id_order = id_ord;
        //    list_of_dishes dish = new list_of_dishes();
        //    var comboselection = dish.SelectListDishMenu(id_dish);
        //    selectList.DataSource = comboselection;
        //    selectList.Columns[0].Visible = false;
        //    selectList.Columns[1].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
        //    selectList.Columns[2].HeaderText = "  ЦЕНА";
        //    selectList.Columns[3].HeaderText = "  КОЛИЧЕСТВО";

        //}
        public ORDER_SELECT()
        {
            InitializeComponent();
            content_orders con = new content_orders();
            selectList.DataSource = content_orders.list.ToArray();
            selectList.Columns[0].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
            selectList.Columns[1].HeaderText = "  КОЛИЧЕСТВО";

        }
        private void ORDER_EDIT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
