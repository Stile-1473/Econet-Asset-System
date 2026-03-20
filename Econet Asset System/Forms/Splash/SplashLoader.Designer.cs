namespace Econet_Asset_System
{
    partial class SplashLoader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            progressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.AnimationSpeed = 0.5F;
            progressBar1.Controls.Add(guna2HtmlLabel2);
            progressBar1.FillColor = Color.DarkSlateGray;
            progressBar1.Font = new Font("Segoe UI", 12F);
            progressBar1.ForeColor = SystemColors.MenuHighlight;
            progressBar1.InnerColor = Color.SteelBlue;
            progressBar1.Location = new Point(40, 141);
            progressBar1.Minimum = 0;
            progressBar1.Name = "progressBar1";
            progressBar1.ProgressThickness = 15;
            progressBar1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            progressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            progressBar1.Size = new Size(150, 150);
            progressBar1.TabIndex = 0;
            progressBar1.Text = "guna2CircleProgressBar1";
            progressBar1.ValueChanged += progressBar1_ValueChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = SystemColors.ButtonFace;
            guna2HtmlLabel1.Location = new Point(26, 66);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(185, 34);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Econet Wireless";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.ForeColor = SystemColors.ButtonFace;
            guna2HtmlLabel2.Location = new Point(45, 65);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(58, 17);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Loading....";
            guna2HtmlLabel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // SplashLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 45, 192);
            ClientSize = new Size(255, 378);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(progressBar1);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashLoader";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SplashLoader_Load;
            progressBar1.ResumeLayout(false);
            progressBar1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}
