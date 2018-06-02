namespace Database_v2
{
    partial class Ticket
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.билетBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.билетTableAdapter = new Database_v2.Database1DataSetTableAdapters.БилетTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.билетDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.билетDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// билетBindingSource
			// 
			this.билетBindingSource.DataMember = "Билет";
			this.билетBindingSource.DataSource = this.database1DataSet;
			// 
			// билетTableAdapter
			// 
			this.билетTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = Database_v2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.БилетTableAdapter = this.билетTableAdapter;
			this.tableAdapterManager.Зал_ожидания_занятоTableAdapter = null;
			this.tableAdapterManager.Зал_ожидания_местаTableAdapter = null;
			this.tableAdapterManager.МаршрутTableAdapter = null;
			this.tableAdapterManager.Место_в_вагонеTableAdapter = null;
			this.tableAdapterManager.ПассажирTableAdapter = null;
			this.tableAdapterManager.ПоездаTableAdapter = null;
			this.tableAdapterManager.РейсTableAdapter = null;
			this.tableAdapterManager.СтанцииTableAdapter = null;
			this.tableAdapterManager.Тип_вагонаTableAdapter = null;
			// 
			// билетDataGridView
			// 
			this.билетDataGridView.AutoGenerateColumns = false;
			this.билетDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.билетDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
			this.билетDataGridView.DataSource = this.билетBindingSource;
			this.билетDataGridView.Location = new System.Drawing.Point(24, 18);
			this.билетDataGridView.Name = "билетDataGridView";
			this.билетDataGridView.Size = new System.Drawing.Size(743, 272);
			this.билетDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Код билета";
			this.dataGridViewTextBoxColumn1.HeaderText = "Код билета";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Код пассажира";
			this.dataGridViewTextBoxColumn2.HeaderText = "Код пассажира";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Код поезда";
			this.dataGridViewTextBoxColumn3.HeaderText = "Код поезда";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Код вагона";
			this.dataGridViewTextBoxColumn4.HeaderText = "Код вагона";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Код места";
			this.dataGridViewTextBoxColumn5.HeaderText = "Код места";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Льгота";
			this.dataGridViewTextBoxColumn6.HeaderText = "Льгота";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Цена";
			this.dataGridViewTextBoxColumn7.HeaderText = "Цена";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(305, 306);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 37);
			this.button1.TabIndex = 2;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Ticket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(789, 355);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.билетDataGridView);
			this.Name = "Ticket";
			this.Text = "Список квитків";
			this.Load += new System.EventHandler(this.Ticket_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.билетBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.билетDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource билетBindingSource;
        private Database1DataSetTableAdapters.БилетTableAdapter билетTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView билетDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.Button button1;
	}
}