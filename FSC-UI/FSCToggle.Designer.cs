
namespace FSC_UI
{
    partial class FSCToggle
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.FSCToggleBackPanel = new System.Windows.Forms.Panel();
            this.FSCTogglePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // FSCToggleBackPanel
            // 
            this.FSCToggleBackPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FSCToggleBackPanel.Location = new System.Drawing.Point(4, 3);
            this.FSCToggleBackPanel.Name = "FSCToggleBackPanel";
            this.FSCToggleBackPanel.Size = new System.Drawing.Size(28, 11);
            this.FSCToggleBackPanel.TabIndex = 0;
            this.FSCToggleBackPanel.Click += new System.EventHandler(this.FSCToggle_Click);
            this.FSCToggleBackPanel.MouseEnter += new System.EventHandler(this.FSCToggle_MouseEnter);
            this.FSCToggleBackPanel.MouseLeave += new System.EventHandler(this.FSCToggle_MouseLeave);
            // 
            // FSCTogglePanel
            // 
            this.FSCTogglePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.FSCTogglePanel.Location = new System.Drawing.Point(0, 0);
            this.FSCTogglePanel.Name = "FSCTogglePanel";
            this.FSCTogglePanel.Size = new System.Drawing.Size(16, 16);
            this.FSCTogglePanel.TabIndex = 1;
            this.FSCTogglePanel.Click += new System.EventHandler(this.FSCToggle_Click);
            this.FSCTogglePanel.MouseEnter += new System.EventHandler(this.FSCToggle_MouseEnter);
            this.FSCTogglePanel.MouseLeave += new System.EventHandler(this.FSCToggle_MouseLeave);
            // 
            // FSCToggle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FSCTogglePanel);
            this.Controls.Add(this.FSCToggleBackPanel);
            this.Name = "FSCToggle";
            this.Size = new System.Drawing.Size(54, 24);
            this.Click += new System.EventHandler(this.FSCToggle_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FSCToggle_Paint);
            this.MouseEnter += new System.EventHandler(this.FSCToggle_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FSCToggle_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FSCToggleBackPanel;
        private System.Windows.Forms.Panel FSCTogglePanel;
    }
}
