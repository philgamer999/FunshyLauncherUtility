using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunshyLauncherUtility
{
    public class ConfigHolders
    {
        public List<ConfigHolder> configHolders = new List<ConfigHolder>();
    }

    public class ConfigHolder
    {
        public string downloadURL { get; set; }
        public string versionURL { get; set; }
        public string executableName { get; set; }
    }

    public class SettingsHolder
    {
        public int themeIndex { get; set; }
        public bool versionHistoryEnabled { get; set; }
        public Point startPosition { get; set;}
        public bool pinOnStartEnabled { get; set; }
    }

    public class ThemeHolder
    {
        public List<string> themesName = new List<string>();
        public List<string> backgroundHEX = new List<string>();
        public List<string> panelHEX = new List<string>();
        public List<string> boxHEX = new List<string>();
        public List<string> buttonHEX = new List<string>();
        public List<string> textHEX = new List<string>();
        public List<string> progressBarBackgroundHEX = new List<string>();
        //public List<Color> progressBarHighlightHEX = new List<Color>();
    }
}
