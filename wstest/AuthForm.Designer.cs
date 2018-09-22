namespace wstest
{
    partial class AuthForm
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
			this.buttonLogin = new System.Windows.Forms.Button();
			this.textBoxLogin = new System.Windows.Forms.TextBox();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.buttonOpenRegisterForm = new System.Windows.Forms.Button();
			this.buttonMysqlConnect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxMysqlPass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxNeedToRemember = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Enabled = false;
			this.buttonLogin.Location = new System.Drawing.Point(171, 205);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 0;
			this.buttonLogin.Text = "Вход";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// textBoxLogin
			// 
			this.textBoxLogin.Location = new System.Drawing.Point(146, 134);
			this.textBoxLogin.Name = "textBoxLogin";
			this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
			this.textBoxLogin.TabIndex = 1;
			// 
			// textBoxPass
			// 
			this.textBoxPass.Location = new System.Drawing.Point(146, 160);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(100, 20);
			this.textBoxPass.TabIndex = 2;
			// 
			// buttonOpenRegisterForm
			// 
			this.buttonOpenRegisterForm.Enabled = false;
			this.buttonOpenRegisterForm.Location = new System.Drawing.Point(157, 264);
			this.buttonOpenRegisterForm.Name = "buttonOpenRegisterForm";
			this.buttonOpenRegisterForm.Size = new System.Drawing.Size(89, 23);
			this.buttonOpenRegisterForm.TabIndex = 3;
			this.buttonOpenRegisterForm.Text = "Регистрация";
			this.buttonOpenRegisterForm.UseVisualStyleBackColor = true;
			this.buttonOpenRegisterForm.Click += new System.EventHandler(this.buttonOpenRegisterForm_Click);
			// 
			// buttonMysqlConnect
			// 
			this.buttonMysqlConnect.Location = new System.Drawing.Point(119, 12);
			this.buttonMysqlConnect.Name = "buttonMysqlConnect";
			this.buttonMysqlConnect.Size = new System.Drawing.Size(198, 47);
			this.buttonMysqlConnect.TabIndex = 4;
			this.buttonMysqlConnect.Text = "Соединиться с MySQL";
			this.buttonMysqlConnect.UseVisualStyleBackColor = true;
			this.buttonMysqlConnect.Click += new System.EventHandler(this.buttonMysqlConnect_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(105, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Логин:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(98, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Пароль:";
			// 
			// textBoxMysqlPass
			// 
			this.textBoxMysqlPass.Location = new System.Drawing.Point(146, 74);
			this.textBoxMysqlPass.Name = "textBoxMysqlPass";
			this.textBoxMysqlPass.Size = new System.Drawing.Size(100, 20);
			this.textBoxMysqlPass.TabIndex = 7;
			this.textBoxMysqlPass.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Пароль от MySQL:";
			// 
			// checkBoxNeedToRemember
			// 
			this.checkBoxNeedToRemember.AutoSize = true;
			this.checkBoxNeedToRemember.Location = new System.Drawing.Point(252, 78);
			this.checkBoxNeedToRemember.Name = "checkBoxNeedToRemember";
			this.checkBoxNeedToRemember.Size = new System.Drawing.Size(88, 17);
			this.checkBoxNeedToRemember.TabIndex = 9;
			this.checkBoxNeedToRemember.Text = "Запомнить?";
			this.checkBoxNeedToRemember.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(252, 163);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(182, 17);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Запомнить данные для входа?";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// AuthForm
			// 
			this.AcceptButton = this.buttonLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 325);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.checkBoxNeedToRemember);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxMysqlPass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonMysqlConnect);
			this.Controls.Add(this.buttonOpenRegisterForm);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.textBoxLogin);
			this.Controls.Add(this.buttonLogin);
			this.Name = "AuthForm";
			this.Text = "Форма авторизации";
			this.Load += new System.EventHandler(this.AuthForm_Load);
			this.DoubleClick += new System.EventHandler(this.AuthForm_DoubleClick);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonOpenRegisterForm;
        private System.Windows.Forms.Button buttonMysqlConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxMysqlPass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBoxNeedToRemember;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

