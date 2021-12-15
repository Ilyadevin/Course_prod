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
        DB dB = new DB();
        private SqlCommandBuilder SqlBuilder = null;
        private DataSet dataSet = null;
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
                dataAdapter = new SqlDataAdapter("SELECT *, 'Delete' as [Command] FROM students", dB.GetConnection());
                SqlBuilder = new SqlCommandBuilder(dataAdapter);
                SqlBuilder.GetInsertCommand();
                SqlBuilder.GetUpdateCommand();
                SqlBuilder.GetDeleteCommand();
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "students");
                dataGridView1.DataSource = dataSet.Tables["students"];
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
