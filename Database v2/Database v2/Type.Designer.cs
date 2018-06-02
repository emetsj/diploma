namespace Database_v2
{
    partial class Type
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Type));
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.тип_вагонаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.тип_вагонаTableAdapter = new Database_v2.Database1DataSetTableAdapters.Тип_вагонаTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.тип_вагонаDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.тип_вагонаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.тип_вагонаDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// тип_вагонаBindingSource
			// 
			this.тип_вагонаBindingSource.DataMember = "Тип вагона";
			this.тип_вагонаBindingSource.DataSource = this.database1DataSet;
			// 
			// тип_вагонаTableAdapter
			// 
			this.тип_вагонаTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = Database_v2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.БилетTableAdapter = null;
			this.tableAdapterManager.Зал_ожидания_занятоTableAdapter = null;
			this.tableAdapterManager.Зал_ожидания_местаTableAdapter = null;
			this.tableAdapterManager.МаршрутTableAdapter = null;
			this.tableAdapterManager.Место_в_вагонеTableAdapter = null;
			this.tableAdapterManager.ПассажирTableAdapter = null;
			this.tableAdapterManager.ПоездаTableAdapter = null;
			this.tableAdapterManager.РейсTableAdapter = null;
			this.tableAdapterManager.СтанцииTableAdapter = null;
			this.tableAdapterManager.Тип_вагонаTableAdapter = this.тип_вагонаTableAdapter;
			// 
			// тип_вагонаDataGridView
			// 
			this.тип_вагонаDataGridView.AutoGenerateColumns = false;
			this.тип_вагонаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.тип_вагонаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.тип_вагонаDataGridView.DataSource = this.тип_вагонаBindingSource;
			this.тип_вагонаDataGridView.Location = new System.Drawing.Point(28, 12);
			this.тип_вагонаDataGridView.Name = "тип_вагонаDataGridView";
			this.тип_вагонаDataGridView.Size = new System.Drawing.Size(348, 243);
			this.тип_вагонаDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Код вагона";
			this.dataGridViewTextBoxColumn1.HeaderText = "Код вагона";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип";
			this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Кол-во мест";
			this.dataGridViewTextBoxColumn3.HeaderText = "Кол-во мест";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(133, 291);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Type
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(414, 360);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.тип_вагонаDataGridView);
			this.Name = "Type";
			this.Text = "Тип вагону";
			this.Load += new System.EventHandler(this.Type_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.тип_вагонаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.тип_вагонаDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource тип_вагонаBindingSource;
        private Database1DataSetTableAdapters.Тип_вагонаTableAdapter тип_вагонаTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView тип_вагонаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Button button1;
	}
}