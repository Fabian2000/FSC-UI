
namespace FSC_UI
{
    partial class FSCMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoTB = new FSC_UI.Controls.FSCTextBox();
            this.Disable = new FSC_UI.Controls.FSCButton();
            this.Option1 = new FSC_UI.Controls.FSCButton();
            this.Option2 = new FSC_UI.Controls.FSCButton();
            this.Option3 = new FSC_UI.Controls.FSCButton();
            this.SuspendLayout();
            // 
            // InfoTB
            // 
            this.InfoTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InfoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoTB.Location = new System.Drawing.Point(12, 48);
            this.InfoTB.Multiline = true;
            this.InfoTB.Name = "InfoTB";
            this.InfoTB.ReadOnly = true;
            this.InfoTB.ShortcutsEnabled = false;
            this.InfoTB.Size = new System.Drawing.Size(502, 134);
            this.InfoTB.TabIndex = 1;
            this.InfoTB.TabStop = false;
            this.InfoTB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InfoTB_MouseDown);
            // 
            // Disable
            // 
            this.Disable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Disable.FlatAppearance.BorderSize = 0;
            this.Disable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disable.Location = new System.Drawing.Point(-96, 173);
            this.Disable.Name = "Disable";
            this.Disable.RadiusBottomLeft = 7;
            this.Disable.RadiusBottomRight = 7;
            this.Disable.RadiusTopLeft = 7;
            this.Disable.RadiusTopRight = 7;
            this.Disable.Size = new System.Drawing.Size(61, 23);
            this.Disable.TabIndex = 2;
            this.Disable.UseVisualStyleBackColor = false;
            // 
            // Option1
            // 
            this.Option1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Option1.FlatAppearance.BorderSize = 0;
            this.Option1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option1.Location = new System.Drawing.Point(390, 188);
            this.Option1.Name = "Option1";
            this.Option1.RadiusBottomLeft = 7;
            this.Option1.RadiusBottomRight = 7;
            this.Option1.RadiusTopLeft = 7;
            this.Option1.RadiusTopRight = 7;
            this.Option1.Size = new System.Drawing.Size(124, 31);
            this.Option1.TabIndex = 3;
            this.Option1.Text = "Option";
            this.Option1.UseVisualStyleBackColor = false;
            this.Option1.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // Option2
            // 
            this.Option2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Option2.FlatAppearance.BorderSize = 0;
            this.Option2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option2.Location = new System.Drawing.Point(260, 188);
            this.Option2.Name = "Option2";
            this.Option2.RadiusBottomLeft = 7;
            this.Option2.RadiusBottomRight = 7;
            this.Option2.RadiusTopLeft = 7;
            this.Option2.RadiusTopRight = 7;
            this.Option2.Size = new System.Drawing.Size(124, 31);
            this.Option2.TabIndex = 4;
            this.Option2.Text = "Option";
            this.Option2.UseVisualStyleBackColor = false;
            this.Option2.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // Option3
            // 
            this.Option3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Option3.FlatAppearance.BorderSize = 0;
            this.Option3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option3.Location = new System.Drawing.Point(130, 188);
            this.Option3.Name = "Option3";
            this.Option3.RadiusBottomLeft = 7;
            this.Option3.RadiusBottomRight = 7;
            this.Option3.RadiusTopLeft = 7;
            this.Option3.RadiusTopRight = 7;
            this.Option3.Size = new System.Drawing.Size(124, 31);
            this.Option3.TabIndex = 5;
            this.Option3.Text = "Option";
            this.Option3.UseVisualStyleBackColor = false;
            this.Option3.Click += new System.EventHandler(this.ButtonAction_Click);
            // 
            // FSCMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 231);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.Disable);
            this.Controls.Add(this.InfoTB);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(526, 231);
            this.Name = "FSCMessageBox";
            this.ShowInTaskbar = false;
            this.Text = "MessageBox";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FSCMessageBox_Shown);
            this.Controls.SetChildIndex(this.InfoTB, 0);
            this.Controls.SetChildIndex(this.Disable, 0);
            this.Controls.SetChildIndex(this.Option1, 0);
            this.Controls.SetChildIndex(this.Option2, 0);
            this.Controls.SetChildIndex(this.Option3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.FSCTextBox InfoTB;
        private Controls.FSCButton Disable;
        private Controls.FSCButton Option1;
        private Controls.FSCButton Option2;
        private Controls.FSCButton Option3;
    }
}