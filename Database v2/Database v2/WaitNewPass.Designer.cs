namespace Database_v2
{
    partial class WaitNewPass
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitNewPass));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.database1DataSet1 = new Database_v2.Database1DataSet();
			this.tableAdapterManager1 = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			this.зал_ожидания_занятоTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.Зал_ожидания_занятоTableAdapter();
			this.зал_ожидания_местаTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.Зал_ожидания_местаTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(91, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 54);
			this.button1.TabIndex = 0;
			this.button1.Text = "Додати запис";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(34, 57);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(127, 24);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Код пасажира";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(34, 104);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(127, 24);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "Місце";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(34, 148);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(127, 24);
			this.textBox3.TabIndex = 3;
			this.textBox3.Text = "Кількість часу";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(167, 57);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 31);
			this.textBox4.TabIndex = 4;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(167, 104);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 31);
			this.textBox5.TabIndex = 5;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(167, 148);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 31);
			this.textBox6.TabIndex = 6;
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
			this.tableAdapterManager1.Зал_ожидания_занятоTableAdapter = this.зал_ожидания_занятоTableAdapter1;
			this.tableAdapterManager1.Зал_ожидания_местаTableAdapter = this.зал_ожидания_местаTableAdapter1;
			this.tableAdapterManager1.МаршрутTableAdapter = null;
			this.tableAdapterManager1.Место_в_вагонеTableAdapter = null;
			this.tableAdapterManager1.ПассажирTableAdapter = null;
			this.tableAdapterManager1.ПоездаTableAdapter = null;
			this.tableAdapterManager1.РейсTableAdapter = null;
			this.tableAdapterManager1.СтанцииTableAdapter = null;
			this.tableAdapterManager1.Тип_вагонаTableAdapter = null;
			// 
			// зал_ожидания_занятоTableAdapter1
			// 
			this.зал_ожидания_занятоTableAdapter1.ClearBeforeFill = true;
			// 
			// зал_ожидания_местаTableAdapter1
			// 
			this.зал_ожидания_местаTableAdapter1.ClearBeforeFill = true;
			// 
			// WaitNewPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(317, 289);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "WaitNewPass";
			this.Text = "Нове зайняте місце";
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private Database1DataSet database1DataSet1;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private Database1DataSetTableAdapters.Зал_ожидания_занятоTableAdapter зал_ожидания_занятоTableAdapter1;
        private Database1DataSetTableAdapters.Зал_ожидания_местаTableAdapter зал_ожидания_местаTableAdapter1;
    }
}