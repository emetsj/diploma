namespace Database_v2
{
	partial class TypeNew
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
			this.database1DataSet1 = new Database_v2.Database1DataSet();
			this.тип_вагонаTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.Тип_вагонаTableAdapter();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// тип_вагонаTableAdapter1
			// 
			this.тип_вагонаTableAdapter1.ClearBeforeFill = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(132, 214);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(77, 77);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox1.Size = new System.Drawing.Size(118, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Код вагону";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(77, 118);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox2.Size = new System.Drawing.Size(118, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "Тип";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(77, 162);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox3.Size = new System.Drawing.Size(118, 20);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "Кількість місць";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(214, 74);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 27);
			this.textBox4.TabIndex = 4;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(214, 116);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 27);
			this.textBox5.TabIndex = 5;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(214, 159);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 27);
			this.textBox6.TabIndex = 6;
			// 
			// TypeNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 321);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "TypeNew";
			this.Text = "Додавання нового типу вагона";
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSet database1DataSet1;
		private Database1DataSetTableAdapters.Тип_вагонаTableAdapter тип_вагонаTableAdapter1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
	}
}