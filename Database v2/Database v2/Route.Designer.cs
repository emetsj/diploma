namespace Database_v2
{
    partial class Route
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Route));
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.маршрутBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.маршрутTableAdapter = new Database_v2.Database1DataSetTableAdapters.МаршрутTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.маршрутDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.маршрутDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// маршрутBindingSource
			// 
			this.маршрутBindingSource.DataMember = "Маршрут";
			this.маршрутBindingSource.DataSource = this.database1DataSet;
			// 
			// маршрутTableAdapter
			// 
			this.маршрутTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = Database_v2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.БилетTableAdapter = null;
			this.tableAdapterManager.Зал_ожидания_занятоTableAdapter = null;
			this.tableAdapterManager.Зал_ожидания_местаTableAdapter = null;
			this.tableAdapterManager.МаршрутTableAdapter = this.маршрутTableAdapter;
			this.tableAdapterManager.Место_в_вагонеTableAdapter = null;
			this.tableAdapterManager.ПассажирTableAdapter = null;
			this.tableAdapterManager.ПоездаTableAdapter = null;
			this.tableAdapterManager.РейсTableAdapter = null;
			this.tableAdapterManager.СтанцииTableAdapter = null;
			this.tableAdapterManager.Тип_вагонаTableAdapter = null;
			// 
			// маршрутDataGridView
			// 
			this.маршрутDataGridView.AutoGenerateColumns = false;
			this.маршрутDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.маршрутDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.маршрутDataGridView.DataSource = this.маршрутBindingSource;
			this.маршрутDataGridView.Location = new System.Drawing.Point(33, 27);
			this.маршрутDataGridView.Name = "маршрутDataGridView";
			this.маршрутDataGridView.ReadOnly = true;
			this.маршрутDataGridView.Size = new System.Drawing.Size(545, 319);
			this.маршрутDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Код поезда";
			this.dataGridViewTextBoxColumn1.HeaderText = "Код поезда";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Код станции";
			this.dataGridViewTextBoxColumn2.HeaderText = "Код станции";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Время прибытия";
			this.dataGridViewTextBoxColumn3.HeaderText = "Время прибытия";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Время отправки";
			this.dataGridViewTextBoxColumn4.HeaderText = "Время отправки";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Расстояние";
			this.dataGridViewTextBoxColumn5.HeaderText = "Расстояние";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(219, 366);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(142, 35);
			this.button1.TabIndex = 2;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Route
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(612, 413);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.маршрутDataGridView);
			this.Name = "Route";
			this.Text = "Маршруты";
			this.Load += new System.EventHandler(this.Route_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.маршрутBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.маршрутDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource маршрутBindingSource;
        private Database1DataSetTableAdapters.МаршрутTableAdapter маршрутTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView маршрутDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Button button1;
	}
}