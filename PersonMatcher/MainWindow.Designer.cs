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
            this.LogPrintListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.JsonOutput = new System.Windows.Forms.RadioButton();
            this.XmlOuput = new System.Windows.Forms.RadioButton();
            this.OutputFilename = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ExportMatches = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PersonDetails = new System.Windows.Forms.ListView();
            this.Field = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoggingLevel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.JsonRadioButton);
            this.panel1.Controls.Add(this.XmlRadioButton);
            this.panel1.Location = new System.Drawing.Point(14, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 52);
            this.panel1.TabIndex = 0;
            // 
            // JsonRadioButton
            // 
            this.JsonRadioButton.AutoSize = true;
            this.JsonRadioButton.Checked = true;
            this.JsonRadioButton.Location = new System.Drawing.Point(40, 16);
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
            this.XmlRadioButton.Location = new System.Drawing.Point(153, 16);
            this.XmlRadioButton.Name = "XmlRadioButton";
            this.XmlRadioButton.Size = new System.Drawing.Size(47, 17);
            this.XmlRadioButton.TabIndex = 0;
            this.XmlRadioButton.Text = "XML";
            this.XmlRadioButton.UseVisualStyleBackColor = true;
            this.XmlRadioButton.CheckedChanged += new System.EventHandler(this.XmlRadioButton_CheckChanged);
            // 
            // InputFilenameTextBox
            // 
            this.InputFilenameTextBox.AllowDrop = true;
            this.InputFilenameTextBox.Location = new System.Drawing.Point(14, 32);
            this.InputFilenameTextBox.Name = "InputFilenameTextBox";
            this.InputFilenameTextBox.Size = new System.Drawing.Size(320, 20);
            this.InputFilenameTextBox.TabIndex = 1;
            this.InputFilenameTextBox.Text = "Select a file...";
            // 
            // FileBrowseButton
            // 
            this.FileBrowseButton.Location = new System.Drawing.Point(340, 29);
            this.FileBrowseButton.Name = "FileBrowseButton";
            this.FileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.FileBrowseButton.TabIndex = 2;
            this.FileBrowseButton.Text = "Browse...";
            this.FileBrowseButton.UseVisualStyleBackColor = true;
            this.FileBrowseButton.Click += new System.EventHandler(this.loadBrowseButton_Click);
            // 
            // MatchResultsListBox
            // 
            this.MatchResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MatchResultsListBox.FormattingEnabled = true;
            this.MatchResultsListBox.Location = new System.Drawing.Point(3, 30);
            this.MatchResultsListBox.Name = "MatchResultsListBox";
            this.MatchResultsListBox.Size = new System.Drawing.Size(151, 277);
            this.MatchResultsListBox.TabIndex = 4;
            this.MatchResultsListBox.SelectedIndexChanged += new System.EventHandler(this.matchIndex_Changed);
            // 
            // RunMatcherButton
            // 
            this.RunMatcherButton.Location = new System.Drawing.Point(281, 66);
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
            this.label1.Location = new System.Drawing.Point(152, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log Messages";
            // 
            // LogPrintListBox
            // 
            this.LogPrintListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogPrintListBox.FormattingEnabled = true;
            this.LogPrintListBox.Location = new System.Drawing.Point(3, 60);
            this.LogPrintListBox.Name = "LogPrintListBox";
            this.LogPrintListBox.Size = new System.Drawing.Size(412, 524);
            this.LogPrintListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Match Details";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Load From File";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LoggingLevel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.LogPrintListBox);
            this.panel3.Location = new System.Drawing.Point(450, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 592);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.InputFilenameTextBox);
            this.panel4.Controls.Add(this.FileBrowseButton);
            this.panel4.Controls.Add(this.RunMatcherButton);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 135);
            this.panel4.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.OutputFilename);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ExportMatches);
            this.panel2.Location = new System.Drawing.Point(12, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 135);
            this.panel2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Save to File";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.JsonOutput);
            this.panel5.Controls.Add(this.XmlOuput);
            this.panel5.Location = new System.Drawing.Point(14, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 52);
            this.panel5.TabIndex = 0;
            // 
            // JsonOutput
            // 
            this.JsonOutput.AutoSize = true;
            this.JsonOutput.Checked = true;
            this.JsonOutput.Location = new System.Drawing.Point(40, 16);
            this.JsonOutput.Name = "JsonOutput";
            this.JsonOutput.Size = new System.Drawing.Size(53, 17);
            this.JsonOutput.TabIndex = 1;
            this.JsonOutput.TabStop = true;
            this.JsonOutput.Text = "JSON";
            this.JsonOutput.UseVisualStyleBackColor = true;
            this.JsonOutput.CheckedChanged += new System.EventHandler(this.OnSaveJsonRadioButton_Click);
            // 
            // XmlOuput
            // 
            this.XmlOuput.AutoSize = true;
            this.XmlOuput.Location = new System.Drawing.Point(153, 16);
            this.XmlOuput.Name = "XmlOuput";
            this.XmlOuput.Size = new System.Drawing.Size(47, 17);
            this.XmlOuput.TabIndex = 0;
            this.XmlOuput.Text = "XML";
            this.XmlOuput.UseVisualStyleBackColor = true;
            this.XmlOuput.CheckedChanged += new System.EventHandler(this.OnSaveXmlRadioButton_CheckChanged);
            this.XmlOuput.Click += new System.EventHandler(this.saveBrowse_clicked);
            // 
            // OutputFilename
            // 
            this.OutputFilename.AllowDrop = true;
            this.OutputFilename.Location = new System.Drawing.Point(14, 32);
            this.OutputFilename.Name = "OutputFilename";
            this.OutputFilename.Size = new System.Drawing.Size(320, 20);
            this.OutputFilename.TabIndex = 1;
            this.OutputFilename.Text = "Choose output file....";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saveBrowse_clicked);
            // 
            // ExportMatches
            // 
            this.ExportMatches.Location = new System.Drawing.Point(281, 68);
            this.ExportMatches.Name = "ExportMatches";
            this.ExportMatches.Size = new System.Drawing.Size(134, 52);
            this.ExportMatches.TabIndex = 5;
            this.ExportMatches.Text = "Export Matches";
            this.ExportMatches.UseVisualStyleBackColor = true;
            this.ExportMatches.Click += new System.EventHandler(this.SaveToFile_Clicked);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PersonDetails);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.MatchResultsListBox);
            this.panel6.Location = new System.Drawing.Point(12, 153);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(432, 310);
            this.panel6.TabIndex = 21;
            // 
            // PersonDetails
            // 
            this.PersonDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Field,
            this.Value1,
            this.Value2});
            this.PersonDetails.Location = new System.Drawing.Point(160, 30);
            this.PersonDetails.Name = "PersonDetails";
            this.PersonDetails.Size = new System.Drawing.Size(269, 277);
            this.PersonDetails.TabIndex = 12;
            this.PersonDetails.UseCompatibleStateImageBehavior = false;
            this.PersonDetails.View = System.Windows.Forms.View.Details;
            // 
            // Field
            // 
            this.Field.Text = "Field";
            this.Field.Width = 85;
            // 
            // Value1
            // 
            this.Value1.Text = "Person 1";
            this.Value1.Width = 85;
            // 
            // Value2
            // 
            this.Value2.Text = "Person 2";
            this.Value2.Width = 85;
            // 
            // LoggingLevel
            // 
            this.LoggingLevel.FormattingEnabled = true;
            this.LoggingLevel.Items.AddRange(new object[] {
            "None",
            "Errors ",
            "Warnings",
            "Informational",
            "Trace"});
            this.LoggingLevel.Location = new System.Drawing.Point(149, 33);
            this.LoggingLevel.Name = "LoggingLevel";
            this.LoggingLevel.Size = new System.Drawing.Size(121, 21);
            this.LoggingLevel.TabIndex = 7;
            this.LoggingLevel.SelectedIndexChanged += new System.EventHandler(this.LogLevel_Changed);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 614);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "MainWindow";
            this.Text = "Matchmaker Matchmaker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_OnClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListBox LogPrintListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton JsonOutput;
        private System.Windows.Forms.RadioButton XmlOuput;
        private System.Windows.Forms.TextBox OutputFilename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExportMatches;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView PersonDetails;
        private System.Windows.Forms.ColumnHeader Field;
        private System.Windows.Forms.ColumnHeader Value1;
        private System.Windows.Forms.ColumnHeader Value2;
        private System.Windows.Forms.ComboBox LoggingLevel;
    }
}

