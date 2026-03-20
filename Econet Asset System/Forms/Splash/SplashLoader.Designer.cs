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
        //creating a gradient color bg
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    this.ClientRectangle,
                    System.Drawing.Color.FromArgb(0, 102, 205), // Blue
                    System.Drawing.Color.White,                 // White
                    45F)) // Angle
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
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
            splashloadingtext = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            progressBar1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.None;
            progressBar1.AnimationSpeed = 0.5F;
            progressBar1.BackColor = Color.Transparent;
            progressBar1.Controls.Add(splashloadingtext);
            progressBar1.FillColor = Color.Transparent;
            progressBar1.Font = new Font("Segoe UI", 12F);
            progressBar1.ForeColor = Color.Transparent;
            progressBar1.InnerColor = Color.Transparent;
            progressBar1.Location = new Point(306, 222);
            progressBar1.Minimum = 0;
            progressBar1.Name = "progressBar1";
            progressBar1.ProgressColor = Color.FromArgb(0, 0, 192);
            progressBar1.ProgressColor2 = Color.FromArgb(0, 0, 192);
            progressBar1.ProgressThickness = 12;
            progressBar1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            progressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            progressBar1.Size = new Size(180, 180);
            progressBar1.TabIndex = 0;
            progressBar1.Text = "guna2CircleProgressBar1";
            progressBar1.ValueChanged += progressBar1_ValueChanged;
            // 
            // splashloadingtext
            // 
            splashloadingtext.Anchor = AnchorStyles.None;
            splashloadingtext.BackColor = Color.Transparent;
            splashloadingtext.ForeColor = SystemColors.ButtonFace;
            splashloadingtext.Location = new Point(65, 79);
            splashloadingtext.Name = "splashloadingtext";
            splashloadingtext.Size = new Size(55, 17);
            splashloadingtext.TabIndex = 2;
            splashloadingtext.Text = "Loading...";
            splashloadingtext.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(247, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(343, 39);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Econet Asset Management";
            lblTitle.TextAlignment = ContentAlignment.TopCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.ForeColor = Color.DarkRed;
            lblStatus.Location = new Point(40, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(3, 2);
            lblStatus.TabIndex = 3;
            lblStatus.Text = null;
            lblStatus.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.TargetForm = this;
            // 
            // SplashLoader
            // 
            AccessibleRole = AccessibleRole.TitleBar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 578);
            Controls.Add(lblStatus);
            Controls.Add(lblTitle);
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel splashloadingtext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}
