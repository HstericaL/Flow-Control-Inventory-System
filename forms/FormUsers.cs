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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flowControl_DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.flowControl_DataSet.users);

        }
    }
}
