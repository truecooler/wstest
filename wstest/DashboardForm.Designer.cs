namespace wstest
{
    partial class DashboardForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.мойАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьНовыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокМоихЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.списокЗаказовВСистемеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьПанельУправленияПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьПанельУправленияТоварамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(441, 247);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Выход с аккаунта";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 252);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Привет, ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(89, 252);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "%empty%";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.мойАккаунтToolStripMenuItem,
            this.заказыToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.товарыToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(657, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// мойАккаунтToolStripMenuItem
			// 
			this.мойАккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem,
            this.сменитьПарольToolStripMenuItem});
			this.мойАккаунтToolStripMenuItem.Name = "мойАккаунтToolStripMenuItem";
			this.мойАккаунтToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.мойАккаунтToolStripMenuItem.Text = "Мой аккаунт";
			// 
			// информацияToolStripMenuItem
			// 
			this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
			this.информацияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.информацияToolStripMenuItem.Text = "Информация";
			// 
			// сменитьПарольToolStripMenuItem
			// 
			this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
			this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
			// 
			// заказыToolStripMenuItem
			// 
			this.заказыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовыйЗаказToolStripMenuItem,
            this.списокМоихЗаказовToolStripMenuItem,
            this.списокЗаказовВСистемеToolStripMenuItem});
			this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
			this.заказыToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.заказыToolStripMenuItem.Text = "Заказы";
			// 
			// пользователиToolStripMenuItem
			// 
			this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПанельУправленияПользователямиToolStripMenuItem});
			this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
			this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
			this.пользователиToolStripMenuItem.Text = "Пользователи";
			// 
			// товарыToolStripMenuItem
			// 
			this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПанельУправленияТоварамиToolStripMenuItem});
			this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
			this.товарыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.товарыToolStripMenuItem.Text = "Товары";
			// 
			// создатьНовыйЗаказToolStripMenuItem
			// 
			this.создатьНовыйЗаказToolStripMenuItem.Name = "создатьНовыйЗаказToolStripMenuItem";
			this.создатьНовыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.создатьНовыйЗаказToolStripMenuItem.Text = "Создать новый заказ";
			// 
			// списокМоихЗаказовToolStripMenuItem
			// 
			this.списокМоихЗаказовToolStripMenuItem.Name = "списокМоихЗаказовToolStripMenuItem";
			this.списокМоихЗаказовToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.списокМоихЗаказовToolStripMenuItem.Text = "Список моих заказов";
			// 
			// списокЗаказовВСистемеToolStripMenuItem
			// 
			this.списокЗаказовВСистемеToolStripMenuItem.Name = "списокЗаказовВСистемеToolStripMenuItem";
			this.списокЗаказовВСистемеToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
			this.списокЗаказовВСистемеToolStripMenuItem.Text = "Список заказов в системе";
			// 
			// открытьПанельУправленияПользователямиToolStripMenuItem
			// 
			this.открытьПанельУправленияПользователямиToolStripMenuItem.Name = "открытьПанельУправленияПользователямиToolStripMenuItem";
			this.открытьПанельУправленияПользователямиToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
			this.открытьПанельУправленияПользователямиToolStripMenuItem.Text = "Открыть панель управления пользователями";
			// 
			// открытьПанельУправленияТоварамиToolStripMenuItem
			// 
			this.открытьПанельУправленияТоварамиToolStripMenuItem.Name = "открытьПанельУправленияТоварамиToolStripMenuItem";
			this.открытьПанельУправленияТоварамиToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
			this.открытьПанельУправленияТоварамиToolStripMenuItem.Text = "Открыть панель управления товарами";
			// 
			// DashboardForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 291);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "DashboardForm";
			this.Text = "Панель управления %position%";
			this.Load += new System.EventHandler(this.DashboardForm_Load);
			this.Click += new System.EventHandler(this.DashboardForm_Click);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem мойАккаунтToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem создатьНовыйЗаказToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокМоихЗаказовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem списокЗаказовВСистемеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьПанельУправленияПользователямиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьПанельУправленияТоварамиToolStripMenuItem;
	}
}