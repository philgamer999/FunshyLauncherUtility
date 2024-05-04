using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunshyLauncherUtility
{
    public partial class AddApplication : Form
    {
        MainWindow mainWindow = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();

        string iconPath = string.Empty;

        public AddApplication()
        {
            InitializeComponent();
        }

        private void AddApplication_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCreateApplication_Click(object sender, EventArgs e)
        {
            mainWindow.CreateApplication(TextBoxName.Text, TextBoxExecutableName.Text, TextBoxDownloadLink.Text, TextBoxVersionLink.Text, TextBoxDescription.Text, iconPath);
        }

        private void ButtonSelectIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            OpenFileIcon.InitialDirectory = "c:\\";
            OpenFileIcon.Filter = "PNG Files (*.png)|*.png";
            OpenFileIcon.FilterIndex = 1;
            OpenFileIcon.RestoreDirectory = true;

            if (OpenFileIcon.ShowDialog() == DialogResult.OK)
            {
                if (OpenFileIcon.FileName.EndsWith(".png"))
                {
                    iconPath = OpenFileIcon.FileName;
                }
            }
        }



        #region TextArea Events

        private void TextBoxName_Enter(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "Enter Name...")
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxExecutableName_Enter(object sender, EventArgs e)
        {
            if (TextBoxExecutableName.Text == "Enter Executable Name...")
            {
                TextBoxExecutableName.Text = "";
                TextBoxExecutableName.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxDownloadLink_Enter(object sender, EventArgs e)
        {
            if (TextBoxDownloadLink.Text == "Enter Download Link...")
            {
                TextBoxDownloadLink.Text = "";
                TextBoxDownloadLink.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxVersionLink_Enter(object sender, EventArgs e)
        {
            if (TextBoxVersionLink.Text == "Enter Version Link...")
            {
                TextBoxVersionLink.Text = "";
                TextBoxVersionLink.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxDescription_Enter(object sender, EventArgs e)
        {
            if (TextBoxDescription.Text == "Enter Description...")
            {
                TextBoxDescription.Text = "";
                TextBoxDescription.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                TextBoxName.Text = "Enter Name...";
                TextBoxName.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }

        private void TextBoxExecutableName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxExecutableName.Text))
            {
                TextBoxExecutableName.Text = "Enter Executable Name...";
                TextBoxExecutableName.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }

        private void TextBoxDownloadLink_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxDownloadLink.Text))
            {
                TextBoxDownloadLink.Text = "Enter Download Link...";
                TextBoxDownloadLink.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }

        private void TextBoxVersionLink_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxVersionLink.Text))
            {
                TextBoxVersionLink.Text = "Enter Version Link...";
                TextBoxVersionLink.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }

        private void TextBoxDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                TextBoxDescription.Text = "Enter Description...";
                TextBoxDescription.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }
        #endregion
    }
}
