﻿namespace MediaBazaar
{
    partial class OverallEmployeeSatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSortEmployees = new System.Windows.Forms.Label();
            this.cbbSortEmployees = new System.Windows.Forms.ComboBox();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnWeek = new System.Windows.Forms.RadioButton();
            this.chbOrderBy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatistics
            // 
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend1);
            this.chartStatistics.Location = new System.Drawing.Point(12, 80);
            this.chartStatistics.Name = "chartStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Total salary";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Average salary";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Total hours worked";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Average hours worked";
            this.chartStatistics.Series.Add(series1);
            this.chartStatistics.Series.Add(series2);
            this.chartStatistics.Series.Add(series3);
            this.chartStatistics.Series.Add(series4);
            this.chartStatistics.Size = new System.Drawing.Size(1111, 400);
            this.chartStatistics.TabIndex = 5;
            this.chartStatistics.Text = "chart1";
            // 
            // lblSortEmployees
            // 
            this.lblSortEmployees.AutoSize = true;
            this.lblSortEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSortEmployees.Location = new System.Drawing.Point(35, 23);
            this.lblSortEmployees.Name = "lblSortEmployees";
            this.lblSortEmployees.Size = new System.Drawing.Size(173, 24);
            this.lblSortEmployees.TabIndex = 6;
            this.lblSortEmployees.Text = "Sort employees on:";
            // 
            // cbbSortEmployees
            // 
            this.cbbSortEmployees.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbbSortEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbbSortEmployees.Items.AddRange(new object[] {
            "Position",
            "Contract",
            "All employees"});
            this.cbbSortEmployees.Location = new System.Drawing.Point(254, 22);
            this.cbbSortEmployees.Name = "cbbSortEmployees";
            this.cbbSortEmployees.Size = new System.Drawing.Size(261, 28);
            this.cbbSortEmployees.TabIndex = 8;
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Checked = true;
            this.rbtnYear.Location = new System.Drawing.Point(609, 26);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(59, 21);
            this.rbtnYear.TabIndex = 11;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "Year";
            this.rbtnYear.UseVisualStyleBackColor = true;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Location = new System.Drawing.Point(717, 26);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(68, 21);
            this.rbtnMonth.TabIndex = 12;
            this.rbtnMonth.Text = "Month";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            this.rbtnMonth.CheckedChanged += new System.EventHandler(this.rbtnMonth_CheckedChanged);
            // 
            // rbtnWeek
            // 
            this.rbtnWeek.AutoSize = true;
            this.rbtnWeek.Location = new System.Drawing.Point(849, 29);
            this.rbtnWeek.Name = "rbtnWeek";
            this.rbtnWeek.Size = new System.Drawing.Size(65, 21);
            this.rbtnWeek.TabIndex = 13;
            this.rbtnWeek.Text = "Week";
            this.rbtnWeek.UseVisualStyleBackColor = true;
            this.rbtnWeek.CheckedChanged += new System.EventHandler(this.rbtnWeek_CheckedChanged);
            // 
            // chbOrderBy
            // 
            this.chbOrderBy.AutoSize = true;
            this.chbOrderBy.Location = new System.Drawing.Point(908, 384);
            this.chbOrderBy.Name = "chbOrderBy";
            this.chbOrderBy.Size = new System.Drawing.Size(135, 38);
            this.chbOrderBy.TabIndex = 14;
            this.chbOrderBy.Text = "Order by \r\nhighest to lowest";
            this.chbOrderBy.UseVisualStyleBackColor = true;
            // 
            // OverallEmployeeSatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 492);
            this.Controls.Add(this.chbOrderBy);
            this.Controls.Add(this.rbtnWeek);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.cbbSortEmployees);
            this.Controls.Add(this.lblSortEmployees);
            this.Controls.Add(this.chartStatistics);
            this.Name = "OverallEmployeeSatisticsForm";
            this.Text = "OverallEmployeeSatisticsForm";
            this.Load += new System.EventHandler(this.OverallEmployeeSatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        private System.Windows.Forms.Label lblSortEmployees;
        private System.Windows.Forms.ComboBox cbbSortEmployees;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnWeek;
        private System.Windows.Forms.CheckBox chbOrderBy;
    }
}