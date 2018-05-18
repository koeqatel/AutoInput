using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInput
{
    public partial class clickPanel : Form
    {
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

        #region Mouse stuff
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        #endregion

        public clickPanel()
        {
            InitializeComponent();

            if (menu.stayInFront)
                TopMost = true;

            hotkeyLabel.Text = "press " + menu.hotkeyModifier + " + " + menu.hotkeyKey + " to start clicking";

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

                //Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                //KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                //int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.


                if (ClickTimer.Enabled)
                    ClickTimer.Stop();
                else
                    ClickTimer.Start();
            }
        }

        private void delayNum_ValueChanged(object sender, EventArgs e)
        {
            ClickTimer.Interval = int.Parse(delayNum.Value.ToString());
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;

            if (LeftClick.Checked)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                //Call the imported function with the cursor's current position
            }
            else if (RightClick.Checked)
            {
                mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
                //Call the imported function with the cursor's current position
            }
            else
            {
                ClickTimer.Stop();
            }
        }

        private void LeftClick_Click(object sender, EventArgs e)
        {
            if (LeftClick.Checked)
                RightClick.Checked = false;
            else
                RightClick.Checked = true;
        }

        private void RightClick_Click(object sender, EventArgs e)
        {
            if (LeftClick.Checked)
                LeftClick.Checked = false;
            else
                LeftClick.Checked = true;
        }

        private void ClickMenu_Load(object sender, EventArgs e)
        {
            if (ClickTimer.Enabled)
                ClickTimer.Enabled = false;
        }
    }
}
