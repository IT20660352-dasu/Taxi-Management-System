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
    public partial class DriverRegForm : Form
    {
        public DriverRegForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U88I4AMS\SQLEXPRESSKD;Initial Catalog=TAXI;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(); //inserting User Name and password to the Driver regForm
                user.UserID = new Random().Next(); //auto genarating UserID 
                user.UserName=textBoxUserName.Text;
                user.Password=textBoxPassword.Text;
                user.IsDriver = true;
                string User_insert_query = "INSERT INTO [User] VALUES( '" + user.UserID + "','" + user.UserName + "','" + user.Password + "' ,'" + user.IsDriver + "')";
                SqlCommand user_command = new SqlCommand(User_insert_query, con);
                con.Open();
                user_command.ExecuteNonQuery();

                //inserting driver
                DriverReg driverReg = new DriverReg();
                driverReg.DriverID = new Random().Next();
                driverReg.Name = textBoxName.Text;
                driverReg.Address = textBoxAddress.Text;
                driverReg.DOB = dateTimePickerDOB.Value;
                driverReg.PhoneNO = textBoxPhoneNO.Text;
                if (radioButtonMale.Checked)
                {
                    driverReg.Gender = true;
                }
                else
                {
                    driverReg.Gender = false;
                }
                
                string insert_query = "INSERT INTO Driver VALUES( '" + driverReg.DriverID + "' , '" + driverReg.Name + "', '" + driverReg.DOB + "' , '" + driverReg.Address + "' , '" + driverReg.Gender + "' ,'"+user.UserID+"' ,'" + driverReg.PhoneNO + "' )";
                SqlCommand driver_command = new SqlCommand(insert_query, con);
                driver_command.ExecuteNonQuery();

                
                MessageBox.Show("Record Insertd Succesfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxName.Clear();
                textBoxAddress.Clear();
                textBoxPhoneNO.Clear();
            
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

        private void DriverRegForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhoneNO_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string load_quary = "Select * from Driver"; //load_quary is a variable name
                SqlCommand cmd = new SqlCommand(load_quary, con); //cmd is a name
                SqlDataAdapter da = new SqlDataAdapter(); // da is a shotr form of data adapter. it's also name
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridDriverView.DataSource = bsource;
                dataGridDriverView.ReadOnly = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error!");
            }
            finally 
            {
                con.Close();
 
            }
        }
    }
}
