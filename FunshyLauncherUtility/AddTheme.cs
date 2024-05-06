using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunshyLauncherUtility
{
    public partial class AddTheme : Form
    {
        MainWindow mainWindow = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();

        public AddTheme()
        {
            InitializeComponent();
        }

        private void ButtonCreateTheme_Click(object sender, EventArgs e)
        {
            mainWindow.CreateTheme(TextBoxName.Text, TextBoxBackground.Text, TextBoxPanel.Text, TextBoxBox.Text, TextBoxButton.Text, TextBoxText.Text, TextBoxProgressBar.Text);
        }



        private void TextBoxName_Enter(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "Enter Name...")
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = ColorTranslator.FromHtml("#646464");
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

        private void TextBoxBackground_Enter(object sender, EventArgs e)
        {
            if (TextBoxBackground.Text == "Enter Background HEX...")
            {
                TextBoxBackground.Text = "";
                TextBoxBackground.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxBackground_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxBackground.Text))
            {
                TextBoxBackground.Text = "Enter Background HEX...";
                TextBoxBackground.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }

        private void TextBoxPanel_Enter(object sender, EventArgs e)
        {
            if (TextBoxPanel.Text == "Enter Panel HEX...")
            {
                TextBoxPanel.Text = "";
                TextBoxPanel.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxPanel_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxPanel.Text))
            {
                TextBoxPanel.Text = "Enter Panel HEX...";
                TextBoxPanel.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }

        private void TextBoxBox_Enter(object sender, EventArgs e)
        {
            if (TextBoxBox.Text == "Enter Box HEX...")
            {
                TextBoxBox.Text = "";
                TextBoxBox.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxBox.Text))
            {
                TextBoxBox.Text = "Enter Box HEX...";
                TextBoxBox.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }

        private void TextBoxButton_Enter(object sender, EventArgs e)
        {
            if (TextBoxButton.Text == "Enter Button HEX...")
            {
                TextBoxButton.Text = "";
                TextBoxButton.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxButton_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxButton.Text))
            {
                TextBoxButton.Text = "Enter Button HEX...";
                TextBoxButton.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }

        private void TextBoxText_Enter(object sender, EventArgs e)
        {
            if (TextBoxText.Text == "Enter Text HEX...")
            {
                TextBoxText.Text = "";
                TextBoxText.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxText.Text))
            {
                TextBoxText.Text = "Enter Text HEX...";
                TextBoxText.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }

        private void TextBoxProgressBar_Enter(object sender, EventArgs e)
        {
            if (TextBoxProgressBar.Text == "Enter ProgressBar HEX...")
            {
                TextBoxProgressBar.Text = "";
                TextBoxProgressBar.ForeColor = ColorTranslator.FromHtml("#646464");
            }
        }

        private void TextBoxProgressBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxProgressBar.Text))
            {
                TextBoxProgressBar.Text = "Enter ProgressBar HEX...";
                TextBoxProgressBar.ForeColor = ColorTranslator.FromHtml("#505050");
            }
        }
    }
}
