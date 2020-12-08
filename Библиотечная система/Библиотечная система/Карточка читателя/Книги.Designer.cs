namespace Библиотечная_система.Карточка_читателя
{
    partial class Книги
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Книги));
            this.panel = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tbIZD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbZhanr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tbDate);
            this.panel.Controls.Add(this.buttonSave);
            this.panel.Controls.Add(this.buttonCancel);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Controls.Add(this.tbSum);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pictureBox7);
            this.panel.Controls.Add(this.pictureBox6);
            this.panel.Controls.Add(this.tbIZD);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.tbZhanr);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.pictureBox5);
            this.panel.Controls.Add(this.pictureBox4);
            this.panel.Controls.Add(this.tbAutor);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Controls.Add(this.tbBookName);
            this.panel.Controls.Add(this.label37);
            this.panel.Controls.Add(this.labelFIO);
            this.panel.Controls.Add(this.label22);
            this.panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1025, 356);
            this.panel.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(3, 313);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 30);
            this.buttonSave.TabIndex = 134;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(121, 313);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 30);
            this.buttonCancel.TabIndex = 135;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Библиотечная_система.Properties.Resources._71669957_star_icon_asterisk_flat_icon_;
            this.pictureBox1.Location = new System.Drawing.Point(526, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(745, 225);
            this.tbSum.MaxLength = 6;
            this.tbSum.Multiline = true;
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(276, 29);
            this.tbSum.TabIndex = 132;
            this.tbSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDate_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(551, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 131;
            this.label1.Text = "Количество";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Библиотечная_система.Properties.Resources._71669957_star_icon_asterisk_flat_icon_;
            this.pictureBox7.Location = new System.Drawing.Point(12, 224);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(21, 23);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 130;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Библиотечная_система.Properties.Resources._71669957_star_icon_asterisk_flat_icon_;
            this.pictureBox6.Location = new System.Drawing.Point(12, 178);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 129;
            this.pictureBox6.TabStop = false;
            // 
            // tbIZD
            // 
            this.tbIZD.Location = new System.Drawing.Point(231, 225);
            this.tbIZD.MaxLength = 6;
            this.tbIZD.Multiline = true;
            this.tbIZD.Name = "tbIZD";
            this.tbIZD.Size = new System.Drawing.Size(276, 29);
            this.tbIZD.TabIndex = 128;
            this.tbIZD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBookName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 127;
            this.label5.Text = "Издательсво";
            // 
            // tbZhanr
            // 
            this.tbZhanr.Location = new System.Drawing.Point(231, 179);
            this.tbZhanr.MaxLength = 4;
            this.tbZhanr.Multiline = true;
            this.tbZhanr.Name = "tbZhanr";
            this.tbZhanr.Size = new System.Drawing.Size(276, 29);
            this.tbZhanr.TabIndex = 126;
            this.tbZhanr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBookName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 125;
            this.label4.Text = "Жанр";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Библиотечная_система.Properties.Resources._71669957_star_icon_asterisk_flat_icon_;
            this.pictureBox5.Location = new System.Drawing.Point(560, 89);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 124;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Библиотечная_система.Properties.Resources._71669957_star_icon_asterisk_flat_icon_;
            this.pictureBox4.Location = new System.Drawing.Point(12, 132);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 123;
            this.pictureBox4.TabStop = false;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(231, 135);
            this.tbAutor.MaxLength = 11;
            this.tbAutor.Multiline = true;
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(276, 29);
            this.tbAutor.TabIndex = 120;
            this.tbAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBookName_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 119;
            this.label3.Text = "Автор";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Библиотечная_система.Properties.Resources._71669957_star_icon_asterisk_flat_icon_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(231, 89);
            this.tbBookName.MaxLength = 30;
            this.tbBookName.Multiline = true;
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(276, 29);
            this.tbBookName.TabIndex = 103;
            this.tbBookName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBookName_KeyPress);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.Location = new System.Drawing.Point(587, 91);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(107, 21);
            this.label37.TabIndex = 57;
            this.label37.Text = "Год издания";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(35, 91);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(135, 21);
            this.labelFIO.TabIndex = 22;
            this.labelFIO.Text = "Название книги";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(341, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(206, 21);
            this.label22.TabIndex = 3;
            this.label22.Text = "Новая карточка книги";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(727, 88);
            this.tbDate.MaxLength = 6;
            this.tbDate.Multiline = true;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(276, 29);
            this.tbDate.TabIndex = 136;
            this.tbDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDate_KeyPress);
            // 
            // Книги
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 383);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Книги";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox tbIZD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbZhanr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbDate;
    }
}