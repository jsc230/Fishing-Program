
namespace Fishing_Program
{
    partial class AddDataForm
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
            this.dataToAddComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataToAddTextBox = new System.Windows.Forms.TextBox();
            this.dataTypeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.alternateDataTextBox = new System.Windows.Forms.TextBox();
            this.alternateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataToAddComboBox
            // 
            this.dataToAddComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataToAddComboBox.FormattingEnabled = true;
            this.dataToAddComboBox.Location = new System.Drawing.Point(152, 48);
            this.dataToAddComboBox.Name = "dataToAddComboBox";
            this.dataToAddComboBox.Size = new System.Drawing.Size(120, 21);
            this.dataToAddComboBox.TabIndex = 0;
            this.dataToAddComboBox.SelectedIndexChanged += new System.EventHandler(this.dataToAddComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Type To Add To";
            // 
            // dataToAddTextBox
            // 
            this.dataToAddTextBox.Location = new System.Drawing.Point(152, 96);
            this.dataToAddTextBox.Name = "dataToAddTextBox";
            this.dataToAddTextBox.Size = new System.Drawing.Size(120, 20);
            this.dataToAddTextBox.TabIndex = 2;
            // 
            // dataTypeLabel
            // 
            this.dataTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTypeLabel.AutoSize = true;
            this.dataTypeLabel.Location = new System.Drawing.Point(24, 104);
            this.dataTypeLabel.Name = "dataTypeLabel";
            this.dataTypeLabel.Size = new System.Drawing.Size(42, 13);
            this.dataTypeLabel.TabIndex = 3;
            this.dataTypeLabel.Text = "Add To";
            this.dataTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dataTypeLabel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alternateDataTextBox
            // 
            this.alternateDataTextBox.Location = new System.Drawing.Point(152, 144);
            this.alternateDataTextBox.Name = "alternateDataTextBox";
            this.alternateDataTextBox.Size = new System.Drawing.Size(120, 20);
            this.alternateDataTextBox.TabIndex = 5;
            this.alternateDataTextBox.Visible = false;
            // 
            // alternateLabel
            // 
            this.alternateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.alternateLabel.AutoSize = true;
            this.alternateLabel.Location = new System.Drawing.Point(24, 152);
            this.alternateLabel.Name = "alternateLabel";
            this.alternateLabel.Size = new System.Drawing.Size(47, 13);
            this.alternateLabel.TabIndex = 6;
            this.alternateLabel.Text = "Add to 2";
            this.alternateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.alternateLabel.Visible = false;
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 235);
            this.Controls.Add(this.alternateLabel);
            this.Controls.Add(this.alternateDataTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTypeLabel);
            this.Controls.Add(this.dataToAddTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataToAddComboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDataForm";
            this.Text = "Add Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dataToAddComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataToAddTextBox;
        private System.Windows.Forms.Label dataTypeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox alternateDataTextBox;
        private System.Windows.Forms.Label alternateLabel;
    }
}