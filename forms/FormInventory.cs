using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flowControl_DataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.flowControl_DataSet.inventory);

        }
    }
}
