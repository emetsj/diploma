namespace Database_v2
{
	partial class TraceNew
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraceNew));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.рейсTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.РейсTableAdapter();
			this.database1DataSet1 = new Database_v2.Database1DataSet();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(71, 50);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Код рейса";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(71, 83);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Код потяга";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(71, 116);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Дата";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(71, 149);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "Статус";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(71, 182);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "Код квитка";
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(186, 47);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 27);
			this.textBox6.TabIndex = 5;
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox7.Location = new System.Drawing.Point(186, 80);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 27);
			this.textBox7.TabIndex = 6;
			// 
			// textBox8
			// 
			this.textBox8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox8.Location = new System.Drawing.Point(186, 113);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 27);
			this.textBox8.TabIndex = 7;
			// 
			// textBox9
			// 
			this.textBox9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox9.Location = new System.Drawing.Point(186, 146);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 27);
			this.textBox9.TabIndex = 8;
			// 
			// textBox10
			// 
			this.textBox10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox10.Location = new System.Drawing.Point(186, 179);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(100, 27);
			this.textBox10.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(106, 243);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 35);
			this.button1.TabIndex = 10;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// рейсTableAdapter1
			// 
			this.рейсTableAdapter1.ClearBeforeFill = true;
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// TraceNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(378, 327);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "TraceNew";
			this.Text = "Додавання рейса";
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Button button1;
		private Database1DataSetTableAdapters.РейсTableAdapter рейсTableAdapter1;
		private Database1DataSet database1DataSet1;
	}
}