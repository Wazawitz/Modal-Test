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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title19 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title20 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.collectdata.Location = new System.Drawing.Point(9, 10);
            this.collectdata.Margin = new System.Windows.Forms.Padding(2);
            this.collectdata.Name = "collectdata";
            this.collectdata.Size = new System.Drawing.Size(108, 22);
            this.collectdata.TabIndex = 0;
            this.collectdata.Text = "Recording: false";
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
            // psd
            // 
            chartArea17.Name = "ChartArea1";
            this.psd.ChartAreas.Add(chartArea17);
            this.psd.Location = new System.Drawing.Point(4, 186);
            this.psd.Margin = new System.Windows.Forms.Padding(2);
            this.psd.Name = "psd";
            series17.ChartArea = "ChartArea1";
            series17.Name = "Series1";
            this.psd.Series.Add(series17);
            this.psd.Size = new System.Drawing.Size(1366, 165);
            this.psd.TabIndex = 5;
            this.psd.Text = "PSD";
            title17.Name = "Title1";
            title17.Text = "PSD";
            this.psd.Titles.Add(title17);
            // 
            // frf
            // 
            chartArea18.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea18.AxisX.Title = "Hz";
            chartArea18.AxisY.Title = "Magnitude";
            chartArea18.Name = "ChartArea1";
            this.frf.ChartAreas.Add(chartArea18);
            this.frf.Location = new System.Drawing.Point(4, 17);
            this.frf.Margin = new System.Windows.Forms.Padding(2);
            this.frf.Name = "frf";
            series18.ChartArea = "ChartArea1";
            series18.Name = "Series1";
            this.frf.Series.Add(series18);
            this.frf.Size = new System.Drawing.Size(1366, 165);
            this.frf.TabIndex = 6;
            this.frf.Text = "FRF";
            title18.Name = "FFT";
            title18.Text = "FFT";
            this.frf.Titles.Add(title18);
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
            chartArea19.Name = "ChartArea1";
            this.accelerometer.ChartAreas.Add(chartArea19);
            this.accelerometer.Location = new System.Drawing.Point(4, 186);
            this.accelerometer.Margin = new System.Windows.Forms.Padding(2);
            this.accelerometer.Name = "accelerometer";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series19.Name = "Series1";
            this.accelerometer.Series.Add(series19);
            this.accelerometer.Size = new System.Drawing.Size(1366, 165);
            this.accelerometer.TabIndex = 5;
            this.accelerometer.Text = "Accelerometer";
            title19.Name = "Title1";
            title19.Text = "Accelerometer over time";
            this.accelerometer.Titles.Add(title19);
            // 
            // vot
            // 
            chartArea20.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea20.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea20.AxisX.Minimum = 0D;
            chartArea20.Name = "ChartArea1";
            this.vot.ChartAreas.Add(chartArea20);
            this.vot.Location = new System.Drawing.Point(4, 17);
            this.vot.Margin = new System.Windows.Forms.Padding(2);
            this.vot.Name = "vot";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series20.Name = "DataSeries";
            this.vot.Series.Add(series20);
            this.vot.Size = new System.Drawing.Size(1366, 165);
            this.vot.TabIndex = 6;
            title20.Name = "Title1";
            title20.Text = "Voltage over time";
            this.vot.Titles.Add(title20);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Stop Live Feed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModalTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 756);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.portlist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveresults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.collectdata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
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

