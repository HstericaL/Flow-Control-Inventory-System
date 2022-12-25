using System.Runtime.InteropServices;

namespace FlowControlInventorySystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            
            //Initialize
            this.Size = new Size(760, 490);
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
        private void PanelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Methods
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ButtonLogin_MouseClick(object sender, MouseEventArgs e)
        {
            if (TextBoxUsername.Text == "admin" && TextBoxPassword.Text == "admin")
            {
                MessageBox.Show("Administrator logged in", "Alert");

                //Open dashboard form and close login form
                FormMainMenu formDashboard = new FormMainMenu();
                this.Hide();
                formDashboard.ShowDialog();
                this.Close();
            }
            else
            {
                TextBoxPassword.Text = "";
                MessageBox.Show("Wrong username or password.", "Alert");
            }
        }
    }
}