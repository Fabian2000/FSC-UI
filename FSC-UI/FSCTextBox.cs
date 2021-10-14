using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSC_UI;

namespace FSC_UI.Controls
{
    public partial class FSCTextBox : TextBox
    {
        public FSCTextBox()
        {
            InitializeComponent();

            this.BorderStyle = BorderStyle.None;
            this.Padding = new Padding(5);
            this.BackColor = Color.WhiteSmoke;

            this.TextChanged += OnTextChanged;
            this.ForeColorChanged += OnForeColorChanged;
        }

        private Color backupColor;
        private string regexPattern = "";

        /// <summary>
        /// Regex validation of the given Regex Pattern
        /// </summary>
        public bool IsMatch
        {
            get
            {
                return Regex.IsMatch(this.Text, RegexPattern);
            }
        }

        [Category("FSC Settings")]
        public string RegexPattern 
        { 
            get 
            {
                return regexPattern;
            } set 
            {
                regexPattern = value;
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if ((sender as FSCTextBox).ForeColor != Color.Red)
            {
                backupColor = (sender as FSCTextBox).ForeColor;
            }

            if (!Regex.IsMatch((sender as FSCTextBox).Text, RegexPattern))
            {
                (sender as FSCTextBox).ForeColor = Color.Red;
            }
            else
            {
                (sender as FSCTextBox).ForeColor = backupColor;
            }
        }

        private void OnForeColorChanged(object sender, EventArgs e)
        {
            if ((sender as FSCTextBox).ForeColor != Color.Red)
            {
                backupColor = (sender as FSCTextBox).ForeColor;
            }
        }
    }
}
