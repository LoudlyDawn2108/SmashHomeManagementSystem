using System;
using System.Windows.Forms;

namespace SmartHomeManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize the application
        }

        private void btnLighting_Click(object sender, EventArgs e)
        {
            var lightingControlForm = new LightingControlForm();
            lightingControlForm.Show();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            var securityControlForm = new SecurityControlForm();
            securityControlForm.Show();
        }

        private void btnClimate_Click(object sender, EventArgs e)
        {
            var climateControlForm = new ClimateControlForm();
            climateControlForm.Show();
        }

        private void btnEntertainment_Click(object sender, EventArgs e)
        {
            var entertainmentControlForm = new EntertainmentControlForm();
            entertainmentControlForm.Show();
        }
    }
}