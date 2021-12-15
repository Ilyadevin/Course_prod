using MaterialSkin.Controls;
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
    public partial class ShowAllStForm : MaterialForm
    {
        DB dB = new DB();
        private DataTable dataTable = null;
        private SqlDataAdapter dataAdapter = null;
        public ShowAllStForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT * FROM students", dB.GetConnection());
                dataTable = new DataTable("students");
                dataAdapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(
                        dataTable.Rows[i][1], dataTable.Rows[i][2], dataTable.Rows[i][3], 
                        dataTable.Rows[i][7], dataTable.Rows[i][4], dataTable.Rows[i][5], 
                        dataTable.Rows[i][8], dataTable.Rows[i][6], dataTable.Rows[i][9]
                  );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void butnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

