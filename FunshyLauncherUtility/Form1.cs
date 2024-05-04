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
using System.Xml.Serialization;

namespace FunshyLauncherUtility
{
    public partial class MainWindow : Form
    {
        ConfigHolders configHolders = new ConfigHolders();
        AddApplication addApplication;

        private string dataPath;
        
        private string settingsPath;
        private string configLibraryPath;
        private string appLibraryPath;

        private List<string> configsPaths = new List<string>();
        private List<string> appPaths = new List<string>();

        private int selectedIndex;

        HttpDownloader httpDownloader;
        HttpDownloader httpDownloaderTXT;


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
        }

        private void SetPaths()
        {
            dataPath = Application.StartupPath + "/data";
            settingsPath = dataPath + "/settigns";
            configLibraryPath = dataPath + "/configLibrary";
            appLibraryPath = dataPath + "/appLibrary";
        }

        private void StructureCheck()
        {
            if (!Directory.Exists(dataPath)) //data Directory
            {
                Directory.CreateDirectory(dataPath);
            }

            if (!Directory.Exists(settingsPath)) //settings Directory
            {
                Directory.CreateDirectory(settingsPath);
            }

            if (!Directory.Exists(configLibraryPath)) //configLibrary Directory
            {
                Directory.CreateDirectory(configLibraryPath);
            }

            if (!Directory.Exists(appLibraryPath)) //appLibrary Directory
            {
                Directory.CreateDirectory(appLibraryPath);
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

        private void LoadList()
        {
            FlowPanelApplications.Controls.Clear();
            for (int i = 0; i < configHolders.configHolders.Count; i++)
            {
                Button libraryBtn = new Button();
                libraryBtn.Size = new Size(100, 20);
                libraryBtn.BackColor = Color.FromArgb(25, 25, 25);
                libraryBtn.ForeColor = Color.FromArgb(100, 100, 100);
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
                Label label = new Label();
                label.Name = "index";
                label.Enabled = false;
                label.Visible = false;
                label.Text = i.ToString();
                libraryBtn.Controls.Add(label);
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
            Directory.CreateDirectory($"{configLibraryPath}/{name}");
            Directory.CreateDirectory($"{appLibraryPath}/{name}");


            File.WriteAllText($"{configLibraryPath}/{name}/description.txt", description);

            File.WriteAllText($"{configLibraryPath}/{name}/config.xml", $"<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<ConfigHolder xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <downloadURL>{downloadLink}</downloadURL>\r\n  <versionURL>{versionLink}</versionURL>\r\n  <executableName>{executableName}</executableName>\r\n</ConfigHolder>\r\n<!--https://www.googleapis.com/drive/v3/files/<FileID>?alt=media&#38;key=<APIKey>-->");
            File.Copy(iconPath, $"{configLibraryPath}/{name}/icon.png");

            File.WriteAllText($"{configLibraryPath}/{name}/localVersion.txt", "0.0.0.0");
            File.WriteAllText($"{configLibraryPath}/{name}/onlineVersion.txt", "0.0.0.0");

            addApplication.Close();

            LoadConfigs();
        }

        private void LibraryButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
            Button clickedButton = (Button)sender;
            Control[] label = clickedButton.Controls.Find("index", true);
            selectedIndex = int.Parse(label[0].Text);
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
            httpDownloaderTXT.Start();

            System.Threading.Thread.Sleep(3000);
            //Set Versions
            LabelApplicationOnlineVersion.Text = File.ReadAllText(configsPaths[selectedIndex] + "/onlineVersion.txt");
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
    }
}
