
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Econet_Asset_System.Forms.Authentication
{
    public class AuthLoginForm : Form
    {

        public AuthLoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthLoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            emailLoginInput = new Guna.UI2.WinForms.Guna2TextBox();
            passwordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            LoginHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            emailLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            passwordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            forgotPasswordLink = new Guna.UI2.WinForms.Guna2HtmlLabel();
            createAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.White;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(3, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(442, 577);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // emailLoginInput
            // 
            emailLoginInput.BackColor = Color.WhiteSmoke;
            emailLoginInput.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            emailLoginInput.CustomizableEdges = customizableEdges3;
            emailLoginInput.DefaultText = "";
            emailLoginInput.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            emailLoginInput.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            emailLoginInput.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            emailLoginInput.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            emailLoginInput.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            emailLoginInput.Font = new Font("Segoe UI", 9F);
            emailLoginInput.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            emailLoginInput.Location = new Point(504, 216);
            emailLoginInput.Name = "emailLoginInput";
            emailLoginInput.PlaceholderText = "Enter Your Email eg. tinashe@gmail.com";
            emailLoginInput.SelectedText = "";
            emailLoginInput.ShadowDecoration.CustomizableEdges = customizableEdges4;
            emailLoginInput.Size = new Size(301, 51);
            emailLoginInput.TabIndex = 1;
            // 
            // passwordLogin
            // 
            passwordLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            passwordLogin.CustomizableEdges = customizableEdges5;
            passwordLogin.DefaultText = "";
            passwordLogin.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordLogin.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordLogin.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordLogin.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordLogin.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordLogin.Font = new Font("Segoe UI", 9F);
            passwordLogin.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordLogin.Location = new Point(504, 324);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.PlaceholderText = "Enter Your Password Here";
            passwordLogin.SelectedText = "";
            passwordLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            passwordLogin.Size = new Size(301, 51);
            passwordLogin.TabIndex = 2;
            // 
            // LoginHeader
            // 
            LoginHeader.BackColor = Color.Transparent;
            LoginHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginHeader.ForeColor = Color.Navy;
            LoginHeader.Location = new Point(445, 68);
            LoginHeader.Name = "LoginHeader";
            LoginHeader.Padding = new Padding(5);
            LoginHeader.Size = new Size(404, 44);
            LoginHeader.TabIndex = 3;
            LoginHeader.Text = "Welcome Login To Manage Assets";
            LoginHeader.TextAlignment = ContentAlignment.TopCenter;
            // 
            // emailLable
            // 
            emailLable.BackColor = Color.Transparent;
            emailLable.Location = new Point(504, 193);
            emailLable.Name = "emailLable";
            emailLable.Size = new Size(32, 17);
            emailLable.TabIndex = 4;
            emailLable.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Location = new Point(504, 301);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(53, 17);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
           
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.BackColor = Color.Transparent;
            forgotPasswordLink.ForeColor = Color.Blue;
            forgotPasswordLink.Location = new Point(750, 549);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(99, 17);
            forgotPasswordLink.TabIndex = 6;
            forgotPasswordLink.Text = "Forgot Password ?";
            forgotPasswordLink.Click += forgotPasswordLink_Click;
            forgotPasswordLink.MouseEnter += forgotPasswordLink_MouseEnter;
            forgotPasswordLink.MouseLeave += forgotPasswordLink_MouseLeave;
            // 
            // createAccount
            // 
            createAccount.BackColor = Color.Transparent;
            createAccount.ForeColor = Color.Blue;
            createAccount.Location = new Point(458, 549);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(90, 17);
            createAccount.TabIndex = 7;
            createAccount.Text = "Create Account?";
            createAccount.Click += createAccount_Click;
            createAccount.MouseEnter += createAccount_MouseEnter;
            createAccount.MouseLeave += createAccount_MouseLeave;
            // 
            // AuthLoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(861, 578);
            Controls.Add(createAccount);
            Controls.Add(forgotPasswordLink);
            Controls.Add(passwordLabel);
            Controls.Add(emailLable);
            Controls.Add(LoginHeader);
            Controls.Add(passwordLogin);
            Controls.Add(emailLoginInput);
            Controls.Add(guna2PictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "AuthLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Econet";
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

       

        private void forgotPasswordLink_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ForgotPassword Box Clicked");
        }

        private void forgotPasswordLink_MouseLeave(object sender, EventArgs e)
        {
            forgotPasswordLink.ForeColor = Color.Blue;
        }

        private void createAccount_MouseLeave(object sender, EventArgs e)
        {
            createAccount.ForeColor = Color.Blue;
        }
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox emailLoginInput;
        private Guna.UI2.WinForms.Guna2TextBox passwordLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel LoginHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel emailLable;
        private Guna.UI2.WinForms.Guna2HtmlLabel passwordLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel forgotPasswordLink;
        private Guna.UI2.WinForms.Guna2HtmlLabel createAccount;

        private void createAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ForgotPassword Box Clicked");
        }

        private void createAccount_MouseEnter(object sender, EventArgs e)
        {
            createAccount.ForeColor = Color.Red;
        }

        private void forgotPasswordLink_MouseEnter(object sender, EventArgs e)
        {
            forgotPasswordLink.ForeColor = Color.Red;
        }
    }
}
