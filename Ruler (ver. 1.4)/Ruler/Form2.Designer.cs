namespace Ruler
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Startlabel0 = new System.Windows.Forms.Label();
            this.StartradioButton2 = new System.Windows.Forms.RadioButton();
            this.StartradioButton1 = new System.Windows.Forms.RadioButton();
            this.panel21 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ManualdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manuallabel1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AutoradioButton4 = new System.Windows.Forms.RadioButton();
            this.AutoradioButton3 = new System.Windows.Forms.RadioButton();
            this.Autolabel4 = new System.Windows.Forms.Label();
            this.AutotextBox4 = new System.Windows.Forms.TextBox();
            this.Autolabel2 = new System.Windows.Forms.Label();
            this.Autolabel3 = new System.Windows.Forms.Label();
            this.AutotextBox2 = new System.Windows.Forms.TextBox();
            this.AutotextBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.AutotextBox1 = new System.Windows.Forms.TextBox();
            this.AutoradioButton2 = new System.Windows.Forms.RadioButton();
            this.AutoradioButton1 = new System.Windows.Forms.RadioButton();
            this.Autolabel1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panlabel3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualdataGridView1)).BeginInit();
            this.panel22.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 329);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автоматический режим";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вариант построения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Startlabel0);
            this.panel2.Controls.Add(this.StartradioButton2);
            this.panel2.Controls.Add(this.StartradioButton1);
            this.panel2.Location = new System.Drawing.Point(155, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 325);
            this.panel2.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(238, 297);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Startlabel0
            // 
            this.Startlabel0.AutoSize = true;
            this.Startlabel0.Location = new System.Drawing.Point(33, 46);
            this.Startlabel0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Startlabel0.Name = "Startlabel0";
            this.Startlabel0.Size = new System.Drawing.Size(196, 13);
            this.Startlabel0.TabIndex = 2;
            this.Startlabel0.Text = "Выберите вариант построения фигур";
            // 
            // StartradioButton2
            // 
            this.StartradioButton2.AutoSize = true;
            this.StartradioButton2.Location = new System.Drawing.Point(35, 161);
            this.StartradioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.StartradioButton2.Name = "StartradioButton2";
            this.StartradioButton2.Size = new System.Drawing.Size(97, 17);
            this.StartradioButton2.TabIndex = 1;
            this.StartradioButton2.Text = "Ручной режим";
            this.StartradioButton2.UseVisualStyleBackColor = true;
            // 
            // StartradioButton1
            // 
            this.StartradioButton1.AutoSize = true;
            this.StartradioButton1.Checked = true;
            this.StartradioButton1.Location = new System.Drawing.Point(35, 139);
            this.StartradioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.StartradioButton1.Name = "StartradioButton1";
            this.StartradioButton1.Size = new System.Drawing.Size(146, 17);
            this.StartradioButton1.TabIndex = 0;
            this.StartradioButton1.TabStop = true;
            this.StartradioButton1.Text = "Автоматический режим";
            this.StartradioButton1.UseVisualStyleBackColor = true;
            this.StartradioButton1.CheckedChanged += new System.EventHandler(this.StartradioButton1_CheckedChanged);
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.button3);
            this.panel21.Controls.Add(this.button4);
            this.panel21.Controls.Add(this.ManualdataGridView1);
            this.panel21.Controls.Add(this.Manuallabel1);
            this.panel21.Controls.Add(this.label21);
            this.panel21.Location = new System.Drawing.Point(155, 0);
            this.panel21.Margin = new System.Windows.Forms.Padding(2);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(375, 325);
            this.panel21.TabIndex = 16;
            this.panel21.Visible = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(238, 297);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 27);
            this.button3.TabIndex = 19;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 297);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 27);
            this.button4.TabIndex = 18;
            this.button4.Text = "Старт";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ManualdataGridView1
            // 
            this.ManualdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ManualdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.ManualdataGridView1.Location = new System.Drawing.Point(201, 40);
            this.ManualdataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.ManualdataGridView1.Name = "ManualdataGridView1";
            this.ManualdataGridView1.RowTemplate.Height = 24;
            this.ManualdataGridView1.Size = new System.Drawing.Size(172, 185);
            this.ManualdataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Сonf";
            this.Column1.Name = "Column1";
            // 
            // Manuallabel1
            // 
            this.Manuallabel1.AutoSize = true;
            this.Manuallabel1.Location = new System.Drawing.Point(2, 40);
            this.Manuallabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Manuallabel1.Name = "Manuallabel1";
            this.Manuallabel1.Size = new System.Drawing.Size(197, 13);
            this.Manuallabel1.TabIndex = 2;
            this.Manuallabel1.Text = "Введите конфигурации для просчета:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(172, 1);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "Вручную";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.panel3);
            this.panel22.Controls.Add(this.button5);
            this.panel22.Controls.Add(this.button6);
            this.panel22.Controls.Add(this.AutotextBox1);
            this.panel22.Controls.Add(this.AutoradioButton2);
            this.panel22.Controls.Add(this.AutoradioButton1);
            this.panel22.Controls.Add(this.Autolabel1);
            this.panel22.Controls.Add(this.label22);
            this.panel22.Location = new System.Drawing.Point(155, 0);
            this.panel22.Margin = new System.Windows.Forms.Padding(2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(375, 325);
            this.panel22.TabIndex = 17;
            this.panel22.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AutoradioButton4);
            this.panel3.Controls.Add(this.AutoradioButton3);
            this.panel3.Controls.Add(this.Autolabel4);
            this.panel3.Controls.Add(this.AutotextBox4);
            this.panel3.Controls.Add(this.Autolabel2);
            this.panel3.Controls.Add(this.Autolabel3);
            this.panel3.Controls.Add(this.AutotextBox2);
            this.panel3.Controls.Add(this.AutotextBox3);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(113, 105);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 120);
            this.panel3.TabIndex = 20;
            // 
            // AutoradioButton4
            // 
            this.AutoradioButton4.AutoSize = true;
            this.AutoradioButton4.Location = new System.Drawing.Point(2, 102);
            this.AutoradioButton4.Margin = new System.Windows.Forms.Padding(2);
            this.AutoradioButton4.Name = "AutoradioButton4";
            this.AutoradioButton4.Size = new System.Drawing.Size(162, 17);
            this.AutoradioButton4.TabIndex = 12;
            this.AutoradioButton4.Text = "Увеличение в обе стороны";
            this.AutoradioButton4.UseVisualStyleBackColor = true;
            // 
            // AutoradioButton3
            // 
            this.AutoradioButton3.AutoSize = true;
            this.AutoradioButton3.Checked = true;
            this.AutoradioButton3.Location = new System.Drawing.Point(2, 70);
            this.AutoradioButton3.Margin = new System.Windows.Forms.Padding(2);
            this.AutoradioButton3.Name = "AutoradioButton3";
            this.AutoradioButton3.Size = new System.Drawing.Size(174, 17);
            this.AutoradioButton3.TabIndex = 11;
            this.AutoradioButton3.TabStop = true;
            this.AutoradioButton3.Text = "Увеличение с одной стороны";
            this.AutoradioButton3.UseVisualStyleBackColor = true;
            // 
            // Autolabel4
            // 
            this.Autolabel4.AutoSize = true;
            this.Autolabel4.Location = new System.Drawing.Point(1, 4);
            this.Autolabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Autolabel4.Name = "Autolabel4";
            this.Autolabel4.Size = new System.Drawing.Size(140, 13);
            this.Autolabel4.TabIndex = 14;
            this.Autolabel4.Text = "Начальная конфигурация:";
            // 
            // AutotextBox4
            // 
            this.AutotextBox4.Location = new System.Drawing.Point(142, 2);
            this.AutotextBox4.Margin = new System.Windows.Forms.Padding(2);
            this.AutotextBox4.Name = "AutotextBox4";
            this.AutotextBox4.Size = new System.Drawing.Size(116, 20);
            this.AutotextBox4.TabIndex = 15;
            // 
            // Autolabel2
            // 
            this.Autolabel2.AutoSize = true;
            this.Autolabel2.Location = new System.Drawing.Point(2, 31);
            this.Autolabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Autolabel2.Name = "Autolabel2";
            this.Autolabel2.Size = new System.Drawing.Size(64, 13);
            this.Autolabel2.TabIndex = 5;
            this.Autolabel2.Text = "Мин. длина";
            // 
            // Autolabel3
            // 
            this.Autolabel3.AutoSize = true;
            this.Autolabel3.Location = new System.Drawing.Point(108, 31);
            this.Autolabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Autolabel3.Name = "Autolabel3";
            this.Autolabel3.Size = new System.Drawing.Size(70, 13);
            this.Autolabel3.TabIndex = 6;
            this.Autolabel3.Text = "Макс. длина";
            // 
            // AutotextBox2
            // 
            this.AutotextBox2.Location = new System.Drawing.Point(70, 28);
            this.AutotextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.AutotextBox2.Name = "AutotextBox2";
            this.AutotextBox2.Size = new System.Drawing.Size(31, 20);
            this.AutotextBox2.TabIndex = 13;
            // 
            // AutotextBox3
            // 
            this.AutotextBox3.Location = new System.Drawing.Point(180, 28);
            this.AutotextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.AutotextBox3.Name = "AutotextBox3";
            this.AutotextBox3.Size = new System.Drawing.Size(31, 20);
            this.AutotextBox3.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(238, 297);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 27);
            this.button5.TabIndex = 19;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(312, 297);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 27);
            this.button6.TabIndex = 18;
            this.button6.Text = "Старт";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // AutotextBox1
            // 
            this.AutotextBox1.Location = new System.Drawing.Point(158, 49);
            this.AutotextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.AutotextBox1.Name = "AutotextBox1";
            this.AutotextBox1.Size = new System.Drawing.Size(31, 20);
            this.AutotextBox1.TabIndex = 9;
            // 
            // AutoradioButton2
            // 
            this.AutoradioButton2.Location = new System.Drawing.Point(4, 93);
            this.AutoradioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.AutoradioButton2.Name = "AutoradioButton2";
            this.AutoradioButton2.Size = new System.Drawing.Size(87, 36);
            this.AutoradioButton2.TabIndex = 8;
            this.AutoradioButton2.Text = "Увеличение звеньев";
            this.AutoradioButton2.UseVisualStyleBackColor = true;
            this.AutoradioButton2.CheckedChanged += new System.EventHandler(this.AutoradioButton2_CheckedChanged);
            // 
            // AutoradioButton1
            // 
            this.AutoradioButton1.AutoSize = true;
            this.AutoradioButton1.Checked = true;
            this.AutoradioButton1.Location = new System.Drawing.Point(4, 48);
            this.AutoradioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.AutoradioButton1.Name = "AutoradioButton1";
            this.AutoradioButton1.Size = new System.Drawing.Size(72, 17);
            this.AutoradioButton1.TabIndex = 7;
            this.AutoradioButton1.TabStop = true;
            this.AutoradioButton1.Text = "По длине";
            this.AutoradioButton1.UseVisualStyleBackColor = true;
            // 
            // Autolabel1
            // 
            this.Autolabel1.AutoSize = true;
            this.Autolabel1.Location = new System.Drawing.Point(116, 51);
            this.Autolabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Autolabel1.Name = "Autolabel1";
            this.Autolabel1.Size = new System.Drawing.Size(40, 13);
            this.Autolabel1.TabIndex = 4;
            this.Autolabel1.Text = "Длина";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(150, 1);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "Автоматически";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.progressBar2);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.Panlabel3);
            this.panel4.Location = new System.Drawing.Point(155, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 325);
            this.panel4.TabIndex = 18;
            this.panel4.Visible = false;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(294, 294);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 28;
            this.button7.Text = "Ок";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(35, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Время выполнения: 00:00:00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(35, 175);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(301, 23);
            this.progressBar2.TabIndex = 27;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(35, 70);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(301, 23);
            this.progressBar1.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(35, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Время выполнения всего: 00:00:00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Location = new System.Drawing.Point(35, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 14);
            this.label12.TabIndex = 24;
            this.label12.Text = "Прогнозируемое время выполнения: 00:00:00";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Location = new System.Drawing.Point(35, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 14);
            this.label13.TabIndex = 23;
            this.label13.Text = "Время выполнения: 00:00:00";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Location = new System.Drawing.Point(35, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(300, 14);
            this.label14.TabIndex = 22;
            this.label14.Text = "Найдено 0 вариантов из 0";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Создание обобщенных чисел Белла";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(35, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Время выполнения всего: 00:00:00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(35, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Прогнозируемое время выполнения: 00:00:00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(35, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Найдено 0 вариантов из 0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Panlabel3
            // 
            this.Panlabel3.AutoSize = true;
            this.Panlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Panlabel3.Location = new System.Drawing.Point(32, 5);
            this.Panlabel3.Name = "Panlabel3";
            this.Panlabel3.Size = new System.Drawing.Size(322, 17);
            this.Panlabel3.TabIndex = 16;
            this.Panlabel3.Text = "Создание массива уникальных разбиений длин";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(0, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Расчет";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 329);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManualdataGridView1)).EndInit();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private int tabItem;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label Startlabel0;
		private System.Windows.Forms.RadioButton StartradioButton2;
		private System.Windows.Forms.RadioButton StartradioButton1;
		private System.Windows.Forms.Panel panel21;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridView ManualdataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Label Manuallabel1;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Panel panel22;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox AutotextBox4;
		private System.Windows.Forms.Label Autolabel4;
		private System.Windows.Forms.TextBox AutotextBox2;
		private System.Windows.Forms.RadioButton AutoradioButton4;
		private System.Windows.Forms.RadioButton AutoradioButton3;
		private System.Windows.Forms.TextBox AutotextBox3;
		private System.Windows.Forms.TextBox AutotextBox1;
		private System.Windows.Forms.RadioButton AutoradioButton2;
		private System.Windows.Forms.RadioButton AutoradioButton1;
		private System.Windows.Forms.Label Autolabel3;
		private System.Windows.Forms.Label Autolabel2;
		private System.Windows.Forms.Label Autolabel1;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Panlabel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
    }
}