namespace Библиотечная_система.Карточка_читателя
{
    partial class Год_издания
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Год_издания));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.годИзданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годИзданияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.библиотекаDataSet = new Библиотечная_система.БиблиотекаDataSet();
            this.год_изданияTableAdapter = new Библиотечная_система.БиблиотекаDataSetTableAdapters.Год_изданияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.годИзданияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.годИзданияDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.годИзданияBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(776, 426);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // годИзданияDataGridViewTextBoxColumn
            // 
            this.годИзданияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.годИзданияDataGridViewTextBoxColumn.DataPropertyName = "Год издания";
            this.годИзданияDataGridViewTextBoxColumn.HeaderText = "Год издания";
            this.годИзданияDataGridViewTextBoxColumn.Name = "годИзданияDataGridViewTextBoxColumn";
            this.годИзданияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // годИзданияBindingSource
            // 
            this.годИзданияBindingSource.DataMember = "Год издания";
            this.годИзданияBindingSource.DataSource = this.библиотекаDataSet;
            // 
            // библиотекаDataSet
            // 
            this.библиотекаDataSet.DataSetName = "БиблиотекаDataSet";
            this.библиотекаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // год_изданияTableAdapter
            // 
            this.год_изданияTableAdapter.ClearBeforeFill = true;
            // 
            // Год_издания
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Год_издания";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Год издания";
            this.Load += new System.EventHandler(this.Год_издания_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.годИзданияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.библиотекаDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private БиблиотекаDataSet библиотекаDataSet;
        private System.Windows.Forms.BindingSource годИзданияBindingSource;
        private БиблиотекаDataSetTableAdapters.Год_изданияTableAdapter год_изданияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn годИзданияDataGridViewTextBoxColumn;
    }
}