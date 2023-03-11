namespace Timelog.Agent
{
    partial class AgentUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentUI));
            this.lblAgentVersion = new System.Windows.Forms.Label();
            this.TimelogIcon = new System.Windows.Forms.Label();
            this.btnMinimized = new System.Windows.Forms.Label();
            this.cpbStatus = new CircularProgressBar.CircularProgressBar();
            this.ProcessedPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ProcBtn = new System.Windows.Forms.Label();
            this.lblProcessed = new System.Windows.Forms.Label();
            this.UnprocLbl = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.UnprocBtn = new System.Windows.Forms.Label();
            this.lblUnprocessed = new System.Windows.Forms.Label();
            this.ErrLbl = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ErrBtn = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Label();
            this.btnPlayStop = new System.Windows.Forms.Label();
            this.TimeLog = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProcessedPanel.SuspendLayout();
            this.UnprocLbl.SuspendLayout();
            this.ErrLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAgentVersion
            // 
            this.lblAgentVersion.AutoSize = true;
            this.lblAgentVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblAgentVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentVersion.ForeColor = System.Drawing.Color.Black;
            this.lblAgentVersion.Location = new System.Drawing.Point(42, 11);
            this.lblAgentVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgentVersion.Name = "lblAgentVersion";
            this.lblAgentVersion.Size = new System.Drawing.Size(147, 16);
            this.lblAgentVersion.TabIndex = 20;
            this.lblAgentVersion.Text = "Empleyado CLK parser";
            this.lblAgentVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgentVersion.Click += new System.EventHandler(this.lblAgentVersion_Click);
            // 
            // TimelogIcon
            // 
            this.TimelogIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimelogIcon.ForeColor = System.Drawing.Color.Black;
            this.TimelogIcon.Image = ((System.Drawing.Image)(resources.GetObject("TimelogIcon.Image")));
            this.TimelogIcon.Location = new System.Drawing.Point(14, 8);
            this.TimelogIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimelogIcon.Name = "TimelogIcon";
            this.TimelogIcon.Size = new System.Drawing.Size(25, 25);
            this.TimelogIcon.TabIndex = 19;
            this.TimelogIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimized.ForeColor = System.Drawing.Color.White;
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(373, 6);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(23, 20);
            this.btnMinimized.TabIndex = 21;
            this.btnMinimized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            this.btnMinimized.MouseLeave += new System.EventHandler(this.btnMinimized_MouseLeave);
            this.btnMinimized.MouseHover += new System.EventHandler(this.btnMinimized_MouseHover);
            // 
            // cpbStatus
            // 
            this.cpbStatus.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbStatus.AnimationSpeed = 1000;
            this.cpbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cpbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cpbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cpbStatus.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.cpbStatus.InnerMargin = 2;
            this.cpbStatus.InnerWidth = -1;
            this.cpbStatus.Location = new System.Drawing.Point(87, 44);
            this.cpbStatus.MarqueeAnimationSpeed = 4000;
            this.cpbStatus.Name = "cpbStatus";
            this.cpbStatus.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbStatus.OuterMargin = -25;
            this.cpbStatus.OuterWidth = 26;
            this.cpbStatus.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cpbStatus.ProgressWidth = 25;
            this.cpbStatus.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbStatus.Size = new System.Drawing.Size(220, 214);
            this.cpbStatus.StartAngle = 270;
            this.cpbStatus.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbStatus.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbStatus.SubscriptText = "    ";
            this.cpbStatus.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbStatus.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbStatus.SuperscriptText = "                       ";
            this.cpbStatus.TabIndex = 22;
            this.cpbStatus.Text = "Stopped";
            this.cpbStatus.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbStatus.Value = 25;
            this.cpbStatus.Click += new System.EventHandler(this.cpbStatus_Click);
            // 
            // ProcessedPanel
            // 
            this.ProcessedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProcessedPanel.BackColor = System.Drawing.Color.White;
            this.ProcessedPanel.Controls.Add(this.panel4);
            this.ProcessedPanel.Controls.Add(this.ProcBtn);
            this.ProcessedPanel.Controls.Add(this.lblProcessed);
            this.ProcessedPanel.Location = new System.Drawing.Point(25, 319);
            this.ProcessedPanel.Name = "ProcessedPanel";
            this.ProcessedPanel.Size = new System.Drawing.Size(117, 110);
            this.ProcessedPanel.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(157)))), ((int)(((byte)(203)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(117, 7);
            this.panel4.TabIndex = 28;
            // 
            // ProcBtn
            // 
            this.ProcBtn.AutoSize = true;
            this.ProcBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ProcBtn.Location = new System.Drawing.Point(20, 17);
            this.ProcBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcBtn.Name = "ProcBtn";
            this.ProcBtn.Size = new System.Drawing.Size(74, 16);
            this.ProcBtn.TabIndex = 5;
            this.ProcBtn.Text = "Processed";
            this.ProcBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcessed
            // 
            this.lblProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProcessed.Location = new System.Drawing.Point(4, 38);
            this.lblProcessed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessed.Name = "lblProcessed";
            this.lblProcessed.Size = new System.Drawing.Size(109, 39);
            this.lblProcessed.TabIndex = 4;
            this.lblProcessed.Text = "0";
            this.lblProcessed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnprocLbl
            // 
            this.UnprocLbl.BackColor = System.Drawing.Color.White;
            this.UnprocLbl.Controls.Add(this.panel5);
            this.UnprocLbl.Controls.Add(this.UnprocBtn);
            this.UnprocLbl.Controls.Add(this.lblUnprocessed);
            this.UnprocLbl.Location = new System.Drawing.Point(143, 319);
            this.UnprocLbl.Name = "UnprocLbl";
            this.UnprocLbl.Size = new System.Drawing.Size(117, 110);
            this.UnprocLbl.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(124)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 7);
            this.panel5.TabIndex = 29;
            // 
            // UnprocBtn
            // 
            this.UnprocBtn.AutoSize = true;
            this.UnprocBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnprocBtn.ForeColor = System.Drawing.Color.DimGray;
            this.UnprocBtn.Location = new System.Drawing.Point(12, 17);
            this.UnprocBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnprocBtn.Name = "UnprocBtn";
            this.UnprocBtn.Size = new System.Drawing.Size(90, 16);
            this.UnprocBtn.TabIndex = 5;
            this.UnprocBtn.Text = "Unprocessed";
            this.UnprocBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnprocessed
            // 
            this.lblUnprocessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnprocessed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnprocessed.Location = new System.Drawing.Point(4, 38);
            this.lblUnprocessed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnprocessed.Name = "lblUnprocessed";
            this.lblUnprocessed.Size = new System.Drawing.Size(109, 39);
            this.lblUnprocessed.TabIndex = 4;
            this.lblUnprocessed.Text = "0";
            this.lblUnprocessed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrLbl
            // 
            this.ErrLbl.BackColor = System.Drawing.Color.White;
            this.ErrLbl.Controls.Add(this.panel6);
            this.ErrLbl.Controls.Add(this.ErrBtn);
            this.ErrLbl.Controls.Add(this.lblError);
            this.ErrLbl.Location = new System.Drawing.Point(261, 319);
            this.ErrLbl.Name = "ErrLbl";
            this.ErrLbl.Size = new System.Drawing.Size(117, 110);
            this.ErrLbl.TabIndex = 24;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(117, 7);
            this.panel6.TabIndex = 29;
            // 
            // ErrBtn
            // 
            this.ErrBtn.AutoSize = true;
            this.ErrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrBtn.ForeColor = System.Drawing.Color.DimGray;
            this.ErrBtn.Location = new System.Drawing.Point(42, 17);
            this.ErrBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrBtn.Name = "ErrBtn";
            this.ErrBtn.Size = new System.Drawing.Size(37, 16);
            this.ErrBtn.TabIndex = 5;
            this.ErrBtn.Text = "Error";
            this.ErrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblError.Location = new System.Drawing.Point(4, 38);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(109, 39);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "0";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.Black;
            this.txtPath.Location = new System.Drawing.Point(25, 288);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(290, 22);
            this.txtPath.TabIndex = 25;
            this.txtPath.Text = "C:\\apex\\datas";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.Location = new System.Drawing.Point(319, 283);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 28);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.MouseLeave += new System.EventHandler(this.btnBrowse_MouseLeave);
            this.btnBrowse.MouseHover += new System.EventHandler(this.btnBrowse_MouseHover);
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayStop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayStop.Location = new System.Drawing.Point(349, 283);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(32, 28);
            this.btnPlayStop.TabIndex = 26;
            this.btnPlayStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            this.btnPlayStop.MouseLeave += new System.EventHandler(this.btnPlayStop_MouseLeave);
            this.btnPlayStop.MouseHover += new System.EventHandler(this.btnPlayStop_MouseHover);
            // 
            // TimeLog
            // 
            this.TimeLog.Icon = ((System.Drawing.Icon)(resources.GetObject("TimeLog.Icon")));
            this.TimeLog.Text = "Fetcher";
            this.TimeLog.Visible = true;
            this.TimeLog.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.TimeLog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "App Version : 1.0.0.2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ping Server Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Connected";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AgentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(403, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnPlayStop);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.ErrLbl);
            this.Controls.Add(this.UnprocLbl);
            this.Controls.Add(this.ProcessedPanel);
            this.Controls.Add(this.cpbStatus);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.lblAgentVersion);
            this.Controls.Add(this.TimelogIcon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgentUI";
            this.Text = "Timelog Agent";
            this.Load += new System.EventHandler(this.AgentUI_Load);
            this.SizeChanged += new System.EventHandler(this.AgentUI_SizeChanged);
            this.ProcessedPanel.ResumeLayout(false);
            this.ProcessedPanel.PerformLayout();
            this.UnprocLbl.ResumeLayout(false);
            this.UnprocLbl.PerformLayout();
            this.ErrLbl.ResumeLayout(false);
            this.ErrLbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgentVersion;
        private System.Windows.Forms.Label TimelogIcon;
        private System.Windows.Forms.Label btnMinimized;
        private CircularProgressBar.CircularProgressBar cpbStatus;
        private System.Windows.Forms.Panel ProcessedPanel;
        private System.Windows.Forms.Label ProcBtn;
        private System.Windows.Forms.Label lblProcessed;
        private System.Windows.Forms.Panel UnprocLbl;
        private System.Windows.Forms.Label UnprocBtn;
        private System.Windows.Forms.Label lblUnprocessed;
        private System.Windows.Forms.Panel ErrLbl;
        private System.Windows.Forms.Label ErrBtn;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label btnBrowse;
        private System.Windows.Forms.Label btnPlayStop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NotifyIcon TimeLog;
        public System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

