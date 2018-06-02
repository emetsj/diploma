namespace Database_v2
{
	partial class PlaceTrainNew
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceTrainNew));
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.место_в_вагонеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.место_в_вагонеTableAdapter = new Database_v2.Database1DataSetTableAdapters.Место_в_вагонеTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.место_в_вагонеBindingSource)).BeginInit();
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
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(90, 63);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Код місця";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(90, 100);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Код вагона";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(90, 136);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Тип місця";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(90, 172);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "Номер місця";
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(207, 60);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 27);
			this.textBox5.TabIndex = 4;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(207, 97);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 27);
			this.textBox6.TabIndex = 5;
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox7.Location = new System.Drawing.Point(207, 133);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 27);
			this.textBox7.TabIndex = 6;
			// 
			// textBox8
			// 
			this.textBox8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox8.Location = new System.Drawing.Point(207, 169);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 27);
			this.textBox8.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(155, 228);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 38);
			this.button1.TabIndex = 8;
			this.button1.Text = "Додати";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// PlaceTrainNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(424, 316);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "PlaceTrainNew";
			this.Text = "Додавання місця в вагоні";
			this.Load += new System.EventHandler(this.PlaceTrainNew_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.место_в_вагонеBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSet database1DataSet;
		private System.Windows.Forms.BindingSource место_в_вагонеBindingSource;
		private Database1DataSetTableAdapters.Место_в_вагонеTableAdapter место_в_вагонеTableAdapter;
		private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Button button1;
	}
}