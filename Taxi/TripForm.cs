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
    public partial class TripForm : Form
    {
        public TripForm()
        {
            InitializeComponent();
            FillDriverDropDown();
            FillRiderDropDown();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U88I4AMS\SQLEXPRESSKD;Initial Catalog=TAXI;Integrated Security=True");
        public void FillDriverDropDown() // void can't retrun any data type. It's only working on this content 
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                string select_quary = "SELECT DriverID,Name FROM Driver "; //We have only two columns from drop down list. It is a rule
                SqlCommand command = new SqlCommand(select_quary, con);
                dt.Load(command.ExecuteReader());
                comboBoxDriver.DataSource = dt;
                comboBoxDriver.ValueMember = "DriverID"; //USER can't see this
                comboBoxDriver.DisplayMember = "Name"; // User can only see this one
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
        public void FillRiderDropDown() 
        {

            try
            {
                DataTable dt = new DataTable();
                con.Open();
                string rider_select_quary = "SELECT RiderID,Name FROM Rider "; //We have only two columns from drop down list. It is a rule
                SqlCommand command = new SqlCommand(rider_select_quary, con);
                dt.Load(command.ExecuteReader());
                comboBoxRider.DataSource = dt;
                comboBoxRider.ValueMember = "RiderID"; //USER can't see this
                comboBoxRider.DisplayMember = "Name"; // User can only see this one
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
                string load_quary = "Select Driver.Name as [Driver Name], Rider.Name as [Rider Name], Trip.PickUpLocation, Trip.DropLocation from Trip Join Driver on Driver.DriverID = Trip.DriverID Join Rider on Rider.RiderID = Trip.RiderID "; //load_quary is a variable name
                SqlCommand cmd = new SqlCommand(load_quary, con); //cmd is a name
                SqlDataAdapter da = new SqlDataAdapter(); // da is a short form of data adapter. it's also name
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridViewTrip.DataSource = bsource;
                dataGridViewTrip.ReadOnly = true;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                TripClass tripClass = new TripClass();
                tripClass.TripID = new Random().Next();
                tripClass.PickUpLocation = textBoxPickUpLocation.Text;
                tripClass.DropLocation = textBoxDropLocation.Text;
                tripClass.Fair = Convert.ToDecimal(textBoxFar.Text);

                string insert_query = "INSERT INTO Trip VALUES( '" + tripClass.TripID + "' , '" + comboBoxDriver.SelectedValue + "',  '" + comboBoxRider.SelectedValue + "',  '" + tripClass.PickUpLocation + "',  '" + tripClass.DropLocation + "', '" + tripClass.Fair + "')";
                SqlCommand trip_command = new SqlCommand(insert_query, con);
                con.Open();
                trip_command.ExecuteNonQuery();


                MessageBox.Show("Record Insertd Succesfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBoxPickUpLocation.Clear();
                textBoxDropLocation.Clear();
                textBoxFar.Clear();
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
