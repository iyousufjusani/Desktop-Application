using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPortal
{
    public partial class FormMainDashboard : Form
    {
        public FormMainDashboard()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Setting label text
            dashboardText.Text = "Home";
            dashboardText.Refresh();


            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 2;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnMarks.FlatAppearance.BorderSize = 0;
            btnTranscript.FlatAppearance.BorderSize = 0;
            btnFeeChallan.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnTentativePlan.FlatAppearance.BorderSize = 0;




            //Setting panel Active
            panelActive.Visible = true;
            panelActive.Height = btnHome.Height;
            panelActive.Top = btnHome.Top;
            panelHome.Visible = true;
            panelRegistration.Visible = false;
            panelAttendance.Visible = false;
            panelMarks.Visible = false;
            panelTranscript.Visible = false;
            panelFeeChallan.Visible = false;
            panelFeedback.Visible = false;
            panelTentativePlan.Visible = false;
            panelSettings.Visible = false;


        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            //Setting label text
            dashboardText.Text = "Registration";
            dashboardText.Refresh();


            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 2;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnMarks.FlatAppearance.BorderSize = 0;
            btnTranscript.FlatAppearance.BorderSize = 0;
            btnFeeChallan.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnTentativePlan.FlatAppearance.BorderSize = 0;


            //Setting panel Active
            panelActive.Visible = true;
            panelActive.Height = btnRegistration.Height;
            panelActive.Top = btnRegistration.Top;
            panelHome.Visible = false;
            panelRegistration.Visible = true;
            panelAttendance.Visible = false;
            panelMarks.Visible = false;
            panelTranscript.Visible = false;
            panelFeeChallan.Visible = false;
            panelFeedback.Visible = false;
            panelTentativePlan.Visible = false;
            panelSettings.Visible = false;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            //Setting label text
            dashboardText.Text = "Attendance";
            dashboardText.Refresh();


            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.BorderSize = 2;
            btnMarks.FlatAppearance.BorderSize = 0;
            btnTranscript.FlatAppearance.BorderSize = 0;
            btnFeeChallan.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnTentativePlan.FlatAppearance.BorderSize = 0;


            //Setting panel Active
            panelActive.Visible = true;
            panelActive.Height = btnAttendance.Height;
            panelActive.Top = btnAttendance.Top;
            panelHome.Visible = false;
            panelRegistration.Visible = false;
            panelAttendance.Visible = true;
            panelMarks.Visible = false;
            panelTranscript.Visible = false;
            panelFeeChallan.Visible = false;
            panelFeedback.Visible = false;
            panelTentativePlan.Visible = false;
            panelSettings.Visible = false;
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            //Setting label text
            dashboardText.Text = "Marks";
            dashboardText.Refresh();


            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnMarks.FlatAppearance.BorderSize = 2;
            btnTranscript.FlatAppearance.BorderSize = 0;
            btnFeeChallan.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnTentativePlan.FlatAppearance.BorderSize = 0;

            //Setting panel Active
            panelActive.Visible = true;
            panelActive.Height = btnMarks.Height;
            panelActive.Top = btnMarks.Top;
            panelHome.Visible = false;
            panelRegistration.Visible = false;
            panelAttendance.Visible = false;
            panelMarks.Visible = true;
            panelTranscript.Visible = false;
            panelFeeChallan.Visible = false;
            panelFeedback.Visible = false;
            panelTentativePlan.Visible = false;
            panelSettings.Visible = false;
        }

        private void btnTranscript_Click(object sender, EventArgs e)
        {
            //Setting label text
            dashboardText.Text = "Transcript";
            dashboardText.Refresh();


            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnMarks.FlatAppearance.BorderSize = 0;
            btnTranscript.FlatAppearance.BorderSize = 2;
            btnFeeChallan.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnTentativePlan.FlatAppearance.BorderSize = 0;


            //Setting panel Active
            panelActive.Visible = true;
            panelActive.Height = btnTranscript.Height;
            panelActive.Top = btnTranscript.Top;
            panelHome.Visible = false;
            panelRegistration.Visible = false;
            panelAttendance.Visible = false;
            panelMarks.Visible = false;
            panelTranscript.Visible = true;
            panelFeeChallan.Visible = false;
            panelFeedback.Visible = false;
            panelTentativePlan.Visible = false;
            panelSettings.Visible = false;
        }

        private void btnFeeChallan_Click(object sender, EventArgs e)
        {
            //Setting label text
            dashboardText.Text = "Fee Challan";
            dashboardText.Refresh();

            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnMarks.FlatAppearance.BorderSize = 0;
            btnTranscript.FlatAppearance.BorderSize = 0;
            btnFeeChallan.FlatAppearance.BorderSize = 2;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnTentativePlan.FlatAppearance.BorderSize = 0;


            //Setting panel Active
            panelActive.Visible = true;
            panelActive.Height = btnFeeChallan.Height;
            panelActive.Top = btnFeeChallan.Top;
            panelHome.Visible = false;
            panelRegistration.Visible = false;
            panelAttendance.Visible = false;
            panelMarks.Visible = false;
            panelTranscript.Visible = false;
            panelFeeChallan.Visible = true;
            panelFeedback.Visible = false;
            panelTentativePlan.Visible = false;
            panelSettings.Visible = false;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            //Setting label text
            dashboardText.Text = "Feedback";
            dashboardText.Refresh();


            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnMarks.FlatAppearance.BorderSize = 0;
            btnTranscript.FlatAppearance.BorderSize = 0;
            btnFeeChallan.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatAppearance.BorderSize = 2;
            btnTentativePlan.FlatAppearance.BorderSize = 0;

            //Setting panel Active
            panelActive.Visible = true;
            panelActive.Height = btnFeedback.Height;
            panelActive.Top = btnFeedback.Top;
            panelHome.Visible = false;
            panelRegistration.Visible = false;
            panelAttendance.Visible = false;
            panelMarks.Visible = false;
            panelTranscript.Visible = false;
            panelFeeChallan.Visible = false;
            panelFeedback.Visible = true;
            panelTentativePlan.Visible = false;
            panelSettings.Visible = false;

        }

        private void btnTentativePlan_Click(object sender, EventArgs e)
        {
            //Setting label text
            dashboardText.Text = "Tentative Plan";
            dashboardText.Refresh();

            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnMarks.FlatAppearance.BorderSize = 0;
            btnTranscript.FlatAppearance.BorderSize = 0;
            btnFeeChallan.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnTentativePlan.FlatAppearance.BorderSize = 2;


            //Setting panel Active
            panelActive.Visible = true;
            panelActive.Height = btnTentativePlan.Height;
            panelActive.Top = btnTentativePlan.Top;
            panelHome.Visible = false;
            panelRegistration.Visible = false;
            panelAttendance.Visible = false;
            panelMarks.Visible = false;
            panelTranscript.Visible = false;
            panelFeeChallan.Visible = false;
            panelFeedback.Visible = false;
            panelTentativePlan.Visible = true;
            panelSettings.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Sign out functionality
            //...
            Environment.Exit(1);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //Account Settings

            //Setting label text
            dashboardText.Text = "Settings";
            dashboardText.Refresh();


            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnMarks.FlatAppearance.BorderSize = 0;
            btnTranscript.FlatAppearance.BorderSize = 0;
            btnFeeChallan.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnTentativePlan.FlatAppearance.BorderSize = 0;

            //Setting panel Active
            panelActive.Visible = false;
            panelHome.Visible = false;
            panelRegistration.Visible = false;
            panelAttendance.Visible = false;
            panelMarks.Visible = false;
            panelTranscript.Visible = false;
            panelFeeChallan.Visible = false;
            panelFeedback.Visible = false;
            panelTentativePlan.Visible = false;
            panelSettings.Visible = true;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            //Signout functionality

            //Setting button border on Active
            btnHome.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnMarks.FlatAppearance.BorderSize = 0;
            btnTranscript.FlatAppearance.BorderSize = 0;
            btnFeeChallan.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnTentativePlan.FlatAppearance.BorderSize = 0;

            //Setting panel Active
            panelActive.Visible = false;


            this.Hide();
            FormLogin form = new FormLogin();
            form.Show();

        }
    }
}
