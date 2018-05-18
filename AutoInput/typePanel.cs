using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInput
{
    public partial class typePanel : Form
    {        
        List<string> textBoxTexts = new List<string>();
        List<long> ms = new List<long>();

        int Boxes = 10;

        #region Hotkey stuff
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }
        #endregion

        public typePanel()
        {
            InitializeComponent();

            if (menu.stayInFront)
                TopMost = true;

            hotkeyLabel.Text = "press " + menu.hotkeyModifier + " + " + menu.hotkeyKey + " to start typing";

            Keys hotkeyKey;
            Enum.TryParse(menu.hotkeyKey, out hotkeyKey);

            KeyModifier hotkeyModifier;
            Enum.TryParse(menu.hotkeyModifier, out hotkeyModifier);

            RegisterHotKey(this.Handle, 0, (int)hotkeyModifier, hotkeyKey.GetHashCode());       // Register global hotkey. 
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

                //Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // Returns the key of the hotkey that was pressed.
                //KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // Returns the modifier of the hotkey that was pressed.
                //int id = m.WParam.ToInt32();                                        // Returns the id of the hotkey that was pressed.

                textBoxTexts.Clear();
                textBoxTexts.Add(richTextBox1.Text);
                textBoxTexts.Add(richTextBox2.Text);
                textBoxTexts.Add(richTextBox3.Text);
                textBoxTexts.Add(richTextBox4.Text);
                textBoxTexts.Add(richTextBox5.Text);
                textBoxTexts.Add(richTextBox6.Text);
                textBoxTexts.Add(richTextBox7.Text);
                textBoxTexts.Add(richTextBox8.Text);
                textBoxTexts.Add(richTextBox9.Text);
                textBoxTexts.Add(richTextBox10.Text);

                if (TypeTimer.Enabled)
                {
                    TypeTimer.Stop();
                }
                else if (TypeTimer.Enabled == false)
                {
                    TypeTimer.Start();
                }
            }
        }

        private void TypeTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i = rnd.Next(0, Boxes);

            if (textBoxTexts[i] != "")
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();

                //TODO: Add end with and start with functionality.
                SendKeys.Send(textBoxTexts[i]);
                SendKeys.Send("{enter}");

                watch.Stop();
                ms.Add(watch.ElapsedMilliseconds);

                int ii = 0;
                int tot = 0;
                foreach (int num in ms)
                {
                    ii++;
                    tot = tot + num;
                }

                Delaybel.Text = "Delay: " + tot / ii + " (average)";
            }
        }

        private void delayNum_ValueChanged(object sender, EventArgs e)
        {
            TypeTimer.Interval = int.Parse(delayNum.Value.ToString());
        }

        private void TextBox_Gotfocus(object sender, EventArgs e)
        {
            TypeTimer.Stop();
        }

        private void All_TextChanged(object sender, EventArgs e)
        {
            TypeTimer.Stop();
        }

        private void typeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TypeTimer.Enabled)
                TypeTimer.Enabled = false;
        }

        private void typeForm_Load(object sender, EventArgs e)
        {
            if (TypeTimer.Enabled)
                TypeTimer.Enabled = false;
        }

        private void specialCharsButton_MouseEnter(object sender, EventArgs e)
        {
            helpText.Visible = true;
            help2Text.Visible = true;
            helpTextBackground.Visible = true;
        }

        private void specialCharsButton_MouseLeave(object sender, EventArgs e)
        {
            helpText.Visible = false;
            help2Text.Visible = false;
            helpTextBackground.Visible = false;
        }
    }
}
