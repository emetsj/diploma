namespace Database_v2
{
    partial class Wait
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wait));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.зал_ожидания_занятоBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.зал_ожидания_занятоTableAdapter = new Database_v2.Database1DataSetTableAdapters.Зал_ожидания_занятоTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.зал_ожидания_местаTableAdapter = new Database_v2.Database1DataSetTableAdapters.Зал_ожидания_местаTableAdapter();
			this.зал_ожидания_занятоDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.зал_ожидания_местаBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.зал_ожидания_местаDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.зал_ожидания_занятоBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.зал_ожидания_занятоDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.зал_ожидания_местаBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.зал_ожидания_местаDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(76, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 24);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Типи місць";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(457, 30);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(125, 24);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Зайняті місця";
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// зал_ожидания_занятоBindingSource
			// 
			this.зал_ожидания_занятоBindingSource.DataMember = "Зал ожидания занято";
			this.зал_ожидания_занятоBindingSource.DataSource = this.database1DataSet;
			// 
			// зал_ожидания_занятоTableAdapter
			// 
			this.зал_ожидания_занятоTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = Database_v2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.БилетTableAdapter = null;
			this.tableAdapterManager.Зал_ожидания_занятоTableAdapter = this.зал_ожидания_занятоTableAdapter;
			this.tableAdapterManager.Зал_ожидания_местаTableAdapter = this.зал_ожидания_местаTableAdapter;
			this.tableAdapterManager.МаршрутTableAdapter = null;
			this.tableAdapterManager.Место_в_вагонеTableAdapter = null;
			this.tableAdapterManager.ПассажирTableAdapter = null;
			this.tableAdapterManager.ПоездаTableAdapter = null;
			this.tableAdapterManager.РейсTableAdapter = null;
			this.tableAdapterManager.СтанцииTableAdapter = null;
			this.tableAdapterManager.Тип_вагонаTableAdapter = null;
			// 
			// зал_ожидания_местаTableAdapter
			// 
			this.зал_ожидания_местаTableAdapter.ClearBeforeFill = true;
			// 
			// зал_ожидания_занятоDataGridView
			// 
			this.зал_ожидания_занятоDataGridView.AutoGenerateColumns = false;
			this.зал_ожидания_занятоDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.зал_ожидания_занятоDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.зал_ожидания_занятоDataGridView.DataSource = this.зал_ожидания_занятоBindingSource;
			this.зал_ожидания_занятоDataGridView.Location = new System.Drawing.Point(340, 73);
			this.зал_ожидания_занятоDataGridView.Name = "зал_ожидания_занятоDataGridView";
			this.зал_ожидания_занятоDataGridView.Size = new System.Drawing.Size(365, 270);
			this.зал_ожидания_занятоDataGridView.TabIndex = 3;
			this.зал_ожидания_занятоDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.зал_ожидания_занятоDataGridView_CellContentClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Код пассажира";
			this.dataGridViewTextBoxColumn1.HeaderText = "Код пассажира";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер места";
			this.dataGridViewTextBoxColumn2.HeaderText = "Номер места";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Кол-во времени, часов";
			this.dataGridViewTextBoxColumn3.HeaderText = "Кол-во времени, часов";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// зал_ожидания_местаBindingSource
			// 
			this.зал_ожидания_местаBindingSource.DataMember = "Зал ожидания места";
			this.зал_ожидания_местаBindingSource.DataSource = this.database1DataSet;
			// 
			// зал_ожидания_местаDataGridView
			// 
			this.зал_ожидания_местаDataGridView.AutoGenerateColumns = false;
			this.зал_ожидания_местаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.зал_ожидания_местаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.зал_ожидания_местаDataGridView.DataSource = this.зал_ожидания_местаBindingSource;
			this.зал_ожидания_местаDataGridView.Location = new System.Drawing.Point(25, 73);
			this.зал_ожидания_местаDataGridView.Name = "зал_ожидания_местаDataGridView";
			this.зал_ожидания_местаDataGridView.Size = new System.Drawing.Size(263, 270);
			this.зал_ожидания_местаDataGridView.TabIndex = 4;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Номер места";
			this.dataGridViewTextBoxColumn4.HeaderText = "Номер места";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Тип";
			this.dataGridViewTextBoxColumn5.HeaderText = "Тип";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(472, 363);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 59);
			this.button1.TabIndex = 5;
			this.button1.Text = "Нове зайняте місце";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(76, 363);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 59);
			this.button2.TabIndex = 6;
			this.button2.Text = "Нове місце";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Wait
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(736, 444);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.зал_ожидания_местаDataGridView);
			this.Controls.Add(this.зал_ожидания_занятоDataGridView);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Wait";
			this.Text = "Зал ожидания";
			this.Load += new System.EventHandler(this.Wait_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.зал_ожидания_занятоBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.зал_ожидания_занятоDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.зал_ожидания_местаBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.зал_ожидания_местаDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource зал_ожидания_занятоBindingSource;
        private Database1DataSetTableAdapters.Зал_ожидания_занятоTableAdapter зал_ожидания_занятоTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.Зал_ожидания_местаTableAdapter зал_ожидания_местаTableAdapter;
        private System.Windows.Forms.DataGridView зал_ожидания_занятоDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource зал_ожидания_местаBindingSource;
        private System.Windows.Forms.DataGridView зал_ожидания_местаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}