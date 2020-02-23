using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using PeanutButter.INIFile;
using PeanutButter.Utils;

namespace IniExample
{
    public partial class MainForm : Form
    {
        private IINIFile _loadedConfig;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadConfig1Button_Click(object sender, EventArgs e)
        {
            LoadConfig("config1.ini");
        }

        private void LoadConfig2Button_Click(object sender, EventArgs e)
        {
            LoadConfig("config2.ini");
        }


        private void LoadConfig(string name)
        {
            // config files will live in the user profile folder (eg C:\users\myprofile)
            var fullPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                name);
            // if the file exists, it will be loaded; if not, then the INIFile instance
            //    will still know that when it's time to save, it should save back to that file
            _loadedConfig = new INIFile(fullPath);
            // load up the label, if we can
            ColorDisplay.Text = _loadedConfig.HasSetting("colors", "FavoriteColor")
                ? _loadedConfig["colors"]["FavoriteColor"]
                : "(no favorite color chosen yet for #1)";
            ColorDisplay.ForeColor = TryDetermineColorFor(ColorDisplay.Text);
            // reset the selected color in the drop-down
            ColorList.SelectedIndex = -1;
            // signal to the user that a color may be selected by enabling the controls
            ColorList.Enabled = true;
            ChangeLabel.Enabled = true;
        }

        private Color TryDetermineColorFor(string colorDisplayText)
        {
            foreach (var item in ColorList.Items)
            {
                if (item is ColorInfo colorInfo &&
                    colorInfo.Name.Equals(colorDisplayText, StringComparison.OrdinalIgnoreCase))
                {
                    return colorInfo.Color;
                }
            }

            // default to the regular color for window text, whatever that is, on the current system
            return SystemColors.WindowText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorDisplay.Text = "Please open a configuration file";
            PopulateColors();
            ChangeLabel.Enabled = false;
            ColorList.Enabled = false;
            SaveCurrentConfigButton.Enabled = false;
        }

        private void SaveCurrentConfigButton_Click(object sender, EventArgs e)
        {
            if (_loadedConfig is null)
            {
                MessageBox.Show("Please load a config file first!");
                return;
            }

            if (!(ColorList.SelectedItem is ColorInfo selected))
            {
                MessageBox.Show("Please select a color first");
                return;
            }

            _loadedConfig["colors"]["FavoriteColor"] = selected.Name;
            // will write out the file to the same filename as where it was loaded from
            _loadedConfig.Persist();
            
            MessageBox.Show("Please re-load configuration to see changes above");
        }

        private void PopulateColors()
        {
            // load up all known colors into the drop-down list
            var allColors = typeof(Color)
                .GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Where(pi => pi.PropertyType == typeof(Color))
                .Select(pi => (Color) pi.GetValue(null))
                .Select(c => new ColorInfo(c.Name, c))
                .OrderBy(c => c.Name)
                .ToArray();
            ColorList.Items.Clear();
            allColors.ForEach(c => ColorList.Items.Add(c));
        }

        private void ColorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCurrentConfigButton.Enabled = true;
        }
    }
}