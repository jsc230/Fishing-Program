namespace Fishing_Program
{
    partial class SearchForm
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.fishTypeSearchComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchRichTextBox = new System.Windows.Forms.RichTextBox();
            this.exportCSVButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(334, 335);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(120, 46);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // fishTypeSearchComboBox
            // 
            this.fishTypeSearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fishTypeSearchComboBox.FormattingEnabled = true;
            this.fishTypeSearchComboBox.Location = new System.Drawing.Point(242, 104);
            this.fishTypeSearchComboBox.Name = "fishTypeSearchComboBox";
            this.fishTypeSearchComboBox.Size = new System.Drawing.Size(137, 21);
            this.fishTypeSearchComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fish Type";
            // 
            // searchRichTextBox
            // 
            this.searchRichTextBox.Location = new System.Drawing.Point(100, 158);
            this.searchRichTextBox.Name = "searchRichTextBox";
            this.searchRichTextBox.Size = new System.Drawing.Size(593, 143);
            this.searchRichTextBox.TabIndex = 3;
            this.searchRichTextBox.Text = "";
            // 
            // exportCSVButton
            // 
            this.exportCSVButton.Location = new System.Drawing.Point(511, 335);
            this.exportCSVButton.Name = "exportCSVButton";
            this.exportCSVButton.Size = new System.Drawing.Size(120, 46);
            this.exportCSVButton.TabIndex = 4;
            this.exportCSVButton.Text = "Export To CSV";
            this.exportCSVButton.UseVisualStyleBackColor = true;
            this.exportCSVButton.Click += new System.EventHandler(this.exportCSVButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exportCSVButton);
            this.Controls.Add(this.searchRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fishTypeSearchComboBox);
            this.Controls.Add(this.SearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox fishTypeSearchComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox searchRichTextBox;
        private System.Windows.Forms.Button exportCSVButton;
    }
}