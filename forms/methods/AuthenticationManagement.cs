using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Flow_Control_Inventory_System.forms.methods
{
    internal class AuthenticationManagement
    {
        // Register User - FormLogin
        public void RegisterUser(string username, string password)
        {
            // Hash the password using SHA-256
            byte[] hash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
            string hashedPassword = BitConverter.ToString(hash).Replace("-", "").ToLower();

            // Connect to the database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\database\\FlowControl-DB.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // create a sql query to insert new record into authentication table
                string query = "INSERT INTO users (user_name, user_password) VALUES (@username, @password)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", hashedPassword);

                    // execute query
                    command.ExecuteNonQuery();
                    MessageBox.Show("User registered successfuly");
                }
            }
        }

        //Login User - FormLogin
        public bool LoginUser(string username, string password)
        {
            // Hash the password using SHA-256
            byte[] hash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
            string hashedPassword = BitConverter.ToString(hash).Replace("-", "").ToLower();

            Console.WriteLine("Username: "+ username);
            Console.WriteLine("Password: " + hashedPassword);

            // Connect to the database
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\database\\FlowControl-DB.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE (user_name = @username) AND (user_password = @password)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", hashedPassword);

                    OleDbDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
