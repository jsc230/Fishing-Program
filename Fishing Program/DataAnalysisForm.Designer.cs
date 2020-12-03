
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(72, 48);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(648, 296);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // fishTypeComboBox
            // 
            this.fishTypeComboBox.FormattingEnabled = true;
            this.fishTypeComboBox.Location = new System.Drawing.Point(112, 368);
            this.fishTypeComboBox.Name = "fishTypeComboBox";
            this.fishTypeComboBox.Size = new System.Drawing.Size(144, 21);
            this.fishTypeComboBox.TabIndex = 1;
            // 
            // dataTypesComboBox
            // 
            this.dataTypesComboBox.FormattingEnabled = true;
            this.dataTypesComboBox.Location = new System.Drawing.Point(368, 368);
            this.dataTypesComboBox.Name = "dataTypesComboBox";
            this.dataTypesComboBox.Size = new System.Drawing.Size(136, 21);
            this.dataTypesComboBox.TabIndex = 2;
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point(584, 368);
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size(128, 32);
            this.analyzeButton.TabIndex = 3;
            this.analyzeButton.Text = "Analyze";
            this.analyzeButton.UseVisualStyleBackColor = true;
            this.analyzeButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // DataAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.analyzeButton);
            this.Controls.Add(this.dataTypesComboBox);
            this.Controls.Add(this.fishTypeComboBox);
            this.Controls.Add(this.chart1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
    }
}