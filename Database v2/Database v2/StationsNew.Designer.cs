namespace Database_v2
{
	partial class StationsNew
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationsNew));
			this.станцииTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.СтанцииTableAdapter();
			this.database1DataSet1 = new Database_v2.Database1DataSet();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// станцииTableAdapter1
			// 
			this.станцииTableAdapter1.ClearBeforeFill = true;
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(88, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 29);
			this.button1.TabIndex = 0;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(43, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(107, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Код станції";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(43, 113);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(107, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "Назва станції";
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(168, 73);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 27);
			this.textBox3.TabIndex = 3;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(168, 113);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 27);
			this.textBox4.TabIndex = 4;
			// 
			// StationsNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(298, 266);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "StationsNew";
			this.Text = "Додавання станції";
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Database1DataSetTableAdapters.СтанцииTableAdapter станцииTableAdapter1;
		private Database1DataSet database1DataSet1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
	}
}