namespace UserConfig_TEST
{
    partial class main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.lblcpu0 = new System.Windows.Forms.Label();
            this.lblgpu = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.lblcpu1 = new System.Windows.Forms.Label();
            this.lblcpu2 = new System.Windows.Forms.Label();
            this.lblcpu3 = new System.Windows.Forms.Label();
            this.Cv1 = new System.Windows.Forms.Label();
            this.Cv2 = new System.Windows.Forms.Label();
            this.Cv3 = new System.Windows.Forms.Label();
            this.Cv4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cavg = new System.Windows.Forms.Label();
            this.chartCpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.Monitor = new System.Windows.Forms.TabPage();
            this.Gv1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.lbl_HTML = new System.Windows.Forms.Label();
            this.txt_Ghtml = new System.Windows.Forms.TextBox();
            this.txt_Bhtml = new System.Windows.Forms.TextBox();
            this.txt_Rhtml = new System.Windows.Forms.TextBox();
            this.lbl_RGB = new System.Windows.Forms.Label();
            this.txt_GREEN = new System.Windows.Forms.TextBox();
            this.txt_BLUE = new System.Windows.Forms.TextBox();
            this.txt_RED = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.track_BLUE = new System.Windows.Forms.TrackBar();
            this.track_GREEN = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.track_RED = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.Monitor.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_BLUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_GREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_RED)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcpu0
            // 
            this.lblcpu0.AutoSize = true;
            this.lblcpu0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpu0.Location = new System.Drawing.Point(17, 16);
            this.lblcpu0.Name = "lblcpu0";
            this.lblcpu0.Size = new System.Drawing.Size(48, 24);
            this.lblcpu0.TabIndex = 0;
            this.lblcpu0.Text = "CPU";
            // 
            // lblgpu
            // 
            this.lblgpu.AutoSize = true;
            this.lblgpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgpu.Location = new System.Drawing.Point(20, 184);
            this.lblgpu.Name = "lblgpu";
            this.lblgpu.Size = new System.Drawing.Size(49, 24);
            this.lblgpu.TabIndex = 1;
            this.lblgpu.Text = "GPU";
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(24, 255);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(61, 46);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Save_Click);
            // 
            // lblcpu1
            // 
            this.lblcpu1.AutoSize = true;
            this.lblcpu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpu1.Location = new System.Drawing.Point(17, 40);
            this.lblcpu1.Name = "lblcpu1";
            this.lblcpu1.Size = new System.Drawing.Size(48, 24);
            this.lblcpu1.TabIndex = 5;
            this.lblcpu1.Text = "CPU";
            // 
            // lblcpu2
            // 
            this.lblcpu2.AutoSize = true;
            this.lblcpu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpu2.Location = new System.Drawing.Point(17, 64);
            this.lblcpu2.Name = "lblcpu2";
            this.lblcpu2.Size = new System.Drawing.Size(48, 24);
            this.lblcpu2.TabIndex = 6;
            this.lblcpu2.Text = "CPU";
            // 
            // lblcpu3
            // 
            this.lblcpu3.AutoSize = true;
            this.lblcpu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpu3.Location = new System.Drawing.Point(17, 88);
            this.lblcpu3.Name = "lblcpu3";
            this.lblcpu3.Size = new System.Drawing.Size(48, 24);
            this.lblcpu3.TabIndex = 7;
            this.lblcpu3.Text = "CPU";
            // 
            // Cv1
            // 
            this.Cv1.AutoSize = true;
            this.Cv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cv1.Location = new System.Drawing.Point(81, 16);
            this.Cv1.Name = "Cv1";
            this.Cv1.Size = new System.Drawing.Size(48, 24);
            this.Cv1.TabIndex = 8;
            this.Cv1.Text = "CPU";
            // 
            // Cv2
            // 
            this.Cv2.AutoSize = true;
            this.Cv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cv2.Location = new System.Drawing.Point(80, 40);
            this.Cv2.Name = "Cv2";
            this.Cv2.Size = new System.Drawing.Size(48, 24);
            this.Cv2.TabIndex = 9;
            this.Cv2.Text = "CPU";
            // 
            // Cv3
            // 
            this.Cv3.AutoSize = true;
            this.Cv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cv3.Location = new System.Drawing.Point(80, 64);
            this.Cv3.Name = "Cv3";
            this.Cv3.Size = new System.Drawing.Size(48, 24);
            this.Cv3.TabIndex = 10;
            this.Cv3.Text = "CPU";
            // 
            // Cv4
            // 
            this.Cv4.AutoSize = true;
            this.Cv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cv4.Location = new System.Drawing.Point(80, 88);
            this.Cv4.Name = "Cv4";
            this.Cv4.Size = new System.Drawing.Size(48, 24);
            this.Cv4.TabIndex = 11;
            this.Cv4.Text = "CPU";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "AVG";
            // 
            // Cavg
            // 
            this.Cavg.AutoSize = true;
            this.Cavg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cavg.Location = new System.Drawing.Point(81, 123);
            this.Cavg.Name = "Cavg";
            this.Cavg.Size = new System.Drawing.Size(48, 24);
            this.Cavg.TabIndex = 13;
            this.Cavg.Text = "CPU";
            // 
            // chartCpu
            // 
            this.chartCpu.BackColor = System.Drawing.Color.Transparent;
            this.chartCpu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartCpu.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartCpu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCpu.Legends.Add(legend1);
            this.chartCpu.Location = new System.Drawing.Point(185, 7);
            this.chartCpu.Name = "chartCpu";
            this.chartCpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartCpu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Fuchsia;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.Transparent;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
            series1.Name = "CPU";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.Points.Add(dataPoint1);
            this.chartCpu.Series.Add(series1);
            this.chartCpu.Size = new System.Drawing.Size(524, 100);
            this.chartCpu.TabIndex = 100;
            this.chartCpu.Text = "chart1";
            // 
            // txt_log
            // 
            this.txt_log.BackColor = System.Drawing.Color.Black;
            this.txt_log.ForeColor = System.Drawing.Color.Lime;
            this.txt_log.Location = new System.Drawing.Point(202, 153);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(466, 157);
            this.txt_log.TabIndex = 16;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Setting";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.Monitor);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Location = new System.Drawing.Point(12, 12);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(717, 371);
            this.tab1.TabIndex = 19;
            // 
            // Monitor
            // 
            this.Monitor.Controls.Add(this.Gv1);
            this.Monitor.Controls.Add(this.chartCpu);
            this.Monitor.Controls.Add(this.txt_log);
            this.Monitor.Controls.Add(this.Cv2);
            this.Monitor.Controls.Add(this.lblcpu0);
            this.Monitor.Controls.Add(this.Stop);
            this.Monitor.Controls.Add(this.Cavg);
            this.Monitor.Controls.Add(this.lblgpu);
            this.Monitor.Controls.Add(this.label6);
            this.Monitor.Controls.Add(this.lblcpu1);
            this.Monitor.Controls.Add(this.Cv4);
            this.Monitor.Controls.Add(this.lblcpu2);
            this.Monitor.Controls.Add(this.Cv3);
            this.Monitor.Controls.Add(this.lblcpu3);
            this.Monitor.Controls.Add(this.Cv1);
            this.Monitor.Location = new System.Drawing.Point(4, 22);
            this.Monitor.Name = "Monitor";
            this.Monitor.Padding = new System.Windows.Forms.Padding(3);
            this.Monitor.Size = new System.Drawing.Size(709, 345);
            this.Monitor.TabIndex = 0;
            this.Monitor.Text = "Monitor";
            this.Monitor.UseVisualStyleBackColor = true;
            // 
            // Gv1
            // 
            this.Gv1.AutoSize = true;
            this.Gv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gv1.Location = new System.Drawing.Point(81, 184);
            this.Gv1.Name = "Gv1";
            this.Gv1.Size = new System.Drawing.Size(49, 24);
            this.Gv1.TabIndex = 19;
            this.Gv1.Text = "GPU";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.btn_OK);
            this.tabPage2.Controls.Add(this.lbl_HTML);
            this.tabPage2.Controls.Add(this.txt_Ghtml);
            this.tabPage2.Controls.Add(this.txt_Bhtml);
            this.tabPage2.Controls.Add(this.txt_Rhtml);
            this.tabPage2.Controls.Add(this.lbl_RGB);
            this.tabPage2.Controls.Add(this.txt_GREEN);
            this.tabPage2.Controls.Add(this.txt_BLUE);
            this.tabPage2.Controls.Add(this.txt_RED);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.track_BLUE);
            this.tabPage2.Controls.Add(this.track_GREEN);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.track_RED);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cpu 0",
            "cpu 1",
            "cpu 2",
            "cpu 3",
            "cpu 0 value",
            "cpu 1 value",
            "cpu 2 value",
            "cpu 3 value",
            "gpu",
            "gpu value"});
            this.comboBox1.Location = new System.Drawing.Point(156, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(299, 283);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 32;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lbl_HTML
            // 
            this.lbl_HTML.AutoSize = true;
            this.lbl_HTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HTML.Location = new System.Drawing.Point(338, 237);
            this.lbl_HTML.Name = "lbl_HTML";
            this.lbl_HTML.Size = new System.Drawing.Size(51, 20);
            this.lbl_HTML.TabIndex = 31;
            this.lbl_HTML.Text = "label3";
            // 
            // txt_Ghtml
            // 
            this.txt_Ghtml.Location = new System.Drawing.Point(453, 158);
            this.txt_Ghtml.Name = "txt_Ghtml";
            this.txt_Ghtml.Size = new System.Drawing.Size(62, 20);
            this.txt_Ghtml.TabIndex = 30;
            this.txt_Ghtml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Bhtml
            // 
            this.txt_Bhtml.Location = new System.Drawing.Point(453, 189);
            this.txt_Bhtml.Name = "txt_Bhtml";
            this.txt_Bhtml.Size = new System.Drawing.Size(62, 20);
            this.txt_Bhtml.TabIndex = 29;
            this.txt_Bhtml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Rhtml
            // 
            this.txt_Rhtml.Location = new System.Drawing.Point(453, 126);
            this.txt_Rhtml.Name = "txt_Rhtml";
            this.txt_Rhtml.Size = new System.Drawing.Size(62, 20);
            this.txt_Rhtml.TabIndex = 28;
            this.txt_Rhtml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_RGB
            // 
            this.lbl_RGB.AutoSize = true;
            this.lbl_RGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RGB.Location = new System.Drawing.Point(179, 237);
            this.lbl_RGB.Name = "lbl_RGB";
            this.lbl_RGB.Size = new System.Drawing.Size(51, 20);
            this.lbl_RGB.TabIndex = 27;
            this.lbl_RGB.Text = "label3";
            // 
            // txt_GREEN
            // 
            this.txt_GREEN.Location = new System.Drawing.Point(400, 158);
            this.txt_GREEN.Name = "txt_GREEN";
            this.txt_GREEN.Size = new System.Drawing.Size(47, 20);
            this.txt_GREEN.TabIndex = 26;
            this.txt_GREEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_BLUE
            // 
            this.txt_BLUE.Location = new System.Drawing.Point(400, 189);
            this.txt_BLUE.Name = "txt_BLUE";
            this.txt_BLUE.Size = new System.Drawing.Size(47, 20);
            this.txt_BLUE.TabIndex = 25;
            this.txt_BLUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_RED
            // 
            this.txt_RED.Location = new System.Drawing.Point(400, 126);
            this.txt_RED.Name = "txt_RED";
            this.txt_RED.Size = new System.Drawing.Size(47, 20);
            this.txt_RED.TabIndex = 24;
            this.txt_RED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "G";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(152, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "R";
            // 
            // track_BLUE
            // 
            this.track_BLUE.BackColor = System.Drawing.Color.White;
            this.track_BLUE.Location = new System.Drawing.Point(202, 189);
            this.track_BLUE.Maximum = 255;
            this.track_BLUE.Name = "track_BLUE";
            this.track_BLUE.Size = new System.Drawing.Size(172, 45);
            this.track_BLUE.TabIndex = 20;
            this.track_BLUE.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // track_GREEN
            // 
            this.track_GREEN.BackColor = System.Drawing.Color.White;
            this.track_GREEN.Location = new System.Drawing.Point(202, 156);
            this.track_GREEN.Maximum = 255;
            this.track_GREEN.Name = "track_GREEN";
            this.track_GREEN.Size = new System.Drawing.Size(172, 45);
            this.track_GREEN.TabIndex = 19;
            this.track_GREEN.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(156, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 65);
            this.panel1.TabIndex = 18;
            // 
            // track_RED
            // 
            this.track_RED.BackColor = System.Drawing.Color.White;
            this.track_RED.Location = new System.Drawing.Point(202, 127);
            this.track_RED.Maximum = 255;
            this.track_RED.Name = "track_RED";
            this.track_RED.Size = new System.Drawing.Size(172, 45);
            this.track_RED.TabIndex = 17;
            this.track_RED.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 391);
            this.Controls.Add(this.tab1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU_MONITOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.Monitor.ResumeLayout(false);
            this.Monitor.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_BLUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_GREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_RED)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcpu0;
        private System.Windows.Forms.Label lblgpu;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label lblcpu1;
        private System.Windows.Forms.Label lblcpu2;
        private System.Windows.Forms.Label lblcpu3;
        private System.Windows.Forms.Label Cv1;
        private System.Windows.Forms.Label Cv2;
        private System.Windows.Forms.Label Cv3;
        private System.Windows.Forms.Label Cv4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Cavg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCpu;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage Monitor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lbl_HTML;
        private System.Windows.Forms.TextBox txt_Ghtml;
        private System.Windows.Forms.TextBox txt_Bhtml;
        private System.Windows.Forms.TextBox txt_Rhtml;
        private System.Windows.Forms.Label lbl_RGB;
        private System.Windows.Forms.TextBox txt_GREEN;
        private System.Windows.Forms.TextBox txt_BLUE;
        private System.Windows.Forms.TextBox txt_RED;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar track_BLUE;
        private System.Windows.Forms.TrackBar track_GREEN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar track_RED;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Gv1;
    }
}

