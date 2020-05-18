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
    public partial class ADD_EDIT_DISH : Form
    {
        employee emp;
        list_of_dishes dish=new list_of_dishes();
        public ADD_EDIT_DISH(employee emp,dynamic dish)
        {
            InitializeComponent();
                this.emp = emp;
                this.dish = list_of_dishes.DynamicDish(dish);
                maskedTextBoxPrice.Text = (Math.Truncate(dish.price)).ToString();
                maskedTextBoxPrice2.Text = ((dish.price - Math.Truncate(dish.price)) * 100).ToString();
                name_dish.Text = dish.name_dish;
                var comboList = menu.ComboSel();
                foreach (menu i in comboList)
                {
                    comboSelection.Items.Add(i.name_selection);
                }
                if (dish.name_selection != null)
                    comboSelection.SelectedItem = dish.name_selection;
                checkBoxAv.Checked = dish.availability;
        }
        public ADD_EDIT_DISH(employee emp, int id)
        {
            InitializeComponent();
            this.emp = emp;
            this.dish.id_dish=id;
            var comboList = menu.ComboSel();
            foreach (menu i in comboList)
            {
                comboSelection.Items.Add(i.name_selection);
            }
        }
        private void ADD_EDIT_DISH_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void close_Click(object sender, EventArgs e)
        {
            SELECT_LIST selList = new SELECT_LIST(1, emp);
            selList.Size = this.Size;
            selList.Location = this.Location;
            selList.Show();
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
                if (comboSelection.SelectedItem != null) { dish.id_selection = menu.SelectSel(comboSelection.SelectedItem.ToString()); }
              
            if (!dish.SaveDish(dish.id_dish, name_dish.Text, dish.id_selection, checkBoxAv.Checked, maskedTextBoxPrice.Text,maskedTextBoxPrice2.Text))
                {
                    MessageForm mes = new MessageForm("Н Е   В С Е   О Б Я З А Т Е Л Ь Н Ы Е    П О Л Я\r\nБ Ы Л И    З А П О Л Н Е Н Ы ");
                    mes.ShowDialog();
                }
                else
                {
                    SELECT_LIST selList = new SELECT_LIST(1, emp);
                    selList.Size = this.Size;
                    selList.Location = this.Location;
                    selList.Show();
                    this.Hide();
                }
        }

        private void name_dish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
