using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_kinda
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            try
            {

                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=AdventureWorks2019;Integrated Security=True;"))
                {
                    conn.Open();

                    // Use SQL proc
                    using (SqlCommand command = new SqlCommand("GetPersonNames", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // a DataTable to hold the result
                        DataTable dataTable = new DataTable();

                        // Execute the proc
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            int personID = Convert.ToInt32(row["BusinessEntityID"]);
                            string fullName = $"{row["FirstName"]} {row["LastName"]}";

                            NameComboBox.Items.Add(new KeyValuePair<int, string>(personID, fullName));

                        }
                        // Only show full name, hide ID
                        NameComboBox.DisplayMember = "Value";
                        NameComboBox.ValueMember = "Key";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (NameComboBox.SelectedItem != null) // Makes sure a person is selected first
            {
                KeyValuePair<int, string> selectedPerson = (KeyValuePair<int, string>)NameComboBox.SelectedItem;
                int selectedPersonID = selectedPerson.Key;

                try
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=AdventureWorks2019;Integrated Security=True;"))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("GetPersonByName", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Add parameters
                            cmd.Parameters.Add(new SqlParameter("@BusinessEntityID", SqlDbType.Int) { Value = selectedPersonID });

                            // a DataTable to hold the result
                            DataTable dataTable = new DataTable();

                            // Execute the proc
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(dataTable);
                            }

                            foreach (DataRow row in dataTable.Rows)
                            {
                                // Makes the labels show the person's info
                                string details = $"{row["Title"]} {row["FirstName"]} {row["MiddleName"]} {row["LastName"]} {row["Suffix"]}  :  {row["ContactTypeName"]}";
                                string details2 = $"E-mail: {row["EmailAddress"]}  |  {row["PhoneName"]}: {row["PhoneNumber"]}";
                                string details3 = $"{row["AddressName"]} Address: {row["AddressLine1"]} {row["AddressLine2"]}, {row["City"]} {row["PostalCode"]}";
                                string details4 = $"{row["StateName"]}, {row["CountryName"]}";
                                SelectedLabel1.Text = details;
                                SelectedLabel2.Text = details2;
                                SelectedLabel3.Text = details3;
                                SelectedLabel4.Text = details4;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

    }
}
