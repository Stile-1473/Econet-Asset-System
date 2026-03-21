// This allows us to use the LoginForm from the Authentication folder
using Econet_Asset_System.Forms.Authentication;

// Basic system functionalities 
using System;

// Needed to import Windows API functions (for rounded corners)
using System.Runtime.InteropServices;

// WinForms library (Forms, Timer, ProgressBar)
using System.Windows.Forms;

namespace Econet_Asset_System
{
    // This is our Splash Screen form (the first screen user sees)
    public partial class SplashLoader : Form
    {
        // Importing a Windows function that allows us to create rounded corners
        // This is not C# code  it's from Windows itself
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        // This method defines how the rounded shape will be created
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // Left position of the form
            int nTopRect,      // Top position
            int nRightRect,    // Right position
            int nBottomRect,   // Bottom position
            int nWidthEllipse, // Width of the curve
            int nHeightEllipse // Height of the curve
        );

        // Local state for animations
        private System.Windows.Forms.Timer fadeTimer;
        private int dotCounter = 0;
        private int tickCounter = 0;

        // Constructor runs immediately when SplashLoader starts
        public SplashLoader()
        {
            InitializeComponent(); // Loads all controls from designer

            // Apply rounded corners to the form
            Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 20, 20)
            );

            // Set up progress bar range
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            // Start from 0%
            progressBar1.Value = 0;

            // Timer controls how fast loading happens (50ms = smooth animation)
            timer1.Interval = 50;
            timer1.Start();

            // Fade timer used for smooth transition to login
            fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 20;
            fadeTimer.Tick += FadeTimer_Tick;

            // Improve rendering
            DoubleBuffered = true;
        }

        // This method runs every time the timer ticks (every 50ms)
        private void timer1_Tick(object sender, EventArgs e)
        {
            // If loading is not complete
            if (progressBar1.Value < 100)
            {
                // Increase progress
                progressBar1.Value++;

                // Animate percentage text with dots
                tickCounter++;
                if (tickCounter % 5 == 0)
                {
                    dotCounter = (dotCounter + 1) % 4; // 0..3
                }

                string dots = new string('.', dotCounter);
                splashloadingtext.Text = $"{progressBar1.Value}%{dots}";

                // Dynamic loading messages 
                if (progressBar1.Value < 30)
                    lblStatus.Text = "Initializing system" + dots;
                else if (progressBar1.Value < 60)
                    lblStatus.Text = "Fetching Modules" + dots;
                else if (progressBar1.Value < 90)
                    lblStatus.Text = "Preparing Modules" + dots;
                else
                    lblStatus.Text = "Almost ready" + dots;
            }
            else
            {
                // Stop the timer when loading reaches 100%
                timer1.Stop();

                // Start fade-out transition
                fadeTimer.Start();
            }
        }

        // Fade-out tick: reduce opacity until 0, then open LoginForm
        private void FadeTimer_Tick(object? sender, EventArgs e)
        {
            // reduce opacity smoothly
            if (this.Opacity > 0.05)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                fadeTimer.Stop();
                // Ensure fully invisible then close splash to return control to Program.Main
                this.Opacity = 0;
                this.Close();
            }
        }

        // This event is triggered when progress changes 
        private void progressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

     

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Designer references SplashLoader_Load; implement to avoid designer/build error
        private void SplashLoader_Load(object sender, EventArgs e)
        {
            // If the picture was not loaded from resources (missing embedded file)
            // try to find the image file in a Resources folder up the directory tree
            try
            {
                if (guna2PictureBox1.Image == null)
                {
                    string fileName = "econet-wireless-seeklogo.png";
                    string dir = AppDomain.CurrentDomain.BaseDirectory;
                    for (int i = 0; i < 6 && dir != null; i++)
                    {
                        string candidate = System.IO.Path.Combine(dir, "Resources", fileName);
                        if (System.IO.File.Exists(candidate))
                        {
                            guna2PictureBox1.Image = System.Drawing.Image.FromFile(candidate);
                            break;
                        }
                        dir = System.IO.Path.GetDirectoryName(dir);
                    }
                }
            }
            catch
            {
                // Swallow exceptions here; missing image should not crash the designer or app.
            }
        }
    }
}