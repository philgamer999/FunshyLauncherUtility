using AltoHttp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FunshyLauncherUtility
{
    public partial class MainWindow : Form
    {
        ConfigHolders configHolders = new ConfigHolders();
        SettingsHolder settingsHolder = new SettingsHolder();
        ThemeHolder themeHolder = new ThemeHolder();
        AddApplication addApplication;
        AddTheme addTheme;

        private Color colorBackground;
        private Color colorPanel;
        private Color colorBox;
        private Color colorButton;
        private Color colorText;
        private Color colorProgressBar;

        private string dataPath;
        
        private string settingsLibraryPath;
        private string configLibraryPath;
        private string appLibraryPath;

        private string settingsXMLPath;
        private string themesXMLPath;

        private List<string> configsPaths = new List<string>();
        private List<string> appPaths = new List<string>();

        private int selectedIndex;

        HttpDownloader httpDownloader;
        HttpDownloader httpDownloaderTXT;

        private enum LibraryState
        {
            Normal,
            Delete    
        };
        LibraryState libraryState = LibraryState.Normal;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LabelCredit.Text = Application.CompanyName;
            LabelVersion.Text = Application.ProductVersion;

            SetPaths();
            StructureCheck();
            LoadConfigs();
            LoadThemes();
            LoadSettings();
            SetSettings();
        }

        private void SetPaths()
        {
            dataPath = Application.StartupPath + "/data";
            settingsLibraryPath = dataPath + "/settings";
            configLibraryPath = dataPath + "/configLibrary";
            appLibraryPath = dataPath + "/appLibrary";
            settingsXMLPath = $"{settingsLibraryPath}/settings.xml";
            themesXMLPath = $"{settingsLibraryPath}/themes.xml";

        }

        private void StructureCheck()
        {
            if (!Directory.Exists(dataPath)) //data Directory
            {
                Directory.CreateDirectory(dataPath);
            }

            if (!Directory.Exists(settingsLibraryPath)) //settings Directory
            {
                Directory.CreateDirectory(settingsLibraryPath);
            }

            if (!Directory.Exists(configLibraryPath)) //configLibrary Directory
            {
                Directory.CreateDirectory(configLibraryPath);
            }

            if (!Directory.Exists(appLibraryPath)) //appLibrary Directory
            {
                Directory.CreateDirectory(appLibraryPath);
            }

            if (!File.Exists(settingsXMLPath))
            {
                settingsHolder.themeIndex = 0;
                settingsHolder.versionHistoryEnabled = false;
                settingsHolder.startPosition = new Point(0, 0);
                settingsHolder.pinOnStartEnabled = false;
                File.WriteAllText(settingsXMLPath, $"<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<SettingsHolder xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <themeIndex>0</themeIndex>\r\n  <versionHistoryEnabled>false</versionHistoryEnabled>\r\n  <startPosition>\r\n    <X>0</X>\r\n    <Y>0</Y>\r\n  </startPosition>\r\n  <pinOnStartEnabled>false</pinOnStartEnabled>\r\n</SettingsHolder>");
            }

            if (!File.Exists(themesXMLPath))
            {
                File.WriteAllText(themesXMLPath, $"<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<ThemeHolder xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <themesName>\r\n    <string>Dark</string>\r\n    <string>Light</string>\r\n  </themesName>\r\n  <backgroundHEX>\r\n    <string>#101010</string>\r\n    <string>#ffffff</string>\r\n  </backgroundHEX>\r\n  <panelHEX>\r\n    <string>#141414</string>\r\n    <string>#ffffff</string>\r\n  </panelHEX>\r\n  <boxHEX>\r\n    <string>#191919</string>\r\n    <string>#ffffff</string>\r\n  </boxHEX>\r\n  <buttonHEX>\r\n    <string>#191919</string>\r\n    <string>#ffffff</string>\r\n  </buttonHEX>\r\n  <textHEX>\r\n    <string>#646464</string>\r\n    <string>#ffffff</string>\r\n  </textHEX>\r\n  <progressBarBackgroundHEX>\r\n    <string>#191919</string>\r\n    <string>#ffffff</string>\r\n  </progressBarBackgroundHEX>\r\n</ThemeHolder>");

                string[] names = new string[2] { "Dark", "Light" };
                themeHolder.themesName.Clear();
                themeHolder.themesName.AddRange(names);
                string[] cbackground = new string[2] { "#101010", "#ffffff" };
                themeHolder.backgroundHEX.Clear();
                themeHolder.backgroundHEX.AddRange(cbackground);
                string[] cPanel = new string[2] { "#141414", "#ffffff" };
                themeHolder.panelHEX.Clear();
                themeHolder.panelHEX.AddRange(cPanel);
                string[] cBox = new string[2] { "#191919", "#ffffff" };
                themeHolder.boxHEX.Clear();
                themeHolder.boxHEX.AddRange(cBox);
                string[] cButton = new string[2] { "#191919", "#ffffff" };
                themeHolder.buttonHEX.Clear();
                themeHolder.buttonHEX.AddRange(cButton);
                string[] cText = new string[2] { "#646464", "#ffffff" };
                themeHolder.textHEX.Clear();
                themeHolder.textHEX.AddRange(cText);
                string[] cProgressBar = new string[2] { "#191919", "#ffffff" };
                themeHolder.progressBarBackgroundHEX.Clear();
                themeHolder.progressBarBackgroundHEX.AddRange(cProgressBar);

                SaveThemes();
            }
        }

        private void LoadConfigs()
        {
            if (InvokeRequired)
            {
                Invoke((Action)delegate { LoadConfigs(); });
            }
            else
            {
                configsPaths.Clear();
                configsPaths.AddRange(Directory.GetDirectories(configLibraryPath));
                configHolders.configHolders.Clear();
                if (configsPaths.Count > 0)
                {
                    foreach (string config in configsPaths)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(ConfigHolder));

                        StreamReader reader = new StreamReader(config + "/config.xml");
                        try
                        {
                            var result = (ConfigHolder)(serializer.Deserialize(reader));
                            configHolders.configHolders.Add(result);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        reader.Dispose();
                    }

                    LoadList();
                }
            }
        }

        private void LoadSettings()
        {
            if (InvokeRequired)
            {
                Invoke((Action)delegate { LoadConfigs(); });
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SettingsHolder));

                StreamReader reader = new StreamReader(settingsXMLPath);
                try
                {
                    var result = (SettingsHolder)(serializer.Deserialize(reader));
                    settingsHolder = result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                reader.Dispose();
            }
        }

        public void SaveSettings()
        {
            if (InvokeRequired)
            {
                Invoke((Action)delegate { SaveSettings(); });
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(SettingsHolder));

                StreamWriter writer = new StreamWriter(settingsXMLPath);

                serializer.Serialize(writer, settingsHolder);
                writer.Dispose();
            }
        }

        public void SetSettings()
        {
            colorBackground = ColorTranslator.FromHtml(themeHolder.backgroundHEX[settingsHolder.themeIndex]);
            colorPanel = ColorTranslator.FromHtml(themeHolder.panelHEX[settingsHolder.themeIndex]);
            colorBox = ColorTranslator.FromHtml(themeHolder.boxHEX[settingsHolder.themeIndex]);
            colorButton = ColorTranslator.FromHtml(themeHolder.buttonHEX[settingsHolder.themeIndex]);
            colorText = ColorTranslator.FromHtml(themeHolder.textHEX[settingsHolder.themeIndex]);
            colorProgressBar = ColorTranslator.FromHtml(themeHolder.progressBarBackgroundHEX[settingsHolder.themeIndex]);
            this.Location = settingsHolder.startPosition;
            SetVisualsTheme();
        }

        private void SetVisualsTheme()
        {
            this.BackColor = colorBackground;

            PanelLibrary.BackColor = colorPanel;
            PanelSelection.BackColor = colorPanel;

            FlowPanelApplications.BackColor = colorBox;
            TextBoxDescription.BackColor = colorBox;

            ButtonApplicationLaunch.BackColor = colorButton;
            ButtonCheck.BackColor = colorButton;
            ButtonUpdate.BackColor = colorButton;
            ButtonCreateApplication.BackColor = colorButton;
            ComboBoxThemes.BackColor = colorButton;
            ButtonCreateTheme.BackColor = colorButton;
            ButtonDeleteApplication.BackColor = colorButton;

            ButtonApplicationLaunch.ForeColor = colorText;
            ButtonCheck.ForeColor = colorText;
            ButtonUpdate.ForeColor = colorText;
            ButtonCreateApplication.ForeColor = colorText;
            LabelCredit.ForeColor = colorText;
            LabelVersion.ForeColor = colorText;
            LabelApplicationName.ForeColor = colorText;
            LabelApplicationLocalVersion.ForeColor = colorText;
            LabelApplicationOnlineVersion.ForeColor = colorText;
            StateLabel.ForeColor = colorText;
            ComboBoxThemes.ForeColor = colorText;
            ButtonCreateTheme.ForeColor = colorText;
            if (libraryState == LibraryState.Normal)
            {
                ButtonDeleteApplication.ForeColor = colorText;
            }

            foreach (Button button in FlowPanelApplications.Controls)
            {
                button.BackColor = colorButton;
                button.ForeColor = colorText;
            }

            DownloadProgressBar.BackColor = colorButton;
            DownloadProgressBar.ForeColor = colorProgressBar;
        }

        private void LoadThemes()
        {
            if (InvokeRequired)
            {
                Invoke((Action)delegate { LoadConfigs(); });
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ThemeHolder));

                StreamReader reader = new StreamReader(themesXMLPath);
                try
                {
                    var result = (ThemeHolder)(serializer.Deserialize(reader));
                    themeHolder = result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                reader.Dispose();

                SetThemes();
            }
        }

        private void SetThemes()
        {
            ComboBoxThemes.Items.Clear();
            foreach (string name in themeHolder.themesName)
            {
                ComboBoxThemes.Items.Add(name);
            }
            ComboBoxThemes.SelectedIndex = settingsHolder.themeIndex;
        }

        public void SaveThemes()
        {
            if (InvokeRequired)
            {
                Invoke((Action)delegate { SaveThemes(); });
            }
            else
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ThemeHolder));

                StreamWriter writer = new StreamWriter(themesXMLPath);

                serializer.Serialize(writer, themeHolder);
                writer.Dispose();
            }
        }

        private void LoadList()
        {
            FlowPanelApplications.Controls.Clear();
            for (int i = 0; i < configHolders.configHolders.Count; i++)
            {
                Button libraryBtn = new Button();
                libraryBtn.Size = new Size(100, 20);
                libraryBtn.BackColor = colorButton;
                libraryBtn.ForeColor = colorText;
                libraryBtn.FlatStyle = FlatStyle.Popup;
                libraryBtn.TextAlign = ContentAlignment.BottomCenter;
                libraryBtn.Text = Path.GetFileNameWithoutExtension(configsPaths[i]);
                libraryBtn.Click += new EventHandler(LibraryButton_Click);
                //Icon
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(16, 16);
                pictureBox.Location = new Point(2,2);
                pictureBox.Enabled = false;
                if (File.Exists(configsPaths[i] + "/icon.png"))
                {
                    pictureBox.BackgroundImage = Image.FromFile(configsPaths[i] + "/icon.png");
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                }
                libraryBtn.Controls.Add(pictureBox);
                libraryBtn.Tag = i;
                FlowPanelApplications.Controls.Add(libraryBtn);
            }
            foreach (string config in configsPaths)
            {
                if (!Directory.Exists($"{appLibraryPath}/{Path.GetFileName(config)}"))
                {
                    Directory.CreateDirectory($"{appLibraryPath}/{Path.GetFileName(config)}");
                }
            }
            appPaths.Clear();
            appPaths.AddRange(Directory.GetDirectories(appLibraryPath));
        }

        public void CreateApplication(string name, string executableName, string downloadLink, string versionLink, string description, string iconPath)
        {
            if (name != string.Empty && name != "Enter Name..." && executableName != string.Empty && executableName != "Enter Executable Name..." && downloadLink != string.Empty && downloadLink != "Enter Download Link..." && versionLink != string.Empty && versionLink != "Enter Version Link...")
            {
                Directory.CreateDirectory($"{configLibraryPath}/{name}");
                Directory.CreateDirectory($"{appLibraryPath}/{name}");


                File.WriteAllText($"{configLibraryPath}/{name}/description.txt", description);

                File.WriteAllText($"{configLibraryPath}/{name}/config.xml", $"<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<ConfigHolder xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <downloadURL>{downloadLink}</downloadURL>\r\n  <versionURL>{versionLink}</versionURL>\r\n  <executableName>{executableName}</executableName>\r\n</ConfigHolder>\r\n<!--https://www.googleapis.com/drive/v3/files/<FileID>?alt=media&#38;key=<APIKey>-->");
                if (iconPath != string.Empty)
                {
                    File.Copy(iconPath, $"{configLibraryPath}/{name}/icon.png");
                }

                File.WriteAllText($"{configLibraryPath}/{name}/localVersion.txt", "0.0.0.0");
                File.WriteAllText($"{configLibraryPath}/{name}/onlineVersion.txt", "0.0.0.0");

                addApplication.Close();

                LoadConfigs();
            }
            else
            {
                MessageBox.Show("Invalid Input!", "Error");
            }
        }

        public void CreateTheme(string name, string background, string panel, string box, string button, string text, string progressbar)
        {
            themeHolder.themesName.Add(name);
            themeHolder.backgroundHEX.Add(background);
            themeHolder.panelHEX.Add(panel);
            themeHolder.boxHEX.Add(box);
            themeHolder.buttonHEX.Add(button);
            themeHolder.textHEX.Add(text);
            themeHolder.progressBarBackgroundHEX.Add(progressbar);

            SaveThemes();
            SetThemes();

            addTheme.Close();
        }

        private void LibraryButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            Button clickedButton = (Button)sender;
            selectedIndex = int.Parse(clickedButton.Tag.ToString());
            if (libraryState == LibraryState.Normal)
            {
                if (File.Exists(configsPaths[selectedIndex] + "/icon.png"))
                {
                    PictureIcon.BackgroundImage = Image.FromFile(configsPaths[selectedIndex] + "/icon.png");
                }
                else
                {
                    //PictureIcon.Image = settingsPath + "/";
                }
                LabelApplicationName.Text = configHolders.configHolders[selectedIndex].executableName;
                LabelApplicationLocalVersion.Text = File.ReadAllText(configsPaths[selectedIndex] + "/localVersion.txt");
                LabelApplicationOnlineVersion.Text = File.ReadAllText(configsPaths[selectedIndex] + "/onlineVersion.txt");
                TextBoxDescription.Text = File.ReadAllText(configsPaths[selectedIndex] + "/description.txt");
                //Check application install
                if (Directory.GetFiles(appPaths[selectedIndex]).Length == 0)
                {
                    StateLabel.Text = "Not installed!";
                }
            }
            else if (libraryState == LibraryState.Delete)
            {
                //
                FlowPanelApplications.Controls.RemoveAt(selectedIndex);
                /*DirectoryInfo dirConfig = new DirectoryInfo(configsPaths[selectedIndex]);
                DirectoryInfo dirApplication = new DirectoryInfo(appPaths[selectedIndex]);

                dirConfig.Delete();
                dirApplication.Delete();*/
                PictureIcon.BackgroundImage = null;

                Directory.Delete(configsPaths[selectedIndex], true);
                Directory.Delete(appPaths[selectedIndex], true);

                if (selectedIndex-1 > 0)
                {
                    selectedIndex = selectedIndex - 1;
                }
                else
                {
                    selectedIndex = 0;
                }
                LoadConfigs();
            }
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            LabelApplicationOnlineVersion.Text = "0.0.0.0";
            //Delete <onlineVersion.txt>
            if (File.Exists(configsPaths[selectedIndex] + "/onlineVersion.txt"))
            {
                File.Delete(configsPaths[selectedIndex] + "/onlineVersion.txt");
            }
            //Download <onlineVersion.txt>
            httpDownloaderTXT = new HttpDownloader(configHolders.configHolders[selectedIndex].versionURL, configsPaths[selectedIndex] + "/onlineVersion.txt");
            httpDownloaderTXT.DownloadCompleted += HttpDownloaderTXTCheck_DownloadCompleted;
            httpDownloaderTXT.Start();
        }

        //Download Feedback
        private void HttpDownloaderTXTCheck_DownloadCompleted(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((Action)delegate { LabelApplicationOnlineVersion.Text = File.ReadAllText(configsPaths[selectedIndex] + "/onlineVersion.txt"); });
            }
            else
            {
                //Set Versions
                LabelApplicationOnlineVersion.Text = File.ReadAllText(configsPaths[selectedIndex] + "/onlineVersion.txt");
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (File.Exists(configsPaths[selectedIndex] + "/localVersion.txt"))
            {
                File.Delete(configsPaths[selectedIndex] + "/localVersion.txt");
            }

            httpDownloaderTXT = new HttpDownloader(configHolders.configHolders[selectedIndex].versionURL, configsPaths[selectedIndex] + "/localVersion.txt");
            httpDownloaderTXT.DownloadCompleted += HttpDownloaderTXT_DownloadCompleted;
            httpDownloaderTXT.Start();

            StateLabel.Text = "Updating...";

            if (File.Exists(appPaths[selectedIndex] + "/app.zip"))
            {
                File.Delete(appPaths[selectedIndex] + "/app.zip");
            }

            httpDownloader = new HttpDownloader(configHolders.configHolders[selectedIndex].downloadURL, appPaths[selectedIndex] + "/app.zip");
            httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
            httpDownloader.ProgressChanged += HttpDownloader_ProgressChanged;
            httpDownloader.Start();
        }
        
        //Download Feedback
        private void HttpDownloaderTXT_DownloadCompleted(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((Action)delegate { LabelApplicationLocalVersion.Text = File.ReadAllText(configsPaths[selectedIndex] + "/localVersion.txt"); });
            }
            else
            {
                LabelApplicationLocalVersion.Text = File.ReadAllText(configsPaths[selectedIndex] + "/localVersion.txt");
            }
        }
        private void HttpDownloader_ProgressChanged(object sender, AltoHttp.ProgressChangedEventArgs e)
        {
            DownloadProgressBar.Value = (int)e.Progress;
            DownloadPercentage.Text = $"{e.Progress.ToString("0.0")}%";
        }

        //Download Feedback
        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            if (sender == httpDownloaderTXT) return;
            ZipFile.ExtractToDirectory(appPaths[selectedIndex] + "/app.zip", appPaths[selectedIndex]);
            this.Invoke((MethodInvoker)delegate
            {
                StateLabel.Text = "Ready to Launch!";
            });
        }

        private void ButtonApplicationLaunch_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine($"{appPaths[selectedIndex]}/{configHolders.configHolders[selectedIndex].executableName}"));
        }

        private void ButtonCreateApplication_Click(object sender, EventArgs e)
        {
            addApplication = new AddApplication();
            addApplication.Show();
        }

        private void ButtonDeleteApplication_Click(object sender, EventArgs e)
        {
            if (libraryState == LibraryState.Normal)
            {
                libraryState = LibraryState.Delete;
                ButtonDeleteApplication.ForeColor = Color.FromArgb(255, 0, 0);
            }else if (libraryState == LibraryState.Delete)
            {
                libraryState = LibraryState.Normal;
                ButtonDeleteApplication.ForeColor = colorText;
            }

        }

        private void ComboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingsHolder.themeIndex = ComboBoxThemes.SelectedIndex;
            SetSettings();
        }

        private void ButtonCreateTheme_Click(object sender, EventArgs e)
        {
            addTheme = new AddTheme();
            addTheme.Show();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            settingsHolder.startPosition = this.Location;
            SaveSettings();
            SaveThemes();
        }
    }
}
