﻿
namespace Fishing_Program
{
    partial class DataAnalysisForm
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fishTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dataTypesComboBox = new System.Windows.Forms.ComboBox();
            this.analyzeButton = new System.Windows.Forms.Button();
            this.alternateDataComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(944, 456);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // fishTypeComboBox
            // 
            this.fishTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fishTypeComboBox.FormattingEnabled = true;
            this.fishTypeComboBox.Location = new System.Drawing.Point(160, 504);
            this.fishTypeComboBox.Name = "fishTypeComboBox";
            this.fishTypeComboBox.Size = new System.Drawing.Size(144, 21);
            this.fishTypeComboBox.TabIndex = 1;
            // 
            // dataTypesComboBox
            // 
            this.dataTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataTypesComboBox.FormattingEnabled = true;
            this.dataTypesComboBox.Location = new System.Drawing.Point(416, 504);
            this.dataTypesComboBox.Name = "dataTypesComboBox";
            this.dataTypesComboBox.Size = new System.Drawing.Size(136, 21);
            this.dataTypesComboBox.TabIndex = 2;
            this.dataTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.dataTypesComboBox_SelectedIndexChanged);
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(632, 504);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(128, 32);
            this.analyzeButton.TabIndex = 3;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // alternateDataComboBox
            // 
            this.alternateDataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alternateDataComboBox.FormattingEnabled = true;
            this.alternateDataComboBox.Location = new System.Drawing.Point(416, 544);
            this.alternateDataComboBox.Name = "alternateDataComboBox";
            this.alternateDataComboBox.Size = new System.Drawing.Size(136, 21);
            this.alternateDataComboBox.TabIndex = 4;
            this.alternateDataComboBox.Visible = false;
            // 
            // DataAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 598);
            this.Controls.Add(this.alternateDataComboBox);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.dataTypesComboBox);
            this.Controls.Add(this.fishTypeComboBox);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(999, 637);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(999, 637);
            this.Name = "DataAnalysisForm";
            this.Text = "Data Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox fishTypeComboBox;
        private System.Windows.Forms.ComboBox dataTypesComboBox;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.ComboBox alternateDataComboBox;
    }
}