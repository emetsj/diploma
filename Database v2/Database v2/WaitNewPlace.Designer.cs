namespace Database_v2
{
	partial class WaitNewPlace
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitNewPlace));
			this.button1 = new System.Windows.Forms.Button();
			this.database1DataSet1 = new Database_v2.Database1DataSet();
			this.tableAdapterManager1 = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.зал_ожидания_местаTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.Зал_ожидания_местаTableAdapter();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(109, 218);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 39);
			this.button1.TabIndex = 0;
			this.button1.Text = "Додати";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.UpdateOrder = Database_v2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager1.БилетTableAdapter = null;
			this.tableAdapterManager1.Зал_ожидания_занятоTableAdapter = null;
			this.tableAdapterManager1.Зал_ожидания_местаTableAdapter = this.зал_ожидания_местаTableAdapter1;
			this.tableAdapterManager1.МаршрутTableAdapter = null;
			this.tableAdapterManager1.Место_в_вагонеTableAdapter = null;
			this.tableAdapterManager1.ПассажирTableAdapter = null;
			this.tableAdapterManager1.ПоездаTableAdapter = null;
			this.tableAdapterManager1.РейсTableAdapter = null;
			this.tableAdapterManager1.СтанцииTableAdapter = null;
			this.tableAdapterManager1.Тип_вагонаTableAdapter = null;
			// 
			// зал_ожидания_местаTableAdapter1
			// 
			this.зал_ожидания_местаTableAdapter1.ClearBeforeFill = true;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(40, 61);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Номер места";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(40, 119);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "Тип места";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(196, 61);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 27);
			this.textBox3.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(196, 119);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 27);
			this.textBox4.TabIndex = 4;
			// 
			// WaitNewPlace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(335, 292);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "WaitNewPlace";
			this.Text = "Додавання нового місця";
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private Database1DataSet database1DataSet1;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
		private Database1DataSetTableAdapters.Зал_ожидания_местаTableAdapter зал_ожидания_местаTableAdapter1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
	}
}