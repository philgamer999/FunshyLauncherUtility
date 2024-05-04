namespace FunshyLauncherUtility
{
    partial class AddApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApplication));
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxExecutableName = new System.Windows.Forms.TextBox();
            this.TextBoxDownloadLink = new System.Windows.Forms.TextBox();
            this.TextBoxVersionLink = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.ButtonCreateApplication = new System.Windows.Forms.Button();
            this.ButtonSelectIcon = new System.Windows.Forms.Button();
            this.OpenFileIcon = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxName.Location = new System.Drawing.Point(37, 13);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(155, 20);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Text = "Enter Name...";
            this.TextBoxName.Enter += new System.EventHandler(this.TextBoxName_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // TextBoxExecutableName
            // 
            this.TextBoxExecutableName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxExecutableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxExecutableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxExecutableName.Location = new System.Drawing.Point(37, 39);
            this.TextBoxExecutableName.Name = "TextBoxExecutableName";
            this.TextBoxExecutableName.Size = new System.Drawing.Size(155, 20);
            this.TextBoxExecutableName.TabIndex = 1;
            this.TextBoxExecutableName.Text = "Enter Executable Name...";
            this.TextBoxExecutableName.Enter += new System.EventHandler(this.TextBoxExecutableName_Enter);
            this.TextBoxExecutableName.Leave += new System.EventHandler(this.TextBoxExecutableName_Leave);
            // 
            // TextBoxDownloadLink
            // 
            this.TextBoxDownloadLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxDownloadLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDownloadLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxDownloadLink.Location = new System.Drawing.Point(37, 65);
            this.TextBoxDownloadLink.Name = "TextBoxDownloadLink";
            this.TextBoxDownloadLink.Size = new System.Drawing.Size(155, 20);
            this.TextBoxDownloadLink.TabIndex = 2;
            this.TextBoxDownloadLink.Text = "Enter Download Link...";
            this.TextBoxDownloadLink.Enter += new System.EventHandler(this.TextBoxDownloadLink_Enter);
            this.TextBoxDownloadLink.Leave += new System.EventHandler(this.TextBoxDownloadLink_Leave);
            // 
            // TextBoxVersionLink
            // 
            this.TextBoxVersionLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxVersionLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxVersionLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxVersionLink.Location = new System.Drawing.Point(37, 91);
            this.TextBoxVersionLink.Name = "TextBoxVersionLink";
            this.TextBoxVersionLink.Size = new System.Drawing.Size(155, 20);
            this.TextBoxVersionLink.TabIndex = 3;
            this.TextBoxVersionLink.Text = "Enter Version Link...";
            this.TextBoxVersionLink.Enter += new System.EventHandler(this.TextBoxVersionLink_Enter);
            this.TextBoxVersionLink.Leave += new System.EventHandler(this.TextBoxVersionLink_Leave);
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextBoxDescription.Location = new System.Drawing.Point(37, 117);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(155, 20);
            this.TextBoxDescription.TabIndex = 4;
            this.TextBoxDescription.Text = "Enter Description...";
            this.TextBoxDescription.Enter += new System.EventHandler(this.TextBoxDescription_Enter);
            this.TextBoxDescription.Leave += new System.EventHandler(this.TextBoxDescription_Leave);
            // 
            // ButtonCreateApplication
            // 
            this.ButtonCreateApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ButtonCreateApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonCreateApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonCreateApplication.Location = new System.Drawing.Point(77, 176);
            this.ButtonCreateApplication.Name = "ButtonCreateApplication";
            this.ButtonCreateApplication.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateApplication.TabIndex = 5;
            this.ButtonCreateApplication.Text = "Create";
            this.ButtonCreateApplication.UseVisualStyleBackColor = false;
            this.ButtonCreateApplication.Click += new System.EventHandler(this.ButtonCreateApplication_Click);
            // 
            // ButtonSelectIcon
            // 
            this.ButtonSelectIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ButtonSelectIcon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonSelectIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ButtonSelectIcon.Location = new System.Drawing.Point(37, 147);
            this.ButtonSelectIcon.Name = "ButtonSelectIcon";
            this.ButtonSelectIcon.Size = new System.Drawing.Size(155, 23);
            this.ButtonSelectIcon.TabIndex = 6;
            this.ButtonSelectIcon.Text = "Select Icon";
            this.ButtonSelectIcon.UseVisualStyleBackColor = false;
            this.ButtonSelectIcon.Click += new System.EventHandler(this.ButtonSelectIcon_Click);
            // 
            // OpenFileIcon
            // 
            this.OpenFileIcon.FileName = "icon";
            // 
            // AddApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.ButtonSelectIcon);
            this.Controls.Add(this.ButtonCreateApplication);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxVersionLink);
            this.Controls.Add(this.TextBoxDownloadLink);
            this.Controls.Add(this.TextBoxExecutableName);
            this.Controls.Add(this.TextBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "AddApplication";
            this.Text = "Add Application";
            this.Load += new System.EventHandler(this.AddApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxExecutableName;
        private System.Windows.Forms.TextBox TextBoxDownloadLink;
        private System.Windows.Forms.TextBox TextBoxVersionLink;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.Button ButtonCreateApplication;
        private System.Windows.Forms.Button ButtonSelectIcon;
        private System.Windows.Forms.OpenFileDialog OpenFileIcon;
    }
}