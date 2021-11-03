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
		private DB dB = new DB();
		string connetionString = @"Server=(localdb)\MSSQLLocalDB;DataBase=Course_prod_bd;Trusted_Connection=True";
		public Login()
		{
			InitializeComponent();
			tabPage1.Text = "Авторизация";
			tabPage2.Text = "Регистрация";
			textRegLogin.Text = "Введите логин";
			textRegPassword.Text = "Введите пароль";
		}
		private void butnRegistration_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages["TabPage2"];
		}
		private void butnClosePage2_Click(object sender, EventArgs e)
		{
			tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
		}


		private void textRegLogin_Enter(object sender, EventArgs e)
		{
			if (textRegLogin.Text == "Введите логин")
			{
				textRegLogin.Text = "";
			}
		}

		private void textRegPassword_Enter(object sender, EventArgs e)
		{
			if (textRegPassword.Text == "Введите пароль")
			{
				textRegPassword.Text = "";
			}

		}

		private void textRegPassword_Leave(object sender, EventArgs e)
		{
			if (textRegPassword.Text == "")
			{
				textRegPassword.Text = "Введите пароль";
			}
		}

		private void textRegLogin_Leave(object sender, EventArgs e)
		{
			if (textRegLogin.Text == "")
			{
				textRegLogin.Text = "Введите логин";
			}
		}

		private void butn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void butn_Auth_Click(object sender, EventArgs e)
		{
            try
			{
				string Login = textLogin.Text;
				string Password = textPassword.Text;
				SqlDataAdapter adapter = new SqlDataAdapter();
				DataTable table = new DataTable();
				SqlCommand command = new SqlCommand("SELECT Password, Login, Priority FROM Users WHERE Login = @Login and Password = @Password", dB.GetConnection());
				SqlParameter LoginParam = new SqlParameter(@"Login", Login);
				SqlParameter PasswordParam = new SqlParameter(@"Password", Password);
				command.Parameters.Add(LoginParam);
				command.Parameters.Add(PasswordParam);
				adapter.SelectCommand = command;
				adapter.Fill(table);
				if (table.Rows.Count > 0)
				{
					MessageBox.Show("Успешная авторизация!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					MainForm fr2 = new MainForm(Login, (int)table.Rows[0]["Priority"]);
					fr2.ShowDialog();

				}
				else
				{
					MessageBox.Show("Пароль неверный", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				} 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
			MainForm fr2 = new MainForm(Login, Role);
			fr2.ShowDialog();
		}

		private void butnRegPage_Click(object sender, EventArgs e)
		{
			try
			{
				if (textRegLogin.Text == "Введите логин")
				{
					MessageBox.Show("Нужно ввести логин!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				if (textRegPassword.Text == "Введите пароль")
				{
					MessageBox.Show("Нужно ввести пароль!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				if (isUserExist())
				{
					return;
				}
				if (strength_check() is false)
				{
					MessageBox.Show("Недостаточно сложный пароль!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				SqlCommand command = new SqlCommand("INSERT INTO dbo.users (Login, Password, Priority) VALUES (@loginu, @passwordu, @priority)", dB.GetConnection());
				command.Parameters.Add("@loginu", SqlDbType.VarChar).Value = textRegLogin.Text;
				command.Parameters.Add("@Passwordu", SqlDbType.VarChar).Value = textRegPassword.Text;
				command.Parameters.Add("@priority", SqlDbType.Int).Value = 3;
				dB.openConnection();
				if (command.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Аккаунт был создан", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Аккаунт не был создан", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				dB.closeConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public Boolean isUserExist()
        {
			SqlDataAdapter adapter = new SqlDataAdapter();
			DataTable table = new DataTable();
			SqlCommand command = new SqlCommand("SELECT Login FROM Users WHERE Login = @Login", dB.GetConnection());
			command.Parameters.Add("@Login", SqlDbType.VarChar).Value = textRegLogin.Text;
			adapter.SelectCommand = command;
			adapter.Fill(table);
			if (table.Rows.Count > 0)
			{
				MessageBox.Show("Такой логин уже есть! Введите другой", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return true;

			}
			else
			{
				return false;
			}
        }
		public Boolean strength_check()
		{
			string pass = textRegPassword.Text;
			int strength = 0;
			if (pass.Length > 5)
			{
				strength++;
				if (ContainsDigit(pass)) strength++;
				if (ContainsLowerLetter(pass)) strength++;
				if (ContainsPunctuation(pass)) strength++;
				if (ContainsSeparator(pass)) strength++;
				if (ContainsUpperLetter(pass)) strength++;
				return true;
			}
			else { return false; }
		}

		static bool ContainsLowerLetter(string pass)
		{
			foreach (char c in pass)
			{
				if ((Char.IsLetter(c)) && (Char.IsLower(c)))
					return true;
			}
			return false;
		}

		static bool ContainsUpperLetter(string pass)
		{
			foreach (char c in pass)
			{
				if ((Char.IsLetter(c)) && (Char.IsUpper(c)))
					return true;
			}
			return false;
		}

		static bool ContainsDigit(string pass)
		{
			foreach (char c in pass)
			{
				if (Char.IsDigit(c))
					return true;
			}
			return false;
		}

		static bool ContainsPunctuation(string pass)
		{
			foreach (char c in pass)
			{
				if (Char.IsPunctuation(c))
					return true;
			}
			return false;
		}

		static bool ContainsSeparator(string pass)
		{
			foreach (char c in pass)
			{
				if (Char.IsSeparator(c))
					return true;
			}
			return false;
		}
	}
}
