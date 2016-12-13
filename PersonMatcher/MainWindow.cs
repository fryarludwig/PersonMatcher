using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using PersonMatcher.IO;
using PersonMatcher.Patterns;

namespace PersonMatcher
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(GuiLoggingLoop);
            Logger.Info("Program ready.");
        }

        private void MainWindow_OnClosing(object sender, FormClosingEventArgs e)
        {
            // Do nothing here, yet at least
        }

        private void RunMatcher_OnClick(object sender, EventArgs e)
        {
            MatchWorker worker = new MatchWorker();
            MatchResultsListBox.Items.Clear();
            LogPrintListBox.Items.Clear();

            if (InputFilenameTextBox.Text.Length > 0)
            {
                RunMatcherButton.Enabled = false;
                Logger.Info("Starting matching process...");

                FileHandler.FileType fileType = FileHandler.FileType.JSON;
                if (XmlRadioButton.Checked)
                {
                    fileType = FileHandler.FileType.XML;
                }

                List<MatchResult> matchList = worker.FindMatchesFromFile(InputFilenameTextBox.Text, fileType);
                MatchResultsListBox.Items.Add("Matching Pairs");
                for (int i = 0; i < matchList.Count; i++)
                {
                    MatchResultsListBox.Items.Add("     " + matchList[i].ToString());
                }


                Logger.Info("Matching process completed.");
            }
            else
            {
                Logger.Warn("Please select a file");
            }

            RunMatcherButton.Enabled = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
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

        protected void GuiLoggingLoop()
        {
            bool keepGoing = true;
            LogItem message;

            while (keepGoing)
            {
                if (!GuiLogQueue.IsEmpty && GuiLogQueue.TryDequeue(out message))
                {
                    Invoke((MethodInvoker)delegate
                    {
                        int NumberOfItems = LogPrintListBox.ClientSize.Height / LogPrintListBox.ItemHeight;

                        try
                        {
                            LogPrintListBox.Items.Add(message.LogMessage);
                            if (LogPrintListBox.TopIndex == LogPrintListBox.Items.Count - NumberOfItems - 1)
                            {
                                //The item at the top when you can just see the bottom item
                                LogPrintListBox.TopIndex = LogPrintListBox.Items.Count - NumberOfItems + 1;
                            }
                        }
                        catch (Exception e)
                        {
                            Logger.GuiOutput = false;
                            Logger.ConsoleOutput = true;
                            Logger.Error(e.Message);
                            keepGoing = false;
                        }
                    });
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        public static ConcurrentQueue<LogItem> GuiLogQueue = new ConcurrentQueue<LogItem>();
        public static ConcurrentDictionary<Level, bool> LogPrintDictionary = new ConcurrentDictionary<Level, bool>();
        protected LogUtility Logger = new LogUtility("Person Matching Patterns");
        
    }
}
