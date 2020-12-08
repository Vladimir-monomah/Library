namespace Библиотечная_система.Карточка_читателя
{
    partial class Новая_книга
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Новая_книга));
            this.positionFilterTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.типыНоменклатурыЗапросBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.библиотекаDataSet = new Библиотечная_система.БиблиотекаDataSet();
            this.типы_номенклатурыЗапросTableAdapter = new Библиотечная_система.БиблиотекаDataSetTableAdapters.Типы_номенклатурыЗапросTableAdapter();
            this.типыНоменклатурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типы_номенклатурыTableAdapter = new Библиотечная_система.БиблиотекаDataSetTableAdapters.Типы_номенклатурыTableAdapter();
            this.positionDataGridView = new System.Windows.Forms.DataGridView();
            this.названиеКнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.издательсвоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годИзданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.типыНоменклатурыЗапросBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыНоменклатурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // positionFilterTextBox
            // 
            this.positionFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positionFilterTextBox.Location = new System.Drawing.Point(81, 11);
            this.positionFilterTextBox.MaxLength = 30;
            this.positionFilterTextBox.Multiline = true;
            this.positionFilterTextBox.Name = "positionFilterTextBox";
            this.positionFilterTextBox.Size = new System.Drawing.Size(749, 30);
            this.positionFilterTextBox.TabIndex = 19;
            this.positionFilterTextBox.TextChanged += new System.EventHandler(this.positionFilterTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Поиск";
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Image = global::Библиотечная_система.Properties.Resources.кнопка_3;
            this.button12.Location = new System.Drawing.Point(836, 7);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(32, 30);
            this.button12.TabIndex = 17;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // типыНоменклатурыЗапросBindingSource
            // 
            this.типыНоменклатурыЗапросBindingSource.DataMember = "Типы номенклатурыЗапрос";
            this.типыНоменклатурыЗапросBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // библиотекаDataSet
            // 
            this.библиотекаDataSet.DataSetName = "БиблиотекаDataSet";
            this.библиотекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типы_номенклатурыЗапросTableAdapter
            // 
            this.типы_номенклатурыЗапросTableAdapter.ClearBeforeFill = true;
            // 
            // типыНоменклатурыBindingSource
            // 
            this.типыНоменклатурыBindingSource.DataMember = "Типы номенклатуры";
            this.типыНоменклатурыBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // типы_номенклатурыTableAdapter
            // 
            this.типы_номенклатурыTableAdapter.ClearBeforeFill = true;
            // 
            // positionDataGridView
            // 
            this.positionDataGridView.AutoGenerateColumns = false;
            this.positionDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.positionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеКнигиDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.издательсвоDataGridViewTextBoxColumn,
            this.годИзданияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.positionDataGridView.DataSource = this.типыНоменклатурыЗапросBindingSource;
            this.positionDataGridView.Location = new System.Drawing.Point(0, 47);
            this.positionDataGridView.Name = "positionDataGridView";
            this.positionDataGridView.RowTemplate.Height = 24;
            this.positionDataGridView.Size = new System.Drawing.Size(868, 501);
            this.positionDataGridView.TabIndex = 20;
            this.positionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.positionDataGridView_CellContentClick);
            // 
            // названиеКнигиDataGridViewTextBoxColumn
            // 
            this.названиеКнигиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеКнигиDataGridViewTextBoxColumn.DataPropertyName = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.HeaderText = "Название книги";
            this.названиеКнигиDataGridViewTextBoxColumn.Name = "названиеКнигиDataGridViewTextBoxColumn";
            this.названиеКнигиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            this.авторDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // издательсвоDataGridViewTextBoxColumn
            // 
            this.издательсвоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.издательсвоDataGridViewTextBoxColumn.DataPropertyName = "Издательсво";
            this.издательсвоDataGridViewTextBoxColumn.HeaderText = "Издательство";
            this.издательсвоDataGridViewTextBoxColumn.Name = "издательсвоDataGridViewTextBoxColumn";
            this.издательсвоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // годИзданияDataGridViewTextBoxColumn
            // 
            this.годИзданияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.годИзданияDataGridViewTextBoxColumn.DataPropertyName = "Год издания";
            this.годИзданияDataGridViewTextBoxColumn.HeaderText = "Год издания";
            this.годИзданияDataGridViewTextBoxColumn.Name = "годИзданияDataGridViewTextBoxColumn";
            this.годИзданияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Новая_книга
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 560);
            this.Controls.Add(this.positionDataGridView);
            this.Controls.Add(this.positionFilterTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Новая_книга";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая книга";
            this.Load += new System.EventHandler(this.Новая_книга_Load);
            ((System.ComponentModel.ISupportInitialize)(this.типыНоменклатурыЗапросBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типыНоменклатурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox positionFilterTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button12;
        private БиблиотекаDataSet библиотекаDataSet;
        private System.Windows.Forms.BindingSource типыНоменклатурыЗапросBindingSource;
        private БиблиотекаDataSetTableAdapters.Типы_номенклатурыЗапросTableAdapter типы_номенклатурыЗапросTableAdapter;
        private System.Windows.Forms.BindingSource типыНоменклатурыBindingSource;
        private БиблиотекаDataSetTableAdapters.Типы_номенклатурыTableAdapter типы_номенклатурыTableAdapter;
        private System.Windows.Forms.DataGridView positionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеКнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn издательсвоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годИзданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
    }
}