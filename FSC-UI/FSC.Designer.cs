
namespace FSC_UI
{
    partial class FSC
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
            this.FSCTitleBarPanel = new System.Windows.Forms.Panel();
            this.FSCTitleLabel = new System.Windows.Forms.Label();
            this.FSCTopMostBTN = new FSC_UI.Controls.FSCButton();
            this.FSCCloseBTN = new FSC_UI.Controls.FSCButton();
            this.FSCMaximizeBTN = new FSC_UI.Controls.FSCButton();
            this.FSCMinimizeBTN = new FSC_UI.Controls.FSCButton();
            this.FSCTitleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FSCTitleBarPanel
            // 
            this.FSCTitleBarPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.FSCTitleBarPanel.Controls.Add(this.FSCTitleLabel);
            this.FSCTitleBarPanel.Controls.Add(this.FSCTopMostBTN);
            this.FSCTitleBarPanel.Controls.Add(this.FSCCloseBTN);
            this.FSCTitleBarPanel.Controls.Add(this.FSCMaximizeBTN);
            this.FSCTitleBarPanel.Controls.Add(this.FSCMinimizeBTN);
            this.FSCTitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FSCTitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.FSCTitleBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FSCTitleBarPanel.Name = "FSCTitleBarPanel";
            this.FSCTitleBarPanel.Size = new System.Drawing.Size(820, 41);
            this.FSCTitleBarPanel.TabIndex = 0;
            this.FSCTitleBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FSCTitleBarPanel_MouseDown);
            // 
            // FSCTitleLabel
            // 
            this.FSCTitleLabel.AutoSize = true;
            this.FSCTitleLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.FSCTitleLabel.Location = new System.Drawing.Point(12, 11);
            this.FSCTitleLabel.Name = "FSCTitleLabel";
            this.FSCTitleLabel.Size = new System.Drawing.Size(0, 22);
            this.FSCTitleLabel.TabIndex = 4;
            this.FSCTitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FSCTitleBarPanel_MouseDown);
            // 
            // FSCTopMostBTN
            // 
            this.FSCTopMostBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FSCTopMostBTN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FSCTopMostBTN.FlatAppearance.BorderSize = 0;
            this.FSCTopMostBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FSCTopMostBTN.Font = new System.Drawing.Font("Arial", 14F);
            this.FSCTopMostBTN.Location = new System.Drawing.Point(606, 0);
            this.FSCTopMostBTN.Margin = new System.Windows.Forms.Padding(0);
            this.FSCTopMostBTN.Name = "FSCTopMostBTN";
            this.FSCTopMostBTN.RadiusBottomLeft = 12;
            this.FSCTopMostBTN.RadiusBottomRight = 12;
            this.FSCTopMostBTN.RadiusTopLeft = 1;
            this.FSCTopMostBTN.RadiusTopRight = 1;
            this.FSCTopMostBTN.Size = new System.Drawing.Size(45, 33);
            this.FSCTopMostBTN.TabIndex = 3;
            this.FSCTopMostBTN.Text = "/";
            this.FSCTopMostBTN.UseVisualStyleBackColor = false;
            this.FSCTopMostBTN.Click += new System.EventHandler(this.FSCTopMostBTN_Click);
            // 
            // FSCCloseBTN
            // 
            this.FSCCloseBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FSCCloseBTN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FSCCloseBTN.FlatAppearance.BorderSize = 0;
            this.FSCCloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FSCCloseBTN.Font = new System.Drawing.Font("Arial", 14F);
            this.FSCCloseBTN.Location = new System.Drawing.Point(755, 0);
            this.FSCCloseBTN.Margin = new System.Windows.Forms.Padding(0);
            this.FSCCloseBTN.Name = "FSCCloseBTN";
            this.FSCCloseBTN.RadiusBottomLeft = 1;
            this.FSCCloseBTN.RadiusBottomRight = 1;
            this.FSCCloseBTN.RadiusTopLeft = 1;
            this.FSCCloseBTN.RadiusTopRight = 1;
            this.FSCCloseBTN.Size = new System.Drawing.Size(65, 33);
            this.FSCCloseBTN.TabIndex = 1;
            this.FSCCloseBTN.Text = "X";
            this.FSCCloseBTN.UseVisualStyleBackColor = false;
            this.FSCCloseBTN.Click += new System.EventHandler(this.FSCCloseBTN_Click);
            // 
            // FSCMaximizeBTN
            // 
            this.FSCMaximizeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FSCMaximizeBTN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FSCMaximizeBTN.FlatAppearance.BorderSize = 0;
            this.FSCMaximizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FSCMaximizeBTN.Font = new System.Drawing.Font("Arial", 14F);
            this.FSCMaximizeBTN.Location = new System.Drawing.Point(710, 0);
            this.FSCMaximizeBTN.Margin = new System.Windows.Forms.Padding(0);
            this.FSCMaximizeBTN.Name = "FSCMaximizeBTN";
            this.FSCMaximizeBTN.RadiusBottomLeft = 1;
            this.FSCMaximizeBTN.RadiusBottomRight = 1;
            this.FSCMaximizeBTN.RadiusTopLeft = 1;
            this.FSCMaximizeBTN.RadiusTopRight = 1;
            this.FSCMaximizeBTN.Size = new System.Drawing.Size(45, 33);
            this.FSCMaximizeBTN.TabIndex = 2;
            this.FSCMaximizeBTN.Text = "O";
            this.FSCMaximizeBTN.UseVisualStyleBackColor = false;
            this.FSCMaximizeBTN.Click += new System.EventHandler(this.FSCMaximizeBTN_Click);
            // 
            // FSCMinimizeBTN
            // 
            this.FSCMinimizeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FSCMinimizeBTN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FSCMinimizeBTN.FlatAppearance.BorderSize = 0;
            this.FSCMinimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FSCMinimizeBTN.Font = new System.Drawing.Font("Arial", 14F);
            this.FSCMinimizeBTN.Location = new System.Drawing.Point(665, 0);
            this.FSCMinimizeBTN.Margin = new System.Windows.Forms.Padding(0);
            this.FSCMinimizeBTN.Name = "FSCMinimizeBTN";
            this.FSCMinimizeBTN.RadiusBottomLeft = 12;
            this.FSCMinimizeBTN.RadiusBottomRight = 1;
            this.FSCMinimizeBTN.RadiusTopLeft = 1;
            this.FSCMinimizeBTN.RadiusTopRight = 1;
            this.FSCMinimizeBTN.Size = new System.Drawing.Size(45, 33);
            this.FSCMinimizeBTN.TabIndex = 2;
            this.FSCMinimizeBTN.Text = "-";
            this.FSCMinimizeBTN.UseVisualStyleBackColor = false;
            this.FSCMinimizeBTN.Click += new System.EventHandler(this.FSCMinimizeBTN_Click);
            // 
            // FSC
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 472);
            this.ControlBox = false;
            this.Controls.Add(this.FSCTitleBarPanel);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FSC";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FSC_Shown);
            this.TextChanged += new System.EventHandler(this.FSC_TextChanged);
            this.Resize += new System.EventHandler(this.FSC_Resize);
            this.FSCTitleBarPanel.ResumeLayout(false);
            this.FSCTitleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel FSCTitleBarPanel;
        private Controls.FSCButton FSCCloseBTN;
        private Controls.FSCButton FSCMinimizeBTN;
        private Controls.FSCButton FSCMaximizeBTN;
        private Controls.FSCButton FSCTopMostBTN;
        private System.Windows.Forms.Label FSCTitleLabel;
    }
}