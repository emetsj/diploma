namespace Database_v2
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button10 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button11 = new System.Windows.Forms.Button();
			this.database1DataSet1 = new Database_v2.Database1DataSet();
			this.билетTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.БилетTableAdapter();
			this.зал_ожидания_местаTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.Зал_ожидания_местаTableAdapter();
			this.поездаTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.ПоездаTableAdapter();
			this.рейсTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.РейсTableAdapter();
			this.станцииTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.СтанцииTableAdapter();
			this.тип_вагонаTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.Тип_вагонаTableAdapter();
			this.пассажирTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.ПассажирTableAdapter();
			this.место_в_вагонеTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.Место_в_вагонеTableAdapter();
			this.маршрутTableAdapter1 = new Database_v2.Database1DataSetTableAdapters.МаршрутTableAdapter();
			this.билетTableAdapter2 = new Database_v2.Database1DataSetTableAdapters.БилетTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(46, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 57);
			this.button1.TabIndex = 0;
			this.button1.Text = "Продані квитки";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.FlatAppearance.BorderSize = 2;
			this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(46, 284);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 57);
			this.button2.TabIndex = 1;
			this.button2.Text = "Зал очікування";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button3.FlatAppearance.BorderSize = 2;
			this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(111, 356);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 48);
			this.button3.TabIndex = 2;
			this.button3.Text = "Маршрути";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button4.FlatAppearance.BorderSize = 2;
			this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(179, 68);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(115, 57);
			this.button4.TabIndex = 3;
			this.button4.Text = "Дані про потяги";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button5.FlatAppearance.BorderSize = 2;
			this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(46, 142);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(115, 57);
			this.button5.TabIndex = 4;
			this.button5.Text = "Місця у вагонах";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button6.FlatAppearance.BorderSize = 2;
			this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.Location = new System.Drawing.Point(46, 219);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(115, 53);
			this.button6.TabIndex = 5;
			this.button6.Text = "Пасажири";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button7.FlatAppearance.BorderSize = 2;
			this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
			this.button7.Location = new System.Drawing.Point(179, 142);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(115, 57);
			this.button7.TabIndex = 6;
			this.button7.Text = "Станції";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button8.FlatAppearance.BorderSize = 2;
			this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button8.Location = new System.Drawing.Point(179, 219);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(115, 53);
			this.button8.TabIndex = 7;
			this.button8.Text = "Тип вагону";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
			this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button9.FlatAppearance.BorderSize = 2;
			this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
			this.button9.Location = new System.Drawing.Point(179, 284);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(115, 57);
			this.button9.TabIndex = 8;
			this.button9.Text = "Рейс";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Cornsilk;
			this.label1.Location = new System.Drawing.Point(77, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 26);
			this.label1.TabIndex = 10;
			this.label1.Text = "Показати таблицю";
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
			this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button10.FlatAppearance.BorderSize = 2;
			this.button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
			this.button10.Location = new System.Drawing.Point(579, 68);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(115, 48);
			this.button10.TabIndex = 19;
			this.button10.Text = "Рейс";
			this.button10.UseVisualStyleBackColor = false;
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
			this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button12.FlatAppearance.BorderSize = 2;
			this.button12.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
			this.button12.Location = new System.Drawing.Point(446, 142);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(115, 57);
			this.button12.TabIndex = 17;
			this.button12.Text = "Додати станцію";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
			this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button16.FlatAppearance.BorderSize = 2;
			this.button16.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
			this.button16.Location = new System.Drawing.Point(579, 142);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(115, 53);
			this.button16.TabIndex = 13;
			this.button16.Text = "Додати нові маршрути";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new System.EventHandler(this.button16_Click);
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.SystemColors.HotTrack;
			this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
			this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button18.FlatAppearance.BorderSize = 2;
			this.button18.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
			this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button18.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
			this.button18.Location = new System.Drawing.Point(446, 68);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(115, 57);
			this.button18.TabIndex = 11;
			this.button18.Text = "Продати квиток";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new System.EventHandler(this.button18_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Cornsilk;
			this.label2.Location = new System.Drawing.Point(499, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 26);
			this.label2.TabIndex = 20;
			this.label2.Text = "Додаткові дії";
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(485, 267);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(75, 23);
			this.button11.TabIndex = 21;
			this.button11.Text = "button11";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Visible = false;
			this.button11.Click += new System.EventHandler(this.button11_Click);
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
			// зал_ожидания_местаTableAdapter1
			// 
			this.зал_ожидания_местаTableAdapter1.ClearBeforeFill = true;
			// 
			// поездаTableAdapter1
			// 
			this.поездаTableAdapter1.ClearBeforeFill = true;
			// 
			// рейсTableAdapter1
			// 
			this.рейсTableAdapter1.ClearBeforeFill = true;
			// 
			// станцииTableAdapter1
			// 
			this.станцииTableAdapter1.ClearBeforeFill = true;
			// 
			// тип_вагонаTableAdapter1
			// 
			this.тип_вагонаTableAdapter1.ClearBeforeFill = true;
			// 
			// пассажирTableAdapter1
			// 
			this.пассажирTableAdapter1.ClearBeforeFill = true;
			// 
			// место_в_вагонеTableAdapter1
			// 
			this.место_в_вагонеTableAdapter1.ClearBeforeFill = true;
			// 
			// маршрутTableAdapter1
			// 
			this.маршрутTableAdapter1.ClearBeforeFill = true;
			// 
			// билетTableAdapter2
			// 
			this.билетTableAdapter2.ClearBeforeFill = true;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(737, 465);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Main";
			this.Text = "Главное меню";
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button11;
		private Database1DataSet database1DataSet1;
		private Database1DataSetTableAdapters.БилетTableAdapter билетTableAdapter1;
		private Database1DataSetTableAdapters.Зал_ожидания_местаTableAdapter зал_ожидания_местаTableAdapter1;
		private Database1DataSetTableAdapters.ПоездаTableAdapter поездаTableAdapter1;
		private Database1DataSetTableAdapters.РейсTableAdapter рейсTableAdapter1;
		private Database1DataSetTableAdapters.СтанцииTableAdapter станцииTableAdapter1;
		private Database1DataSetTableAdapters.Тип_вагонаTableAdapter тип_вагонаTableAdapter1;
		private Database1DataSetTableAdapters.ПассажирTableAdapter пассажирTableAdapter1;
		private Database1DataSetTableAdapters.Место_в_вагонеTableAdapter место_в_вагонеTableAdapter1;
		private Database1DataSetTableAdapters.МаршрутTableAdapter маршрутTableAdapter1;
		private Database1DataSetTableAdapters.БилетTableAdapter билетTableAdapter2;
	}
}

