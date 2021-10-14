using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FSC_UI;
using FSC_UI.Controls;

namespace FSC_UI
{
    public class ThemeBuilder
    {
        /// <summary>
        /// Background color for the Window
        /// </summary>
        public Color Window_BackColor { get; set; }
        /// <summary>
        /// Foreground color for the Window
        /// </summary>
        public Color Window_ForeColor { get; set; }

        /// <summary>
        /// Background color for all not matching elements (for example Panel or FSCPanel)
        /// </summary>
        public Color AreaElement_BackColor { get; set; }
        /// <summary>
        /// Foreground color for all not matching elements (for example Panel or FSCPanel)
        /// </summary>
        public Color AreaElement_ForeColor { get; set; }

        /// <summary>
        /// Background color for clickable controls (Button or FSCButton)
        /// </summary>
        public Color ClickItem_BackColor { get; set; }
        /// <summary>
        /// Background mouse over color for clickable controls (Button or FSCButton)
        /// </summary>
        public Color ClickItem_HoverColor { get; set; }
        /// <summary>
        /// Background mouse down color for clickable controls (Button or FSCButton)
        /// </summary>
        public Color ClickItem_ActiveColor { get; set; }
        /// <summary>
        /// Foreground color for clickable controls (Button or FSCButton)
        /// </summary>
        public Color ClickItem_ForeColor { get; set; }

        /// <summary>
        /// Background color for the FSCToggle control body
        /// </summary>
        public Color ToggleBackground_BackColor { get; set; }
        /// <summary>
        /// Background color for the FSCToggle control toggle
        /// </summary>
        public Color Toggle_BackColor { get; set; }
        /// <summary>
        /// Background hover color for the FSCToggle control toggle
        /// </summary>
        public Color Toggle_HoverColor { get; set; }

        /// <summary>
        /// Background color for textbox controls (TextBox or RichTextBox)
        /// </summary>
        public Color TextBox_BackColor { get; set; }
        /// <summary>
        /// Foreground color for textbox controls (TextBox or RichTextBox)
        /// </summary>
        public Color TextBox_ForeColor { get; set; }

        /// <summary>
        /// Foreground color for all labels
        /// </summary>
        public Color TextElement_ForeColor { get; set; }
    }

    public static class ThemeLoader
    {
        private static ThemeBuilder currentTheme = LoadDefaultLightTheme();
        public static ThemeBuilder CurrentTheme 
        {
            get
            {
                return currentTheme;
            }
        }

        public static void LoadTheme(this Form fsc_form, ThemeBuilder theme)
        {
            currentTheme = theme;

            fsc_form.BackColor = theme.Window_BackColor;
            fsc_form.ForeColor = theme.Window_ForeColor;

            foreach (Control ctrl in fsc_form.Controls)
            {
                ctrl.SetTheme(theme);
                ctrl.LoadTheme(theme);
            }
        }

        private static void LoadTheme(this Control control, ThemeBuilder theme)
        {
            foreach (Control ctrl in control.Controls)
            {
                ctrl.SetTheme(theme);
                ctrl.LoadTheme(theme);
            }
        }

        private static void SetTheme(this Control control, ThemeBuilder theme)
        {
            if (control is FSCToggle)
            {
                (control as FSCToggle).BackColor = (control as FSCToggle).Parent.BackColor;
                (control as FSCToggle).Background = theme.ToggleBackground_BackColor;
                (control as FSCToggle).Toggle = theme.Toggle_BackColor;
                (control as FSCToggle).ToggleHover = theme.Toggle_HoverColor;
            }
            else if (control is TextBox || control is RichTextBox || control is FSCTextBox)
            {
                control.BackColor = theme.TextBox_BackColor;
                control.ForeColor = theme.TextBox_ForeColor;
            }
            else if (control is Label || control is LinkLabel)
            {
                 control.BackColor = control.Parent.BackColor;
                 control.ForeColor = theme.TextElement_ForeColor;
            }
            else if (control is Button || control is FSCButton)
            {
                 control.BackColor = theme.ClickItem_BackColor;
                 control.ForeColor = theme.ClickItem_ForeColor;
                 (control as Button).FlatAppearance.MouseDownBackColor = theme.ClickItem_ActiveColor;
                 (control as Button).FlatAppearance.MouseOverBackColor = theme.ClickItem_HoverColor;
            }
            else
            {
                control.BackColor = theme.AreaElement_BackColor;
                control.ForeColor = theme.AreaElement_ForeColor;
            }
        }

        public static ThemeBuilder LoadDefaultLightTheme()
        {
            ThemeBuilder theme = new ThemeBuilder();

            theme.Window_BackColor = Color.White;
            theme.Window_ForeColor = Color.Black;

            theme.AreaElement_BackColor = Color.White;
            theme.AreaElement_ForeColor = Color.Black;

            theme.ClickItem_BackColor = Color.WhiteSmoke;
            theme.ClickItem_HoverColor = Color.Gainsboro;
            theme.ClickItem_ActiveColor = Color.FromArgb(255, 224, 224, 224);
            theme.ClickItem_ForeColor = Color.Black;

            theme.ToggleBackground_BackColor = Color.WhiteSmoke;
            theme.Toggle_BackColor = Color.Gainsboro;
            theme.Toggle_HoverColor = Color.Silver;

            theme.TextBox_BackColor = Color.WhiteSmoke;
            theme.TextBox_ForeColor = Color.Black;

            theme.TextElement_ForeColor = Color.Black;

            return theme;
        }

        public static ThemeBuilder LoadDefaultDarkTheme()
        {
            ThemeBuilder theme = new ThemeBuilder();

            theme.Window_BackColor = Color.FromArgb(255, 30, 30, 30);
            theme.Window_ForeColor = Color.White;

            theme.AreaElement_BackColor = Color.FromArgb(255, 30, 30, 30);
            theme.AreaElement_ForeColor = Color.White;

            theme.ClickItem_BackColor = Color.FromArgb(255, 40, 40, 40);
            theme.ClickItem_HoverColor = Color.FromArgb(255, 50, 50, 50);
            theme.ClickItem_ActiveColor = Color.FromArgb(255, 54, 54, 54);
            theme.ClickItem_ForeColor = Color.White;

            theme.ToggleBackground_BackColor = Color.FromArgb(255, 50, 50, 50);
            theme.Toggle_BackColor = Color.FromArgb(255, 40, 40, 40);
            theme.Toggle_HoverColor = Color.FromArgb(255, 45, 45, 45);

            theme.TextBox_BackColor = Color.FromArgb(255, 40, 40, 40);
            theme.TextBox_ForeColor = Color.White;

            theme.TextElement_ForeColor = Color.White;

            return theme;
        }

        private static byte[] GetARGBString(Color color)
        {
            byte[] ret = { 
                Convert.ToByte(color.A), 
                Convert.ToByte(' '), 
                Convert.ToByte(color.R),
                Convert.ToByte(' '),
                Convert.ToByte(color.G),
                Convert.ToByte(' '),
                Convert.ToByte(color.B),
                Convert.ToByte(' ')
            };

            return ret;
        }

        private static Color GetColorFromARGBString(string color)
        {
            return  Color.FromArgb
                    (
                        Convert.ToInt32
                        (
                            color.Split(';')[0]
                        ),
                        Convert.ToInt32
                        (
                            color.Split(';')[1]
                        ),
                        Convert.ToInt32
                        (
                            color.Split(';')[2]
                        ),
                        Convert.ToInt32
                        (
                            color.Split(';')[3]
                        )
                    );
        }

        private static void AppendArrayToList(ref List<byte> list, byte[] array)
        {
            foreach (byte b in array)
            {
                list.Add(b);
            }
        }

        public static void Save(string filename, ThemeBuilder theme)
        {
            List<byte> bytes = new List<byte>();

            AppendArrayToList(ref bytes, GetARGBString(theme.Window_BackColor));
            AppendArrayToList(ref bytes, GetARGBString(theme.Window_ForeColor));
            
            AppendArrayToList(ref bytes, GetARGBString(theme.AreaElement_BackColor));
            AppendArrayToList(ref bytes, GetARGBString(theme.AreaElement_ForeColor));
            
            AppendArrayToList(ref bytes, GetARGBString(theme.ClickItem_BackColor));
            AppendArrayToList(ref bytes, GetARGBString(theme.ClickItem_HoverColor));
            AppendArrayToList(ref bytes, GetARGBString(theme.ClickItem_ActiveColor));
            AppendArrayToList(ref bytes, GetARGBString(theme.ClickItem_ForeColor));
            
            AppendArrayToList(ref bytes, GetARGBString(theme.ToggleBackground_BackColor));
            AppendArrayToList(ref bytes, GetARGBString(theme.Toggle_BackColor));
            AppendArrayToList(ref bytes, GetARGBString(theme.Toggle_HoverColor));
            
            AppendArrayToList(ref bytes, GetARGBString(theme.TextBox_BackColor));
            AppendArrayToList(ref bytes, GetARGBString(theme.TextBox_ForeColor));

            AppendArrayToList(ref bytes, GetARGBString(theme.TextElement_ForeColor));

            File.WriteAllBytes(filename, bytes.ToArray());
        }

        public static ThemeBuilder Read(string filename)
        {
            byte[] bytes = File.ReadAllBytes(filename);
            StringBuilder sb = new StringBuilder();
            int count = 0;

            foreach (byte b in bytes)
            {
                if (b == Convert.ToByte(' '))
                {                    
                    if (sb.ToString().Split('\n')[count].Split(';').Length == 4)
                    {
                        sb.AppendLine("");
                        count++;
                    }
                    else
                    {
                        sb.Append(";");
                    }

                    continue;
                }

                sb.Append(Convert.ToInt32(b).ToString());
            }

            ThemeBuilder theme = new ThemeBuilder();

            theme.Window_BackColor = GetColorFromARGBString(sb.ToString().Split('\n')[0]);
            theme.Window_ForeColor = GetColorFromARGBString(sb.ToString().Split('\n')[1]);

            theme.AreaElement_BackColor = GetColorFromARGBString(sb.ToString().Split('\n')[2]);
            theme.AreaElement_ForeColor = GetColorFromARGBString(sb.ToString().Split('\n')[3]);

            theme.ClickItem_BackColor = GetColorFromARGBString(sb.ToString().Split('\n')[4]);
            theme.ClickItem_HoverColor = GetColorFromARGBString(sb.ToString().Split('\n')[5]);
            theme.ClickItem_ActiveColor = GetColorFromARGBString(sb.ToString().Split('\n')[6]);
            theme.ClickItem_ForeColor = GetColorFromARGBString(sb.ToString().Split('\n')[7]);

            theme.ToggleBackground_BackColor = GetColorFromARGBString(sb.ToString().Split('\n')[8]);
            theme.Toggle_BackColor = GetColorFromARGBString(sb.ToString().Split('\n')[9]);
            theme.Toggle_HoverColor = GetColorFromARGBString(sb.ToString().Split('\n')[10]);

            theme.TextBox_BackColor = GetColorFromARGBString(sb.ToString().Split('\n')[11]);
            theme.TextBox_ForeColor = GetColorFromARGBString(sb.ToString().Split('\n')[12]);

            theme.TextElement_ForeColor = GetColorFromARGBString(sb.ToString().Split('\n')[13]);

            return theme;
        }
    }
}
