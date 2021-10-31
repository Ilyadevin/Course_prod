using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_prod
{
    public partial class Form2 : Form
    {
        public int check = 0;
        short error, a, count;
        int i = 0;
        string priority="";
        public Form2(string param1, int param2)
        {
            InitializeComponent();
            if (param2 == 3)
            {
                priority = "guest";
                butnAddingStudent.Enabled = false;
                butnFiltred.Enabled = false;
            }
            else if (param2 == 2)
            {
                priority = "user";
            }
            if (param2 == 1)
                priority = "admin";
            this.Text += " " + param1 + " " + priority;
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            dateTimePicker1.MaxDate = DateTime.Now;
            textScore.Text = "0";
            textS_number.Text = Convert.ToString(check);
        }
        public class Student
        {
            public string Name;	  // Имя
            public string Surname;  // Фамилия
            public string LName;	  // Отчество
            public int DateD;	  // Число ДР
            public int DateM;	  //  Месяц ДР
            public int DateY;	  // Год ДР
            public string Gender;	  // Пол
            public int S_number;	  // № студенческого билета 
            public string L_base;	  // основа обучения
            public int Score;	  // количество задолженностей
            public string Note;	  // примечание
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Student[] array1 = new Student[15];

        private void butnAddingStudent_Click(object sender, EventArgs e)
        {

            if (textSurname.Text == "") { label1.ForeColor = Color.Red; }
            else if (textFirstname.Text == "") { label2.ForeColor = Color.Red; }
            else if (textLname.Text == "") { label3.ForeColor = Color.Red; }
            else if (textS_number.Text == "") { label6.ForeColor = Color.Red; }
            if (textS_number.Text != "")
            {
                for (a = 0; a <= check - 1; a++)
                {

                    if (Convert.ToInt16(textS_number.Text) == array1[a].S_number)
                    {
                        error -= 1;
                        break;
                    }
                }
                if (error == -1)
                {
                    error = 0;
                    MessageBox.Show("Такой студентческий уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    array1[check] = new Student
                    {
                        Name = textSurname.Text,
                        Surname = textFirstname.Text,
                        LName = textLname.Text,
                        DateD = dateTimePicker1.Value.Day,
                        DateM = dateTimePicker1.Value.Month,
                        DateY = dateTimePicker1.Value.Year,
                        Gender = comboBox1.Text,
                        S_number = Convert.ToInt32(textS_number.Text),
                        L_base = comboBox2.Text,
                        Score = Convert.ToInt32(textScore.Text),
                        Note = textNote.Text
                    };
                    check++;
                    MessageBox.Show("Студент добавлен!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                /*private void butnFiltred_Click(object sender, EventArgs e)
                {
                            Form2 form2 = new(array1, check);
                            form2.ShowDialog();
                        }

                private void butnShowStud_Click(object sender, EventArgs e)
                        {
                            Form3 form3 = new(array1, check);
                            form3.ShowDialog();
                        }
                    }
                */
            }
        }
    }
}
