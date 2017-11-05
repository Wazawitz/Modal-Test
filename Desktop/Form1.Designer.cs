﻿namespace ModalTest
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.collectdata.Location = new System.Drawing.Point(9, 10);
            this.collectdata.Margin = new System.Windows.Forms.Padding(2);
            this.collectdata.Name = "collectdata";
            this.collectdata.Size = new System.Drawing.Size(108, 22);
            this.collectdata.TabIndex = 0;
            this.collectdata.Text = "Start data collection";
            this.collectdata.UseVisualStyleBackColor = true;
            this.collectdata.Click += new System.EventHandler(this.collectdata_Click);
            // 
            // saveresults
            // 
            this.saveresults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveresults.Location = new System.Drawing.Point(347, 10);
            this.saveresults.Margin = new System.Windows.Forms.Padding(2);
            this.saveresults.Name = "saveresults";
            this.saveresults.Size = new System.Drawing.Size(108, 22);
            this.saveresults.TabIndex = 1;
            this.saveresults.Text = "Save to CSV";
            this.saveresults.UseVisualStyleBackColor = true;
            this.saveresults.Click += new System.EventHandler(this.saveresults_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Location = new System.Drawing.Point(122, 10);
            this.stop.Margin = new System.Windows.Forms.Padding(2);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(108, 22);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // psd
            // 
            chartArea9.Name = "ChartArea1";
            this.psd.ChartAreas.Add(chartArea9);
            this.psd.Location = new System.Drawing.Point(4, 186);
            this.psd.Margin = new System.Windows.Forms.Padding(2);
            this.psd.Name = "psd";
            series9.ChartArea = "ChartArea1";
            series9.Name = "Series1";
            this.psd.Series.Add(series9);
            this.psd.Size = new System.Drawing.Size(1366, 165);
            this.psd.TabIndex = 5;
            this.psd.Text = "PSD";
            title9.Name = "Title1";
            title9.Text = "PSD";
            this.psd.Titles.Add(title9);
            // 
            // frf
            // 
            chartArea10.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea10.Name = "ChartArea1";
            this.frf.ChartAreas.Add(chartArea10);
            this.frf.Location = new System.Drawing.Point(4, 17);
            this.frf.Margin = new System.Windows.Forms.Padding(2);
            this.frf.Name = "frf";
            series10.ChartArea = "ChartArea1";
            series10.Name = "Series1";
            this.frf.Series.Add(series10);
            this.frf.Size = new System.Drawing.Size(1366, 165);
            this.frf.TabIndex = 6;
            this.frf.Text = "FRF";
            title10.Name = "FFT";
            title10.Text = "FFT";
            this.frf.Titles.Add(title10);
            this.frf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frf);
            this.groupBox1.Controls.Add(this.psd);
            this.groupBox1.Location = new System.Drawing.Point(9, 399);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1374, 360);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampled data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.accelerometer);
            this.groupBox2.Controls.Add(this.vot);
            this.groupBox2.Location = new System.Drawing.Point(9, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1374, 360);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live";
            // 
            // accelerometer
            // 
            chartArea11.Name = "ChartArea1";
            this.accelerometer.ChartAreas.Add(chartArea11);
            this.accelerometer.Location = new System.Drawing.Point(4, 186);
            this.accelerometer.Margin = new System.Windows.Forms.Padding(2);
            this.accelerometer.Name = "accelerometer";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Name = "Series1";
            this.accelerometer.Series.Add(series11);
            this.accelerometer.Size = new System.Drawing.Size(1366, 165);
            this.accelerometer.TabIndex = 5;
            this.accelerometer.Text = "Accelerometer";
            title11.Name = "Title1";
            title11.Text = "Accelerometer over time";
            this.accelerometer.Titles.Add(title11);
            // 
            // vot
            // 
            chartArea12.AxisX.Interval = 1D;
            chartArea12.AxisX.Minimum = 0D;
            chartArea12.Name = "ChartArea1";
            this.vot.ChartAreas.Add(chartArea12);
            this.vot.Location = new System.Drawing.Point(4, 17);
            this.vot.Margin = new System.Windows.Forms.Padding(2);
            this.vot.Name = "vot";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Name = "DataSeries";
            this.vot.Series.Add(series12);
            this.vot.Size = new System.Drawing.Size(1366, 165);
            this.vot.TabIndex = 6;
            title12.Name = "Title1";
            title12.Text = "Voltage over time";
            this.vot.Titles.Add(title12);
            this.vot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // portlist
            // 
            this.portlist.FormattingEnabled = true;
            this.portlist.Location = new System.Drawing.Point(842, 11);
            this.portlist.Margin = new System.Windows.Forms.Padding(2);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(92, 21);
            this.portlist.TabIndex = 12;
            this.portlist.SelectedIndexChanged += new System.EventHandler(this.portlist_SelectedIndexChanged);
            // 
            // datadebugbox
            // 
            this.datadebugbox.Location = new System.Drawing.Point(937, 12);
            this.datadebugbox.Margin = new System.Windows.Forms.Padding(2);
            this.datadebugbox.Name = "datadebugbox";
            this.datadebugbox.ReadOnly = true;
            this.datadebugbox.Size = new System.Drawing.Size(90, 20);
            this.datadebugbox.TabIndex = 9;
            // 
            // sampletimechooser
            // 
            this.sampletimechooser.Location = new System.Drawing.Point(800, 12);
            this.sampletimechooser.Margin = new System.Windows.Forms.Padding(2);
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
            this.sampletimechooser.Size = new System.Drawing.Size(37, 20);
            this.sampletimechooser.TabIndex = 13;
            this.sampletimechooser.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(730, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sample time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // load
            // 
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Location = new System.Drawing.Point(235, 10);
            this.load.Margin = new System.Windows.Forms.Padding(2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(108, 22);
            this.load.TabIndex = 15;
            this.load.Text = "Load CSV";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(459, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 22);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save FRF to CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 756);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button1;
    }
}

