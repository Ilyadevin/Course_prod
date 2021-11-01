using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_prod
{
    public partial class Form3 : Form
    {
        public Form3(int len)
        {
            InitializeComponent();
            if (len != 0)
            {
                dataGridView1.RowCount = len;
                dataGridView1.ColumnCount = 7;
                dataGridView1.Columns[0].Name = "ФИО";
                dataGridView1.Columns[1].Name = "№ Cтуденческого билета";
                dataGridView1.Columns[2].Name = "Пол";
                dataGridView1.Columns[3].Name = "Дата рождения";
                dataGridView1.Columns[4].Name = "Задолжности";
                dataGridView1.Columns[5].Name = "Основа обучения";
                dataGridView1.Columns[6].Name = "Примечания";
                for (int i = 0; i < len; i++)
                {
                    if (a[i].Score == 0)
                    {
                        var date = Convert.ToString(a[i].DateD) + '/' + Convert.ToString(a[i].DateM) + '/' + Convert.ToString(a[i].DateY);
                        dataGridView1.Rows[i].Cells[0].Value = a[i].Surname + " " + a[0].Name + " " + a[i].LName;
                        dataGridView1.Rows[i].Cells[1].Value = a[i].S_number;
                        dataGridView1.Rows[i].Cells[2].Value = a[i].Gender;
                        dataGridView1.Rows[i].Cells[3].Value = Convert.ToDateTime(date).ToString("dd/MM/yyyy");
                        dataGridView1.Rows[i].Cells[4].Value = a[i].Score;
                        dataGridView1.Rows[i].Cells[5].Value = a[i].L_base;
                        dataGridView1.Rows[i].Cells[6].Value = a[i].Note;

                    }
                    this.dataGridView1.Sort(this.dataGridView1.Columns["№ Cтуденческого билета"], ListSortDirection.Descending);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Close();
        }

        // Удаление пустых строк после фильтрации
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
        }
    }
}
