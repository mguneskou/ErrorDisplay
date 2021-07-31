using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.ComponentModel;
using System.Windows.Forms;

namespace ErrorDisplay
{
    public partial class MessageViewer: UserControl
    {
        readonly List<Items> MessageItems = new List<Items>();
        BackgroundWorker FlashWorker = new BackgroundWorker() { WorkerReportsProgress = false, WorkerSupportsCancellation = false };

        /// <summary>
        /// Initializes a new instance of ErrorDisplay class
        /// </summary>
        public MessageViewer()
        {
            InitializeComponent();
            try
            {
                ListViewMessage.ItemSelectionChanged += ListViewMessage_ItemSelectionChanged;
                ListViewMessage.MouseDown += ListViewMessage_MouseDown;
                ListViewMessage.FullRowSelect = true;
                ListViewMessage.MultiSelect = false;
                ListViewMessage.View = View.Details;
                ListViewMessage.Columns.Add("Type");
                ListViewMessage.Columns.Add("Message");
                ListViewMessage.Columns.Add("Time");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChkAutoScroll_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAutoScroll.Checked && ListViewMessage.Items.Count > 0) ListViewMessage.Items[ListViewMessage.Items.Count - 1].EnsureVisible();
        }

        private void ListViewMessage_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    MessageItems.Clear();
                    ListViewMessage.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListViewMessage_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                if (e.IsSelected) e.Item.Selected = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ErrorDisplay_Resize(object sender, EventArgs e)
        {
            ListViewMessage.Height = this.Height - GrpControls.Height;
        }

        /// <summary>
        /// Adds a new message to the error list
        /// </summary>
        /// <param name="Message">Message to add in the list</param>
        /// <param name="MType">Message type, selected from enum (Error/Warning/Message)</param>
        /// <param name="Visible">Is added message going to be visible or not. This can be changed using the checkbox controls</param>
        public void AddNewMessage(string Message, MessageType MType, bool Visible = true)
        {
            try
            {
                Items Item = new Items();
                switch (MType)
                {
                    case MessageType.Error:
                        {

                            Item.LVItem = new ListViewItem(new string[] { "Error", Message, DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString() }) { ForeColor = Color.Red };
                            break;
                        }
                    case MessageType.Warning:
                        {
                            Item.LVItem = new ListViewItem(new string[] { "Warning", Message, DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString() }) { ForeColor = Color.Orange };
                            break;
                        }
                    case MessageType.Message:
                        {
                            Item.LVItem = new ListViewItem(new string[] { "Message", Message, DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString() }) { ForeColor = Color.White };
                            break;
                        }
                }
                Item.Visible = Visible;
                Item.MType = MType;
                MessageItems.Add(Item);
                if (Item.Visible) ListViewMessage.Items.Add(Item.LVItem);
                ListViewMessage.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                if (ChkAutoScroll.Checked && ListViewMessage.Items.Count > 0) ListViewMessage.Items[ListViewMessage.Items.Count - 1].EnsureVisible();
                //flash background if error or warning
                if(MType == MessageType.Error || MType == MessageType.Warning)
                {
                    FlashWorker.DoWork += FlashWorker_DoWork;
                    FlashWorker.RunWorkerCompleted += FlashWorker_RunWorkerCompleted;
                    if (!FlashWorker.IsBusy) FlashWorker.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddNewMessageThreadSafe(string Message, MessageType MType, bool Visible = true)
        {
            try
            {
                ListViewMessage.BeginInvoke((MethodInvoker)delegate ()
                {
                    Items Item = new Items();
                    switch (MType)
                    {
                        case MessageType.Error:
                            {

                                Item.LVItem = new ListViewItem(new string[] { "Error", Message, DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString() }) { ForeColor = Color.Red };
                                break;
                            }
                        case MessageType.Warning:
                            {
                                Item.LVItem = new ListViewItem(new string[] { "Warning", Message, DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString() }) { ForeColor = Color.Orange };
                                break;
                            }
                        case MessageType.Message:
                            {
                                Item.LVItem = new ListViewItem(new string[] { "Message", Message, DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToShortTimeString() }) { ForeColor = Color.White };
                                break;
                            }
                    }
                    Item.Visible = Visible;
                    Item.MType = MType;
                    MessageItems.Add(Item);
                    if (Item.Visible) ListViewMessage.Items.Add(Item.LVItem);
                    ListViewMessage.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    if (ChkAutoScroll.Checked && ListViewMessage.Items.Count > 0) ListViewMessage.Items[ListViewMessage.Items.Count - 1].EnsureVisible();
                    //flash background if error or warning
                    if (MType == MessageType.Error || MType == MessageType.Warning)
                    {
                        FlashWorker.DoWork += FlashWorker_DoWork;
                        FlashWorker.RunWorkerCompleted += FlashWorker_RunWorkerCompleted;
                        if (!FlashWorker.IsBusy) FlashWorker.RunWorkerAsync();
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FlashWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (ListViewMessage.InvokeRequired)
                {
                    ListViewMessage.BeginInvoke((MethodInvoker)delegate { ListViewMessage.BackColor = Color.White; });
                    System.Threading.Thread.Sleep(250);
                    ListViewMessage.BeginInvoke((MethodInvoker)delegate { ListViewMessage.BackColor = Color.Black; });
                    System.Threading.Thread.Sleep(250);
                    ListViewMessage.BeginInvoke((MethodInvoker)delegate { ListViewMessage.BackColor = Color.White; });
                    System.Threading.Thread.Sleep(250);
                    ListViewMessage.BeginInvoke((MethodInvoker)delegate { ListViewMessage.BackColor = Color.Black; });
                }
                else
                {
                    ListViewMessage.BackColor = Color.White;
                    System.Threading.Thread.Sleep(250);
                    ListViewMessage.BackColor = Color.Black;
                    System.Threading.Thread.Sleep(250);
                    ListViewMessage.BackColor = Color.White;
                    System.Threading.Thread.Sleep(250);
                    ListViewMessage.BackColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FlashWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                FlashWorker.DoWork -= FlashWorker_DoWork;
                FlashWorker.RunWorkerCompleted -= FlashWorker_RunWorkerCompleted;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Filter(object sender, EventArgs e)
        {
            try
            {
                CheckBox Chk = (CheckBox)sender;
                ListViewMessage.Items.Clear();
                foreach (Items Item in MessageItems)
                {
                    if (Item.MType == MessageType.Error && Chk.Name == "ChkError") Item.Visible = Chk.Checked;
                    if (Item.MType == MessageType.Warning && Chk.Name == "ChkWarning") Item.Visible = Chk.Checked;
                    if (Item.MType == MessageType.Message && Chk.Name == "ChkMessage") Item.Visible = Chk.Checked;
                    if (Item.Visible) ListViewMessage.Items.Add(Item.LVItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSaveLog_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Title = "Save Error List";
                SFD.Filter = "CSV Files|*.CSV|All Files|*.*";
                SFD.DefaultExt = "CSV";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    if (SFD.FileName != "")
                    {
                        using (StreamWriter Writer = new StreamWriter(SFD.FileName))
                        {
                            for(int i = 0; i < MessageItems.Count; i++)
                            {
                                Writer.WriteLine("{0}{1}{2}{3}{4}", MessageItems[i].LVItem.SubItems[0].Text, ",", MessageItems[i].LVItem.SubItems[1].Text, ",", MessageItems[i].LVItem.SubItems[2].Text);
                            }
                        }
                    }
                }
            }
        }
    }

    public enum MessageType
    {
        Error = 0,
        Warning = 1,
        Message = 2
    }

    internal class Items
    {
        internal ListViewItem LVItem;
        internal bool Visible;
        internal MessageType MType;
    }
}