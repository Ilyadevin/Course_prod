
namespace Course_prod
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.butnRegistration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butn_exit = new System.Windows.Forms.Button();
            this.butn_Auth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butnClosePage2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textRegPassword = new System.Windows.Forms.TextBox();
            this.textRegLogin = new System.Windows.Forms.TextBox();
            this.butnRegPage = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butnRegistration
            // 
            this.butnRegistration.Location = new System.Drawing.Point(685, 487);
            this.butnRegistration.Name = "butnRegistration";
            this.butnRegistration.Size = new System.Drawing.Size(194, 36);
            this.butnRegistration.TabIndex = 7;
            this.butnRegistration.Text = "Регистрация";
            this.butnRegistration.UseVisualStyleBackColor = true;
            this.butnRegistration.Click += new System.EventHandler(this.butnRegistration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нет учетной записи?\r\n";
            // 
            // butn_exit
            // 
            this.butn_exit.Location = new System.Drawing.Point(970, 567);
            this.butn_exit.Name = "butn_exit";
            this.butn_exit.Size = new System.Drawing.Size(152, 59);
            this.butn_exit.TabIndex = 5;
            this.butn_exit.Text = "Выход";
            this.butn_exit.UseVisualStyleBackColor = true;
            this.butn_exit.Click += new System.EventHandler(this.butn_exit_Click);
            // 
            // butn_Auth
            // 
            this.butn_Auth.Location = new System.Drawing.Point(914, 487);
            this.butn_Auth.Name = "butn_Auth";
            this.butn_Auth.Size = new System.Drawing.Size(194, 36);
            this.butn_Auth.TabIndex = 4;
            this.butn_Auth.Text = "Авторизация";
            this.butn_Auth.UseVisualStyleBackColor = true;
            this.butn_Auth.Click += new System.EventHandler(this.butn_Auth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1003, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(910, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // butnClosePage2
            // 
            this.butnClosePage2.Location = new System.Drawing.Point(230, 762);
            this.butnClosePage2.Name = "butnClosePage2";
            this.butnClosePage2.Size = new System.Drawing.Size(136, 54);
            this.butnClosePage2.TabIndex = 5;
            this.butnClosePage2.Text = "Меню входа";
            this.butnClosePage2.UseVisualStyleBackColor = true;
            this.butnClosePage2.Click += new System.EventHandler(this.butnClosePage2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 638);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин";
            // 
            // textRegPassword
            // 
            this.textRegPassword.Location = new System.Drawing.Point(230, 632);
            this.textRegPassword.Name = "textRegPassword";
            this.textRegPassword.Size = new System.Drawing.Size(155, 26);
            this.textRegPassword.TabIndex = 2;
            this.textRegPassword.Enter += new System.EventHandler(this.textRegPassword_Enter);
            this.textRegPassword.Leave += new System.EventHandler(this.textRegPassword_Leave);
            // 
            // textRegLogin
            // 
            this.textRegLogin.Location = new System.Drawing.Point(230, 583);
            this.textRegLogin.Name = "textRegLogin";
            this.textRegLogin.Size = new System.Drawing.Size(155, 26);
            this.textRegLogin.TabIndex = 1;
            this.textRegLogin.Enter += new System.EventHandler(this.textRegLogin_Enter);
            this.textRegLogin.Leave += new System.EventHandler(this.textRegLogin_Leave);
            // 
            // butnRegPage
            // 
            this.butnRegPage.Location = new System.Drawing.Point(230, 687);
            this.butnRegPage.Name = "butnRegPage";
            this.butnRegPage.Size = new System.Drawing.Size(155, 41);
            this.butnRegPage.TabIndex = 0;
            this.butnRegPage.Text = "Регистрация";
            this.butnRegPage.UseVisualStyleBackColor = true;
            this.butnRegPage.Click += new System.EventHandler(this.butnRegPage_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(425, 86);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(194, 26);
            this.textPassword.TabIndex = 3;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(425, 18);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(194, 26);
            this.textLogin.TabIndex = 2;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 74);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(654, 298);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialRaisedButton3);
            this.tabPage1.Controls.Add(this.materialRaisedButton2);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.textPassword);
            this.tabPage1.Controls.Add(this.textLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(23, 69);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(193, 43);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Регистрация";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(293, 18);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 27);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Логин";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(293, 86);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(90, 27);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Пароль";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(229, 27);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Нет учетной записи?";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(426, 133);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(193, 45);
            this.materialRaisedButton2.TabIndex = 4;
            this.materialRaisedButton2.Text = "Авторизация";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(426, 203);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(193, 46);
            this.materialRaisedButton3.TabIndex = 5;
            this.materialRaisedButton3.Text = "Выход";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(1311, 984);
            this.Controls.Add(this.butn_exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butnClosePage2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butnRegPage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butnRegistration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRegPassword);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.textRegLogin);
            this.Controls.Add(this.butn_Auth);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butnRegistration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butn_exit;
        private System.Windows.Forms.Button butn_Auth;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butnClosePage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRegPassword;
        private System.Windows.Forms.TextBox textRegLogin;
        private System.Windows.Forms.Button butnRegPage;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}

