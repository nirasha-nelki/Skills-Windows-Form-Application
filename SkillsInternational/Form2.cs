using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SkillsInternational
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=NELKI\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False"); // Initialize the SqlConnection field in the constructor

            populateComboBox();

        }



        private void btn_reg_Click(object sender, EventArgs e)
        {
            String fName = txt_fname.Text;
            String lName = txt_lname.Text;
            DateTime dt = dob.Value.Date;
            String gender;

            if (radio_male.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }

            String address = txt_address.Text;
            String email = txt_email.Text;
            int mobilePhone = int.Parse(txt_mobile.Text);
            int homePhone = int.Parse(txt_home.Text);
            String parentName = txt_parent_name.Text;
            String nic = txt_nic.Text;
            long parentContat = int.Parse(txt_parent_contact.Text);


            try
            {
                con.Open();
                String query = "INSERT INTO [Registration] (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) " +
                    "VALUES(@fName, @lName, @dob, @gender, @address, @email, @mobile, @home, @parentName, @nic, @contactNo);";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@fname", fName);
                cmd.Parameters.AddWithValue("@lName", lName);
                cmd.Parameters.AddWithValue("@dob", dt);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobile", mobilePhone);
                cmd.Parameters.AddWithValue("@home", homePhone);
                cmd.Parameters.AddWithValue("@parentName", parentName);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@contactNo", parentContat);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Query executed successfully and affected one or more rows
                    MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_fname.Clear();
                    txt_lname.Clear();
                    dob.Value = DateTime.Today;
                    txt_address.Clear();
                    txt_email.Clear();
                    txt_mobile.Clear();
                    txt_home.Clear();
                    txt_parent_name.Clear();
                    txt_nic.Clear();
                    txt_parent_contact.Clear();

                    if (radio_male.Checked)
                    {
                        radio_male.Checked = false;
                    }
                    else
                    {
                        radio_female.Checked = false;
                    }

                    //populateComboBox();
                }
                else
                {
                    // Query executed successfully but did not affect any rows
                    MessageBox.Show("No records inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Exception occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
        }

        private void cmb_reg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_reg.SelectedIndex != -1)
            {
                // An item is selected in the ComboBox
                String selectedValue = cmb_reg.SelectedItem.ToString();
                Console.WriteLine(selectedValue);

                try
                {
                    con.Open();
                    String query = "SELECT * FROM [Registration] WHERE RegNo = @regNo;";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@regNo", selectedValue);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txt_fname.Text = reader["firstName"].ToString();
                        txt_lname.Text = reader["lastName"].ToString();
                        dob.Value = (DateTime)reader["dateOfBirth"];

                        if (reader["gender"].ToString() == "male")
                        {
                            radio_male.Checked = true;
                            radio_female.Checked = false;
                        }
                        else
                        {
                            radio_female.Checked = true;
                            radio_male.Checked = false;
                        }

                        txt_address.Text = reader["address"].ToString();
                        txt_nic.Text = reader["nic"].ToString();
                        txt_email.Text = reader["email"].ToString();

                        txt_mobile.Text = reader["mobilePhone"].ToString();
                        txt_home.Text = reader["homePhone"].ToString();

                        txt_parent_name.Text = reader["parentName"].ToString();
                        txt_parent_contact.Text = reader["contactNo"].ToString();

                        


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                // No item is selected in the ComboBox
                MessageBox.Show("Please select an item from the ComboBox.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int regNo = int.Parse(cmb_reg.SelectedItem.ToString());
            String fName = txt_fname.Text;
            String lName = txt_lname.Text;
            DateTime dt = dob.Value.Date;
            String gender;

            if (radio_male.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }

            String address = txt_address.Text;
            String email = txt_email.Text;
            int mobilePhone = int.Parse(txt_mobile.Text);
            int homePhone = int.Parse(txt_home.Text);
            String parentName = txt_parent_name.Text;
            String nic = txt_nic.Text;
            int parentContat = int.Parse(txt_parent_contact.Text);


            try
            {
                con.Open();
                String query = "UPDATE [Registration] SET firstName=@fname, lastName=@lname, dateOfBirth=@dob, gender=@gender, address=@address, email=@email, mobilePhone=@mobile, homePhone=@home, parentName=@parentName, nic=@nic, contactNo=@contactNo " +
                    "WHERE RegNo=@regNo;";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@fname", fName);
                cmd.Parameters.AddWithValue("@lName", lName);
                cmd.Parameters.AddWithValue("@dob", dt);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobile", mobilePhone);
                cmd.Parameters.AddWithValue("@home", homePhone);
                cmd.Parameters.AddWithValue("@parentName", parentName);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@contactNo", parentContat);
                cmd.Parameters.AddWithValue("@regNo", regNo);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Query executed successfully and affected one or more rows
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_fname.Clear();
                    txt_lname.Clear();
                    dob.Value = DateTime.Today;
                    txt_address.Clear();
                    txt_email.Clear();
                    txt_mobile.Clear();
                    txt_home.Clear();
                    txt_parent_name.Clear();
                    txt_nic.Clear();
                    txt_parent_contact.Clear();

                    if (radio_male.Checked)
                    {
                        radio_male.Checked = false;
                    }
                    else
                    {
                        radio_female.Checked = false;
                    }

                    //populateComboBox();
                }
                else
                {
                    // Query executed successfully but did not affect any rows
                    MessageBox.Show("No records inserted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Exception occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cmb_reg.SelectedIndex != -1)
            {
                int regNo = int.Parse(cmb_reg.SelectedItem.ToString());

                // Display confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();

                        string query = "DELETE FROM [Registration] WHERE regNo = @regNo";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@regNo", regNo);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txt_fname.Clear();
                            txt_lname.Clear();
                            dob.Value = DateTime.Today;
                            txt_address.Clear();
                            txt_email.Clear();
                            txt_mobile.Clear();
                            txt_home.Clear();
                            txt_parent_name.Clear();
                            txt_nic.Clear();
                            txt_parent_contact.Clear();

                            if (radio_male.Checked)
                            {
                                radio_male.Checked = false;
                            }
                            else
                            {
                                radio_female.Checked = false;
                            }

                            //populateComboBox();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the selected registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                // If the user selects "No" or closes the message box, do nothing
            }
            /*else
            {
                MessageBox.Show("Please select an item from the ComboBox.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void populateComboBox()
        {
            cmb_reg.SelectedIndex = -1;
            try
            {
                con.Open();

                string query = "SELECT regNo FROM [Registration]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // cmb_reg.Items.Add("Select reg No");
                    int regNo = int.Parse(reader["regNo"].ToString());
                    cmb_reg.Items.Add(regNo);
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Exception occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Close the connection if it's still open
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            dob.Value = DateTime.Today;
            txt_address.Clear();
            txt_email.Clear();
            txt_mobile.Clear();
            txt_home.Clear();
            txt_parent_name.Clear();
            txt_nic.Clear();
            txt_parent_contact.Clear();

            if (radio_male.Checked)
            {
                radio_male.Checked = false;
            }
            else
            {
                radio_female.Checked = false;
            }

            cmb_reg.SelectedIndex = -1;
        }

        private void linklabel_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // User clicked Yes, so exit the application
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
