using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FSC_UI;
using FSC_UI.Controls;

namespace FSC_UI
{
    public partial class FSCMessageBox : FSC
    {
        private FSCMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            this.Text = caption;
            InfoTB.Visible = false;
            InfoTB.Text = text;

            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1:
                    Option1.Focus();
                break;
                case MessageBoxDefaultButton.Button2:
                    Option2.Focus();
                break;
                case MessageBoxDefaultButton.Button3:
                    Option3.Focus();
                break;
            }

            if (buttons == MessageBoxButtons.AbortRetryIgnore)
            {
                Option3.Text = "Abort";
                Option2.Text = "Retry";
                Option1.Text = "Ignore";
            }
            else if (buttons == MessageBoxButtons.OK)
            {
                Option3.Visible = false;
                Option2.Visible = false;
                Option1.Text = "OK";
            }
            else if (buttons == MessageBoxButtons.OKCancel)
            {
                Option3.Visible = false;
                Option2.Text = "OK";
                Option1.Text = "Cancel";
            }
            else if (buttons == MessageBoxButtons.RetryCancel)
            {
                Option3.Visible = false;
                Option2.Text = "Retry";
                Option1.Text = "Cancel";
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                Option3.Visible = false;
                Option2.Text = "Yes";
                Option1.Text = "No";
            }
            else if (buttons == MessageBoxButtons.YesNoCancel)
            {
                Option3.Text = "Yes";
                Option2.Text = "No";
                Option1.Text = "Cancel";
            }
        }

        private void FSCMessageBox_Shown(object sender, EventArgs e)
        {
            InfoTB.BackColor = ThemeLoader.CurrentTheme.Window_BackColor;
            InfoTB.ForeColor = ThemeLoader.CurrentTheme.Window_ForeColor;
            InfoTB.Visible = true;
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Abort")
            {
                Action = DialogResult.Abort;
            }
            else if ((sender as Button).Text == "Retry")
            {
                Action = DialogResult.Retry;
            }
            else if ((sender as Button).Text == "Ignore")
            {
                Action = DialogResult.Ignore;
            }
            else if ((sender as Button).Text == "OK")
            {
                Action = DialogResult.OK;
            }
            else if ((sender as Button).Text == "Cancel")
            {
                Action = DialogResult.Cancel;
            }
            else if ((sender as Button).Text == "Yes")
            {
                Action = DialogResult.Yes;
            }
            else if ((sender as Button).Text == "No")
            {
                Action = DialogResult.No;
            }

            Close();
        }

        private DialogResult Action = DialogResult.OK;

        private void InfoTB_MouseDown(object sender, MouseEventArgs e)
        {
            Disable.Focus();
        }

        public static DialogResult Show(string text)
        {
            return Show(text, "", MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult Show(string text, string caption)
        {
            return Show(text, caption, MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return Show(text, caption, buttons, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            using (FSCMessageBox msgBox = new FSCMessageBox(text, caption, buttons, defaultButton))
            {
                msgBox.LoadTheme(ThemeLoader.CurrentTheme);
                msgBox.TopMostBTNVisible = false;
                msgBox.ShowDialog();

                return msgBox.Action;
            }
        }
    }
}
