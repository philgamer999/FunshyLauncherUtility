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
            this.PanelLibrary = new System.Windows.Forms.Panel();
            this.PanelSelection = new System.Windows.Forms.Panel();
            this.PanelControls = new System.Windows.Forms.Panel();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelCredit = new System.Windows.Forms.Label();
            this.PanelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLibrary
            // 
            this.PanelLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelLibrary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLibrary.Location = new System.Drawing.Point(12, 53);
            this.PanelLibrary.Name = "PanelLibrary";
            this.PanelLibrary.Size = new System.Drawing.Size(274, 424);
            this.PanelLibrary.TabIndex = 0;
            // 
            // PanelSelection
            // 
            this.PanelSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSelection.Location = new System.Drawing.Point(292, 53);
            this.PanelSelection.Name = "PanelSelection";
            this.PanelSelection.Size = new System.Drawing.Size(480, 424);
            this.PanelSelection.TabIndex = 1;
            // 
            // PanelControls
            // 
            this.PanelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelControls.Controls.Add(this.LabelCredit);
            this.PanelControls.Controls.Add(this.LabelVersion);
            this.PanelControls.Location = new System.Drawing.Point(12, 483);
            this.PanelControls.Name = "PanelControls";
            this.PanelControls.Size = new System.Drawing.Size(760, 66);
            this.PanelControls.TabIndex = 2;
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LabelVersion.Location = new System.Drawing.Point(3, 38);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(49, 13);
            this.LabelVersion.TabIndex = 0;
            this.LabelVersion.Text = "v.0.0.0.0";
            // 
            // LabelCredit
            // 
            this.LabelCredit.AutoSize = true;
            this.LabelCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LabelCredit.Location = new System.Drawing.Point(3, 51);
            this.LabelCredit.Name = "LabelCredit";
            this.LabelCredit.Size = new System.Drawing.Size(33, 13);
            this.LabelCredit.TabIndex = 1;
            this.LabelCredit.Text = "credit";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PanelControls);
            this.Controls.Add(this.PanelSelection);
            this.Controls.Add(this.PanelLibrary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Text = "FunshyLauncherUtility";
            this.PanelControls.ResumeLayout(false);
            this.PanelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLibrary;
        private System.Windows.Forms.Panel PanelSelection;
        private System.Windows.Forms.Panel PanelControls;
        private System.Windows.Forms.Label LabelCredit;
        private System.Windows.Forms.Label LabelVersion;
    }
}

