namespace Database_v2
{
    partial class Stations
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stations));
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.станцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.станцииTableAdapter = new Database_v2.Database1DataSetTableAdapters.СтанцииTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.станцииDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.станцииBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.станцииDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// станцииBindingSource
			// 
			this.станцииBindingSource.DataMember = "Станции";
			this.станцииBindingSource.DataSource = this.database1DataSet;
			// 
			// станцииTableAdapter
			// 
			this.станцииTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.СтанцииTableAdapter = this.станцииTableAdapter;
			this.tableAdapterManager.Тип_вагонаTableAdapter = null;
			// 
			// станцииDataGridView
			// 
			this.станцииDataGridView.AutoGenerateColumns = false;
			this.станцииDataGridView.BackgroundColor = System.Drawing.Color.GhostWhite;
			this.станцииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.станцииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.станцииDataGridView.DataSource = this.станцииBindingSource;
			this.станцииDataGridView.Location = new System.Drawing.Point(52, 24);
			this.станцииDataGridView.Name = "станцииDataGridView";
			this.станцииDataGridView.ReadOnly = true;
			this.станцииDataGridView.Size = new System.Drawing.Size(254, 292);
			this.станцииDataGridView.TabIndex = 1;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
			this.dataGridViewTextBoxColumn2.HeaderText = "Название";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F);
			this.button1.Location = new System.Drawing.Point(120, 332);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Stations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(394, 374);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.станцииDataGridView);
			this.Name = "Stations";
			this.Text = "Станції";
			this.Load += new System.EventHandler(this.Stations_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.станцииBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.станцииDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource станцииBindingSource;
        private Database1DataSetTableAdapters.СтанцииTableAdapter станцииTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView станцииDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Button button1;
	}
}