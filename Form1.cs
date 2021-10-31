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
	public partial class Login : Form
	{
		string connetionString = @"Server=(localdb)\MSSQLLocalDB;DataBase=Course_prod_bd;Trusted_Connection=True";
		public Login()
		{
			InitializeComponent();
			tabPage1.Text = "Авторизация";
			tabPage2.Text = "Регистрация";
		}

		private void butn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void butn_Auth_Click(object sender, EventArgs e)
		{
			string Login = textLogin.Text;
			string Password = textPassword.Text;
			int Role = 1;
			string ID = "0";
			SqlDataReader DBPassword;
			string pass = "";
			string sqlExpression = "SELECT Password, ID FROM Users WHERE Login = @Login";
			SqlConnection connetion;
			connetion = new SqlConnection(connetionString);
			connetion.Open();
			SqlCommand command = new SqlCommand(sqlExpression, connetion);
			SqlParameter LoginParam = new SqlParameter(@"Login", Login);
			command.Parameters.Add(LoginParam);
			DBPassword = command.ExecuteReader();
			while (DBPassword.Read())
			{
				pass = Convert.ToString(DBPassword.GetValue(0));
				ID = Convert.ToString(DBPassword.GetValue(1));
			}
			if (DBPassword.HasRows)
			{
				if (pass != Password)
				{
					MessageBox.Show("Пароль неверный");
				}
				else
				{
					Form2 fr2 = new Form2(Login, Role);
					fr2.ShowDialog();
				}
			}

		}

        private void butnRegistration_Click(object sender, EventArgs e)
        {
			tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
		}

        private void butnGuest_Click(object sender, EventArgs e)
        {
			string Login = "guest";
			string Password = "guest";
			int Role = 3;
			string sqlExpression = "SELECT Password, ID FROM Users WHERE Login = @Login";
			SqlConnection connetion;
			connetion = new SqlConnection(connetionString);
			connetion.Open();
			SqlCommand command = new SqlCommand(sqlExpression, connetion);
			SqlParameter LoginParam = new SqlParameter(@"Login", Login);
			command.Parameters.Add(LoginParam);
			Form2 fr2 = new Form2(Login, Role);
			fr2.ShowDialog();

		}

        private void butnClosePage2_Click(object sender, EventArgs e)
        {
			tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
		}
    }
}
