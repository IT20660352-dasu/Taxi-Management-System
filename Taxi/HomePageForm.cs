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
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void buttonDriver_Click(object sender, EventArgs e)
        {
            DriverRegForm _DriverregForm = new DriverRegForm(); // destination page
            _DriverregForm.Show();
            this.Hide();
        }

        private void buttonRider_Click(object sender, EventArgs e)
        {
            RiderReg _riderReg = new RiderReg();
            _riderReg.Show();
            this.Hide();

        }

        private void buttonTrip_Click(object sender, EventArgs e)
        { 
            TripForm _tripForm = new TripForm();
            _tripForm.Show();
            this.Hide();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LoginForm _loginForm = new LoginForm();
            _loginForm.Show();
            this.Hide();
          
           
        }
    }
}
