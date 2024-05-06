namespace FunshyLauncherUtility
{
    partial class AddTheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTheme));
            this.ButtonCreateTheme = new System.Windows.Forms.Button();
            this.TextBoxButton = new System.Windows.Forms.TextBox();
            this.TextBoxBox = new System.Windows.Forms.TextBox();
            this.TextBoxPanel = new System.Windows.Forms.TextBox();
            this.TextBoxBackground = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxProgressBar = new System.Windows.Forms.TextBox();
            this.TextBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCreateTheme
            // 
            this.ButtonCreateTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ButtonCreateTheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCreateTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonCreateTheme.Location = new System.Drawing.Point(80, 194);
            this.ButtonCreateTheme.Name = "ButtonCreateTheme";
            this.ButtonCreateTheme.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateTheme.TabIndex = 11;
            this.ButtonCreateTheme.Text = "Create";
            this.ButtonCreateTheme.UseVisualStyleBackColor = false;
            this.ButtonCreateTheme.Click += new System.EventHandler(this.ButtonCreateTheme_Click);
            // 
            // TextBoxButton
            // 
            this.TextBoxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxButton.Location = new System.Drawing.Point(40, 116);
            this.TextBoxButton.Multiline = true;
            this.TextBoxButton.Name = "TextBoxButton";
            this.TextBoxButton.Size = new System.Drawing.Size(155, 20);
            this.TextBoxButton.TabIndex = 10;
            this.TextBoxButton.Text = "Enter Button HEX...";
            this.TextBoxButton.Enter += new System.EventHandler(this.TextBoxButton_Enter);
            this.TextBoxButton.Leave += new System.EventHandler(this.TextBoxButton_Leave);
            // 
            // TextBoxBox
            // 
            this.TextBoxBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxBox.Location = new System.Drawing.Point(40, 90);
            this.TextBoxBox.Name = "TextBoxBox";
            this.TextBoxBox.Size = new System.Drawing.Size(155, 20);
            this.TextBoxBox.TabIndex = 9;
            this.TextBoxBox.Text = "Enter Box HEX...";
            this.TextBoxBox.Enter += new System.EventHandler(this.TextBoxBox_Enter);
            this.TextBoxBox.Leave += new System.EventHandler(this.TextBoxBox_Leave);
            // 
            // TextBoxPanel
            // 
            this.TextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxPanel.Location = new System.Drawing.Point(40, 64);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Size = new System.Drawing.Size(155, 20);
            this.TextBoxPanel.TabIndex = 8;
            this.TextBoxPanel.Text = "Enter Panel HEX...";
            this.TextBoxPanel.Enter += new System.EventHandler(this.TextBoxPanel_Enter);
            this.TextBoxPanel.Leave += new System.EventHandler(this.TextBoxPanel_Leave);
            // 
            // TextBoxBackground
            // 
            this.TextBoxBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxBackground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxBackground.Location = new System.Drawing.Point(40, 38);
            this.TextBoxBackground.Name = "TextBoxBackground";
            this.TextBoxBackground.Size = new System.Drawing.Size(155, 20);
            this.TextBoxBackground.TabIndex = 7;
            this.TextBoxBackground.Text = "Enter Background HEX...";
            this.TextBoxBackground.Enter += new System.EventHandler(this.TextBoxBackground_Enter);
            this.TextBoxBackground.Leave += new System.EventHandler(this.TextBoxBackground_Leave);
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxName.Location = new System.Drawing.Point(40, 12);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(155, 20);
            this.TextBoxName.TabIndex = 6;
            this.TextBoxName.Text = "Enter Name...";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBoxName_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // TextBoxProgressBar
            // 
            this.TextBoxProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxProgressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxProgressBar.Location = new System.Drawing.Point(40, 168);
            this.TextBoxProgressBar.Multiline = true;
            this.TextBoxProgressBar.Name = "TextBoxProgressBar";
            this.TextBoxProgressBar.Size = new System.Drawing.Size(155, 20);
            this.TextBoxProgressBar.TabIndex = 13;
            this.TextBoxProgressBar.Text = "Enter ProgressBar HEX...";
            this.TextBoxProgressBar.Enter += new System.EventHandler(this.TextBoxProgressBar_Enter);
            this.TextBoxProgressBar.Leave += new System.EventHandler(this.TextBoxProgressBar_Leave);
            // 
            // TextBoxText
            // 
            this.TextBoxText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxText.Location = new System.Drawing.Point(40, 142);
            this.TextBoxText.Name = "TextBoxText";
            this.TextBoxText.Size = new System.Drawing.Size(155, 20);
            this.TextBoxText.TabIndex = 12;
            this.TextBoxText.Text = "Enter Text HEX...";
            this.TextBoxText.Enter += new System.EventHandler(this.TextBoxText_Enter);
            this.TextBoxText.Leave += new System.EventHandler(this.TextBoxText_Leave);
            // 
            // AddTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(234, 236);
            this.Controls.Add(this.TextBoxProgressBar);
            this.Controls.Add(this.TextBoxText);
            this.Controls.Add(this.ButtonCreateTheme);
            this.Controls.Add(this.TextBoxButton);
            this.Controls.Add(this.TextBoxBox);
            this.Controls.Add(this.TextBoxPanel);
            this.Controls.Add(this.TextBoxBackground);
            this.Controls.Add(this.TextBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 275);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 275);
            this.Name = "AddTheme";
            this.Text = "AddTheme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreateTheme;
        private System.Windows.Forms.TextBox TextBoxButton;
        private System.Windows.Forms.TextBox TextBoxBox;
        private System.Windows.Forms.TextBox TextBoxPanel;
        private System.Windows.Forms.TextBox TextBoxBackground;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxProgressBar;
        private System.Windows.Forms.TextBox TextBoxText;
    }
}