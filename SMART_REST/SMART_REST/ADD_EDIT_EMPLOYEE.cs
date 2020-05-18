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
    public partial class ADD_EDIT_EMPLOYEE : Form
    {
        employee empl;        // сотрудник, информацию о котором необходимо изменить или добавить
        employee emplUser;   //вошедший в систему сотрудник
        public ADD_EDIT_EMPLOYEE(employee emplUser,dynamic empl)
        {

            InitializeComponent();
            this.emplUser = emplUser;
            this.empl = employee.DynamicEmp(empl);
            surname.Text = empl.surname;
            name.Text = empl.name;
            lastname.Text = empl.lastname;
            login.Text = empl.login;
            password.Text = empl.password;
            var comboList = positions.ComboPos();
            foreach (positions i in comboList) 
            {
                comboPosition.Items.Add(i);
            }
            if (empl.position != null)
                comboPosition.SelectedItem = empl.position;
        }
        public ADD_EDIT_EMPLOYEE(employee emplUser,int id) 
        { 
            InitializeComponent();
            this.emplUser = emplUser;
            empl = new employee();
            empl.id_employee = id;
            var comboList = positions.ComboPos();
            foreach (positions i in comboList)
            {
                comboPosition.Items.Add(i);
            }
        }
        private void ADD_EDIT_EMPLOYEE_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboPosition.SelectedItem != null) { empl.id_position = positions.SelectPos(comboPosition.SelectedItem.ToString()); }
                if (!empl.SaveEmp(empl.id_employee, surname.Text, name.Text, lastname.Text, login.Text, password.Text, empl.id_position))
                {
                    MessageForm mes = new MessageForm("Н Е   В С Е   О Б Я З А Т Е Л Ь Н Ы Е    П О Л Я\r\nБ Ы Л И    З А П О Л Н Е Н Ы ");
                    mes.ShowDialog();
                }
                else 
                {
                    SELECT_LIST selList = new SELECT_LIST(0, emplUser);
                    selList.Size = this.Size;
                    selList.Location = this.Location;
                    selList.Show();
                    this.Hide();
                }
            }
            catch { error.Visible = true; }
        }

        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            SELECT_LIST selList = new SELECT_LIST(0, emplUser);
            selList.Size = this.Size;
            selList.Location = this.Location;
            selList.Show();
            this.Hide();
        }
    }
}
