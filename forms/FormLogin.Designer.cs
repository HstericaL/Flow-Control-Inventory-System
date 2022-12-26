namespace Flow_Control_Inventory_System.forms
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panelLeftTitle = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.panelLeftTitle.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.panelLeftTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(744, 30);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelLeftTitle
            // 
            this.panelLeftTitle.BackColor = System.Drawing.Color.White;
            this.panelLeftTitle.Controls.Add(this.ButtonExit);
            this.panelLeftTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLeftTitle.Location = new System.Drawing.Point(444, 0);
            this.panelLeftTitle.Name = "panelLeftTitle";
            this.panelLeftTitle.Size = new System.Drawing.Size(300, 30);
            this.panelLeftTitle.TabIndex = 0;
            this.panelLeftTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeftTitle_MouseDown);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe Fluent Icons", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Black;
            this.ButtonExit.Location = new System.Drawing.Point(270, 0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(30, 30);
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.Text = "";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.buttonLogin);
            this.panelRight.Controls.Add(this.labelPassword);
            this.panelRight.Controls.Add(this.textBoxPassword);
            this.panelRight.Controls.Add(this.labelUsername);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.textBoxUsername);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(444, 30);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(300, 421);
            this.panelRight.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(89, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "It\'s all under control.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(132)))), ((int)(((byte)(240)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Raleway SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(48, 315);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(215, 40);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Enabled = false;
            this.labelPassword.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.labelPassword.Location = new System.Drawing.Point(48, 197);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 18);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(48, 217);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(215, 23);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Enabled = false;
            this.labelUsername.Font = new System.Drawing.Font("Raleway", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.labelUsername.Location = new System.Drawing.Point(48, 130);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(72, 18);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(124, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log in";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(48, 150);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(215, 23);
            this.textBoxUsername.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.pictureBoxLogo);
            this.panelLeft.Controls.Add(this.labelSubtitle);
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 30);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(444, 421);
            this.panelLeft.TabIndex = 9;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Image = global::Flow_Control_Inventory_System.Properties.Resources.logo_120px;
            this.pictureBoxLogo.Location = new System.Drawing.Point(162, 110);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(120, 116);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSubtitle.Location = new System.Drawing.Point(153, 289);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(140, 22);
            this.labelSubtitle.TabIndex = 10;
            this.labelSubtitle.Text = "Inventory System";
            this.labelSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Raleway SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(115, 244);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(213, 44);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Flow Control";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(132)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(744, 451);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.panelTitleBar.ResumeLayout(false);
            this.panelLeftTitle.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelLeftTitle;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelTitle;
    }
}