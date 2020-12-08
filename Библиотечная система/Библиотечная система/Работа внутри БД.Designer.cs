namespace Библиотечная_система
{
    partial class Работа_внутри_БД
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Работа_внутри_БД));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.типыНоменклатурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.карточкиСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сменитьАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменаПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьНаВыдачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLib = new System.Windows.Forms.Label();
            this.ведомостьКнигНаРукахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl.Location = new System.Drawing.Point(0, 96);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(788, 307);
            this.tabControl.TabIndex = 5;
            this.tabControl.Visible = false;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Location = new System.Drawing.Point(0, 37);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 53);
            this.panel.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::Библиотечная_система.Properties.Resources.no_photo_girl;
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.AddTabControl);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(270, 6);
            // 
            // типыНоменклатурыToolStripMenuItem
            // 
            this.типыНоменклатурыToolStripMenuItem.Name = "типыНоменклатурыToolStripMenuItem";
            this.типыНоменклатурыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.типыНоменклатурыToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.типыНоменклатурыToolStripMenuItem.Text = "Книги";
            this.типыНоменклатурыToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(270, 6);
            // 
            // карточкиСотрудниковToolStripMenuItem
            // 
            this.карточкиСотрудниковToolStripMenuItem.Name = "карточкиСотрудниковToolStripMenuItem";
            this.карточкиСотрудниковToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.карточкиСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.карточкиСотрудниковToolStripMenuItem.Text = "Карточки читателей";
            this.карточкиСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.карточкиСотрудниковToolStripMenuItem,
            this.toolStripMenuItem4,
            this.типыНоменклатурыToolStripMenuItem,
            this.toolStripMenuItem5,
            this.жанрКнигToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // жанрКнигToolStripMenuItem
            // 
            this.жанрКнигToolStripMenuItem.Name = "жанрКнигToolStripMenuItem";
            this.жанрКнигToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.жанрКнигToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.жанрКнигToolStripMenuItem.Text = "Жанр книг";
            this.жанрКнигToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьАккаунтToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.ведомостьНаВыдачуToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сменитьАккаунтToolStripMenuItem
            // 
            this.сменитьАккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменаПользователяToolStripMenuItem});
            this.сменитьАккаунтToolStripMenuItem.Name = "сменитьАккаунтToolStripMenuItem";
            this.сменитьАккаунтToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.сменитьАккаунтToolStripMenuItem.Text = "Сменить аккаунт";
            // 
            // сменаПользователяToolStripMenuItem
            // 
            this.сменаПользователяToolStripMenuItem.Name = "сменаПользователяToolStripMenuItem";
            this.сменаПользователяToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.сменаПользователяToolStripMenuItem.Text = "Смена пользователя";
            this.сменаПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменаПользователяToolStripMenuItem_Click);
            // 
            // ведомостьНаВыдачуToolStripMenuItem
            // 
            this.ведомостьНаВыдачуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ведомостьToolStripMenuItem,
            this.ведомостьКнигНаРукахToolStripMenuItem});
            this.ведомостьНаВыдачуToolStripMenuItem.Name = "ведомостьНаВыдачуToolStripMenuItem";
            this.ведомостьНаВыдачуToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.ведомостьНаВыдачуToolStripMenuItem.Text = "Ведомость на выдачу";
            // 
            // ведомостьToolStripMenuItem
            // 
            this.ведомостьToolStripMenuItem.Name = "ведомостьToolStripMenuItem";
            this.ведомостьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.ведомостьToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.ведомостьToolStripMenuItem.Text = "Ведомость по долгам";
            this.ведомостьToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(233, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // labelLib
            // 
            this.labelLib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLib.AutoSize = true;
            this.labelLib.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLib.Location = new System.Drawing.Point(8, 417);
            this.labelLib.Name = "labelLib";
            this.labelLib.Size = new System.Drawing.Size(64, 24);
            this.labelLib.TabIndex = 6;
            this.labelLib.Text = "label1";
            // 
            // ведомостьКнигНаРукахToolStripMenuItem
            // 
            this.ведомостьКнигНаРукахToolStripMenuItem.Name = "ведомостьКнигНаРукахToolStripMenuItem";
            this.ведомостьКнигНаРукахToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.ведомостьКнигНаРукахToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.ведомостьКнигНаРукахToolStripMenuItem.Text = "Ведомость книг на руках";
            this.ведомостьКнигНаРукахToolStripMenuItem.Click += new System.EventHandler(this.AddTabControl);
            // 
            // Работа_внутри_БД
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelLib);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Работа_внутри_БД";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Работа_внутри_БД_FormClosing);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem типыНоменклатурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem карточкиСотрудниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьАккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменаПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьНаВыдачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостьToolStripMenuItem;
        private System.Windows.Forms.Label labelLib;
        private System.Windows.Forms.ToolStripMenuItem ведомостьКнигНаРукахToolStripMenuItem;
    }
}

