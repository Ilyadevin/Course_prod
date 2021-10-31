
namespace Course_prod
{
    partial class Form2
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
            this.butnAddingStudent = new System.Windows.Forms.Button();
            this.butnFiltred = new System.Windows.Forms.Button();
            this.butnShowStud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textFirstname = new System.Windows.Forms.TextBox();
            this.textLname = new System.Windows.Forms.TextBox();
            this.textS_number = new System.Windows.Forms.TextBox();
            this.textScore = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textNote = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butnAddingStudent
            // 
            this.butnAddingStudent.Location = new System.Drawing.Point(337, 215);
            this.butnAddingStudent.Name = "butnAddingStudent";
            this.butnAddingStudent.Size = new System.Drawing.Size(300, 60);
            this.butnAddingStudent.TabIndex = 0;
            this.butnAddingStudent.Text = "Добавить студента";
            this.butnAddingStudent.UseVisualStyleBackColor = true;
            this.butnAddingStudent.Click += new System.EventHandler(this.butnAddingStudent_Click);
            // 
            // butnFiltred
            // 
            this.butnFiltred.Location = new System.Drawing.Point(337, 319);
            this.butnFiltred.Name = "butnFiltred";
            this.butnFiltred.Size = new System.Drawing.Size(300, 60);
            this.butnFiltred.TabIndex = 1;
            this.butnFiltred.Text = "Фильтрация списка";
            this.butnFiltred.UseVisualStyleBackColor = true;
            // 
            // butnShowStud
            // 
            this.butnShowStud.Location = new System.Drawing.Point(337, 414);
            this.butnShowStud.Name = "butnShowStud";
            this.butnShowStud.Size = new System.Drawing.Size(300, 60);
            this.butnShowStud.TabIndex = 2;
            this.butnShowStud.Text = "Отображение всего списка";
            this.butnShowStud.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер студенческого";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Количество задолженностей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 558);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Пол";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Основа обучения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Примечание";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(70, 84);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(151, 26);
            this.textSurname.TabIndex = 12;
            // 
            // textFirstname
            // 
            this.textFirstname.Location = new System.Drawing.Point(70, 182);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.Size = new System.Drawing.Size(151, 26);
            this.textFirstname.TabIndex = 13;
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(70, 270);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(151, 26);
            this.textLname.TabIndex = 14;
            // 
            // textS_number
            // 
            this.textS_number.Location = new System.Drawing.Point(70, 354);
            this.textS_number.Name = "textS_number";
            this.textS_number.Size = new System.Drawing.Size(151, 26);
            this.textS_number.TabIndex = 15;
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(70, 431);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(151, 26);
            this.textScore.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 507);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBox1.Location = new System.Drawing.Point(70, 592);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Бюджетная",
            "Платная",
            "Лготная"});
            this.comboBox2.Location = new System.Drawing.Point(70, 679);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 19;
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(337, 84);
            this.textNote.Multiline = true;
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(300, 100);
            this.textNote.TabIndex = 20;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(444, 647);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(193, 60);
            this.Exit.TabIndex = 21;
            this.Exit.Text = "Закрыть";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 766);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.textS_number);
            this.Controls.Add(this.textLname);
            this.Controls.Add(this.textFirstname);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butnShowStud);
            this.Controls.Add(this.butnFiltred);
            this.Controls.Add(this.butnAddingStudent);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butnAddingStudent;
        private System.Windows.Forms.Button butnFiltred;
        private System.Windows.Forms.Button butnShowStud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textFirstname;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.TextBox textS_number;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.Button Exit;
    }
}