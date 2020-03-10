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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textUser.Text == "student" && textPassword.Text == "fast")
            {
                this.Hide();
                FormMainDashboard formMainDashboard = new FormMainDashboard();
                formMainDashboard.Show();
            }
            else
            {
                MessageBox.Show("Student Id or Password is inccorect");
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
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

    }
}
