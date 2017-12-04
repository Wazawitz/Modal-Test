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
            this.psd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.accelerometer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portlist = new System.Windows.Forms.ToolStripComboBox();
            this.collectdata = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.psd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vot)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // psd
            // 
            chartArea1.Name = "ChartArea1";
            this.psd.ChartAreas.Add(chartArea1);
            this.psd.Location = new System.Drawing.Point(0, 559);
            this.psd.Margin = new System.Windows.Forms.Padding(2);
            this.psd.Name = "psd";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.psd.Series.Add(series1);
            this.psd.Size = new System.Drawing.Size(1383, 165);
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
            this.frf.Location = new System.Drawing.Point(0, 390);
            this.frf.Margin = new System.Windows.Forms.Padding(2);
            this.frf.Name = "frf";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.frf.Series.Add(series2);
            this.frf.Size = new System.Drawing.Size(1383, 165);
            this.frf.TabIndex = 6;
            this.frf.Text = "FRF";
            title2.Name = "FFT";
            title2.Text = "FFT";
            this.frf.Titles.Add(title2);
            this.frf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // accelerometer
            // 
            chartArea3.Name = "ChartArea1";
            this.accelerometer.ChartAreas.Add(chartArea3);
            this.accelerometer.Location = new System.Drawing.Point(0, 221);
            this.accelerometer.Margin = new System.Windows.Forms.Padding(2);
            this.accelerometer.Name = "accelerometer";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "Series1";
            this.accelerometer.Series.Add(series3);
            this.accelerometer.Size = new System.Drawing.Size(1383, 165);
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
            this.vot.Location = new System.Drawing.Point(0, 52);
            this.vot.Margin = new System.Windows.Forms.Padding(2);
            this.vot.Name = "vot";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Name = "DataSeries";
            this.vot.Series.Add(series4);
            this.vot.Size = new System.Drawing.Size(1383, 165);
            this.vot.TabIndex = 6;
            title4.Name = "Title1";
            title4.Text = "Voltage over time";
            this.vot.Titles.Add(title4);
            this.vot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.portlist,
            this.collectdata});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1394, 27);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToCSVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.exportToCSVToolStripMenuItem.Text = "Export to CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveToolStripMenuItem,
            this.simulatedToolStripMenuItem,
            this.cSVToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.viewToolStripMenuItem.Text = "Input";
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.liveToolStripMenuItem.Text = "COM";
            this.liveToolStripMenuItem.Click += new System.EventHandler(this.liveToolStripMenuItem_Click);
            // 
            // simulatedToolStripMenuItem
            // 
            this.simulatedToolStripMenuItem.Name = "simulatedToolStripMenuItem";
            this.simulatedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.simulatedToolStripMenuItem.Text = "Simulated";
            this.simulatedToolStripMenuItem.Click += new System.EventHandler(this.simulatedToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // portlist
            // 
            this.portlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portlist.Name = "portlist";
            this.portlist.Size = new System.Drawing.Size(75, 23);
            // 
            // collectdata
            // 
            this.collectdata.Name = "collectdata";
            this.collectdata.Size = new System.Drawing.Size(97, 23);
            this.collectdata.Text = "Record (space)";
            this.collectdata.Click += new System.EventHandler(this.collectdata_Click);
            // 
            // ModalTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 730);
            this.Controls.Add(this.psd);
            this.Controls.Add(this.frf);
            this.Controls.Add(this.accelerometer);
            this.Controls.Add(this.vot);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModalTesterForm";
            this.Text = "Modal Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModalTesterForm_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModalTesterForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.psd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vot)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart psd;
        private System.Windows.Forms.DataVisualization.Charting.Chart frf;
        private System.Windows.Forms.DataVisualization.Charting.Chart vot;
        private System.Windows.Forms.DataVisualization.Charting.Chart accelerometer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox portlist;
        private System.Windows.Forms.ToolStripMenuItem collectdata;
    }
}

