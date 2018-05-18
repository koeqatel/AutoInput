using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInput
{
    public partial class menu : Form
    {
        public static bool stayInFront;
        public static string hotkeyModifier;
        public static string hotkeyKey;


        public menu()
        {
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
            SnSConfig sConfig = new SnSConfig();

            if (sConfig.fileEmpty())
            {
                Dictionary<string, string> configLine = new Dictionary<string, string>();

                configLine.Add("stayInFront", "False");
                configLine.Add("hotkeyModifier", "Shift");
                configLine.Add("hotkeyKey", "Z");

                sConfig.setDefaultConfig(configLine);
            }


            stayInFront = Convert.ToBoolean(sConfig.getConfigItem("stayInFront"));
            settingsPanel.stayInFront = stayInFront;

            hotkeyModifier = sConfig.getConfigItem("hotkeyModifier").ToString();
            settingsPanel.hotkeyModifier = hotkeyModifier;

            hotkeyKey = sConfig.getConfigItem("hotkeyKey").ToString();
            settingsPanel.hotkeyKey = hotkeyKey;
        }
    }
}
