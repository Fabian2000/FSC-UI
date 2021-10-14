using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSC_UI
{
    public static class Cimports
    {
        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private static int WM_NCLBUTTONDOWN = 0xA1;
        private static int HT_CAPTION = 0x2;

        public static void MoveWindow(this Control ctrl)
        {
            ReleaseCapture();
            SendMessage(ctrl.FindForm().Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
