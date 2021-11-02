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

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butnAddingStudent_Click(object sender, EventArgs e)
        {

            if (textSurname.Text == "") { label1.ForeColor = Color.Red; }
            else if (textFirstname.Text == "") { label2.ForeColor = Color.Red; }
            else if (textLname.Text == "") { label3.ForeColor = Color.Red; }
            else if (textS_number.Text == "") { label6.ForeColor = Color.Red; }
            if (textS_number.Text != "")
            {
                int pass = 0;
                int number = Convert.ToInt32(textS_number.Text);
                string sqlExpression = $"SELECT S_number FROM dbo.students where S_number = {Convert.ToString(number)}";
                SqlConnection connetion;
                connetion = new SqlConnection(connetionString);
                connetion.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connetion);
                command.CommandText = sqlExpression;
                Int32 S_number_DB = (Int32)command.ExecuteScalar();
#pragma warning disable CS0472 // Результат значения всегда одинаковый, так как значение этого типа никогда не равно NULL
                if (S_number_DB != null)
#pragma warning restore CS0472 // Результат значения всегда одинаковый, так как значение этого типа никогда не равно NULL
                {
                    MessageBox.Show("Такой студентческий уже есть", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                /*
                else
                { 
                    string sql = string.Format("Insert Into students" +
                                "(Name, Surname, LName, BirthDate, Gender, S_number, Score, Note) Values('{0}','{1}','{2}','{3}')");

                        // Параметризованная команда
                        using (SqlConnection sc = new SqlConnection())
                        {
                            sc.ConnectionString = "Data Source=localhost;Initial Catalog=LoginScreen;Integrated Security=True";
                            sc.Open();

                            using (SqlCommand com = sc.CreateCommand())
                            {
                                com.CommandText =
                                  "insert into students(\n" +
                                  "  id,\n" +
                                  "  Name,\n" +
                                  "  Surname,\n" +
                                  "  LName,\n" +
                                  "  BirthDate,\n" +
                                  "  Gender,\n" +
                                  "  S_number,\n" +
                                  "  Score,\n" +
                                  "  L_base,\n" +
                                  "  Note)\n" +
                                  "values(\n" +
                                  "  @Id,\n" +
                                  "  @Name,\n" +
                                  "  @Surname,\n" +
                                  "  @LName,\n" +
                                  "  @BirthDate,\n" +
                                  "  @Gender,\n" +
                                  "  @S_number,\n" +
                                  "  @Score,\n" +
                                  "  @L_base,\n" +
                                  "  @Note)";

                                //TODO: Change my arbitrary "80" to actual Stock fields' sizes! 
                                com.Parameters.Add("@id", SqlDbType.Int).Value = check;
                                com.Parameters.Add("@Name", SqlDbType.VarChar, 20).Value = textFirstname.Text;
                                com.Parameters.Add("@Surname", SqlDbType.VarChar, 20).Value = textSurname.Text;
                                com.Parameters.Add("@LName", SqlDbType.VarChar, 20).Value = textLname.Text;
                                com.Parameters.Add("@S_number", SqlDbType.Int).Value = textS_number.Text;
                                com.Parameters.Add("@Score", SqlDbType.Int).Value = textScore.Text;
                                com.Parameters.Add("@BirthDate", SqlDbType.Date).Value = dateTimePicker1.Text;
                                com.Parameters.Add("@Gender", SqlDbType.VarChar, 20).Value = comboBox1.Text;
                                com.Parameters.Add("@L_base", SqlDbType.VarChar, 20).Value = comboBox2.Text;
                                com.Parameters.Add("@Note", SqlDbType.VarChar, 256).Value = textNote.Text;
                                com.ExecuteNonQuery();
                            }
                        }
                        check++;
                        MessageBox.Show("Студент добавлен!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

                private void butnShowStud_Click_1(object sender, EventArgs e)
                {
                    /*Form3 form3 = new(array1, check);
                    form3.ShowDialog();
                }

                private void butnFiltred_Click_1(object sender, EventArgs e)
                {
                    /*string sqlExpression = "SELECT * FROM students WHERE L_Base = @L_Base";
                    SqlConnection connetion;
                    connetion = new SqlConnection(connetionString);
                    connetion.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connetion);
                    SqlParameter S_Number = new SqlParameter(@"L_Base", "Бюджетная");
                    command.Parameters.Add(S_Number);
                    DBS_number = command.ExecuteReader();*/
            }
        }
    }
}

            

    


