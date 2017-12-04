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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lcpsd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lcfrf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.acc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portlist = new System.Windows.Forms.ToolStripComboBox();
            this.collectdata = new System.Windows.Forms.ToolStripMenuItem();
            this.accpsd = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.accfrf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.lcpsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcfrf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accpsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accfrf)).BeginInit();
            this.SuspendLayout();
            // 
            // lcpsd
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsLogarithmic = true;
            chartArea1.AxisY.Minimum = 0.01D;
            chartArea1.Name = "ChartArea1";
            this.lcpsd.ChartAreas.Add(chartArea1);
            this.lcpsd.Location = new System.Drawing.Point(0, 559);
            this.lcpsd.Margin = new System.Windows.Forms.Padding(2);
            this.lcpsd.Name = "lcpsd";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.lcpsd.Series.Add(series1);
            this.lcpsd.Size = new System.Drawing.Size(935, 165);
            this.lcpsd.TabIndex = 5;
            this.lcpsd.Text = "PSD";
            title1.Name = "Title1";
            title1.Text = "PSD (input)";
            this.lcpsd.Titles.Add(title1);
            // 
            // lcfrf
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.Title = "Hz";
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IsLogarithmic = true;
            chartArea2.AxisY.Minimum = 0.01D;
            chartArea2.Name = "ChartArea1";
            this.lcfrf.ChartAreas.Add(chartArea2);
            this.lcfrf.Location = new System.Drawing.Point(0, 390);
            this.lcfrf.Margin = new System.Windows.Forms.Padding(2);
            this.lcfrf.Name = "lcfrf";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.lcfrf.Series.Add(series2);
            this.lcfrf.Size = new System.Drawing.Size(935, 165);
            this.lcfrf.TabIndex = 6;
            this.lcfrf.Text = "FRF";
            title2.Name = "FFT";
            title2.Text = "FFT ( input)";
            this.lcfrf.Titles.Add(title2);
            // 
            // acc
            // 
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea3.Name = "ChartArea1";
            this.acc.ChartAreas.Add(chartArea3);
            this.acc.Location = new System.Drawing.Point(0, 198);
            this.acc.Margin = new System.Windows.Forms.Padding(2);
            this.acc.Name = "acc";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Name = "Series1";
            this.acc.Series.Add(series3);
            this.acc.Size = new System.Drawing.Size(1873, 165);
            this.acc.TabIndex = 5;
            title3.Name = "Title1";
            title3.Text = "Accelerometer repsonse (voltage)";
            this.acc.Titles.Add(title3);
            // 
            // lc
            // 
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.lc.ChartAreas.Add(chartArea4);
            this.lc.Location = new System.Drawing.Point(0, 29);
            this.lc.Margin = new System.Windows.Forms.Padding(2);
            this.lc.Name = "lc";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Name = "DataSeries";
            this.lc.Series.Add(series4);
            this.lc.Size = new System.Drawing.Size(1873, 165);
            this.lc.TabIndex = 6;
            title4.Name = "Title1";
            title4.Text = "Input force (voltage)";
            this.lc.Titles.Add(title4);
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
            this.simulatedToolStripMenuItem,
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
            // simulatedToolStripMenuItem
            // 
            this.simulatedToolStripMenuItem.Name = "simulatedToolStripMenuItem";
            this.simulatedToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.simulatedToolStripMenuItem.Text = "Simulated";
            this.simulatedToolStripMenuItem.Click += new System.EventHandler(this.simulatedToolStripMenuItem_Click);
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
            // accpsd
            // 
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisY.IsLogarithmic = true;
            chartArea5.AxisY.Minimum = 0.01D;
            chartArea5.Name = "ChartArea1";
            this.accpsd.ChartAreas.Add(chartArea5);
            this.accpsd.Location = new System.Drawing.Point(938, 559);
            this.accpsd.Margin = new System.Windows.Forms.Padding(2);
            this.accpsd.Name = "accpsd";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Series1";
            this.accpsd.Series.Add(series5);
            this.accpsd.Size = new System.Drawing.Size(935, 165);
            this.accpsd.TabIndex = 20;
            this.accpsd.Text = "PSD";
            title5.Name = "Title1";
            title5.Text = "PSD (output)";
            this.accpsd.Titles.Add(title5);
            // 
            // accfrf
            // 
            chartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisX.Title = "Hz";
            chartArea6.AxisY.IsLogarithmic = true;
            chartArea6.AxisY.Minimum = 0.01D;
            chartArea6.Name = "ChartArea1";
            this.accfrf.ChartAreas.Add(chartArea6);
            this.accfrf.Location = new System.Drawing.Point(938, 390);
            this.accfrf.Margin = new System.Windows.Forms.Padding(2);
            this.accfrf.Name = "accfrf";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.accfrf.Series.Add(series6);
            this.accfrf.Size = new System.Drawing.Size(935, 165);
            this.accfrf.TabIndex = 21;
            this.accfrf.Text = "FRF";
            title6.Name = "FFT";
            title6.Text = "FFT (output)";
            this.accfrf.Titles.Add(title6);
            // 
            // ModalTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 961);
            this.Controls.Add(this.accpsd);
            this.Controls.Add(this.accfrf);
            this.Controls.Add(this.lcpsd);
            this.Controls.Add(this.lcfrf);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.lc);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModalTesterForm";
            this.Text = "Modal Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModalTesterForm_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ModalTesterForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.lcpsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcfrf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accpsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accfrf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart lcpsd;
        private System.Windows.Forms.DataVisualization.Charting.Chart lcfrf;
        private System.Windows.Forms.DataVisualization.Charting.Chart lc;
        private System.Windows.Forms.DataVisualization.Charting.Chart acc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulatedToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox portlist;
        private System.Windows.Forms.ToolStripMenuItem collectdata;
        private System.Windows.Forms.DataVisualization.Charting.Chart accpsd;
        private System.Windows.Forms.DataVisualization.Charting.Chart accfrf;
    }
}

