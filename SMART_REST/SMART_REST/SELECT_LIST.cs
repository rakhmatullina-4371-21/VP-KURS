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
            switch (item) 
            {
                case 0: 
                    {
                        dataGridView1.DataSource = emp.SelectListEmp();
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "ФАМИЛИЯ";
                        dataGridView1.Columns[2].HeaderText = "ИМЯ";
                        dataGridView1.Columns[3].HeaderText = "ОТЧЕСТВО";
                        dataGridView1.Columns[4].HeaderText = "ЛОГИН";
                        dataGridView1.Columns[5].HeaderText = "ПАРОЛЬ";
                        dataGridView1.Columns[6].Visible = false;
                        dataGridView1.Columns[7].HeaderText = "ДОЛЖНОСТЬ";
                        foreach (string i in employee.ComboBoxItem())
                        {
                            comboBox1.Items.Add(i) ;
                        }
                    }
                    break;
                case 1:
                    {
                        dataGridView1.DataSource = dish.SelectListDish();
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
                        dataGridView1.Columns[2].Visible = false;
                        dataGridView1.Columns[3].HeaderText = "  РАЗДЕЛ";
                        dataGridView1.Columns[4].HeaderText = "  ДОСТУПНОСТЬ";
                        dataGridView1.Columns[5].HeaderText = "  ЦЕНА";
                        foreach (string i in list_of_dishes.ComboBoxItem())
                        {
                            comboBox1.Items.Add(i);
                        }
                    }
                    break;
                case 2: 
                    {
                        stocks stock=new stocks();
                        dataGridView1.DataSource = stock.SelectListStocks();
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "НАЧАЛО\r\nАКЦИИ";
                        dataGridView1.Columns[2].HeaderText = "КОНЕЦ\r\nАКЦИИ";
                        dataGridView1.Columns[3].HeaderText = "РАЗМЕР\r\n СКИДКИ В %";
                        dataGridView1.Columns[4].Visible = false;
                        label2.Visible = false;
                        comboBox1.Visible = false;
                        textBox1.Visible = false;
                        label3.Visible = true;
                        comboBox2.Visible = true;
                        button1.Visible = false;
                        foreach (string i in stocks.ComboBoxItem())
                        {
                            comboBox2.Items.Add(i);
                        }
                    } break;
            }
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
           
            if (dataGridView1.SelectedCells.Count == 1) 
            {
                int edit = 0;
                try {  edit = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value; } catch { };
               
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
            label1.Visible = false;
            switch (item)
            {
                case 0:
                    {
                        dataGridView1.DataSource = emp.SelectListEmp();
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "ФАМИЛИЯ";
                        dataGridView1.Columns[2].HeaderText = "ИМЯ";
                        dataGridView1.Columns[3].HeaderText = "ОТЧЕСТВО";
                        dataGridView1.Columns[4].HeaderText = "ЛОГИН";
                        dataGridView1.Columns[5].HeaderText = "ПАРОЛЬ";
                        dataGridView1.Columns[6].Visible = false;
                        dataGridView1.Columns[7].HeaderText = "ДОЛЖНОСТЬ";
                    }
                    break;
                case 1: 
                    {
                        dataGridView1.DataSource = dish.SelectListDish();
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА"; 
                        dataGridView1.Columns[2].Visible = false;
                        dataGridView1.Columns[3].HeaderText = "  РАЗДЕЛ";
                        dataGridView1.Columns[4].HeaderText = "  ДОСТУПНОСТЬ";
                        dataGridView1.Columns[5].HeaderText = "  ЦЕНА";
                    } break;
                case 2:
                    {
                        dataGridView1.DataSource = stock.SelectListStocks();
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "  НАЧАЛО\r\n  АКЦИИ";
                        dataGridView1.Columns[2].HeaderText = "  КОНЕЦ\r\n  АКЦИИ";
                        dataGridView1.Columns[3].HeaderText = "  РАЗМЕР\r\n СКИДКИ В %";
                        dataGridView1.Columns[4].Visible = false;
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
            if (dataGridView1.SelectedCells.Count == 1)
            {
                var delete = (int)dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value;
                string a = "У Д А Л Е Н О!\r\nО Б Н О В И Т Е  С П И С О К!";
                string b = "У Д А Л Е Н И Е   Н Е В О З М О Ж Н О!";
                MessageForm mess;
                  try 
                  {
                      if (emp.DeleteEmp(delete) || (stock.DeleteStock(delete) || dish.DeleteDish(delete)))
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
            label1.Visible = false;
            switch (item)
            {
                case 0:
                    {
                        try
                        {
                            dataGridView1.DataSource = emp.searchEmp(comboBox1.SelectedIndex, textBox1.Text);
                            dataGridView1.Columns[0].Visible = false;
                            dataGridView1.Columns[1].HeaderText = "ФАМИЛИЯ";
                            dataGridView1.Columns[2].HeaderText = "ИМЯ";
                            dataGridView1.Columns[3].HeaderText = "ОТЧЕСТВО";
                            dataGridView1.Columns[4].HeaderText = "ЛОГИН";
                            dataGridView1.Columns[5].HeaderText = "ПАРОЛЬ";
                            dataGridView1.Columns[6].HeaderText = "ДОЛЖНОСТЬ";
                        }
                        catch { label1.Visible = true; }
                    
                    }
                    break;
                case 1:
                    {
                        try
                        {
                            dataGridView1.DataSource = dish.searchDish(comboBox1.SelectedIndex, textBox1.Text);
                            dataGridView1.Columns[0].Visible = false;
                            dataGridView1.Columns[1].HeaderText = "  НАЗВАНИЕ\r\nБЛЮДА";
                            dataGridView1.Columns[2].Visible = false;
                            dataGridView1.Columns[3].HeaderText = "  РАЗДЕЛ";
                            dataGridView1.Columns[4].HeaderText = "  ДОСТУПНОСТЬ";
                            dataGridView1.Columns[5].HeaderText = "  ЦЕНА";
                        }
                        catch { label1.Visible = true; }
            }
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = stock.OrderByStock(comboBox2.SelectedIndex);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "  НАЧАЛО\r\n  АКЦИИ";
            dataGridView1.Columns[2].HeaderText = "  КОНЕЦ\r\n  АКЦИИ";
            dataGridView1.Columns[3].HeaderText = "  РАЗМЕР\r\n СКИДКИ В %";
            dataGridView1.Columns[4].Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
