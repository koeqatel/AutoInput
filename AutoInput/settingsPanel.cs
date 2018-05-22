using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnSConfig;

namespace AutoInput
{
    public partial class settingsPanel : Form
    {
        public settingsPanel()
        {
            InitializeComponent();

            if (menu.stayInFront)
                TopMost = true;

            if (menu.stayInFront)
                stayInFrontCheck.Checked = true;
            else
                stayInFrontCheck.Checked = false;

            if (menu.spamRandom)
                spamRandomCheck.Checked = true;
            else
                spamRandomCheck.Checked = false;

            hotkeyTextBox.Text = menu.hotkeyModifier + " + " + menu.hotkeyKey;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string[] parts = hotkeyTextBox.Text.Replace(" ", "").Split('+');

            string hotkeyMod = parts[0];
            string hotkeyKey = parts[1];
            menu.stayInFront = stayInFrontCheck.Checked;
            menu.spamRandom = spamRandomCheck.Checked;
            
            config.updateConfig("stayInFront", stayInFrontCheck.Checked.ToString());
            config.updateConfig("hotkeyModifier", hotkeyMod);
            config.updateConfig("hotkeyKey", hotkeyKey);
            config.updateConfig("spamRandom", spamRandomCheck.Checked.ToString());

            menu mnu = new menu();
            mnu.readConfig();

            this.Close();
        }

        private void hotkeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string modifier = e.Modifiers.ToString();
            string key = e.KeyCode.ToString();

            if (modifier == key.Replace("Key", ""))
                hotkeyTextBox.Text = modifier;
            else
                hotkeyTextBox.Text = modifier + " + " + key;
        }
    }
}
