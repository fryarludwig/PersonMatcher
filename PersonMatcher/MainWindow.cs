using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;
using System.Reflection;

namespace PersonMatcher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            PersonMatcher = new MatchMaker();
            PersonMatcher.OnMatchFound += new MatchMaker.MatchEvent(OnMatchFound_Trigger);
            Logger.RegisterGuiCallback(this);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoggingLevel.SelectedIndex = (int)Logger.LogLevel;
            Logger.Info("Program ready.");
        }

        private void MainWindow_OnClosing(object sender, FormClosingEventArgs e)
        {
            Logger.RemoveGuiCallback(this);
        }

        private void RunMatcher_OnClick(object sender, EventArgs e)
        {
            MatchResultsListBox.Items.Clear();
            LogPrintListBox.Items.Clear();

            if (InputFilenameTextBox.Text.Length > 0)
            {
                List<MatchResult> matchList = new List<MatchResult>();
                RunMatcherButton.Enabled = false;
                Logger.Info("Starting matching process...");

                FileHandler.FileType fileType = FileHandler.FileType.JSON;
                if (XmlRadioButton.Checked)
                {
                    fileType = FileHandler.FileType.XML;
                }

                if (PersonMatcher.LoadPersonsFromFile(InputFilenameTextBox.Text, fileType))
                {
                    matchList = PersonMatcher.FindAllMatches();
                }

                Logger.Info("Matching process completed.");
            }
            else
            {
                Logger.Warn("Please select a file");
            }

            RunMatcherButton.Enabled = true;
        }

        private void loadBrowseButton_Click(object sender, EventArgs e)
        {
            Logger.Info("Selecting File for input");
            OpenFileDialog dlg = new OpenFileDialog { };
            DialogResult result;

            if (XmlRadioButton.Checked)
            {
                dlg = new OpenFileDialog
                {
                    DefaultExt = "txt",
                    Filter = @"XML files (*.xml)|*.xml",
                    Multiselect = false
                };
            }
            else if (JsonRadioButton.Checked)
            {
                dlg = new OpenFileDialog
                {
                    DefaultExt = "txt",
                    Filter = @"JSON files (*.json)|*.json",
                    Multiselect = false
                };
            }
            else
            {
                Logger.Warn("No radio buttons are selected. How did you pull that off?");
            }

            result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                InputFilenameTextBox.Text = dlg.FileName;
            }
        }

        private void saveBrowse_clicked(object sender, EventArgs e)
        {
            Logger.Info("Selecting File for input");
            SaveFileDialog dlg = new SaveFileDialog { };
            DialogResult result;

            if (XmlOuput.Checked)
            {
                dlg = new SaveFileDialog
                {
                    DefaultExt = "txt",
                    Filter = @"XML files (*.xml)|*.xml",
                };
            }
            else if (JsonOutput.Checked)
            {
                dlg = new SaveFileDialog
                {
                    DefaultExt = "txt",
                    Filter = @"JSON files (*.json)|*.json",
                };
            }
            else
            {
                Logger.Warn("No radio buttons are selected. How did you pull that off?");
            }

            result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                OutputFilename.Text = dlg.FileName;
            }
        }

        private void matchIndex_Changed(object sender, EventArgs e)
        {
            PersonDetails.Items.Clear();

            int index = MatchResultsListBox.SelectedIndex;
            if (index < PersonMatcher.Matches.Count)
            {
                Person a = PersonMatcher.Matches[index].Person1;
                Person b = PersonMatcher.Matches[index].Person2;
                IList<PropertyInfo> person1Properties = new List<PropertyInfo>(a.GetType().GetProperties());
                foreach (PropertyInfo prop in person1Properties)
                {
                    if (prop.Name == "ObjectId") { continue; }
                    object value1 = prop.GetValue(a, null);
                    object value2 = prop.GetValue(b, null);

                    ListViewItem itemToAdd = new ListViewItem(prop.Name);

                    itemToAdd.SubItems.Add($"{value1 ?? "null"}");
                    itemToAdd.SubItems.Add($"{value2 ?? "null"}");

                    if (value1 != null && value2 != null)
                    {
                        if (value1.GetType() == typeof(int))
                        {
                            if ((int)value1 == (int)value2)
                            {
                                itemToAdd.BackColor = System.Drawing.Color.LightGreen;
                            }
                            else
                            {
                                itemToAdd.BackColor = System.Drawing.Color.LightSalmon;
                            }
                        }
                        else if (value1.GetType() == typeof(String))
                        {
                            if ((String)value1 == (String)value2)
                            {
                                itemToAdd.BackColor = System.Drawing.Color.LightGreen;
                            }
                            else if (BasePattern.PartialStringMatch((String)value1, (String)value2))
                            {
                                itemToAdd.BackColor = System.Drawing.Color.LightGray;
                            }
                            else
                            {
                                itemToAdd.BackColor = System.Drawing.Color.LightSalmon;
                            }
                        }
                    }
                    else
                    {
                        itemToAdd.BackColor = System.Drawing.Color.LightGray;
                    }

                    PersonDetails.Items.Add(itemToAdd);
                }
            }
        }

        private void SaveToFile_Clicked(object sender, EventArgs e)
        {
            FileHandler.FileType type = FileHandler.FileType.JSON;
            if (XmlOuput.Checked)
            {
                type = FileHandler.FileType.XML;
            }

            PersonMatcher.SaveMatchesToFile(OutputFilename.Text, type);
        }

        private void OnJsonRadioButton_Click(object sender, EventArgs e)
        {
            if (JsonRadioButton.Checked)
            {
                XmlRadioButton.Checked = false;
            }
        }

        private void XmlRadioButton_CheckChanged(object sender, EventArgs e)
        {
            if (XmlRadioButton.Checked)
            {
                JsonRadioButton.Checked = false;
            }
        }

        private void OnSaveJsonRadioButton_Click(object sender, EventArgs e)
        {
            if (JsonOutput.Checked)
            {
                XmlOuput.Checked = false;
            }
        }

        private void OnSaveXmlRadioButton_CheckChanged(object sender, EventArgs e)
        {
            if (XmlOuput.Checked)
            {
                JsonOutput.Checked = false;
            }
        }

        public void OnMatchFound_Trigger(MatchResult result)
        {
            Logger.Info("Match found!");

            if (InvokeRequired)
            {
                this.BeginInvoke(new OnMatchFound_GuiUpdate(OnMatchFound_Trigger), new object[] { result });
            }
            else
            {
                MatchResultsListBox.Items.Add("     " + result.ToString());
            }
        }
        
        public void PrintLogMessage(LogItem message)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new OnLogMessageReceived(PrintLogMessage), new object[] { message });
            }
            else
            {
                int NumberOfItems = LogPrintListBox.ClientSize.Height / LogPrintListBox.ItemHeight;

                try
                {
                    if (Logger.CanPrintLevel(message.LogLevel))
                    {
                        LogPrintListBox.Items.Add(message.LogMessage);
                        if (LogPrintListBox.TopIndex == LogPrintListBox.Items.Count - NumberOfItems - 1)
                        {
                            //The item at the top when you can just see the bottom item
                            LogPrintListBox.TopIndex = LogPrintListBox.Items.Count - NumberOfItems + 1;
                        }
                    }
                }
                catch (Exception e)
                {
                    Logger.GuiOutput = false;
                    Logger.ConsoleOutput = true;
                    Logger.Error(e.Message);
                }
            }
        }

        public delegate void OnLogMessageReceived(LogItem message);
        public delegate void OnMatchFound_GuiUpdate(MatchResult result);
        public MatchMaker PersonMatcher { get; set; }
        public static ConcurrentQueue<LogItem> GuiLogQueue = new ConcurrentQueue<LogItem>();
        public static ConcurrentDictionary<Level, bool> LogPrintDictionary = new ConcurrentDictionary<Level, bool>();
        public LogUtility Logger = new LogUtility("Person Matching Patterns");

        private void LogLevel_Changed(object sender, EventArgs e)
        {
            Logger.LogLevel = (Level)LoggingLevel.SelectedIndex;
        }
    }
}
