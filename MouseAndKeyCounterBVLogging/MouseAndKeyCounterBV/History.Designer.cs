namespace WindowsFormsApplication1
{
    partial class History
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.HistoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDayByDay = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryChart
            // 
            chartArea2.Name = "ChartArea1";
            this.HistoryChart.ChartAreas.Add(chartArea2);
            this.HistoryChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.HistoryChart.Legends.Add(legend2);
            this.HistoryChart.Location = new System.Drawing.Point(0, 33);
            this.HistoryChart.Name = "HistoryChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.LegendText = "Tastatur";
            series3.Name = "Tastatur";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Legend = "Legend1";
            series4.Name = "Mus";
            this.HistoryChart.Series.Add(series3);
            this.HistoryChart.Series.Add(series4);
            this.HistoryChart.Size = new System.Drawing.Size(626, 463);
            this.HistoryChart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Startdato:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDayByDay);
            this.panel1.Controls.Add(this.dtEndDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtStartDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 33);
            this.panel1.TabIndex = 3;
            // 
            // btnDayByDay
            // 
            this.btnDayByDay.Location = new System.Drawing.Point(364, 5);
            this.btnDayByDay.Name = "btnDayByDay";
            this.btnDayByDay.Size = new System.Drawing.Size(92, 23);
            this.btnDayByDay.TabIndex = 6;
            this.btnDayByDay.Text = "Vis dag for dag";
            this.btnDayByDay.UseVisualStyleBackColor = true;
            this.btnDayByDay.Click += new System.EventHandler(this.btnDayByDay_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(243, 7);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtEndDate.Size = new System.Drawing.Size(88, 20);
            this.dtEndDate.TabIndex = 5;
            this.dtEndDate.ValueChanged += new System.EventHandler(this.dtEndDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sluttdato:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(70, 7);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtStartDate.Size = new System.Drawing.Size(88, 20);
            this.dtStartDate.TabIndex = 3;
            this.dtStartDate.Value = new System.DateTime(2017, 1, 7, 0, 0, 0, 0);
            this.dtStartDate.ValueChanged += new System.EventHandler(this.dtStartDate_ValueChanged);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 496);
            this.Controls.Add(this.HistoryChart);
            this.Controls.Add(this.panel1);
            this.Name = "History";
            this.Text = "Historie";
            ((System.ComponentModel.ISupportInitialize)(this.HistoryChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart HistoryChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDayByDay;
    }
}