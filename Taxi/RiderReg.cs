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
    public partial class RiderReg : Form
    {
        public RiderReg()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U88I4AMS\SQLEXPRESSKD;Initial Catalog=TAXI;Integrated Security=True");
        bool passwordshow = false;
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(); //inserting User Name and password to the Driver regForm
                user.UserID = new Random().Next(); //auto genarating UserID 
                user.UserName = textBoxUserName.Text;
                user.Password = textBoxPassword.Text;
                user.IsDriver = false;
                string User_insert_query = "INSERT INTO [User] VALUES( '" + user.UserID + "','" + user.UserName + "','" + user.Password + "' ,'" + user.IsDriver + "')";
                SqlCommand user_command = new SqlCommand(User_insert_query, con);
                con.Open();
                user_command.ExecuteNonQuery();

                RiderRegClass riderRegClass = new RiderRegClass();
                riderRegClass.RiderID = new Random().Next();
                riderRegClass.Name = textBoxName.Text;
                riderRegClass.Address = textBoxAddress.Text;
                riderRegClass.DOB = dateTimePickerDOB.Value;
                riderRegClass.PhoneNo = textBoxPhoneNo.Text;
                if (radioButtonMale.Checked)
                {
                    riderRegClass.Gender = true;
                }
                else
                {
                    riderRegClass.Gender = false;
                }

                string Rider_insert_query = "INSERT INTO Rider VALUES ( '" + riderRegClass.RiderID + "', '" + riderRegClass.Name + "' , '" + riderRegClass.DOB + "' , '" + riderRegClass.Address + "' , '" + riderRegClass.Gender + "','" + user.UserID + "','" + riderRegClass.PhoneNo + "' )"; //  insert valuse to driver reg data base
                SqlCommand rider_command = new SqlCommand(Rider_insert_query, con);
                rider_command.ExecuteNonQuery();
                MessageBox.Show("Record inserted succsesfully", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxName.Clear();
                textBoxAddress.Clear();
                textBoxPhoneNo.Clear();
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string load_quary = "Select * from Rider"; //load_quary is a variable name
                SqlCommand cmd = new SqlCommand(load_quary, con); //cmd is a name
                SqlDataAdapter da = new SqlDataAdapter(); // da is a shotr form of data adapter. it's also name
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridRiderView.DataSource = bsource;
                dataGridRiderView.ReadOnly = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }
            finally
            {
                con.Close();
            }
        }


        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (passwordshow == false)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                passwordshow = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                passwordshow = false;

            }
        }

        private void buttonAGE_Click(object sender, EventArgs e)
        {
            //RiderRegClass riderRegClass = new RiderRegClass();
            //riderRegClass.DOB = dateTimePickerDOB.Value;
        }
    }
}