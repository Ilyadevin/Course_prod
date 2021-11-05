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
    public partial class ShowUsersForm : Form
    {
        DB dB = new DB();
        private SqlCommandBuilder SqlBuilder = null;
        private DataSet dataSet = null;
        private SqlDataAdapter dataAdapter = null;
        private bool newRowAdding = false;
        public ShowUsersForm()
        {
            InitializeComponent();
        }


        private void LoadData()
        {
            try
            {
                dataAdapter = new SqlDataAdapter("SELECT *, 'Delete' as [Command] FROM users", dB.GetConnection());
                SqlBuilder = new SqlCommandBuilder(dataAdapter);
                SqlBuilder.GetInsertCommand();
                SqlBuilder.GetUpdateCommand();
                SqlBuilder.GetDeleteCommand();
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "users");
                dataGridView1.DataSource = dataSet.Tables["users"];
                for (int i = 0; i< dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[4, i] = linkCell;
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReData()
        {
            try
            {
                dataSet.Tables["users"].Clear();
                dataAdapter.Fill(dataSet, "users");
                dataGridView1.DataSource = dataSet.Tables["users"];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[4, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowUsersForm_Load(object sender, EventArgs e)
        {
            dB.openConnection();
            LoadData();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 4)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            dataSet.Tables["users"].Rows[rowIndex].Delete();
                            dataAdapter.Update(dataSet, "users");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;
                        DataRow row = dataSet.Tables["users"].NewRow();
                        row["Id"] = dataGridView1.Rows[rowIndex].Cells["Id"].Value;
                        row["Login"] = dataGridView1.Rows[rowIndex].Cells["Login"].Value;
                        row["Password"] = dataGridView1.Rows[rowIndex].Cells["Password"].Value;
                        row["Priority"] = dataGridView1.Rows[rowIndex].Cells["Priority"].Value;
                        dataSet.Tables["users"].Rows.Add(row);
                        dataSet.Tables["users"].Rows.RemoveAt(dataSet.Tables["users"].Rows.Count - 1);
                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
                        dataAdapter.Update(dataSet, "users");
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = "Delete";
                        newRowAdding = false;
                        MessageBox.Show("Данные обновлены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;
                        dataSet.Tables["users"].Rows[r]["Login"] = dataGridView1.Rows[r].Cells["Login"].Value;
                        dataSet.Tables["users"].Rows[r]["Password"] = dataGridView1.Rows[r].Cells["Password"].Value;
                        dataSet.Tables["users"].Rows[r]["Priority"] = dataGridView1.Rows[r].Cells["Priority"].Value;
                        dataAdapter.Update(dataSet, "users");
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = "Delete";
                        newRowAdding = true;
                        MessageBox.Show("Данные обновлены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ReData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedRows[0].Index;
                    DataGridViewRow gridrow = dataGridView1.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[4, rowIndex] = linkCell;
                    gridrow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_UserAddedRow_1(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;
                    int lastRow = dataGridView1.Rows.Count - 2;
                    DataGridViewRow row = dataGridView1.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[4, lastRow] = linkCell;
                    row.Cells["Command"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow gridViewRow = dataGridView1.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[4, rowIndex] = linkCell;
                    gridViewRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 3)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
