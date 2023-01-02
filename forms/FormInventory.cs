using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flow_Control_Inventory_System.forms
{
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();

            timer.Interval= 1000;
            timer.Tick += FormInventory_Load;
            timer.Start();
        }

        Timer timer = new Timer();

        private void FormInventory_Load(object sender, EventArgs e)
        {
            // load data to datagridview
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\database\\FlowControl-DB.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM inventory";
                OleDbCommand command= new OleDbCommand(query, connection);
                OleDbDataAdapter adapter= new OleDbDataAdapter(command);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                dataGridViewInventory.DataSource= datatable;
            }
        }
    }
}
