namespace NeuronProg
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.max_tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.min_tb = new System.Windows.Forms.TextBox();
            this.epoch_tb = new System.Windows.Forms.TextBox();
            this.e_tb = new System.Windows.Forms.TextBox();
            this.ro_tb = new System.Windows.Forms.TextBox();
            this.p_b = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.p_k = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mnk_b = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mnk_k = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.xlv = new System.Windows.Forms.ListBox();
            this.ylv = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.max_tb);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.min_tb);
            this.groupBox2.Controls.Add(this.epoch_tb);
            this.groupBox2.Controls.Add(this.e_tb);
            this.groupBox2.Controls.Add(this.ro_tb);
            this.groupBox2.Controls.Add(this.p_b);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.p_k);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(740, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 297);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Персептрон";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "до";
            // 
            // max_tb
            // 
            this.max_tb.Location = new System.Drawing.Point(202, 126);
            this.max_tb.Name = "max_tb";
            this.max_tb.Size = new System.Drawing.Size(39, 20);
            this.max_tb.TabIndex = 15;
            this.max_tb.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Случайные веса от";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Эпох";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Погрешность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Коэф. обучения";
            // 
            // min_tb
            // 
            this.min_tb.Location = new System.Drawing.Point(121, 126);
            this.min_tb.Name = "min_tb";
            this.min_tb.Size = new System.Drawing.Size(39, 20);
            this.min_tb.TabIndex = 10;
            this.min_tb.Text = "-1";
            // 
            // epoch_tb
            // 
            this.epoch_tb.Location = new System.Drawing.Point(122, 100);
            this.epoch_tb.Name = "epoch_tb";
            this.epoch_tb.Size = new System.Drawing.Size(81, 20);
            this.epoch_tb.TabIndex = 9;
            this.epoch_tb.Text = "5000";
            // 
            // e_tb
            // 
            this.e_tb.Location = new System.Drawing.Point(122, 74);
            this.e_tb.Name = "e_tb";
            this.e_tb.Size = new System.Drawing.Size(81, 20);
            this.e_tb.TabIndex = 8;
            this.e_tb.Text = "0,3";
            // 
            // ro_tb
            // 
            this.ro_tb.Location = new System.Drawing.Point(122, 48);
            this.ro_tb.Name = "ro_tb";
            this.ro_tb.Size = new System.Drawing.Size(81, 20);
            this.ro_tb.TabIndex = 7;
            this.ro_tb.Text = "0,00005";
            // 
            // p_b
            // 
            this.p_b.Location = new System.Drawing.Point(43, 247);
            this.p_b.Name = "p_b";
            this.p_b.Size = new System.Drawing.Size(57, 20);
            this.p_b.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "b = ";
            // 
            // p_k
            // 
            this.p_k.Location = new System.Drawing.Point(43, 218);
            this.p_k.Name = "p_k";
            this.p_k.Size = new System.Drawing.Size(57, 20);
            this.p_k.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "k = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "y = kx + b";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Расчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mnk_b);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mnk_k);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(446, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 297);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "МНК";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "y = kx + b";
            // 
            // mnk_b
            // 
            this.mnk_b.Location = new System.Drawing.Point(44, 126);
            this.mnk_b.Name = "mnk_b";
            this.mnk_b.Size = new System.Drawing.Size(57, 20);
            this.mnk_b.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "k = ";
            // 
            // mnk_k
            // 
            this.mnk_k.Location = new System.Drawing.Point(44, 96);
            this.mnk_k.Name = "mnk_k";
            this.mnk_k.Size = new System.Drawing.Size(57, 20);
            this.mnk_k.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(140, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // xlv
            // 
            this.xlv.FormattingEnabled = true;
            this.xlv.Items.AddRange(new object[] {
            "-2,9",
            "-2,2",
            "-1,5",
            "-0,8",
            "-0,1",
            "0,6",
            "1,3",
            "2",
            "2,7",
            "3,4",
            "4,1",
            "4,8",
            "5,5",
            "6,2",
            "6,9",
            "7,6",
            "8,3",
            "9",
            "9,7",
            "10,4"});
            this.xlv.Location = new System.Drawing.Point(12, 15);
            this.xlv.Name = "xlv";
            this.xlv.Size = new System.Drawing.Size(46, 277);
            this.xlv.TabIndex = 14;
            // 
            // ylv
            // 
            this.ylv.FormattingEnabled = true;
            this.ylv.Items.AddRange(new object[] {
            "-30,77",
            "-29,85",
            "-29,48",
            "-25,29",
            "-27,93",
            "-23,82",
            "-22,81",
            "-22,84",
            "-21,91",
            "-20,80",
            "-17,65",
            "-17,03",
            "-16,14",
            "-17",
            "-13,29",
            "-14,01",
            "-12,87",
            "-10,98",
            "-9,53",
            "-9,95"});
            this.ylv.Location = new System.Drawing.Point(64, 15);
            this.ylv.Name = "ylv";
            this.ylv.Size = new System.Drawing.Size(46, 277);
            this.ylv.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Расчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mnk_k
            // 
            this.mnk_k.Location = new System.Drawing.Point(44, 96);
            this.mnk_k.Name = "mnk_k";
            this.mnk_k.Size = new System.Drawing.Size(57, 20);
            this.mnk_k.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "k = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "b = ";
            // 
            // mnk_b
            // 
            this.mnk_b.Location = new System.Drawing.Point(44, 126);
            this.mnk_b.Name = "mnk_b";
            this.mnk_b.Size = new System.Drawing.Size(57, 20);
            this.mnk_b.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "y = kx + b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 438);
            this.Controls.Add(this.ylv);
            this.Controls.Add(this.xlv);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox max_tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox min_tb;
        private System.Windows.Forms.TextBox epoch_tb;
        private System.Windows.Forms.TextBox e_tb;
        private System.Windows.Forms.TextBox ro_tb;
        private System.Windows.Forms.TextBox p_b;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox p_k;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mnk_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mnk_k;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox xlv;
        private System.Windows.Forms.ListBox ylv;
    }
}

