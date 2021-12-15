
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
            this.textRegPassword = new System.Windows.Forms.TextBox();
            this.textRegLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butnExit = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButnAuth = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButnReg = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textRegPassword
            // 
            this.textRegPassword.Font = new System.Drawing.Font("Roboto Cn", 11F);
            this.textRegPassword.Location = new System.Drawing.Point(152, 84);
            this.textRegPassword.Name = "textRegPassword";
            this.textRegPassword.Size = new System.Drawing.Size(200, 34);
            this.textRegPassword.TabIndex = 2;
            this.textRegPassword.Enter += new System.EventHandler(this.textRegPassword_Enter);
            this.textRegPassword.Leave += new System.EventHandler(this.textRegPassword_Leave);
            // 
            // textRegLogin
            // 
            this.textRegLogin.Font = new System.Drawing.Font("Roboto Cn", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRegLogin.Location = new System.Drawing.Point(152, 23);
            this.textRegLogin.Name = "textRegLogin";
            this.textRegLogin.Size = new System.Drawing.Size(200, 34);
            this.textRegLogin.TabIndex = 1;
            this.textRegLogin.Enter += new System.EventHandler(this.textRegLogin_Enter);
            this.textRegLogin.Leave += new System.EventHandler(this.textRegLogin_Leave);
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.textPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textPassword.Location = new System.Drawing.Point(154, 76);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(194, 34);
            this.textPassword.TabIndex = 3;
            this.textPassword.Enter += new System.EventHandler(this.textRegPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.textRegPassword_Leave);
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.textLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textLogin.Location = new System.Drawing.Point(153, 24);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(194, 34);
            this.textLogin.TabIndex = 2;
            this.textLogin.Enter += new System.EventHandler(this.textRegLogin_Enter);
            this.textLogin.Leave += new System.EventHandler(this.textRegLogin_Leave);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(1, 95);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(506, 437);
            this.materialTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
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
            this.tabPage1.Size = new System.Drawing.Size(498, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(155, 313);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(193, 46);
            this.materialRaisedButton3.TabIndex = 5;
            this.materialRaisedButton3.Text = "Выход";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(155, 123);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(193, 45);
            this.materialRaisedButton2.TabIndex = 4;
            this.materialRaisedButton2.Text = "Авторизация";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(154, 231);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(193, 43);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Регистрация";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(47, 24);
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
            this.materialLabel2.Location = new System.Drawing.Point(47, 76);
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
            this.materialLabel1.Location = new System.Drawing.Point(149, 186);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(229, 27);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Нет учетной записи?";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.butnExit);
            this.tabPage2.Controls.Add(this.materialRaisedButnAuth);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialButnReg);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Controls.Add(this.textRegPassword);
            this.tabPage2.Controls.Add(this.textRegLogin);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // butnExit
            // 
            this.butnExit.Depth = 0;
            this.butnExit.Location = new System.Drawing.Point(152, 328);
            this.butnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.butnExit.Name = "butnExit";
            this.butnExit.Primary = true;
            this.butnExit.Size = new System.Drawing.Size(200, 45);
            this.butnExit.TabIndex = 7;
            this.butnExit.Text = "Выход";
            this.butnExit.UseVisualStyleBackColor = true;
            this.butnExit.Click += new System.EventHandler(this.butnExit_Click);
            // 
            // materialRaisedButnAuth
            // 
            this.materialRaisedButnAuth.Depth = 0;
            this.materialRaisedButnAuth.Location = new System.Drawing.Point(152, 225);
            this.materialRaisedButnAuth.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButnAuth.Name = "materialRaisedButnAuth";
            this.materialRaisedButnAuth.Primary = true;
            this.materialRaisedButnAuth.Size = new System.Drawing.Size(200, 45);
            this.materialRaisedButnAuth.TabIndex = 8;
            this.materialRaisedButnAuth.Text = "Меню входа";
            this.materialRaisedButnAuth.UseVisualStyleBackColor = true;
            this.materialRaisedButnAuth.Click += new System.EventHandler(this.materialRaisedButnAuth_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(43, 23);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(76, 27);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Логин";
            // 
            // materialButnReg
            // 
            this.materialButnReg.Depth = 0;
            this.materialButnReg.Location = new System.Drawing.Point(152, 154);
            this.materialButnReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButnReg.Name = "materialButnReg";
            this.materialButnReg.Primary = true;
            this.materialButnReg.Size = new System.Drawing.Size(200, 45);
            this.materialButnReg.TabIndex = 6;
            this.materialButnReg.Text = "Регистрация";
            this.materialButnReg.UseVisualStyleBackColor = true;
            this.materialButnReg.Click += new System.EventHandler(this.materialButnReg_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(43, 84);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(90, 27);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Пароль";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.ClientSize = new System.Drawing.Size(506, 531);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textRegPassword;
        private System.Windows.Forms.TextBox textRegLogin;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRaisedButton materialButnReg;
        private MaterialSkin.Controls.MaterialRaisedButton butnExit;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButnAuth;
    }
}

