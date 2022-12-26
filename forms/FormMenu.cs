﻿using System;
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
        private bool isSubmenuExpanded;
        private int subMenuHeight;
        private Button currentButton;

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (isSubmenuExpanded)
            {
                if (subMenuHeight < 100)
                {
                    subMenuHeight += 10;
                } else
                {
                    timerMenu.Stop();
                }
            } else
            {
                if(subMenuHeight > 0)
                {
                    subMenuHeight -= 10;
                } else
                {
                    timerMenu.Stop();
                }
            }
            panelInventoryContainer.Height = subMenuHeight;
        }
        private void toggleSubmenu(Button button)
        {
            if (currentButton != button)
            {
                currentButton = button;
                timerMenu.Start();
                isSubmenuExpanded = true;
            } else
            {
                timerMenu.Start();
                isSubmenuExpanded = !isSubmenuExpanded; 
            }
        }

        private void buttonInventoryManagement_Click(object sender, EventArgs e)
        {
            toggleSubmenu((Button) sender);
        }
    }
}