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

namespace Flow_Control_Inventory_System.forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            //Initialize
            this.CenterToScreen();
            this.Size = new Size(1000, 600);    //Form default size
            this.Padding = new Padding(borderSize);     //Border padding
            this.BackColor = Color.FromArgb(52, 132, 240);    //Border color
        }

        //private variables
        private int borderSize = 2; //Border size

        //Open Child Form
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            childForm.Show();
        }

        //timerclock
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelDateDayTime.Text = DateTime.Now.ToString("dddd , MMM dd yyyy, hh:mm:ss");
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

        //make form draggable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //resizeform on maximize
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        private void FormMenu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        //button events
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Size = new Size(1000, 600);
                buttonMaximize.Text = ""; //Change to Windows logo
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                buttonMaximize.Text = ""; //Change to Maximize logo
            }
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Method for expanding a button
        private bool isSubMenuExpanded;
        private int subMenuHeight;
        private Panel currentPanel;
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (isSubMenuExpanded)
            {
                if (subMenuHeight < 100)
                {
                    subMenuHeight += 10;
                }
                else
                {
                    timerMenu.Stop();
                }
            }
            else
            {
                if (subMenuHeight > 0)
                {
                    subMenuHeight -= 10;
                }
                else
                {
                    timerMenu.Stop();
                }
            }
            currentPanel.Height = subMenuHeight;
        }

        // toggle panel
        private void toggleSubmenu(Panel panel)
        {
            if (panel != currentPanel)
            {
                currentPanel = panel;
                subMenuHeight = 0;
                isSubMenuExpanded = true;
            }
            else
            {
                isSubMenuExpanded = !isSubMenuExpanded;
            }
            timerMenu.Start();
        }

        // Panel buttons
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            //Set color of other button
            buttonCategoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
            buttonInventoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
            buttonOrderManagement.ForeColor = Color.FromArgb(100, 109, 119);
            buttonCustomerManagement.ForeColor = Color.FromArgb(100, 109, 119);
            buttonUserManagement.ForeColor = Color.FromArgb(100, 109, 119);

            //set color of current button
            buttonDashboard.ForeColor = Color.FromArgb(52, 132, 240);

            panelInventoryContainer.Height = 0;
            panelCategoryContainer.Height = 0;
            panelOrderContainer.Height = 0;
            panelUserContainer.Height = 0;
        }
        private void buttonInventoryManagement_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelInventoryContainer);
            //Close other panel if it is expanded
            if (currentPanel == panelInventoryContainer && isSubMenuExpanded)
            {
                //Set color of other button
                buttonCategoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonOrderManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonDashboard.ForeColor = Color.FromArgb(100, 109, 119);
                buttonCustomerManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonUserManagement.ForeColor = Color.FromArgb(100, 109, 119);

                //set color of current button
                buttonInventoryManagement.ForeColor = Color.FromArgb(52, 132, 240);

                panelOrderContainer.Height = 0;
                panelCategoryContainer.Height = 0;
                panelCustomerContainer.Height = 0;
                panelUserContainer.Height = 0;
            }
        }
        private void buttonCategoryManagement_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelCategoryContainer);
            //Close other panel if it is expanded
            if (currentPanel == panelCategoryContainer && isSubMenuExpanded)
            {
                //Set color of other button
                buttonInventoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonOrderManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonDashboard.ForeColor = Color.FromArgb(100, 109, 119);
                buttonCustomerManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonUserManagement.ForeColor = Color.FromArgb(100, 109, 119);

                //set color of current button
                buttonCategoryManagement.ForeColor = Color.FromArgb(52, 132, 240);

                panelOrderContainer.Height = 0;
                panelInventoryContainer.Height = 0;
                panelCustomerContainer.Height = 0;
                panelUserContainer.Height = 0;
            }
        }
        private void buttonOrderManagement_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelOrderContainer);
            //Close other panel if it is expanded
            if (currentPanel == panelOrderContainer && isSubMenuExpanded)
            {
                //Set color of other button
                buttonCategoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonInventoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonDashboard.ForeColor = Color.FromArgb(100, 109, 119);
                buttonCustomerManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonUserManagement.ForeColor = Color.FromArgb(100, 109, 119);

                //set color of current button
                buttonOrderManagement.ForeColor = Color.FromArgb(52, 132, 240);

                panelInventoryContainer.Height = 0;
                panelCategoryContainer.Height = 0;
                panelCustomerContainer.Height = 0;
                panelUserContainer.Height = 0;
            }
        }
        private void buttonCustomerManagement_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelCustomerContainer);
            //Close other panel if it is expanded
            if (currentPanel == panelCustomerContainer && isSubMenuExpanded)
            {
                //Set color of other button
                buttonCategoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonInventoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonDashboard.ForeColor = Color.FromArgb(100, 109, 119);
                buttonOrderManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonUserManagement.ForeColor = Color.FromArgb(100, 109, 119);

                //set color of current button
                buttonCustomerManagement.ForeColor = Color.FromArgb(52, 132, 240);

                panelInventoryContainer.Height = 0;
                panelCategoryContainer.Height = 0;
                panelOrderContainer.Height = 0;
                panelUserContainer.Height = 0;
            }
        }
        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelUserContainer);
            //Close other panel if it is expanded
            if (currentPanel == panelUserContainer && isSubMenuExpanded)
            {
                //Set color of other button
                buttonCategoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonInventoryManagement.ForeColor = Color.FromArgb(100, 109, 119);
                buttonDashboard.ForeColor = Color.FromArgb(100, 109, 119);
                buttonOrderManagement.ForeColor = Color.FromArgb(100, 109, 119);

                //set color of current button
                buttonUserManagement.ForeColor = Color.FromArgb(52, 132, 240);

                panelInventoryContainer.Height = 0;
                panelCategoryContainer.Height = 0;
                panelOrderContainer.Height = 0;
                panelCustomerContainer.Height = 0;
            }
        }

        // Sub-buttons
        private void buttonShowProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new FormInventory());
        }
        private void buttonShowCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCategory());
        }
        private void buttonShowUsers_Click(object sender, EventArgs e)
        {
            openChildForm(new FormUsers());
        }

        // Sign-out user button
        private void buttonSignout_Click(object sender, EventArgs e)
        {
            // prompt the user before signing out
            DialogResult result = MessageBox.Show("Are you sure you want to sign out?", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Close();
            }
            else
            {
                // do nothing
            }
        }


    }
}
