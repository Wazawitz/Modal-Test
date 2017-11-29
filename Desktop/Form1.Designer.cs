namespace ModalTest
{
    partial class ModalTesterForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.collectdata = new System.Windows.Forms.Button();
            this.saveresults = new System.Windows.Forms.Button();
            this.psd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accelerometer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.portlist = new System.Windows.Forms.ComboBox();
            this.load = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.psd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frf)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accelerometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vot)).BeginInit();
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
            this.collectdata.Text = "Recording: false";
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
            // psd
            // 
            chartArea1.Name = "ChartArea1";
            this.psd.ChartAreas.Add(chartArea1);
            this.psd.Location = new System.Drawing.Point(5, 229);
            this.psd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.psd.Name = "psd";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.psd.Series.Add(series1);
            this.psd.Size = new System.Drawing.Size(1821, 203);
            this.psd.TabIndex = 5;
            this.psd.Text = "PSD";
            title1.Name = "Title1";
            title1.Text = "PSD";
            this.psd.Titles.Add(title1);
            // 
            // frf
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.Title = "Hz";
            chartArea2.AxisY.Title = "Magnitude";
            chartArea2.Name = "ChartArea1";
            this.frf.ChartAreas.Add(chartArea2);
            this.frf.Location = new System.Drawing.Point(5, 21);
            this.frf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frf.Name = "frf";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.frf.Series.Add(series2);
            this.frf.Size = new System.Drawing.Size(1821, 203);
            this.frf.TabIndex = 6;
            this.frf.Text = "FRF";
            title2.Name = "FFT";
            title2.Text = "FFT";
            this.frf.Titles.Add(title2);
            this.frf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frf);
            this.groupBox1.Controls.Add(this.psd);
            this.groupBox1.Location = new System.Drawing.Point(12, 491);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1832, 443);
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
            this.groupBox2.Size = new System.Drawing.Size(1832, 443);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Live";
            // 
            // accelerometer
            // 
            chartArea3.Name = "ChartArea1";
            this.accelerometer.ChartAreas.Add(chartArea3);
            this.accelerometer.Location = new System.Drawing.Point(5, 229);
            this.accelerometer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accelerometer.Name = "accelerometer";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "Series1";
            this.accelerometer.Series.Add(series3);
            this.accelerometer.Size = new System.Drawing.Size(1821, 203);
            this.accelerometer.TabIndex = 5;
            this.accelerometer.Text = "Accelerometer";
            title3.Name = "Title1";
            title3.Text = "Accelerometer over time";
            this.accelerometer.Titles.Add(title3);
            // 
            // vot
            // 
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.vot.ChartAreas.Add(chartArea4);
            this.vot.Location = new System.Drawing.Point(5, 21);
            this.vot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vot.Name = "vot";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Name = "DataSeries";
            this.vot.Series.Add(series4);
            this.vot.Size = new System.Drawing.Size(1821, 203);
            this.vot.TabIndex = 6;
            title4.Name = "Title1";
            title4.Text = "Voltage over time";
            this.vot.Titles.Add(title4);
            this.vot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // portlist
            // 
            this.portlist.FormattingEnabled = true;
            this.portlist.Location = new System.Drawing.Point(1123, 14);
            this.portlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(121, 24);
            this.portlist.TabIndex = 12;
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(612, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save FRF to CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(763, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Stop Live Feed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModalTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 930);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveresults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.collectdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModalTesterForm";
            this.Text = "Modal Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModalTesterForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.psd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frf)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accelerometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button collectdata;
        private System.Windows.Forms.Button saveresults;
        private System.Windows.Forms.DataVisualization.Charting.Chart psd;
        private System.Windows.Forms.DataVisualization.Charting.Chart frf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart vot;
        private System.Windows.Forms.DataVisualization.Charting.Chart accelerometer;
        private System.Windows.Forms.ComboBox portlist;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

