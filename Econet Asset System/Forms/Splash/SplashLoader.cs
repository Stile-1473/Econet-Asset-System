using Econet_Asset_System.Forms.Authentication;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Econet_Asset_System
{
    public partial class SplashLoader : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public SplashLoader()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, Width, Height, 25, 25)
            );

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Interval = 50;   // speed
            timer1.Start();         // start timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
                // designer-created label is named guna2HtmlLabel2, update text there
                guna2HtmlLabel2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        private void progressBar1_ValueChanged(object sender, EventArgs e)
        {
            // leave empty or remove this event from designer
        }

        private void SplashLoader_Load(object sender, EventArgs e)
        {

        }
    }
}