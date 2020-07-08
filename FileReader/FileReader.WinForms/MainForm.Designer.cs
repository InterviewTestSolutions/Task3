namespace FileReader.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.readFileButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileContentsTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.decryptFileCheckBox = new System.Windows.Forms.CheckBox();
            this.checkRoleCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userRoleComboBox = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readFileButton
            // 
            this.readFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.readFileButton.Location = new System.Drawing.Point(542, 12);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(75, 23);
            this.readFileButton.TabIndex = 5;
            this.readFileButton.Text = "Read file";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.ReadFileButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Location = new System.Drawing.Point(73, 12);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(382, 23);
            this.filePathTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "File path:";
            // 
            // fileContentsTextBox
            // 
            this.fileContentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileContentsTextBox.Location = new System.Drawing.Point(12, 134);
            this.fileContentsTextBox.Multiline = true;
            this.fileContentsTextBox.Name = "fileContentsTextBox";
            this.fileContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileContentsTextBox.Size = new System.Drawing.Size(605, 189);
            this.fileContentsTextBox.TabIndex = 6;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(542, 105);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contents:";
            // 
            // decryptFileCheckBox
            // 
            this.decryptFileCheckBox.AutoSize = true;
            this.decryptFileCheckBox.Location = new System.Drawing.Point(73, 41);
            this.decryptFileCheckBox.Name = "decryptFileCheckBox";
            this.decryptFileCheckBox.Size = new System.Drawing.Size(86, 19);
            this.decryptFileCheckBox.TabIndex = 2;
            this.decryptFileCheckBox.Text = "Decrypt file";
            this.decryptFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkRoleCheckBox
            // 
            this.checkRoleCheckBox.AutoSize = true;
            this.checkRoleCheckBox.Location = new System.Drawing.Point(73, 66);
            this.checkRoleCheckBox.Name = "checkRoleCheckBox";
            this.checkRoleCheckBox.Size = new System.Drawing.Size(82, 19);
            this.checkRoleCheckBox.TabIndex = 3;
            this.checkRoleCheckBox.Text = "Check role";
            this.checkRoleCheckBox.UseVisualStyleBackColor = true;
            this.checkRoleCheckBox.CheckedChanged += new System.EventHandler(this.CheckRoleCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "User role:";
            // 
            // userRoleComboBox
            // 
            this.userRoleComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userRoleComboBox.FormattingEnabled = true;
            this.userRoleComboBox.Location = new System.Drawing.Point(334, 63);
            this.userRoleComboBox.Name = "userRoleComboBox";
            this.userRoleComboBox.Size = new System.Drawing.Size(121, 23);
            this.userRoleComboBox.TabIndex = 4;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(461, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 335);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.userRoleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkRoleCheckBox);
            this.Controls.Add(this.decryptFileCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fileContentsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.readFileButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File reader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileContentsTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox decryptFileCheckBox;
        private System.Windows.Forms.CheckBox checkRoleCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox userRoleComboBox;
        private System.Windows.Forms.Button browseButton;
    }
}

