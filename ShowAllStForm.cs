using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_prod
{
    public partial class ShowAllStForm : Form
    {
        public ShowAllStForm()
        {
            InitializeComponent();
            DB dB = new DB();
            dB.openConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM students Order by Surname", dB.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[9]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
            }
            reader.Close();
            dB.closeConnection();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
		}

        private void butnClose_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
