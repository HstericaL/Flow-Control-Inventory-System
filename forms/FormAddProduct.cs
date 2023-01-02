using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Web;
using System.Runtime.InteropServices;

namespace Flow_Control_Inventory_System.forms
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
            LoadComboBox();
        }

        // button submit to access database
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // user input
            string productid = textBoxProductID.Text;
            string brand = textBoxBrand.Text;
            string description = textBoxDescription.Text;
            string category = comboBoxCategory.Text;
            string price = textBoxPrice.Text;
            string quantity = textBoxQuanity.Text;

            // connection
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\database\\FlowControl-DB.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO inventory (product_id, product_brand, product_description, category_name, product_price,product_quantity) VALUES (@productid, @brand, @description, @category, @price, @quanity)";
                OleDbCommand command= new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@productid", productid);
                command.Parameters.AddWithValue("@brand", brand);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@quantity", quantity);

                command.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully!");
            }
        }

        // load combo box
        private void LoadComboBox()
        {
            // Connect to the database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\database\\FlowControl-DB.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM category";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader= command.ExecuteReader();

                while (reader.Read())
                {
                    string item = reader["category_name"].ToString();
                    comboBoxCategory.Items.Add(item);
                }
            }
        }


    }

}
