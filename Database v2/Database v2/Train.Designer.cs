namespace Database_v2
{
    partial class Train
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Train));
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.место_в_вагонеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.место_в_вагонеTableAdapter = new Database_v2.Database1DataSetTableAdapters.Место_в_вагонеTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.поездаTableAdapter = new Database_v2.Database1DataSetTableAdapters.ПоездаTableAdapter();
			this.поездаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.поездаDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.место_в_вагонеBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.поездаDataGridView)).BeginInit();
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
			this.tableAdapterManager.ПоездаTableAdapter = this.поездаTableAdapter;
			this.tableAdapterManager.РейсTableAdapter = null;
			this.tableAdapterManager.СтанцииTableAdapter = null;
			this.tableAdapterManager.Тип_вагонаTableAdapter = null;
			// 
			// поездаTableAdapter
			// 
			this.поездаTableAdapter.ClearBeforeFill = true;
			// 
			// поездаBindingSource
			// 
			this.поездаBindingSource.DataMember = "Поезда";
			this.поездаBindingSource.DataSource = this.database1DataSet;
			// 
			// поездаDataGridView
			// 
			this.поездаDataGridView.AutoGenerateColumns = false;
			this.поездаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.поездаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
			this.поездаDataGridView.DataSource = this.поездаBindingSource;
			this.поездаDataGridView.Location = new System.Drawing.Point(28, 21);
			this.поездаDataGridView.Name = "поездаDataGridView";
			this.поездаDataGridView.Size = new System.Drawing.Size(738, 244);
			this.поездаDataGridView.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Код поезда";
			this.dataGridViewTextBoxColumn1.HeaderText = "Код поезда";
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
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер поезда";
			this.dataGridViewTextBoxColumn3.HeaderText = "Номер поезда";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Код станции отпр";
			this.dataGridViewTextBoxColumn4.HeaderText = "Код станции отпр";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Время отправления";
			this.dataGridViewTextBoxColumn5.HeaderText = "Время отправления";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Код станции прибытия";
			this.dataGridViewTextBoxColumn6.HeaderText = "Код станции прибытия";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Время прибытия";
			this.dataGridViewTextBoxColumn7.HeaderText = "Время прибытия";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Периодичность";
			this.dataGridViewTextBoxColumn8.HeaderText = "Периодичность";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Код рейса";
			this.dataGridViewTextBoxColumn9.HeaderText = "Код рейса";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(336, 285);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Train
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(799, 343);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.поездаDataGridView);
			this.Name = "Train";
			this.Text = "Потяги";
			this.Load += new System.EventHandler(this.Train_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.место_в_вагонеBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.поездаDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource место_в_вагонеBindingSource;
        private Database1DataSetTableAdapters.Место_в_вагонеTableAdapter место_в_вагонеTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.ПоездаTableAdapter поездаTableAdapter;
        private System.Windows.Forms.BindingSource поездаBindingSource;
        private System.Windows.Forms.DataGridView поездаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.Button button1;
	}
}