namespace ErrorDisplay
{
    partial class MessageViewer
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrpControls = new System.Windows.Forms.GroupBox();
            this.ChkAutoScroll = new System.Windows.Forms.CheckBox();
            this.BtnSaveLog = new System.Windows.Forms.Button();
            this.ChkMessage = new System.Windows.Forms.CheckBox();
            this.ChkWarning = new System.Windows.Forms.CheckBox();
            this.ChkError = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ListViewMessage = new System.Windows.Forms.ListView();
            this.GrpControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpControls
            // 
            this.GrpControls.Controls.Add(this.ChkAutoScroll);
            this.GrpControls.Controls.Add(this.BtnSaveLog);
            this.GrpControls.Controls.Add(this.ChkMessage);
            this.GrpControls.Controls.Add(this.ChkWarning);
            this.GrpControls.Controls.Add(this.ChkError);
            this.GrpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpControls.Location = new System.Drawing.Point(3, 3);
            this.GrpControls.Name = "GrpControls";
            this.GrpControls.Size = new System.Drawing.Size(492, 44);
            this.GrpControls.TabIndex = 1;
            this.GrpControls.TabStop = false;
            // 
            // ChkAutoScroll
            // 
            this.ChkAutoScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkAutoScroll.AutoSize = true;
            this.ChkAutoScroll.Checked = true;
            this.ChkAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAutoScroll.Location = new System.Drawing.Point(402, 19);
            this.ChkAutoScroll.Name = "ChkAutoScroll";
            this.ChkAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.ChkAutoScroll.TabIndex = 4;
            this.ChkAutoScroll.Text = "Auto Scroll";
            this.ChkAutoScroll.UseVisualStyleBackColor = true;
            this.ChkAutoScroll.CheckedChanged += new System.EventHandler(this.ChkAutoScroll_CheckedChanged);
            // 
            // BtnSaveLog
            // 
            this.BtnSaveLog.Location = new System.Drawing.Point(6, 15);
            this.BtnSaveLog.Name = "BtnSaveLog";
            this.BtnSaveLog.Size = new System.Drawing.Size(140, 23);
            this.BtnSaveLog.TabIndex = 3;
            this.BtnSaveLog.Text = "Save Error Log";
            this.BtnSaveLog.UseVisualStyleBackColor = true;
            this.BtnSaveLog.Click += new System.EventHandler(this.BtnSaveLog_Click);
            // 
            // ChkMessage
            // 
            this.ChkMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkMessage.AutoSize = true;
            this.ChkMessage.BackColor = System.Drawing.Color.White;
            this.ChkMessage.Checked = true;
            this.ChkMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkMessage.ForeColor = System.Drawing.Color.Black;
            this.ChkMessage.Location = new System.Drawing.Point(291, 19);
            this.ChkMessage.Name = "ChkMessage";
            this.ChkMessage.Size = new System.Drawing.Size(69, 17);
            this.ChkMessage.TabIndex = 2;
            this.ChkMessage.Text = "Message";
            this.ChkMessage.UseVisualStyleBackColor = false;
            this.ChkMessage.CheckedChanged += new System.EventHandler(this.Filter);
            // 
            // ChkWarning
            // 
            this.ChkWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkWarning.AutoSize = true;
            this.ChkWarning.BackColor = System.Drawing.Color.Orange;
            this.ChkWarning.Checked = true;
            this.ChkWarning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkWarning.ForeColor = System.Drawing.Color.Black;
            this.ChkWarning.Location = new System.Drawing.Point(219, 19);
            this.ChkWarning.Name = "ChkWarning";
            this.ChkWarning.Size = new System.Drawing.Size(66, 17);
            this.ChkWarning.TabIndex = 1;
            this.ChkWarning.Text = "Warning";
            this.ChkWarning.UseVisualStyleBackColor = false;
            this.ChkWarning.CheckedChanged += new System.EventHandler(this.Filter);
            // 
            // ChkError
            // 
            this.ChkError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkError.AutoSize = true;
            this.ChkError.BackColor = System.Drawing.Color.Red;
            this.ChkError.Checked = true;
            this.ChkError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkError.ForeColor = System.Drawing.Color.Black;
            this.ChkError.Location = new System.Drawing.Point(165, 19);
            this.ChkError.Name = "ChkError";
            this.ChkError.Size = new System.Drawing.Size(48, 17);
            this.ChkError.TabIndex = 0;
            this.ChkError.Text = "Error";
            this.ChkError.UseVisualStyleBackColor = false;
            this.ChkError.CheckedChanged += new System.EventHandler(this.Filter);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ListViewMessage, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.GrpControls, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 148);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ListViewMessage
            // 
            this.ListViewMessage.BackColor = System.Drawing.Color.Black;
            this.ListViewMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewMessage.HideSelection = false;
            this.ListViewMessage.Location = new System.Drawing.Point(3, 53);
            this.ListViewMessage.Name = "ListViewMessage";
            this.ListViewMessage.Size = new System.Drawing.Size(492, 92);
            this.ListViewMessage.TabIndex = 2;
            this.ListViewMessage.UseCompatibleStateImageBehavior = false;
            // 
            // MessageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "MessageViewer";
            this.Size = new System.Drawing.Size(498, 148);
            this.Resize += new System.EventHandler(this.ErrorDisplay_Resize);
            this.GrpControls.ResumeLayout(false);
            this.GrpControls.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GrpControls;
        private System.Windows.Forms.Button BtnSaveLog;
        private System.Windows.Forms.CheckBox ChkMessage;
        private System.Windows.Forms.CheckBox ChkWarning;
        private System.Windows.Forms.CheckBox ChkError;
        private System.Windows.Forms.CheckBox ChkAutoScroll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView ListViewMessage;
    }
}
