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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.InputForcePSD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InputForceFFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AccelerometerResponse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InputForce = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portlist = new System.Windows.Forms.ToolStripComboBox();
            this.collectdata = new System.Windows.Forms.ToolStripMenuItem();
            this.AccelerometerResponsePSD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AccelerometerResponseFFT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.InputForcePSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputForceFFT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerometerResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputForce)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerometerResponsePSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerometerResponseFFT)).BeginInit();
            this.SuspendLayout();
            // 
            // InputForcePSD
            // 
            chartArea7.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea7.AxisY.IsLogarithmic = true;
            chartArea7.AxisY.Minimum = 0.001D;
            chartArea7.Name = "ChartArea1";
            this.InputForcePSD.ChartAreas.Add(chartArea7);
            this.InputForcePSD.Location = new System.Drawing.Point(0, 559);
            this.InputForcePSD.Margin = new System.Windows.Forms.Padding(2);
            this.InputForcePSD.Name = "InputForcePSD";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Name = "Series1";
            this.InputForcePSD.Series.Add(series7);
            this.InputForcePSD.Size = new System.Drawing.Size(935, 165);
            this.InputForcePSD.TabIndex = 5;
            this.InputForcePSD.Text = "power,hz";
            title7.Name = "Title1";
            title7.Text = "PSD (input)";
            this.InputForcePSD.Titles.Add(title7);
            // 
            // InputForceFFT
            // 
            chartArea8.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea8.AxisX.Title = "Hz";
            chartArea8.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea8.AxisY.IsLogarithmic = true;
            chartArea8.AxisY.Minimum = 0.001D;
            chartArea8.Name = "ChartArea1";
            this.InputForceFFT.ChartAreas.Add(chartArea8);
            this.InputForceFFT.Location = new System.Drawing.Point(0, 390);
            this.InputForceFFT.Margin = new System.Windows.Forms.Padding(2);
            this.InputForceFFT.Name = "InputForceFFT";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "Series1";
            this.InputForceFFT.Series.Add(series8);
            this.InputForceFFT.Size = new System.Drawing.Size(935, 165);
            this.InputForceFFT.TabIndex = 6;
            this.InputForceFFT.Text = "hz,magnitude";
            title8.Name = "FFT";
            title8.Text = "FFT ( input)";
            this.InputForceFFT.Titles.Add(title8);
            // 
            // AccelerometerResponse
            // 
            chartArea9.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea9.Name = "ChartArea1";
            this.AccelerometerResponse.ChartAreas.Add(chartArea9);
            this.AccelerometerResponse.Location = new System.Drawing.Point(0, 198);
            this.AccelerometerResponse.Margin = new System.Windows.Forms.Padding(2);
            this.AccelerometerResponse.Name = "AccelerometerResponse";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Name = "Series1";
            this.AccelerometerResponse.Series.Add(series9);
            this.AccelerometerResponse.Size = new System.Drawing.Size(1873, 165);
            this.AccelerometerResponse.TabIndex = 5;
            this.AccelerometerResponse.Text = "seconds,voltage";
            title9.Name = "Title1";
            title9.Text = "Accelerometer repsonse (voltage)";
            this.AccelerometerResponse.Titles.Add(title9);
            // 
            // InputForce
            // 
            chartArea10.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea10.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea10.AxisX.Minimum = 0D;
            chartArea10.Name = "ChartArea1";
            this.InputForce.ChartAreas.Add(chartArea10);
            this.InputForce.Location = new System.Drawing.Point(0, 29);
            this.InputForce.Margin = new System.Windows.Forms.Padding(2);
            this.InputForce.Name = "InputForce";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Name = "DataSeries";
            this.InputForce.Series.Add(series10);
            this.InputForce.Size = new System.Drawing.Size(1873, 165);
            this.InputForce.TabIndex = 6;
            this.InputForce.Text = "seconds,voltage";
            title10.Name = "Title1";
            title10.Text = "Input force (voltage)";
            this.InputForce.Titles.Add(title10);
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
            this.menuStrip1.Size = new System.Drawing.Size(1884, 27);
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
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToCSVToolStripMenuItem.Text = "Export to CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportToCSVToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liveToolStripMenuItem,
            this.cSVToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.viewToolStripMenuItem.Text = "Input";
            // 
            // liveToolStripMenuItem
            // 
            this.liveToolStripMenuItem.Name = "liveToolStripMenuItem";
            this.liveToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.liveToolStripMenuItem.Text = "COM";
            this.liveToolStripMenuItem.Click += new System.EventHandler(this.liveToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
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
            // AccelerometerResponsePSD
            // 
            chartArea11.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea11.AxisY.IsLogarithmic = true;
            chartArea11.AxisY.Minimum = 0.001D;
            chartArea11.Name = "ChartArea1";
            this.AccelerometerResponsePSD.ChartAreas.Add(chartArea11);
            this.AccelerometerResponsePSD.Location = new System.Drawing.Point(938, 559);
            this.AccelerometerResponsePSD.Margin = new System.Windows.Forms.Padding(2);
            this.AccelerometerResponsePSD.Name = "AccelerometerResponsePSD";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Name = "Series1";
            this.AccelerometerResponsePSD.Series.Add(series11);
            this.AccelerometerResponsePSD.Size = new System.Drawing.Size(935, 165);
            this.AccelerometerResponsePSD.TabIndex = 20;
            this.AccelerometerResponsePSD.Text = "power,hz";
            title11.Name = "Title1";
            title11.Text = "PSD (output)";
            this.AccelerometerResponsePSD.Titles.Add(title11);
            // 
            // AccelerometerResponseFFT
            // 
            chartArea12.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea12.AxisX.Title = "Hz";
            chartArea12.AxisY.IsLogarithmic = true;
            chartArea12.AxisY.Minimum = 0.001D;
            chartArea12.Name = "ChartArea1";
            this.AccelerometerResponseFFT.ChartAreas.Add(chartArea12);
            this.AccelerometerResponseFFT.Location = new System.Drawing.Point(938, 390);
            this.AccelerometerResponseFFT.Margin = new System.Windows.Forms.Padding(2);
            this.AccelerometerResponseFFT.Name = "AccelerometerResponseFFT";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Name = "Series1";
            this.AccelerometerResponseFFT.Series.Add(series12);
            this.AccelerometerResponseFFT.Size = new System.Drawing.Size(935, 165);
            this.AccelerometerResponseFFT.TabIndex = 21;
            this.AccelerometerResponseFFT.Text = "hz,magnitude";
            title12.Name = "FFT";
            title12.Text = "FFT (output)";
            this.AccelerometerResponseFFT.Titles.Add(title12);
            // 
            // ModalTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 961);
            this.Controls.Add(this.AccelerometerResponsePSD);
            this.Controls.Add(this.AccelerometerResponseFFT);
            this.Controls.Add(this.InputForcePSD);
            this.Controls.Add(this.InputForceFFT);
            this.Controls.Add(this.AccelerometerResponse);
            this.Controls.Add(this.InputForce);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModalTesterForm";
            this.Text = "Modal Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModalTesterForm_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModalTesterForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.InputForcePSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputForceFFT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerometerResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputForce)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerometerResponsePSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerometerResponseFFT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart InputForcePSD;
        private System.Windows.Forms.DataVisualization.Charting.Chart InputForceFFT;
        private System.Windows.Forms.DataVisualization.Charting.Chart InputForce;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccelerometerResponse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox portlist;
        private System.Windows.Forms.ToolStripMenuItem collectdata;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccelerometerResponsePSD;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccelerometerResponseFFT;
    }
}

