using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Course_prod
{
    public partial class Form2 : Form
    {
        string connetionString = @"Server=(localdb)\MSSQLLocalDB;DataBase=Course_prod_bd;Trusted_Connection=True";
        public int check = 0;
        short error, a, count;
        int i = 0;
        string priority = "";
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
                int pass = 0;
                SqlDataReader DBS_number;
                string sqlExpression = "SELECT S_number FROM students WHERE S_number = @textS_number";
                SqlConnection connetion;
                connetion = new SqlConnection(connetionString);
                connetion.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connetion);
                SqlParameter S_Number = new SqlParameter(@"S_number", textS_number);
                command.Parameters.Add(S_Number);
                DBS_number = command.ExecuteReader();
                while (DBS_number.Read())
                {
                    pass = Convert.ToInt32(DBS_number.GetValue(0));
                }
                if (Convert.ToInt32(textS_number.Text) == pass)
                {
                    error -= 1;
                }
                if (error == -1)
                {
                    error = 0;
                    MessageBox.Show("Такой студентческий уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = string.Format("Insert Into students" +
                            "(Name, Surname, LName, BirthDate, Gender, S_number, Score, Note) Values('{0}','{1}','{2}','{3}')");

                    // Параметризованная команда

                    using (SqlCommand cmd = new SqlCommand(sql, connetion))
                    {
                        SqlParameter param = new SqlParameter
                        {
                            ParameterName = "@Name",
                            Value = textFirstname,
                            SqlDbType = SqlDbType.VarChar
                        };
                        cmd.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@Surname",
                            Value = textSurname,
                            SqlDbType = SqlDbType.VarChar,
                            Size = 10
                        };
                        cmd.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@LName",
                            Value = textLname,
                            SqlDbType = SqlDbType.VarChar,
                            Size = 10
                        };
                        cmd.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@BirthDate",
                            Value = dateTimePicker1,
                            SqlDbType = SqlDbType.Date
                        };
                        cmd.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@Gender",
                            Value = comboBox1.Text,
                            SqlDbType = SqlDbType.Char
                        };
                        cmd.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@S_number",
                            Value = textS_number,
                            SqlDbType = SqlDbType.Int
                        };
                        cmd.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@Score",
                            Value = textScore,
                            SqlDbType = SqlDbType.Int
                        };
                        cmd.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@Score",
                            Value = textScore,
                            SqlDbType = SqlDbType.Int
                        };
                        cmd.Parameters.Add(param);

                        param = new SqlParameter
                        {
                            ParameterName = "@Note",
                            Value = textNote,
                            SqlDbType = SqlDbType.VarChar
                        };
                        cmd.Parameters.Add(param);

                        cmd.ExecuteNonQuery();
                    }
                    check++;
                    MessageBox.Show("Студент добавлен!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void butnShowStud_Click_1(object sender, EventArgs e)
        {
            /*Form3 form3 = new(array1, check);
            form3.ShowDialog();*/
        }

        private void butnFiltred_Click_1(object sender, EventArgs e)
        {

            /*Form2 form2 = new(array1, check);
            form2.ShowDialog();*/
        }
    } 
}
    


