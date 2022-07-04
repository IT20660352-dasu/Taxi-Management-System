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

namespace RiderReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-U88I4AMS\SQLEXPRESSKD;Initial Catalog=TAXI;Integrated Security=True"); 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                RiderRegClass riderRegClass = new RiderRegClass();
                riderRegClass.Name = textBoxName.Text;
                riderRegClass.Address = textBoxAddress.Text;
                riderRegClass.DOF = dateTimePickerDOF.Value;
                riderRegClass.PhoneNo = textBoxPhoneNo.Text;
                //riderRegClass.Male = radioButtonMale.Text;
                //riderRegClass.Female = radioButtonFemale.Text;

                string insert_query = "INSERT INTO DriverReg VALUES ( '" + new Random().Next() + "', '" + riderRegClass.Name + "' , '" + riderRegClass.Address + "' , '" + riderRegClass.DOF + "' , '" + riderRegClass.PhoneNo + "' )"; //  insert valuse to driver reg data base
                SqlCommand command = new SqlCommand(insert_query, con);
                con.Open();
                command.ExecuteNonQuery();
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
    }
}
