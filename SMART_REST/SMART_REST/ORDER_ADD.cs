using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMART_REST
{
    public partial class ORDER_ADD : Form
    {
        list_of_dishes dish=new list_of_dishes();
        employee emp;
        orders ord = new orders();
        content_orders cont = new content_orders();
        public ORDER_ADD( employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            selectList.DataSource = dish.SelectListDishAva();
            var comboList = list_of_table.ComboTab();
            foreach (list_of_table i in comboList)
            {
                comboTable.Items.Add(i.name_table);
            }
            var comboselection = menu.ComboSel();
            foreach (menu i in comboselection)
            {
                comboSelection.Items.Add(i.name_selection);
            }
            selectList.Columns[0].Visible = false;
            selectList.Columns[1].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
            selectList.Columns[2].Visible = false;
            selectList.Columns[3].HeaderText = "  РАЗДЕЛ";
            selectList.Columns[4].HeaderText = "  ЦЕНА";
             ord.id_order=ord.AddOrd();

        }

        private void ORDER_ADD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void close_Click(object sender, EventArgs e)
        {
            MENU_ADM_WAITER waiter = new MENU_ADM_WAITER(2, emp);
            waiter.Location = this.Location;
            waiter.Size = this.Size; waiter.Show(); this.Hide();
        }


        private void selectList_MouseClick(object sender, MouseEventArgs e)
        {
            cont.id_dish = (int)selectList.SelectedCells[0].OwningRow.Cells[0].Value;
            this.selectList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.selectList.Rows[selectList.CurrentRow.Index].DefaultCellStyle.BackColor =ColorTranslator.FromHtml("#a8a8a8");
            comboBox1.Visible = true;
            label1.Visible = true;
            selectList.Visible = false;
            this.selectList.MultiSelect = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (content_orders.ListOrder.Count != 0)
            {
                //try
                //{
                    ord.SaveOrd(ord.id_order, emp.id_employee, list_of_table.SelectTab(comboTable.SelectedItem));
                    cont.SaveCont(ord.id_order);
                    MessageForm f = new MessageForm($"З А К А З  №  {ord.id_order}\r\n У С П Е Ш Н О  С О Х Р А Н Е Н"); f.ShowDialog();
                //}
                //catch { MessageForm f = new MessageForm("З А К А З   Н Е   Б Ы Л   С О Х Р А Н Е Н"); f.ShowDialog(); }
            }
            else { MessageForm f = new MessageForm("В Ы Б Е Р И Т Е   Х О Т Я   Б Ы \r\nО Д Н О   Б Л Ю Д О"); f.ShowDialog(); }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cont.count_dish =int.Parse(comboBox1.SelectedItem.ToString());
            if (cont.count_dish == 0)
            {
                this.selectList.Rows[selectList.CurrentRow.Index].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                content_orders.ListContOrder(cont.id_dish, cont.count_dish);
            }
                selectList.Visible = true;
                label1.Visible = false;
                comboBox1.Visible = false;
            
           
        }

        private void comboTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTable.Visible = false;
            comboTable.Visible = false;
            selectList.Visible = true;
            comboSelection.Visible = true;
            labelSelection.Visible = true;
            textCearch.Visible = true;
            search.Visible = true;
            save.Visible = true;
            buttonSelOrd.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ORDER_EDIT selectOrd = new ORDER_EDIT();
            selectOrd.ShowDialog();
        }
    }
}
