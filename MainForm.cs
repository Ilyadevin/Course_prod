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

using MaterialSkin.Controls;
using MaterialSkin;
namespace Course_prod
{
    public partial class MainForm : MaterialForm
    {
        public int check = 0;
        string priority = "";
        private DB dB = new DB();
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        private SqlCommand command = null;
        public MainForm(string param1, int param2)
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
                butnShowUsers.Enabled = false;
            }
            if (param2 == 1)
                priority = "admin";
            this.Text = "Эрлингас И.Д. ЭБИ-211 " + param1 + " " + priority;
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            dateTimePicker1.MaxDate = DateTime.Now;
            textScore.Text = "0";
            textS_number.Text = Convert.ToString(check);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butnAddingStudent_Click(object sender, EventArgs e)
        {
            if (!(textS_number.Text == "" || textSurname.Text == "" || textFirstname.Text == "" || textLname.Text == "" || textScore.Text == ""))
            {
                adapter = new SqlDataAdapter();
                table = new DataTable();
                command = new SqlCommand("SELECT S_number FROM students WHERE S_number = @s_number", dB.GetConnection());
                SqlParameter S_numberParam = new SqlParameter(@"s_number", textS_number.Text);
                command.Parameters.Add(S_numberParam);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такой студентческий уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else
                {
                    SqlCommand command_insert = new SqlCommand(
                        "insert into dbo.students" +
                            " ( Name, " +
                            " Surname, " +
                            " LName," +
                            " BirthDate," +
                            " Gender," +
                            " S_number, " +
                            " Score," +
                            "L_base, " +
                            " Note) values" +
                            " (@Name," +
                            " @Surname," +
                            " @LName, " +
                            " @BirthDate, " +
                            " @Gender, " +
                            " @S_number, " +
                            " @Score," +
                            " @L_base," +
                            " @Note)", dB.GetConnection());
                    var date = Convert.ToString(dateTimePicker1.Value.Day) + '/' + Convert.ToString(dateTimePicker1.Value.Month) + '/' + Convert.ToString(dateTimePicker1.Value.Year);
                    command_insert.Parameters.Add("@Name", SqlDbType.VarChar).Value = textFirstname.Text;
                    command_insert.Parameters.Add("@Surname", SqlDbType.VarChar).Value = textSurname.Text;
                    command_insert.Parameters.Add("@LName", SqlDbType.VarChar).Value = textLname.Text;
                    command_insert.Parameters.Add("@S_number", SqlDbType.Int).Value = textS_number.Text;
                    command_insert.Parameters.Add("@Score", SqlDbType.Int).Value = textScore.Text;
                    command_insert.Parameters.Add("@BirthDate", SqlDbType.Date).Value = Convert.ToDateTime(date).ToString("dd/MM/yyyy");
                    command_insert.Parameters.Add("@Gender", SqlDbType.VarChar).Value = comboBox1.Text;
                    command_insert.Parameters.Add("@L_base", SqlDbType.VarChar).Value = comboBox2.Text;
                    command_insert.Parameters.Add("@Note", SqlDbType.VarChar).Value = textNote.Text;
                    dB.openConnection();
                    command_insert.ExecuteNonQuery();
                    MessageBox.Show("Студент добавлен!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
            }
        }

        private void butnShowUsers_Click(object sender, EventArgs e)
        {
            ShowUsersForm form5 = new ShowUsersForm();
            form5.Text = "Все пользователи";
            form5.ShowDialog();
        }

        private void butnFiltred_Click(object sender, EventArgs e)
        {
            FiltredStForm form4 = new FiltredStForm();
            form4.Text = "Отфильтрованный список студентов";
            form4.ShowDialog();
        }

        private void butnShowStud_Click(object sender, EventArgs e)
        {
            ShowAllStForm form3 = new ShowAllStForm();
            form3.Text = "Все студенты";
            form3.ShowDialog();
        }

        private void textS_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) { e.Handled = true; }
        }

        private void textScore_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) { e.Handled = true; }
        }
    } 
}


            

    


