
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthLoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            btnMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            emailLoginInput = new Guna.UI2.WinForms.Guna2TextBox();
            passwordLogin = new Guna.UI2.WinForms.Guna2TextBox();
            LoginHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            emailLable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            passwordLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            forgotPasswordLink = new Guna.UI2.WinForms.Guna2HtmlLabel();
            createAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            loginBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            btnMinimize.CustomizableEdges = customizableEdges1;
            btnMinimize.FillColor = Color.SlateGray;
            btnMinimize.IconColor = Color.White;
            btnMinimize.Location = new Point(739, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMinimize.Size = new Size(40, 30);
            btnMinimize.TabIndex = 1;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            btnMaximize.CustomizableEdges = customizableEdges3;
            btnMaximize.FillColor = Color.SlateGray;
            btnMaximize.IconColor = Color.White;
            btnMaximize.Location = new Point(779, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMaximize.Size = new Size(40, 30);
            btnMaximize.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Red;
            btnClose.CustomizableEdges = customizableEdges5;
            btnClose.FillColor = Color.Transparent;
            btnClose.IconColor = Color.Black;
            btnClose.Location = new Point(819, 3);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnClose.Size = new Size(40, 30);
            btnClose.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackColor = Color.White;
            guna2PictureBox1.CustomizableEdges = customizableEdges7;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(3, 0);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.Size = new Size(442, 577);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 0;
            guna2PictureBox1.TabStop = false;
            // 
            // emailLoginInput
            // 
            emailLoginInput.BackColor = Color.WhiteSmoke;
            emailLoginInput.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            emailLoginInput.CustomizableEdges = customizableEdges9;
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
            emailLoginInput.ShadowDecoration.CustomizableEdges = customizableEdges10;
            emailLoginInput.Size = new Size(301, 51);
            emailLoginInput.TabIndex = 1;
            // 
            // passwordLogin
            // 
            passwordLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            passwordLogin.CustomizableEdges = customizableEdges11;
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
            passwordLogin.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            // loginBtn
            // 
            loginBtn.CustomizableEdges = customizableEdges13;
            loginBtn.DisabledState.BorderColor = Color.DarkGray;
            loginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginBtn.FillColor = Color.FromArgb(0, 0, 64);
            loginBtn.FillColor2 = Color.DarkBlue;
            loginBtn.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(504, 424);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges14;
            loginBtn.Size = new Size(301, 49);
            loginBtn.TabIndex = 8;
            loginBtn.Text = "Login";
            loginBtn.Click += guna2GradientButton1_Click;
            // 
            // AuthLoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(861, 578);
            Controls.Add(btnMaximize);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(loginBtn);
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
        private Guna.UI2.WinForms.Guna2GradientButton loginBtn;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnMaximize;
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
