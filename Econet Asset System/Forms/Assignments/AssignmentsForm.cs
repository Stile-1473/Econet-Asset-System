using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Econet_Asset_System.Forms.Assignments
{
    public partial class AssignmentsForm : Form
    {
        // Change 'object asset' to 'List<Asset> assets'
        private List<Asset> assets;

        public AssignmentsForm()
        {
            InitializeComponent();
            // Initialize the assets list
            assets = new List<Asset>();
        }

        // FORM LOAD (runs when form opens)
        private void AssignmentsForm_Load(object sender, EventArgs e)
        {
           	InitializeComponent();
            // Setup DataGridView columns
            DataGridView1.ColumnCount = 3;
            DataGridView1.Columns[0].Name = "ID";
            DataGridView1.Columns[1].Name = "Asset Name";
            DataGridView1.Columns[2].Name = "User";
        }

        // ADD BUTTON CLICK
        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        
            // Validate ID
            if (!int.TryParse(txtUser.Text.Trim(), out int id))
            {
                MessageBox.Show("Enter a valid ID");
                return;
            }

            // Check empty fields
            if (txtName.Text == "" || txtID.Text == "")
            {
                MessageBox.Show("Fill all fields");
                return;
            }

            // Create asset object
            Asset a = new Asset()
            {
                Id = id,
                Name = txtName.Text,
                User = txtID.Text
            };

            // Add to list
            assets.Add(a);

            // Display in DataGridView
            DataGridView1.Rows.Add(a.Id, a.Name, a.User);

            // Clear inputs
            txtUser.Clear();
            txtName.Clear();
            txtID.Clear();
        }


    }

    // Asset class
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
