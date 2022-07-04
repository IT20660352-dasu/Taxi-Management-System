using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Taxi
{
    public partial class RiderSearchForm : Form
    {
        public RiderSearchForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U88I4AMS\SQLEXPRESSKD;Initial Catalog=TAXI;Integrated Security=True");
        int RiderID;
        private void RiderSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string PhoneNo = textBoxSearch.Text.Trim();//
                string search_quary = "SELECT * FROM Rider WHERE PhoneNo = '" + PhoneNo + "' ";
                con.Open();
                SqlCommand driverSearch_command = new SqlCommand(search_quary, con);
                SqlDataReader dr = driverSearch_command.ExecuteReader(); // row by row data reading
                while (dr.Read())
                {
                    RiderID = int.Parse(dr[0].ToString());
                    textBoxName.Text = dr[1].ToString();
                    dateTimePickerDOB.Value = Convert.ToDateTime(dr[2]);
                    textBoxAddress.Text = dr[3].ToString();
                    if (Convert.ToBoolean(dr[4]))
                    {
                        radioButtonMale.Checked = true;
                    }
                    else
                    {
                        radioButtonFemale.Checked = true;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error!");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
