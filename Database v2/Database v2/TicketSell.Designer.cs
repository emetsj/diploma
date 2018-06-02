namespace Database_v2
{
	partial class TicketSell
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketSell));
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
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.database1DataSet1 = new Database_v2.Database1DataSet();
			this.билетTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.БилетTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(113, 51);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox1.Size = new System.Drawing.Size(149, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Код квитка";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(113, 86);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox2.Size = new System.Drawing.Size(149, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Код пасажира";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.Highlight;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(113, 121);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox3.Size = new System.Drawing.Size(149, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Код потягу";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.Highlight;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(113, 156);
			this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox4.Size = new System.Drawing.Size(149, 20);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "Код вагона";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.Highlight;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(113, 191);
			this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox5.Size = new System.Drawing.Size(149, 20);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "Код місця";
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.SystemColors.Highlight;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(113, 226);
			this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox6.Size = new System.Drawing.Size(149, 20);
			this.textBox6.TabIndex = 5;
			this.textBox6.Text = "Льгота";
			// 
			// textBox7
			// 
			this.textBox7.BackColor = System.Drawing.SystemColors.Highlight;
			this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox7.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox7.Location = new System.Drawing.Point(113, 261);
			this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox7.Size = new System.Drawing.Size(149, 20);
			this.textBox7.TabIndex = 6;
			this.textBox7.Text = "Ціна";
			// 
			// textBox8
			// 
			this.textBox8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox8.Location = new System.Drawing.Point(270, 48);
			this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(132, 27);
			this.textBox8.TabIndex = 7;
			// 
			// textBox9
			// 
			this.textBox9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox9.Location = new System.Drawing.Point(270, 83);
			this.textBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(132, 27);
			this.textBox9.TabIndex = 8;
			// 
			// textBox10
			// 
			this.textBox10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox10.Location = new System.Drawing.Point(270, 118);
			this.textBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(132, 27);
			this.textBox10.TabIndex = 9;
			// 
			// textBox11
			// 
			this.textBox11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox11.Location = new System.Drawing.Point(270, 153);
			this.textBox11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(132, 27);
			this.textBox11.TabIndex = 10;
			// 
			// textBox12
			// 
			this.textBox12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox12.Location = new System.Drawing.Point(270, 188);
			this.textBox12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(132, 27);
			this.textBox12.TabIndex = 11;
			// 
			// textBox13
			// 
			this.textBox13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox13.Location = new System.Drawing.Point(270, 223);
			this.textBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(132, 27);
			this.textBox13.TabIndex = 12;
			// 
			// textBox14
			// 
			this.textBox14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox14.Location = new System.Drawing.Point(270, 258);
			this.textBox14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(132, 27);
			this.textBox14.TabIndex = 13;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(186, 311);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 41);
			this.button1.TabIndex = 14;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// билетTableAdapter1
			// 
			this.билетTableAdapter1.ClearBeforeFill = true;
			// 
			// TicketSell
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(520, 385);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox14);
			this.Controls.Add(this.textBox13);
			this.Controls.Add(this.textBox12);
			this.Controls.Add(this.textBox11);
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
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "TicketSell";
			this.Text = "Продаж квитків";
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
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.Button button1;
		private Database1DataSet database1DataSet1;
		private Database1DataSetTableAdapters.БилетTableAdapter билетTableAdapter1;
	}
}