namespace ModalTest
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title13 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title14 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.collectdata = new System.Windows.Forms.Button();
            this.saveresults = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.psd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accelerometer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.portlist = new System.Windows.Forms.ComboBox();
            this.datadebugbox = new System.Windows.Forms.TextBox();
            this.sampletimechooser = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.psd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frf)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accelerometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampletimechooser)).BeginInit();
            this.SuspendLayout();
            // 
            // collectdata
            // 
            this.collectdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collectdata.Location = new System.Drawing.Point(12, 12);
            this.collectdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.collectdata.Name = "collectdata";
            this.collectdata.Size = new System.Drawing.Size(144, 27);
            this.collectdata.TabIndex = 0;
            this.collectdata.Text = "Start data collection";
            this.collectdata.UseVisualStyleBackColor = true;
            this.collectdata.Click += new System.EventHandler(this.collectdata_Click);
            // 
            // saveresults
            // 
            this.saveresults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveresults.Location = new System.Drawing.Point(463, 12);
            this.saveresults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveresults.Name = "saveresults";
            this.saveresults.Size = new System.Drawing.Size(144, 27);
            this.saveresults.TabIndex = 1;
            this.saveresults.Text = "Save to CSV";
            this.saveresults.UseVisualStyleBackColor = true;
            this.saveresults.Click += new System.EventHandler(this.saveresults_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Location = new System.Drawing.Point(163, 12);
            this.stop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(144, 27);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // psd
            // 
            chartArea13.Name = "ChartArea1";
            this.psd.ChartAreas.Add(chartArea13);
            this.psd.Location = new System.Drawing.Point(5, 183);
            this.psd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.psd.Name = "psd";
            series13.ChartArea = "ChartArea1";
            series13.Name = "Series1";
            this.psd.Series.Add(series13);
            this.psd.Size = new System.Drawing.Size(1346, 145);
            this.psd.TabIndex = 5;
            this.psd.Text = "PSD";
            title13.Name = "Title1";
            title13.Text = "PSD";
            this.psd.Titles.Add(title13);
            // 
            // frf
            // 
            chartArea14.Name = "ChartArea1";
            this.frf.ChartAreas.Add(chartArea14);
            this.frf.Location = new System.Drawing.Point(5, 21);
            this.frf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frf.Name = "frf";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Name = "Series1";
            this.frf.Series.Add(series14);
            this.frf.Size = new System.Drawing.Size(1346, 145);
            this.frf.TabIndex = 6;
            this.frf.Text = "FRF";
            title14.Name = "FFT";
            title14.Text = "FFT";
            this.frf.Titles.Add(title14);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frf);
            this.groupBox1.Controls.Add(this.psd);
            this.groupBox1.Location = new System.Drawing.Point(12, 379);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1357, 332);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampled data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.accelerometer);
            this.groupBox2.Controls.Add(this.vot);
            this.groupBox2.Location = new System.Drawing.Point(12, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1357, 332);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live";
            // 
            // accelerometer
            // 
            chartArea15.Name = "ChartArea1";
            this.accelerometer.ChartAreas.Add(chartArea15);
            this.accelerometer.Location = new System.Drawing.Point(5, 181);
            this.accelerometer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accelerometer.Name = "accelerometer";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series15.Name = "Series1";
            this.accelerometer.Series.Add(series15);
            this.accelerometer.Size = new System.Drawing.Size(1346, 145);
            this.accelerometer.TabIndex = 5;
            this.accelerometer.Text = "Accelerometer";
            title15.Name = "Title1";
            title15.Text = "Accelerometer over time";
            this.accelerometer.Titles.Add(title15);
            // 
            // vot
            // 
            chartArea16.AxisX.Interval = 1D;
            chartArea16.AxisX.Minimum = 0D;
            chartArea16.Name = "ChartArea1";
            this.vot.ChartAreas.Add(chartArea16);
            this.vot.Location = new System.Drawing.Point(5, 21);
            this.vot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vot.Name = "vot";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series16.Name = "DataSeries";
            this.vot.Series.Add(series16);
            this.vot.Size = new System.Drawing.Size(1346, 145);
            this.vot.TabIndex = 6;
            title16.Name = "Title1";
            title16.Text = "Voltage over time";
            this.vot.Titles.Add(title16);
            // 
            // portlist
            // 
            this.portlist.FormattingEnabled = true;
            this.portlist.Location = new System.Drawing.Point(1122, 14);
            this.portlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(121, 24);
            this.portlist.TabIndex = 12;
            this.portlist.SelectedIndexChanged += new System.EventHandler(this.portlist_SelectedIndexChanged);
            // 
            // datadebugbox
            // 
            this.datadebugbox.Location = new System.Drawing.Point(1249, 15);
            this.datadebugbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datadebugbox.Name = "datadebugbox";
            this.datadebugbox.ReadOnly = true;
            this.datadebugbox.Size = new System.Drawing.Size(119, 22);
            this.datadebugbox.TabIndex = 9;
            // 
            // sampletimechooser
            // 
            this.sampletimechooser.Location = new System.Drawing.Point(1067, 15);
            this.sampletimechooser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sampletimechooser.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sampletimechooser.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sampletimechooser.Name = "sampletimechooser";
            this.sampletimechooser.Size = new System.Drawing.Size(49, 22);
            this.sampletimechooser.TabIndex = 13;
            this.sampletimechooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(974, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sample time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // load
            // 
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Location = new System.Drawing.Point(313, 12);
            this.load.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(144, 27);
            this.load.TabIndex = 15;
            this.load.Text = "Load CSV";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 713);
            this.Controls.Add(this.load);
            this.Controls.Add(this.sampletimechooser);
            this.Controls.Add(this.datadebugbox);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveresults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.collectdata);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Modal Tester";
            ((System.ComponentModel.ISupportInitialize)(this.psd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frf)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accelerometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampletimechooser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button collectdata;
        private System.Windows.Forms.Button saveresults;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.DataVisualization.Charting.Chart psd;
        private System.Windows.Forms.DataVisualization.Charting.Chart frf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart vot;
        private System.Windows.Forms.DataVisualization.Charting.Chart accelerometer;
        private System.Windows.Forms.ComboBox portlist;
        private System.Windows.Forms.TextBox datadebugbox;
        private System.Windows.Forms.NumericUpDown sampletimechooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button load;
    }
}

