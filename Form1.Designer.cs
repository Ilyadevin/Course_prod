
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butnRegistration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.butn_exit = new System.Windows.Forms.Button();
            this.butn_Auth = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butnGuest = new System.Windows.Forms.Button();
            this.butnRegPage = new System.Windows.Forms.Button();
            this.textRegLogin = new System.Windows.Forms.TextBox();
            this.textRegPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.errorlabel2 = new System.Windows.Forms.Label();
            this.errorlabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.butnGuest);
            this.tabPage1.Controls.Add(this.butnRegistration);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.butn_exit);
            this.tabPage1.Controls.Add(this.butn_Auth);
            this.tabPage1.Controls.Add(this.textPassword);
            this.tabPage1.Controls.Add(this.textLogin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // butnRegistration
            // 
            this.butnRegistration.Location = new System.Drawing.Point(12, 113);
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
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нет учетной записи?\r\n";
            // 
            // butn_exit
            // 
            this.butn_exit.Location = new System.Drawing.Point(342, 164);
            this.butn_exit.Name = "butn_exit";
            this.butn_exit.Size = new System.Drawing.Size(152, 59);
            this.butn_exit.TabIndex = 5;
            this.butn_exit.Text = "Выход";
            this.butn_exit.UseVisualStyleBackColor = true;
            this.butn_exit.Click += new System.EventHandler(this.butn_exit_Click);
            // 
            // butn_Auth
            // 
            this.butn_Auth.Location = new System.Drawing.Point(300, 113);
            this.butn_Auth.Name = "butn_Auth";
            this.butn_Auth.Size = new System.Drawing.Size(194, 36);
            this.butn_Auth.TabIndex = 4;
            this.butn_Auth.Text = "Авторизация";
            this.butn_Auth.UseVisualStyleBackColor = true;
            this.butn_Auth.Click += new System.EventHandler(this.butn_Auth_Click);
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(300, 68);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(194, 26);
            this.textPassword.TabIndex = 3;
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(300, 15);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(194, 26);
            this.textLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.errorlabel1);
            this.tabPage2.Controls.Add(this.errorlabel2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textRegPassword);
            this.tabPage2.Controls.Add(this.textRegLogin);
            this.tabPage2.Controls.Add(this.butnRegPage);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(508, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // butnGuest
            // 
            this.butnGuest.Location = new System.Drawing.Point(12, 58);
            this.butnGuest.Name = "butnGuest";
            this.butnGuest.Size = new System.Drawing.Size(194, 36);
            this.butnGuest.TabIndex = 8;
            this.butnGuest.Text = "Войти как гость";
            this.butnGuest.UseVisualStyleBackColor = true;
            // 
            // butnRegPage
            // 
            this.butnRegPage.Location = new System.Drawing.Point(100, 165);
            this.butnRegPage.Name = "butnRegPage";
            this.butnRegPage.Size = new System.Drawing.Size(155, 41);
            this.butnRegPage.TabIndex = 0;
            this.butnRegPage.Text = "Регистрация";
            this.butnRegPage.UseVisualStyleBackColor = true;
            // 
            // textRegLogin
            // 
            this.textRegLogin.Location = new System.Drawing.Point(100, 26);
            this.textRegLogin.Name = "textRegLogin";
            this.textRegLogin.Size = new System.Drawing.Size(155, 26);
            this.textRegLogin.TabIndex = 1;
            // 
            // textRegPassword
            // 
            this.textRegPassword.Location = new System.Drawing.Point(100, 97);
            this.textRegPassword.Name = "textRegPassword";
            this.textRegPassword.Size = new System.Drawing.Size(155, 26);
            this.textRegPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorlabel2
            // 
            this.errorlabel2.AutoSize = true;
            this.errorlabel2.Location = new System.Drawing.Point(276, 97);
            this.errorlabel2.Name = "errorlabel2";
            this.errorlabel2.Size = new System.Drawing.Size(0, 20);
            this.errorlabel2.TabIndex = 6;
            // 
            // errorlabel1
            // 
            this.errorlabel1.AutoSize = true;
            this.errorlabel1.Location = new System.Drawing.Point(276, 26);
            this.errorlabel1.Name = "errorlabel1";
            this.errorlabel1.Size = new System.Drawing.Size(0, 20);
            this.errorlabel1.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 282);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button butnRegistration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butn_exit;
        private System.Windows.Forms.Button butn_Auth;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butnGuest;
        private System.Windows.Forms.Label errorlabel1;
        private System.Windows.Forms.Label errorlabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textRegPassword;
        private System.Windows.Forms.TextBox textRegLogin;
        private System.Windows.Forms.Button butnRegPage;
    }
}

