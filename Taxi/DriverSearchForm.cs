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
    public partial class DriverSearchForm : Form
    {
        public DriverSearchForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U88I4AMS\SQLEXPRESSKD;Initial Catalog=TAXI;Integrated Security=True");
        int DriverID;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string PhoneNo = textBoxSearch.Text.Trim();//
                string search_quary = "SELECT * FROM Driver WHERE PhoneNo = '" + PhoneNo + "' ";
                con.Open();
                SqlCommand driverSearch_command = new SqlCommand(search_quary, con);
                SqlDataReader dr = driverSearch_command.ExecuteReader(); // row by row data reading
                while (dr.Read())
                {
                    DriverID = int.Parse(dr[0].ToString());
                    textBoxName.Text = dr[1].ToString();
                    dateTimePickerDOF.Value = Convert.ToDateTime(dr[2]);
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DriverReg driverReg = new DriverReg();
                driverReg.DriverID = DriverID;
                driverReg.Name = textBoxName.Text;
                driverReg.DOB = dateTimePickerDOF.Value;
                driverReg.Address = textBoxAddress.Text;
                if (Convert.ToBoolean(driverReg.Gender))
                {
                    radioButtonMale.Checked = true;
                }
                else
                {
                    radioButtonFemale.Checked = true;
                }
                con.Open();
                string Update_Quary = "UPDATE Driver SET Name='" + driverReg.Name + "', DOB='" + driverReg.DOB + "' , Address='" + driverReg.Address + "' , Gender='" + driverReg.Gender + "'  WHERE DriverID='" + driverReg.DriverID + "'";
                SqlCommand command = new SqlCommand(Update_Quary, con);
                command.ExecuteReader();
                MessageBox.Show("Record Update Succsefully", "Succsefull");
                textBoxName.Clear(); //We cant cleat date time picker
                textBoxAddress.Clear();
                
                
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string delete_quary = "DELETE FROM [Driver] WHERE DriverID = '" + DriverID + "'";
                SqlCommand command = new SqlCommand(delete_quary, con);
                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record Delete Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                con.Close();
            }
        }
    }
}
