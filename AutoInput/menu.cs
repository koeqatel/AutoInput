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
using SnSConfig;

namespace AutoInput
{
    public partial class menu : Form
    {
        public static bool stayInFront;
        public static bool spamRandom;
        public static string hotkeyModifier;
        public static string hotkeyKey;


        public menu()
        {
            if (!File.Exists("SnSConfig.dll"))
                MessageBox.Show("Error: Missing SnSConfig.dll\n\nTo get this, you have to draw a pentagram, on the night of a full moon...\nSlaughter a red catterpillar in the middle...\nThen a demon will come out and give you the file.\nOn a usb...\nThey're demons, not savages...\n\nYet never forget...\nMagic always comes with a price.\n\nOr you could contact the person that gave you the program...\n\nSpeak to you soon, Sander.\n\nBtw, I'm not responsible for any dead catterpillars or if it didn't work out.");

            InitializeComponent();

            readConfig();        

            if (stayInFront)
                TopMost = true;

        }

        private void typeButton_Click(object sender, EventArgs e)
        {
            //Open type menu.
            typePanel typeMenu = new typePanel();
            typeMenu.ShowDialog();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            //Open click menu.
            clickPanel clickMenu = new clickPanel();
            clickMenu.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            readConfig();

            //Open settings menu.
            settingsPanel settingsMenu = new settingsPanel();
            settingsMenu.ShowDialog();
        }        

        public void menu_Enter(object sender, EventArgs e)
        {
            readConfig();
        }

        public void readConfig()
        {
            if (config.fileEmpty())
            {
                Dictionary<string, string> configLine = new Dictionary<string, string>();

                configLine.Add("stayInFront", "False");
                configLine.Add("spamRandom", "True");
                configLine.Add("hotkeyModifier", "Shift");
                configLine.Add("hotkeyKey", "Z");

                config.setDefaultConfig(configLine);
            }

            stayInFront = Convert.ToBoolean(config.getConfigItem("stayInFront"));
            //settingsPanel.stayInFront = stayInFront;

            spamRandom = Convert.ToBoolean(config.getConfigItem("spamRandom"));
            //settingsPanel.spamRandom = spamRandom;

            hotkeyModifier = config.getConfigItem("hotkeyModifier").ToString();
            //settingsPanel.hotkeyModifier = hotkeyModifier;

            hotkeyKey = config.getConfigItem("hotkeyKey").ToString();
            //settingsPanel.hotkeyKey = hotkeyKey;
        }
    }
}
