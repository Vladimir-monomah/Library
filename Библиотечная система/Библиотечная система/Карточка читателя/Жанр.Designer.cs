namespace Библиотечная_система.Карточка_читателя
{
    partial class Жанр
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Жанр));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.названиеЖанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.библиотекаDataSet = new Библиотечная_система.БиблиотекаDataSet();
            this.жанрTableAdapter = new Библиотечная_система.БиблиотекаDataSetTableAdapters.ЖанрTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеЖанраDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.жанрBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(824, 470);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // названиеЖанраDataGridViewTextBoxColumn
            // 
            this.названиеЖанраDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеЖанраDataGridViewTextBoxColumn.DataPropertyName = "Название жанра";
            this.названиеЖанраDataGridViewTextBoxColumn.HeaderText = "Название жанра";
            this.названиеЖанраDataGridViewTextBoxColumn.Name = "названиеЖанраDataGridViewTextBoxColumn";
            this.названиеЖанраDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // жанрBindingSource
            // 
            this.жанрBindingSource.DataMember = "Жанр";
            this.жанрBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // библиотекаDataSet
            // 
            this.библиотекаDataSet.DataSetName = "БиблиотекаDataSet";
            this.библиотекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // жанрTableAdapter
            // 
            this.жанрTableAdapter.ClearBeforeFill = true;
            // 
            // Жанр
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 494);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Жанр";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Жанр";
            this.Load += new System.EventHandler(this.Жанр_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.жанрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private БиблиотекаDataSet библиотекаDataSet;
        private System.Windows.Forms.BindingSource жанрBindingSource;
        private БиблиотекаDataSetTableAdapters.ЖанрTableAdapter жанрTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеЖанраDataGridViewTextBoxColumn;
    }
}