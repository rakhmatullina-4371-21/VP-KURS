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
        employee emp;
        orders ord = new orders();
        content_orders cont = new content_orders();
        public ORDER_ADD( employee emp)
        {
            InitializeComponent();
            this.emp = emp;
            selectList.DataSource = list_of_dishes.SelectListDishAva();
            var comboList = list_of_table.ComboTab(emp);
            foreach (int i in comboList)
            {
                comboTable.Items.Add(i);
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
            content_orders.list.Clear();
        }


        private void selectList_MouseClick(object sender, MouseEventArgs e)
        {
            cont.id_dish =((int)selectList.SelectedCells[0].OwningRow.Cells[0].Value);
            this.selectList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.selectList.Rows[selectList.CurrentRow.Index].DefaultCellStyle.BackColor =ColorTranslator.FromHtml("#a8a8a8");
            comboBox1.Visible = true;
            label1.Visible = true;
            selectList.Visible = false;
            this.selectList.MultiSelect = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            MessageForm f;
            string notSave = "З А К А З   Н Е   Б Ы Л   С О Х Р А Н Е Н";
            if (content_orders.list.Count!= 0)
            {

                   try
                   {
                          ord.id_order=ord.SaveOrd(emp.id_employee, (int)comboTable.SelectedItem);
                          f = new MessageForm($"З А К А З  №  {ord.id_order}\r\n У С П Е Ш Н О  С О Х Р А Н Е Н"); f.ShowDialog(); orders.ListDishesinOrd.Clear();
                          MENU_ADM_WAITER waiter = new MENU_ADM_WAITER(2, emp);
                          waiter.Location = this.Location;
                          waiter.Size = this.Size; waiter.Show(); this.Hide();
                          content_orders.list.Clear();
                   }
                    catch { f = new MessageForm(notSave); f.ShowDialog(); }
            }
            else {f = new MessageForm("В Ы Б Е Р И Т Е   Х О Т Я   Б Ы \r\nО Д Н О   Б Л Ю Д О"); f.ShowDialog(); }
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
                if (!content_orders.list.ContainsKey(list_of_dishes.SearchDish((int)cont.id_dish))) 
                {
                    content_orders.list.Add(list_of_dishes.SearchDish((int)cont.id_dish), cont.count_dish);
                }
                cont.ListDihInOrder((int)cont.id_dish, cont.count_dish);

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
            save.Visible = true;
            buttonSelOrd.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ORDER_SELECT selectOrd = new ORDER_SELECT();
            selectOrd.ShowDialog();
        }

        private void comboSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_of_dishes dish = new list_of_dishes();
            selectList.DataSource= dish.SelectListDish(comboSelection.SelectedItem.ToString());
            selectList.Columns[0].Visible = false;
            selectList.Columns[1].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
            selectList.Columns[2].Visible = false;
            selectList.Columns[3].HeaderText = "  РАЗДЕЛ";
            selectList.Columns[4].HeaderText = "  ЦЕНА";
        }

        private void comboSelection_MouseClick(object sender, MouseEventArgs e)
        {
            selectList.DataSource = list_of_dishes.SelectListDishAva();
            selectList.Columns[0].Visible = false;
            selectList.Columns[1].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
            selectList.Columns[2].Visible = false;
            selectList.Columns[3].HeaderText = "  РАЗДЕЛ";
            selectList.Columns[4].HeaderText = "  ЦЕНА";
        }

        private void comboSelection_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
