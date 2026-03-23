using Econet_Asset_System.Forms.Assets;
using Econet_Asset_System.Forms.Assignments;
using Econet_Asset_System.Forms.Authentication;
using Econet_Asset_System.Forms.Employees;
using Econet_Asset_System.Forms.Locations;
using Econet_Asset_System.Forms.Maintanance;
using Econet_Asset_System.Forms.User;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Econet_Asset_System.Forms.Dashboard
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            dashboardLinkBtn.Click += dashboardLinkBtn_Click;
            assetLinkBtn.Click += assetsLinkBtn_Click;
            maintenanceLinkBtn.Click += maintenanceLinkBtn_Click;
            assignmentLinkBtn.Click += assignmentLinkBtn_Click;
            employeeLinkBtn.Click += employeeLinkBtn_Click;
            settingsLinkBtn.Click += settingsLinkBtn_Click;
            locationLinkBtn.Click += locationLinkBtn_Click;
            logoutBtn.Click += logoutBtn_Click;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }


        //method to load the form into the panel this code removes current content
       // prepares the new form to behave like a panel
//docks it inside mainPanel
//shows it
        private void loadPage(Form page) { 

            mainPanel.Controls.Clear();
            page.TopLevel = false;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(page);
            mainPanel.Tag = page;

            page.Show();


        }



        private void dashboardLinkBtn_Click(object sender, EventArgs e)
        {
            ResetSidebarButtons();
            dashboardLinkBtn.FillColor = Color.FromArgb(0, 102, 204);

            ShowDashboardHome();


        }


        private void assetsLinkBtn_Click(object sender, EventArgs e)
        {
            ResetSidebarButtons();
            assetLinkBtn.FillColor = Color.FromArgb(0, 102, 204);
            loadPage(new AssetsForm());
        }


        private void maintenanceLinkBtn_Click(object sender, EventArgs e) {

            ResetSidebarButtons();
            maintenanceLinkBtn.FillColor = Color.FromArgb(0, 102, 204);
            loadPage(new MaintananceForm());


        }

        private void assignmentLinkBtn_Click(object sender, EventArgs e) {
            ResetSidebarButtons();
            assignmentLinkBtn.FillColor = Color.FromArgb(0, 102, 204);
            loadPage(new AssetsForm());
        }

        private void settingsLinkBtn_Click(object sender, EventArgs e) {

            ResetSidebarButtons();
            settingsLinkBtn.FillColor = Color.FromArgb(0, 102, 204);
            loadPage(new UserForm());
        }

        private void employeeLinkBtn_Click(Object sender, EventArgs e) {
            ResetSidebarButtons();
            employeeLinkBtn.FillColor = Color.FromArgb(0, 102, 204);
            loadPage(new employeesForm());
        }

        private void locationLinkBtn_Click(Object sender, EventArgs e) {
            ResetSidebarButtons();
            locationLinkBtn.FillColor = Color.FromArgb(0, 102, 204);
            loadPage(new locationsForm());

        }


        private void logoutBtn_Click(Object sender, EventArgs e) {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );



            if (result == DialogResult.Yes) { 
            
                AuthLoginForm loginForm = new AuthLoginForm();
                loginForm.Show();
                this.Close();
            }
        
        }



        private void ShowDashboardHome()
        {
            mainPanel.Controls.Clear();

            cardTotalAssets.Parent = mainPanel;
            cardAssignedAssets.Parent = mainPanel;
            cardAvailableAssets.Parent = mainPanel;
            cardMaintenanceAssets.Parent = mainPanel;
            recentActivityPanel.Parent = mainPanel;
            alertsPanel.Parent = mainPanel;

            mainPanel.Controls.Add(cardTotalAssets);
            mainPanel.Controls.Add(cardAssignedAssets);
            mainPanel.Controls.Add(cardAvailableAssets);
            mainPanel.Controls.Add(cardMaintenanceAssets);
            mainPanel.Controls.Add(recentActivityPanel);
            mainPanel.Controls.Add(alertsPanel);
        }


        private void ResetSidebarButtons() {


            dashboardLinkBtn.FillColor = Color.Transparent;
            assetLinkBtn.FillColor = Color.Transparent;
            settingsLinkBtn.FillColor = Color.Transparent;
            assignmentLinkBtn.FillColor = Color.Transparent;
            maintenanceLinkBtn.FillColor = Color.Transparent;
            locationLinkBtn.FillColor = Color.Transparent;
            settingsLinkBtn.FillColor = Color.Transparent;
            employeeLinkBtn.FillColor = Color.Transparent;

            logoutBtn.FillColor = Color.FromArgb(220, 53, 69);

        }

    }
}
