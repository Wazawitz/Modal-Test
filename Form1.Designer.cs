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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.collectdata = new System.Windows.Forms.Button();
            this.saveresults = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.psd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accelerometer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.samplerate = new System.Windows.Forms.Label();
            this.portlist = new System.Windows.Forms.ComboBox();
            this.datadebugbox = new System.Windows.Forms.TextBox();
            this.sampletimechooser = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
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
            this.saveresults.Location = new System.Drawing.Point(312, 12);
            this.saveresults.Name = "saveresults";
            this.saveresults.Size = new System.Drawing.Size(144, 27);
            this.saveresults.TabIndex = 1;
            this.saveresults.Text = "Save results";
            this.saveresults.UseVisualStyleBackColor = true;
            this.saveresults.Click += new System.EventHandler(this.saveresults_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Location = new System.Drawing.Point(162, 12);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(144, 27);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // psd
            // 
            chartArea1.Name = "ChartArea1";
            this.psd.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.psd.Legends.Add(legend1);
            this.psd.Location = new System.Drawing.Point(501, 21);
            this.psd.Name = "psd";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.psd.Series.Add(series1);
            this.psd.Size = new System.Drawing.Size(450, 282);
            this.psd.TabIndex = 5;
            this.psd.Text = "PSD";
            title1.Name = "Title1";
            title1.Text = "PSD";
            this.psd.Titles.Add(title1);
            // 
            // frf
            // 
            chartArea2.Name = "ChartArea1";
            this.frf.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.frf.Legends.Add(legend2);
            this.frf.Location = new System.Drawing.Point(6, 21);
            this.frf.Name = "frf";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.frf.Series.Add(series2);
            this.frf.Size = new System.Drawing.Size(450, 282);
            this.frf.TabIndex = 6;
            this.frf.Text = "FRF";
            title2.Name = "FFT";
            title2.Text = "FFT";
            this.frf.Titles.Add(title2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frf);
            this.groupBox1.Controls.Add(this.psd);
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 332);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampled data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.accelerometer);
            this.groupBox2.Controls.Add(this.vot);
            this.groupBox2.Location = new System.Drawing.Point(13, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 332);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live";
            // 
            // accelerometer
            // 
            chartArea3.Name = "ChartArea1";
            this.accelerometer.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.accelerometer.Legends.Add(legend3);
            this.accelerometer.Location = new System.Drawing.Point(6, 181);
            this.accelerometer.Name = "accelerometer";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.accelerometer.Series.Add(series3);
            this.accelerometer.Size = new System.Drawing.Size(945, 145);
            this.accelerometer.TabIndex = 5;
            this.accelerometer.Text = "Accelerometer";
            title3.Name = "Title1";
            title3.Text = "Accelerometer over time";
            this.accelerometer.Titles.Add(title3);
            // 
            // vot
            // 
            chartArea4.Name = "ChartArea1";
            this.vot.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.vot.Legends.Add(legend4);
            this.vot.Location = new System.Drawing.Point(6, 21);
            this.vot.Name = "vot";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "DataSeries";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.vot.Series.Add(series4);
            this.vot.Size = new System.Drawing.Size(945, 145);
            this.vot.TabIndex = 6;
            title4.Name = "Title1";
            title4.Text = "Voltage over time";
            this.vot.Titles.Add(title4);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(462, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bytes/s";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // samplerate
            // 
            this.samplerate.Location = new System.Drawing.Point(521, 17);
            this.samplerate.Name = "samplerate";
            this.samplerate.Size = new System.Drawing.Size(54, 16);
            this.samplerate.TabIndex = 9;
            this.samplerate.Text = "0";
            this.samplerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // portlist
            // 
            this.portlist.FormattingEnabled = true;
            this.portlist.Location = new System.Drawing.Point(724, 14);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(121, 24);
            this.portlist.TabIndex = 12;
            this.portlist.SelectedIndexChanged += new System.EventHandler(this.portlist_SelectedIndexChanged);
            // 
            // datadebugbox
            // 
            this.datadebugbox.Location = new System.Drawing.Point(851, 15);
            this.datadebugbox.Name = "datadebugbox";
            this.datadebugbox.ReadOnly = true;
            this.datadebugbox.Size = new System.Drawing.Size(119, 22);
            this.datadebugbox.TabIndex = 9;
            // 
            // sampletimechooser
            // 
            this.sampletimechooser.Location = new System.Drawing.Point(669, 15);
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
            this.label1.Location = new System.Drawing.Point(576, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sample time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 716);
            this.Controls.Add(this.sampletimechooser);
            this.Controls.Add(this.datadebugbox);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveresults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.collectdata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.samplerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label samplerate;
        private System.Windows.Forms.ComboBox portlist;
        private System.Windows.Forms.TextBox datadebugbox;
        private System.Windows.Forms.NumericUpDown sampletimechooser;
        private System.Windows.Forms.Label label1;
    }
}

