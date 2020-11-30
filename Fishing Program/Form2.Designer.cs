
namespace Fishing_Program
{
    partial class exportFileNameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.exportOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(154, 39);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.fileNameTextBox.TabIndex = 1;
            // 
            // exportOKButton
            // 
            this.exportOKButton.Location = new System.Drawing.Point(154, 85);
            this.exportOKButton.Name = "exportOKButton";
            this.exportOKButton.Size = new System.Drawing.Size(93, 25);
            this.exportOKButton.TabIndex = 2;
            this.exportOKButton.Text = "Ok";
            this.exportOKButton.UseVisualStyleBackColor = true;
            // 
            // exportFileNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 132);
            this.Controls.Add(this.exportOKButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "exportFileNameForm";
            this.Text = "Export File Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button exportOKButton;
    }
}