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
    public partial class settingsPanel : Form
    {
        public static bool stayInFront;
        public static string hotkeyModifier;
        public static string hotkeyKey;

        public settingsPanel()
        {
            InitializeComponent();

            if (stayInFront)
                TopMost = true;

            if (stayInFront)
                stayInFrontCheck.Checked = true;
            else
                stayInFrontCheck.Checked = false;

            hotkeyTextBox.Text = hotkeyModifier + " + " + hotkeyKey;

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

            SnSConfig sConfig = new SnSConfig();
            sConfig.updateConfig("stayInFront", stayInFrontCheck.Checked.ToString());
            sConfig.updateConfig("hotkeyModifier", hotkeyMod);
            sConfig.updateConfig("hotkeyKey", hotkeyKey);

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

        private void settingsPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
