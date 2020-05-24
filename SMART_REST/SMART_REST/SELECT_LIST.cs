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
    public partial class SELECT_LIST : Form
    {
        ADD_EDIT_DISH addEditDish;
        ADD_EDIT_EMPLOYEE addEditEmp;
        ADD_EDIT_STOCK addEditstock;
        int item;
        employee emp;
        stocks stock = new stocks();
        list_of_dishes dish = new list_of_dishes();
        public SELECT_LIST( int item,  employee emp)
        {
            InitializeComponent();
            this.item = item;
            this.emp = emp;
            try {
                switch (item)
                {
                    case 0:
                        {
                            comboBoxItem.Visible = true;
                            selectList.DataSource = emp.SelectListEmp();
                            selectList.Columns[0].Visible = false;
                            selectList.Columns[1].HeaderText = "ФАМИЛИЯ";
                            selectList.Columns[2].HeaderText = "ИМЯ";
                            selectList.Columns[3].HeaderText = "ОТЧЕСТВО";
                            selectList.Columns[4].HeaderText = "ЛОГИН";
                            selectList.Columns[5].HeaderText = "ПАРОЛЬ";
                            selectList.Columns[6].Visible = false;
                            selectList.Columns[7].HeaderText = "ДОЛЖНОСТЬ";
                            foreach (string i in employee.ComboBoxItem())
                            {
                                comboBoxItem.Items.Add(i);
                            }
                        }
                        break;
                    case 1:
                        {
                            comboBoxItem.Visible = true;
                            selectList.DataSource = dish.SelectListDish();
                            selectList.Columns[0].Visible = false;
                            selectList.Columns[1].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
                            selectList.Columns[2].Visible = false;
                            selectList.Columns[3].HeaderText = "  РАЗДЕЛ";
                            selectList.Columns[4].HeaderText = "  ДОСТУПНОСТЬ";
                            selectList.Columns[5].HeaderText = "  ЦЕНА (руб)";
                            foreach (string i in list_of_dishes.ComboBoxItem())
                            {
                                comboBoxItem.Items.Add(i);
                            }
                        }
                        break;
                    case 2:
                        {
                            stocks stock = new stocks();
                            selectList.DataSource = stock.SelectListStocks();
                            selectList.Columns[0].Visible = false;
                            selectList.Columns[1].HeaderText = "НАЧАЛО\r\nАКЦИИ";
                            selectList.Columns[2].HeaderText = "КОНЕЦ\r\nАКЦИИ";
                            selectList.Columns[3].HeaderText = "РАЗМЕР\r\n СКИДКИ В %";
                            selectList.Columns[4].Visible = false;
                            labelSearch.Visible = false;
                            comboBoxItem.Visible = false;
                            textBoxsearch.Visible = false;
                            searchh.Visible = true;
                            comboBoxSearch.Visible = true;
                            buttonSearch.Visible = false;
                            foreach (string i in stocks.ComboBoxItem())
                            {
                                comboBoxSearch.Items.Add(i);
                            }
                        } break;
                }
            }
            catch { MessageForm f = new MessageForm(); f.ShowDialog(); }
        }

        private void SELECT_LIST_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
       
        private void add_Click(object sender, EventArgs e)
        {
            switch(item)
            {
               
                case 0:
                    {
                        addEditEmp = new ADD_EDIT_EMPLOYEE(emp, emp.AddEmp());
                        addEditEmp.Location = this.Location;
                        addEditEmp.Size = this.Size;
                        addEditEmp.Show();
                    } break;
                case 1: 
                    {
                        addEditDish = new ADD_EDIT_DISH(emp, dish.AddDish());
                        addEditDish.Size = this.Size;
                        addEditDish.Location = this.Location;
                        addEditDish.Show();
                        this.Hide();
                    } break;
                case 2: 
                    {
                        addEditstock = new ADD_EDIT_STOCK(emp,stock.AddStock());
                        addEditstock.Location = this.Location;
                        addEditstock.Size = this.Size;
                        addEditstock.Show();
                        this.Hide();
                    } break;
            }
          
            this.Hide();
        }

        private void edit_Click(object sender, EventArgs e)
        {
           
            if (selectList.SelectedCells.Count == 1) 
            {
                int edit = 0;
                try {  edit = (int)selectList.SelectedCells[0].OwningRow.Cells[0].Value; } catch { };
               
                switch (item) 
                {
                    case 0: 
                        {
                            addEditEmp = new ADD_EDIT_EMPLOYEE(emp, emp.Editemp(edit));
                            addEditEmp.Location = this.Location;
                            addEditEmp.Size = this.Size;
                            addEditEmp.Show();
                            this.Hide();
                        } break;
                    case 1:
                        {
                            addEditDish = new ADD_EDIT_DISH(emp, dish.EditDish(edit));
                            addEditDish.Location = this.Location;
                            addEditDish.Size = this.Size;
                            addEditDish.Show();
                            this.Hide();
                        }
                        break;
                    case 2:
                        {
                            addEditstock = new ADD_EDIT_STOCK(emp, stock.EditStock(edit));
                            addEditstock.Location = this.Location;
                            addEditstock.Size = this.Size;
                            addEditstock.Show();
                            this.Hide();
                        }
                        break;
                }
               
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            labelNo.Visible = false;
            switch (item)
            {
                case 0:
                    {
                        selectList.DataSource = emp.SelectListEmp();
                    }
                    break;
                case 1: 
                    {
                        selectList.DataSource = dish.SelectListDish();
                    } break;
                case 2:
                    {
                        selectList.DataSource = stock.SelectListStocks();
                    }
                    break;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            MENU_ADM_WAITER mENU = new MENU_ADM_WAITER(1,emp);
            mENU.Size = this.Size;
            this.Hide();
            mENU.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectList.SelectedCells.Count == 1)
            {
                var delete = (int)selectList.SelectedCells[0].OwningRow.Cells[0].Value;
                string a = "У Д А Л Е Н О!\r\nО Б Н О В И Т Е  С П И С О К!";
                string b = "У Д А Л Е Н И Е   Н Е В О З М О Ж Н О!";
                MessageForm mess;
                  try 
                  {
                      if (emp.DeleteEmp(delete,emp) || (stock.DeleteStock(delete) || dish.DeleteDish(delete)))
                      {
                        mess = new MessageForm(a);
                        mess.Show();
                      }
                  }
                  catch
                  {
                    mess = new MessageForm(b);
                    mess.Show();
                  }

                
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelNo.Visible = false;
            switch (item)
            {
                case 0:
                    {
                        try
                        {
                            selectList.DataSource = emp.searchEmp(comboBoxItem.SelectedIndex, textBoxsearch.Text);
                        }
                        catch { labelNo.Visible = true; }
                    
                    }
                    break;
                case 1:
                    {
                        try
                        {
                            selectList.DataSource = dish.searchDish(comboBoxItem.SelectedIndex, textBoxsearch.Text);
                        }
                        catch { labelNo.Visible = true; }
            }
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectList.DataSource = stock.OrderByStock(comboBoxSearch.SelectedIndex);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') ||  e.KeyChar == '-' || e.KeyChar == (char)Keys.Back || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
