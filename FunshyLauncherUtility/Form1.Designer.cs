namespace FunshyLauncherUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PanelLibrary = new System.Windows.Forms.Panel();
            this.ButtonCreateApplication = new System.Windows.Forms.Button();
            this.FlowPanelApplications = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelSelection = new System.Windows.Forms.Panel();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.DownloadPercentage = new System.Windows.Forms.Label();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.LabelApplicationOnlineVersion = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonApplicationLaunch = new System.Windows.Forms.Button();
            this.LabelApplicationLocalVersion = new System.Windows.Forms.Label();
            this.LabelApplicationName = new System.Windows.Forms.Label();
            this.PictureIcon = new System.Windows.Forms.PictureBox();
            this.LabelCredit = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.ComboBoxThemes = new System.Windows.Forms.ComboBox();
            this.ButtonCreateTheme = new System.Windows.Forms.Button();
            this.PanelLibrary.SuspendLayout();
            this.PanelSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLibrary
            // 
            this.PanelLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLibrary.Controls.Add(this.ButtonCreateApplication);
            this.PanelLibrary.Controls.Add(this.FlowPanelApplications);
            this.PanelLibrary.Location = new System.Drawing.Point(12, 12);
            this.PanelLibrary.Name = "PanelLibrary";
            this.PanelLibrary.Size = new System.Drawing.Size(142, 424);
            this.PanelLibrary.TabIndex = 0;
            // 
            // ButtonCreateApplication
            // 
            this.ButtonCreateApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ButtonCreateApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCreateApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonCreateApplication.Location = new System.Drawing.Point(34, 396);
            this.ButtonCreateApplication.Name = "ButtonCreateApplication";
            this.ButtonCreateApplication.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateApplication.TabIndex = 20;
            this.ButtonCreateApplication.Text = "Create";
            this.ButtonCreateApplication.UseVisualStyleBackColor = false;
            this.ButtonCreateApplication.Click += new System.EventHandler(this.ButtonCreateApplication_Click);
            // 
            // FlowPanelApplications
            // 
            this.FlowPanelApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FlowPanelApplications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowPanelApplications.Location = new System.Drawing.Point(6, 4);
            this.FlowPanelApplications.Name = "FlowPanelApplications";
            this.FlowPanelApplications.Size = new System.Drawing.Size(131, 389);
            this.FlowPanelApplications.TabIndex = 0;
            // 
            // PanelSelection
            // 
            this.PanelSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSelection.Controls.Add(this.ButtonUpdate);
            this.PanelSelection.Controls.Add(this.DownloadPercentage);
            this.PanelSelection.Controls.Add(this.DownloadProgressBar);
            this.PanelSelection.Controls.Add(this.StateLabel);
            this.PanelSelection.Controls.Add(this.ButtonCheck);
            this.PanelSelection.Controls.Add(this.LabelApplicationOnlineVersion);
            this.PanelSelection.Controls.Add(this.TextBoxDescription);
            this.PanelSelection.Controls.Add(this.ButtonApplicationLaunch);
            this.PanelSelection.Controls.Add(this.LabelApplicationLocalVersion);
            this.PanelSelection.Controls.Add(this.LabelApplicationName);
            this.PanelSelection.Controls.Add(this.PictureIcon);
            this.PanelSelection.Location = new System.Drawing.Point(160, 12);
            this.PanelSelection.Name = "PanelSelection";
            this.PanelSelection.Size = new System.Drawing.Size(480, 424);
            this.PanelSelection.TabIndex = 1;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonUpdate.Location = new System.Drawing.Point(185, 370);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 19;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // DownloadPercentage
            // 
            this.DownloadPercentage.AutoSize = true;
            this.DownloadPercentage.BackColor = System.Drawing.Color.Transparent;
            this.DownloadPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DownloadPercentage.Location = new System.Drawing.Point(382, 380);
            this.DownloadPercentage.Name = "DownloadPercentage";
            this.DownloadPercentage.Size = new System.Drawing.Size(21, 13);
            this.DownloadPercentage.TabIndex = 18;
            this.DownloadPercentage.Text = "0%";
            this.DownloadPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Location = new System.Drawing.Point(286, 379);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(92, 14);
            this.DownloadProgressBar.TabIndex = 17;
            // 
            // StateLabel
            // 
            this.StateLabel.AccessibleName = "StateLabel";
            this.StateLabel.AutoSize = true;
            this.StateLabel.BackColor = System.Drawing.Color.Transparent;
            this.StateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.StateLabel.Location = new System.Drawing.Point(286, 362);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(92, 13);
            this.StateLabel.TabIndex = 16;
            this.StateLabel.Text = "Ready to Launch!";
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ButtonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonCheck.Location = new System.Drawing.Point(25, 370);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(75, 23);
            this.ButtonCheck.TabIndex = 6;
            this.ButtonCheck.Text = "Check";
            this.ButtonCheck.UseVisualStyleBackColor = false;
            this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // LabelApplicationOnlineVersion
            // 
            this.LabelApplicationOnlineVersion.AutoSize = true;
            this.LabelApplicationOnlineVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelApplicationOnlineVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LabelApplicationOnlineVersion.Location = new System.Drawing.Point(27, 350);
            this.LabelApplicationOnlineVersion.Name = "LabelApplicationOnlineVersion";
            this.LabelApplicationOnlineVersion.Size = new System.Drawing.Size(63, 17);
            this.LabelApplicationOnlineVersion.TabIndex = 5;
            this.LabelApplicationOnlineVersion.Text = "v.0.0.0.0";
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxDescription.Location = new System.Drawing.Point(15, 160);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.Size = new System.Drawing.Size(445, 170);
            this.TextBoxDescription.TabIndex = 4;
            // 
            // ButtonApplicationLaunch
            // 
            this.ButtonApplicationLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ButtonApplicationLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonApplicationLaunch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonApplicationLaunch.Location = new System.Drawing.Point(163, 98);
            this.ButtonApplicationLaunch.Name = "ButtonApplicationLaunch";
            this.ButtonApplicationLaunch.Size = new System.Drawing.Size(97, 32);
            this.ButtonApplicationLaunch.TabIndex = 3;
            this.ButtonApplicationLaunch.Text = "Launch";
            this.ButtonApplicationLaunch.UseVisualStyleBackColor = false;
            this.ButtonApplicationLaunch.Click += new System.EventHandler(this.ButtonApplicationLaunch_Click);
            // 
            // LabelApplicationLocalVersion
            // 
            this.LabelApplicationLocalVersion.AutoSize = true;
            this.LabelApplicationLocalVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabelApplicationLocalVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LabelApplicationLocalVersion.Location = new System.Drawing.Point(160, 63);
            this.LabelApplicationLocalVersion.Name = "LabelApplicationLocalVersion";
            this.LabelApplicationLocalVersion.Size = new System.Drawing.Size(63, 17);
            this.LabelApplicationLocalVersion.TabIndex = 2;
            this.LabelApplicationLocalVersion.Text = "v.0.0.0.0";
            // 
            // LabelApplicationName
            // 
            this.LabelApplicationName.AutoSize = true;
            this.LabelApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.LabelApplicationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LabelApplicationName.Location = new System.Drawing.Point(158, 28);
            this.LabelApplicationName.Name = "LabelApplicationName";
            this.LabelApplicationName.Size = new System.Drawing.Size(71, 26);
            this.LabelApplicationName.TabIndex = 1;
            this.LabelApplicationName.Text = "Name";
            // 
            // PictureIcon
            // 
            this.PictureIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureIcon.Location = new System.Drawing.Point(15, 15);
            this.PictureIcon.Name = "PictureIcon";
            this.PictureIcon.Size = new System.Drawing.Size(128, 128);
            this.PictureIcon.TabIndex = 0;
            this.PictureIcon.TabStop = false;
            // 
            // LabelCredit
            // 
            this.LabelCredit.AutoSize = true;
            this.LabelCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LabelCredit.Location = new System.Drawing.Point(9, 452);
            this.LabelCredit.Name = "LabelCredit";
            this.LabelCredit.Size = new System.Drawing.Size(33, 13);
            this.LabelCredit.TabIndex = 3;
            this.LabelCredit.Text = "credit";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LabelVersion.Location = new System.Drawing.Point(9, 439);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(49, 13);
            this.LabelVersion.TabIndex = 2;
            this.LabelVersion.Text = "v.0.0.0.0";
            // 
            // ComboBoxThemes
            // 
            this.ComboBoxThemes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ComboBoxThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxThemes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBoxThemes.FormattingEnabled = true;
            this.ComboBoxThemes.Items.AddRange(new object[] {
            "Dark",
            "White"});
            this.ComboBoxThemes.Location = new System.Drawing.Point(160, 443);
            this.ComboBoxThemes.Name = "ComboBoxThemes";
            this.ComboBoxThemes.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxThemes.TabIndex = 4;
            this.ComboBoxThemes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxThemes_SelectedIndexChanged);
            // 
            // ButtonCreateTheme
            // 
            this.ButtonCreateTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ButtonCreateTheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCreateTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonCreateTheme.Location = new System.Drawing.Point(287, 443);
            this.ButtonCreateTheme.Name = "ButtonCreateTheme";
            this.ButtonCreateTheme.Size = new System.Drawing.Size(86, 23);
            this.ButtonCreateTheme.TabIndex = 21;
            this.ButtonCreateTheme.Text = "Create Theme";
            this.ButtonCreateTheme.UseVisualStyleBackColor = false;
            this.ButtonCreateTheme.Click += new System.EventHandler(this.ButtonCreateTheme_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(654, 471);
            this.Controls.Add(this.ButtonCreateTheme);
            this.Controls.Add(this.ComboBoxThemes);
            this.Controls.Add(this.LabelCredit);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.PanelSelection);
            this.Controls.Add(this.PanelLibrary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 510);
            this.MinimumSize = new System.Drawing.Size(670, 510);
            this.Name = "MainWindow";
            this.Text = "FunshyLauncherUtility";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.PanelLibrary.ResumeLayout(false);
            this.PanelSelection.ResumeLayout(false);
            this.PanelSelection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLibrary;
        private System.Windows.Forms.Panel PanelSelection;
        private System.Windows.Forms.PictureBox PictureIcon;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelApplications;
        private System.Windows.Forms.Label LabelApplicationName;
        private System.Windows.Forms.Label LabelApplicationLocalVersion;
        private System.Windows.Forms.Button ButtonApplicationLaunch;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label DownloadPercentage;
        private System.Windows.Forms.ProgressBar DownloadProgressBar;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.Label LabelApplicationOnlineVersion;
        private System.Windows.Forms.Button ButtonCreateApplication;
        private System.Windows.Forms.Label LabelCredit;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.ComboBox ComboBoxThemes;
        private System.Windows.Forms.Button ButtonCreateTheme;
    }
}

