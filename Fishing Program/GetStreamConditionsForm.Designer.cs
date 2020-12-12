
namespace Fishing_Program
{
    partial class GetStreamConditionsForm
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
            this.getConditionsButton = new System.Windows.Forms.Button();
            this.applyAndCloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gageLocationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowTextBox = new System.Windows.Forms.TextBox();
            this.gageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getConditionsButton
            // 
            this.getConditionsButton.Location = new System.Drawing.Point(80, 184);
            this.getConditionsButton.Name = "getConditionsButton";
            this.getConditionsButton.Size = new System.Drawing.Size(128, 32);
            this.getConditionsButton.TabIndex = 0;
            this.getConditionsButton.Text = "Get Current Conditions";
            this.getConditionsButton.UseVisualStyleBackColor = true;
            this.getConditionsButton.Click += new System.EventHandler(this.getConditionsButton_Click);
            // 
            // applyAndCloseButton
            // 
            this.applyAndCloseButton.Location = new System.Drawing.Point(296, 184);
            this.applyAndCloseButton.Name = "applyAndCloseButton";
            this.applyAndCloseButton.Size = new System.Drawing.Size(128, 32);
            this.applyAndCloseButton.TabIndex = 1;
            this.applyAndCloseButton.Text = "Apply and Close";
            this.applyAndCloseButton.UseVisualStyleBackColor = true;
            this.applyAndCloseButton.Click += new System.EventHandler(this.applyAndCloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stream Gage Location";
            // 
            // gageLocationComboBox
            // 
            this.gageLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gageLocationComboBox.FormattingEnabled = true;
            this.gageLocationComboBox.Location = new System.Drawing.Point(128, 32);
            this.gageLocationComboBox.Name = "gageLocationComboBox";
            this.gageLocationComboBox.Size = new System.Drawing.Size(360, 21);
            this.gageLocationComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Flow (ft^3/s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gage (ft)";
            // 
            // flowTextBox
            // 
            this.flowTextBox.Location = new System.Drawing.Point(112, 120);
            this.flowTextBox.Name = "flowTextBox";
            this.flowTextBox.Size = new System.Drawing.Size(96, 20);
            this.flowTextBox.TabIndex = 6;
            // 
            // gageTextBox
            // 
            this.gageTextBox.Location = new System.Drawing.Point(328, 120);
            this.gageTextBox.Name = "gageTextBox";
            this.gageTextBox.Size = new System.Drawing.Size(96, 20);
            this.gageTextBox.TabIndex = 7;
            // 
            // GetStreamConditionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 239);
            this.Controls.Add(this.gageTextBox);
            this.Controls.Add(this.flowTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gageLocationComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyAndCloseButton);
            this.Controls.Add(this.getConditionsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetStreamConditionsForm";
            this.Text = "Get Current Stream Conditions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getConditionsButton;
        private System.Windows.Forms.Button applyAndCloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gageLocationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox flowTextBox;
        private System.Windows.Forms.TextBox gageTextBox;
    }
}