using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBoxLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            // And = &&
            // Or = ||
            if (userName == "Admin" && password == "Password123")
            {
                HomePageForm _HomePageForm = new HomePageForm(); // destination page
                _HomePageForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrct login credential","Information",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}
