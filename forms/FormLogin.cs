using Flow_Control_Inventory_System.forms.methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flow_Control_Inventory_System.forms.methods;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace Flow_Control_Inventory_System.forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //Initialize
            this.Size = new Size(744, 451);
            this.CenterToScreen();
        }

        //Remove Title-Bar
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0083 && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        //Make form draggable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelLeftTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //events
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Get the username, password, and role from the input fields
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Connect to database - LoginUser
            AuthenticationManagement authentication = new AuthenticationManagement();
            if (authentication.LoginUser(username, password))
            {
                MessageBox.Show(username + " logged in successfully!" );

                // show FormMain
                FormMenu formMenu = new FormMenu();
                formMenu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
                textBoxPassword.Clear();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Get the username, password, and role from the input fields
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Connect to database - RegisterUser
            AuthenticationManagement authentication = new AuthenticationManagement();
            authentication.RegisterUser(username, password);
        }
    }
}
