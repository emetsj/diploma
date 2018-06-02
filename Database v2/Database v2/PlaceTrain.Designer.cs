namespace Database_v2
{
    partial class PlaceTrain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceTrain));
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.место_в_вагонеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.место_в_вагонеTableAdapter = new Database_v2.Database1DataSetTableAdapters.Место_в_вагонеTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.место_в_вагонеDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.место_в_вагонеBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.место_в_вагонеDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// место_в_вагонеBindingSource
			// 
			this.место_в_вагонеBindingSource.DataMember = "Место в вагоне";
			this.место_в_вагонеBindingSource.DataSource = this.database1DataSet;
			// 
			// место_в_вагонеTableAdapter
			// 
			this.место_в_вагонеTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = Database_v2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.БилетTableAdapter = null;
			this.tableAdapterManager.Зал_ожидания_занятоTableAdapter = null;
			this.tableAdapterManager.Зал_ожидания_местаTableAdapter = null;
			this.tableAdapterManager.МаршрутTableAdapter = null;
			this.tableAdapterManager.Место_в_вагонеTableAdapter = this.место_в_вагонеTableAdapter;
			this.tableAdapterManager.ПассажирTableAdapter = null;
			this.tableAdapterManager.ПоездаTableAdapter = null;
			this.tableAdapterManager.РейсTableAdapter = null;
			this.tableAdapterManager.СтанцииTableAdapter = null;
			this.tableAdapterManager.Тип_вагонаTableAdapter = null;
			// 
			// место_в_вагонеDataGridView
			// 
			this.место_в_вагонеDataGridView.AutoGenerateColumns = false;
			this.место_в_вагонеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.место_в_вагонеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.место_в_вагонеDataGridView.DataSource = this.место_в_вагонеBindingSource;
			this.место_в_вагонеDataGridView.Location = new System.Drawing.Point(22, 24);
			this.место_в_вагонеDataGridView.Name = "место_в_вагонеDataGridView";
			this.место_в_вагонеDataGridView.ReadOnly = true;
			this.место_в_вагонеDataGridView.Size = new System.Drawing.Size(448, 277);
			this.место_в_вагонеDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
			this.dataGridViewTextBoxColumn1.HeaderText = "Код";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Код вагона";
			this.dataGridViewTextBoxColumn2.HeaderText = "Код вагона";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Тип места";
			this.dataGridViewTextBoxColumn3.HeaderText = "Тип места";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер места";
			this.dataGridViewTextBoxColumn4.HeaderText = "Номер места";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(151, 322);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 34);
			this.button1.TabIndex = 2;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// PlaceTrain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(509, 379);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.место_в_вагонеDataGridView);
			this.Name = "PlaceTrain";
			this.Text = "Місце в вагоні";
			this.Load += new System.EventHandler(this.PlaceTrain_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.место_в_вагонеBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.место_в_вагонеDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource место_в_вагонеBindingSource;
        private Database1DataSetTableAdapters.Место_в_вагонеTableAdapter место_в_вагонеTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView место_в_вагонеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.Button button1;
	}
}