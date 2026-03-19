using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Animated_LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Private void SetRoundedRegion(int r)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, r, r, 180, 90);
                path.AddArc(Width - r, 0, r, r, 270, 90);
                path.AddArc(Width - r, Height - r, r, r, 0, 90);
                path.AddArc(0, Height - r, r, r, 90, 90);
                path.CloseFigure();
                this.Region = new Region(path);
            }

        }
    }
}
