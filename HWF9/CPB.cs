using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HWF9 // Додаємо простір назв вашого проекту
{
    public static class CBP
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        public static void ChangeProgressBarColor(ProgressBar pBar, int colorCode)
        {
            SendMessage(pBar.Handle, 0x410, colorCode, 0);
        }
    }
}
