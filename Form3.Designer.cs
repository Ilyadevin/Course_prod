
namespace Course_prod
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butnCLose = new System.Windows.Forms.Button();
            this.btnDeleteEmptyCell = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // butnCLose
            // 
            this.butnCLose.Location = new System.Drawing.Point(1071, 571);
            this.butnCLose.Name = "butnCLose";
            this.butnCLose.Size = new System.Drawing.Size(166, 62);
            this.butnCLose.TabIndex = 2;
            this.butnCLose.Text = "Закрыть";
            this.butnCLose.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmptyCell
            // 
            this.btnDeleteEmptyCell.Location = new System.Drawing.Point(840, 571);
            this.btnDeleteEmptyCell.Name = "btnDeleteEmptyCell";
            this.btnDeleteEmptyCell.Size = new System.Drawing.Size(209, 62);
            this.btnDeleteEmptyCell.TabIndex = 3;
            this.btnDeleteEmptyCell.Text = "Удалить пустые ячейки";
            this.btnDeleteEmptyCell.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 645);
            this.Controls.Add(this.btnDeleteEmptyCell);
            this.Controls.Add(this.butnCLose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butnCLose;
        private System.Windows.Forms.Button btnDeleteEmptyCell;
    }
}