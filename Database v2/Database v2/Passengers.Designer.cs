namespace Database_v2
{
    partial class Passengers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passengers));
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.пассажирBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.пассажирTableAdapter = new Database_v2.Database1DataSetTableAdapters.ПассажирTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.пассажирDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.пассажирBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.пассажирDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// пассажирBindingSource
			// 
			this.пассажирBindingSource.DataMember = "Пассажир";
			this.пассажирBindingSource.DataSource = this.database1DataSet;
			// 
			// пассажирTableAdapter
			// 
			this.пассажирTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.ПассажирTableAdapter = this.пассажирTableAdapter;
			this.tableAdapterManager.ПоездаTableAdapter = null;
			this.tableAdapterManager.РейсTableAdapter = null;
			this.tableAdapterManager.СтанцииTableAdapter = null;
			this.tableAdapterManager.Тип_вагонаTableAdapter = null;
			// 
			// пассажирDataGridView
			// 
			this.пассажирDataGridView.AutoGenerateColumns = false;
			this.пассажирDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.пассажирDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.пассажирDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.пассажирDataGridView.DataSource = this.пассажирBindingSource;
			this.пассажирDataGridView.Location = new System.Drawing.Point(45, 26);
			this.пассажирDataGridView.Name = "пассажирDataGridView";
			this.пассажирDataGridView.ReadOnly = true;
			this.пассажирDataGridView.Size = new System.Drawing.Size(350, 275);
			this.пассажирDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Код пассажира";
			this.dataGridViewTextBoxColumn1.HeaderText = "Код пассажира";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
			this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Паспорт";
			this.dataGridViewTextBoxColumn3.HeaderText = "Паспорт";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(133, 319);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Passengers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(445, 367);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.пассажирDataGridView);
			this.Name = "Passengers";
			this.Text = "Пасажири";
			this.Load += new System.EventHandler(this.Passengers_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.пассажирBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.пассажирDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource пассажирBindingSource;
        private Database1DataSetTableAdapters.ПассажирTableAdapter пассажирTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView пассажирDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}