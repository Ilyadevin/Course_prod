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
    public partial class FiltredStForm : Form
    {
        DB dB = new DB();
        private SqlCommandBuilder SqlBuilder = null;
        private DataSet dataSet = null;
        private SqlDataAdapter dataAdapter = null;
        private bool newRowAdding = false;
        public FiltredStForm()
        {
            InitializeComponent();
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
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[10, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReData()
        {
            try
            {
                dataSet.Tables["students"].Clear();
                dataAdapter.Fill(dataSet, "students");
                dataGridView1.DataSource = dataSet.Tables["students"];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[10, i] = linkCell;
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

        private void ShowAllStForm_Load(object sender, EventArgs e)
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
                if (e.ColumnIndex == 10)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            dataSet.Tables["students"].Rows[rowIndex].Delete();
                            dataAdapter.Update(dataSet, "students");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;
                        DataRow row = dataSet.Tables["users"].NewRow();
                        row["Id"] = dataGridView1.Rows[rowIndex].Cells["Id"].Value;
                        row["Surname"] = dataGridView1.Rows[rowIndex].Cells["Фамилия"].Value;
                        row["Name"] = dataGridView1.Rows[rowIndex].Cells["Name"].Value;
                        row["LName"] = dataGridView1.Rows[rowIndex].Cells["LName"].Value;
                        row["BirthDate"] = dataGridView1.Rows[rowIndex].Cells["BirthDate"].Value;
                        row["Gender"] = dataGridView1.Rows[rowIndex].Cells["Gender"].Value;
                        row["L_base"] = dataGridView1.Rows[rowIndex].Cells["L_base"].Value;
                        row["Score"] = dataGridView1.Rows[rowIndex].Cells["Score"].Value;
                        row["Note"] = dataGridView1.Rows[rowIndex].Cells["Note"].Value;
                        dataSet.Tables["students"].Rows.Add(row);
                        dataSet.Tables["students"].Rows.RemoveAt(dataSet.Tables["students"].Rows.Count - 1);
                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
                        dataAdapter.Update(dataSet, "students");
                        dataGridView1.Rows[e.RowIndex].Cells[10].Value = "Delete";
                        newRowAdding = false;
                        MessageBox.Show("Данные обновлены", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;
                        dataSet.Tables["Id"].Rows[r]["Id"] = dataGridView1.Rows[r].Cells["Id"].Value;
                        dataSet.Tables["Surname"].Rows[r]["Surname"] = dataGridView1.Rows[r].Cells["Surname"].Value;
                        dataSet.Tables["Name"].Rows[r]["Name"] = dataGridView1.Rows[r].Cells["Name"].Value;
                        dataSet.Tables["LName"].Rows[r]["LName"] = dataGridView1.Rows[r].Cells["LName"].Value;
                        dataSet.Tables["BirthDate"].Rows[r]["BirthDate"] = dataGridView1.Rows[r].Cells["BirthDate"].Value;
                        dataSet.Tables["Gender"].Rows[r]["Gender"] = dataGridView1.Rows[r].Cells["Gender"].Value;
                        dataSet.Tables["L_base"].Rows[r]["L_base"] = dataGridView1.Rows[r].Cells["L_base"].Value;
                        dataSet.Tables["Score"].Rows[r]["Score"] = dataGridView1.Rows[r].Cells["Score"].Value;
                        dataSet.Tables["Note"].Rows[r]["Note"] = dataGridView1.Rows[r].Cells["Note"].Value;
                        dataAdapter.Update(dataSet, "students");
                        dataGridView1.Rows[e.RowIndex].Cells[10].Value = "Delete";
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
                    dataGridView1[10, rowIndex] = linkCell;
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
                    dataGridView1[10, lastRow] = linkCell;
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
                    dataGridView1[10, rowIndex] = linkCell;
                    gridViewRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 6)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
            if (dataGridView1.CurrentCell.ColumnIndex == 7)
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
    }
}


