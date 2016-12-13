namespace PersonMatcher
{
    partial class MainWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.JsonRadioButton = new System.Windows.Forms.RadioButton();
            this.XmlRadioButton = new System.Windows.Forms.RadioButton();
            this.InputFilenameTextBox = new System.Windows.Forms.TextBox();
            this.FileBrowseButton = new System.Windows.Forms.Button();
            this.MatchResultsListBox = new System.Windows.Forms.ListBox();
            this.RunMatcherButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogPrintListBox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.JsonRadioButton);
            this.panel1.Controls.Add(this.XmlRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 52);
            this.panel1.TabIndex = 0;
            // 
            // JsonRadioButton
            // 
            this.JsonRadioButton.AutoSize = true;
            this.JsonRadioButton.Checked = true;
            this.JsonRadioButton.Location = new System.Drawing.Point(19, 16);
            this.JsonRadioButton.Name = "JsonRadioButton";
            this.JsonRadioButton.Size = new System.Drawing.Size(53, 17);
            this.JsonRadioButton.TabIndex = 1;
            this.JsonRadioButton.TabStop = true;
            this.JsonRadioButton.Text = "JSON";
            this.JsonRadioButton.UseVisualStyleBackColor = true;
            this.JsonRadioButton.CheckedChanged += new System.EventHandler(this.OnJsonRadioButton_Click);
            // 
            // XmlRadioButton
            // 
            this.XmlRadioButton.AutoSize = true;
            this.XmlRadioButton.Location = new System.Drawing.Point(130, 16);
            this.XmlRadioButton.Name = "XmlRadioButton";
            this.XmlRadioButton.Size = new System.Drawing.Size(47, 17);
            this.XmlRadioButton.TabIndex = 0;
            this.XmlRadioButton.Text = "XML";
            this.XmlRadioButton.UseVisualStyleBackColor = true;
            this.XmlRadioButton.CheckedChanged += new System.EventHandler(this.XmlRadioButton_CheckChanged);
            // 
            // InputFilenameTextBox
            // 
            this.InputFilenameTextBox.Location = new System.Drawing.Point(12, 30);
            this.InputFilenameTextBox.Name = "InputFilenameTextBox";
            this.InputFilenameTextBox.Size = new System.Drawing.Size(260, 20);
            this.InputFilenameTextBox.TabIndex = 1;
            this.InputFilenameTextBox.Text = "Select a file...";
            // 
            // FileBrowseButton
            // 
            this.FileBrowseButton.Location = new System.Drawing.Point(284, 28);
            this.FileBrowseButton.Name = "FileBrowseButton";
            this.FileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.FileBrowseButton.TabIndex = 2;
            this.FileBrowseButton.Text = "Browse...";
            this.FileBrowseButton.UseVisualStyleBackColor = true;
            this.FileBrowseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // MatchResultsListBox
            // 
            this.MatchResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MatchResultsListBox.FormattingEnabled = true;
            this.MatchResultsListBox.Location = new System.Drawing.Point(12, 168);
            this.MatchResultsListBox.Name = "MatchResultsListBox";
            this.MatchResultsListBox.Size = new System.Drawing.Size(347, 329);
            this.MatchResultsListBox.TabIndex = 4;
            // 
            // RunMatcherButton
            // 
            this.RunMatcherButton.Location = new System.Drawing.Point(225, 66);
            this.RunMatcherButton.Name = "RunMatcherButton";
            this.RunMatcherButton.Size = new System.Drawing.Size(134, 52);
            this.RunMatcherButton.TabIndex = 5;
            this.RunMatcherButton.Text = "Run Matcher";
            this.RunMatcherButton.UseVisualStyleBackColor = true;
            this.RunMatcherButton.Click += new System.EventHandler(this.RunMatcher_OnClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Logger Data";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Match Details";
            // 
            // LogPrintListBox
            // 
            this.LogPrintListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPrintListBox.FormattingEnabled = true;
            this.LogPrintListBox.HorizontalScrollbar = true;
            this.LogPrintListBox.Location = new System.Drawing.Point(391, 38);
            this.LogPrintListBox.Name = "LogPrintListBox";
            this.LogPrintListBox.Size = new System.Drawing.Size(621, 459);
            this.LogPrintListBox.TabIndex = 3;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunMatcherButton);
            this.Controls.Add(this.MatchResultsListBox);
            this.Controls.Add(this.LogPrintListBox);
            this.Controls.Add(this.FileBrowseButton);
            this.Controls.Add(this.InputFilenameTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_OnClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton JsonRadioButton;
        private System.Windows.Forms.RadioButton XmlRadioButton;
        private System.Windows.Forms.TextBox InputFilenameTextBox;
        private System.Windows.Forms.Button FileBrowseButton;
        private System.Windows.Forms.ListBox MatchResultsListBox;
        private System.Windows.Forms.Button RunMatcherButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LogPrintListBox;
    }
}

