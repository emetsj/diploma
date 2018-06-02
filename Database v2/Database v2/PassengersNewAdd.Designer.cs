namespace Database_v2
{
    partial class PassengersNewAdd
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassengersNewAdd));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.database1DataSet = new Database_v2.Database1DataSet();
			this.пассажирBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.пассажирTableAdapter = new Database_v2.Database1DataSetTableAdapters.ПассажирTableAdapter();
			this.tableAdapterManager = new Database_v2.Database1DataSetTableAdapters.TableAdapterManager();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.пассажирBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(63, 81);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox1.Size = new System.Drawing.Size(119, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Код пасажира";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(63, 125);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox2.Size = new System.Drawing.Size(119, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "ПІБ";
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox3.Location = new System.Drawing.Point(63, 168);
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.textBox3.Size = new System.Drawing.Size(119, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Паспорт";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox4.Location = new System.Drawing.Point(197, 78);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(124, 27);
			this.textBox4.TabIndex = 3;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox5.Location = new System.Drawing.Point(197, 122);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(124, 27);
			this.textBox5.TabIndex = 4;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox6.Location = new System.Drawing.Point(197, 165);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(124, 27);
			this.textBox6.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(139, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 30);
			this.button1.TabIndex = 6;
			this.button1.Text = "Додати";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			// PassengersNewAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(364, 295);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "PassengersNewAdd";
			this.Text = "Додавання пасажира";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassengersNewAdd_FormClosing);
			this.Load += new System.EventHandler(this.PassengersNewAdd_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.пассажирBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource пассажирBindingSource;
        private Database1DataSetTableAdapters.ПассажирTableAdapter пассажирTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
	}
}