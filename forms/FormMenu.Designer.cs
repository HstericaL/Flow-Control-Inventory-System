namespace Flow_Control_Inventory_System.forms
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelParent = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelSignoutContainer = new System.Windows.Forms.Panel();
            this.buttonSignout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInventoryContainer = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonInventoryManagement = new System.Windows.Forms.Button();
            this.panelCategoryContainer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonCategoryManagement = new System.Windows.Forms.Button();
            this.panelOrderContainer = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonOrderManagement = new System.Windows.Forms.Button();
            this.panelDashboardContainer = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolRemoveProduct = new System.Windows.Forms.ToolStripButton();
            this.toolAddProduct = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRemoveCategory = new System.Windows.Forms.ToolStripButton();
            this.toolAddCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRemoveOrder = new System.Windows.Forms.ToolStripButton();
            this.toolAddOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRemoveCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolAddCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDateDayTime = new System.Windows.Forms.Label();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panelParent.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelSignoutContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelInventoryContainer.SuspendLayout();
            this.panelCategoryContainer.SuspendLayout();
            this.panelOrderContainer.SuspendLayout();
            this.panelDashboardContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.toolStripTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelParent
            // 
            this.panelParent.Controls.Add(this.panelChild);
            this.panelParent.Controls.Add(this.panelLeft);
            this.panelParent.Controls.Add(this.toolStripTop);
            this.panelParent.Controls.Add(this.panel1);
            this.panelParent.Controls.Add(this.panelTitlebar);
            this.panelParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParent.Location = new System.Drawing.Point(0, 0);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(984, 561);
            this.panelParent.TabIndex = 0;
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(250, 70);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(734, 461);
            this.panelChild.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Controls.Add(this.panelSignoutContainer);
            this.panelLeft.Controls.Add(this.flowLayoutPanel1);
            this.panelLeft.Controls.Add(this.panelDashboardContainer);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 70);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 461);
            this.panelLeft.TabIndex = 3;
            // 
            // panelSignoutContainer
            // 
            this.panelSignoutContainer.Controls.Add(this.buttonSignout);
            this.panelSignoutContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSignoutContainer.Location = new System.Drawing.Point(0, 436);
            this.panelSignoutContainer.Name = "panelSignoutContainer";
            this.panelSignoutContainer.Size = new System.Drawing.Size(250, 25);
            this.panelSignoutContainer.TabIndex = 1;
            // 
            // buttonSignout
            // 
            this.buttonSignout.BackColor = System.Drawing.Color.White;
            this.buttonSignout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSignout.FlatAppearance.BorderSize = 0;
            this.buttonSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignout.Font = new System.Drawing.Font("Raleway SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.buttonSignout.Location = new System.Drawing.Point(0, 0);
            this.buttonSignout.Name = "buttonSignout";
            this.buttonSignout.Size = new System.Drawing.Size(250, 25);
            this.buttonSignout.TabIndex = 1;
            this.buttonSignout.Text = "Signout";
            this.buttonSignout.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panelInventoryContainer);
            this.flowLayoutPanel1.Controls.Add(this.panelCategoryContainer);
            this.flowLayoutPanel1.Controls.Add(this.panelOrderContainer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 125);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(250, 280);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(250, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 105);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelInventoryContainer
            // 
            this.panelInventoryContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelInventoryContainer.Controls.Add(this.button4);
            this.panelInventoryContainer.Controls.Add(this.button3);
            this.panelInventoryContainer.Controls.Add(this.button2);
            this.panelInventoryContainer.Controls.Add(this.buttonInventoryManagement);
            this.panelInventoryContainer.Location = new System.Drawing.Point(0, 0);
            this.panelInventoryContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelInventoryContainer.MaximumSize = new System.Drawing.Size(250, 100);
            this.panelInventoryContainer.MinimumSize = new System.Drawing.Size(250, 25);
            this.panelInventoryContainer.Name = "panelInventoryContainer";
            this.panelInventoryContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelInventoryContainer.Size = new System.Drawing.Size(250, 25);
            this.panelInventoryContainer.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.button4.Location = new System.Drawing.Point(0, 75);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(250, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Remove Product";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.button3.Location = new System.Drawing.Point(0, 50);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Product";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.button2.Location = new System.Drawing.Point(0, 25);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(250, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Product";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonInventoryManagement
            // 
            this.buttonInventoryManagement.BackColor = System.Drawing.Color.White;
            this.buttonInventoryManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInventoryManagement.FlatAppearance.BorderSize = 0;
            this.buttonInventoryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryManagement.Font = new System.Drawing.Font("Raleway SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventoryManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.buttonInventoryManagement.Location = new System.Drawing.Point(0, 0);
            this.buttonInventoryManagement.Name = "buttonInventoryManagement";
            this.buttonInventoryManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonInventoryManagement.Size = new System.Drawing.Size(250, 25);
            this.buttonInventoryManagement.TabIndex = 0;
            this.buttonInventoryManagement.Text = "Inventory Management";
            this.buttonInventoryManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventoryManagement.UseVisualStyleBackColor = false;
            this.buttonInventoryManagement.Click += new System.EventHandler(this.buttonInventoryManagement_Click);
            // 
            // panelCategoryContainer
            // 
            this.panelCategoryContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelCategoryContainer.Controls.Add(this.button1);
            this.panelCategoryContainer.Controls.Add(this.button5);
            this.panelCategoryContainer.Controls.Add(this.button6);
            this.panelCategoryContainer.Controls.Add(this.buttonCategoryManagement);
            this.panelCategoryContainer.Location = new System.Drawing.Point(0, 35);
            this.panelCategoryContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelCategoryContainer.MaximumSize = new System.Drawing.Size(250, 100);
            this.panelCategoryContainer.MinimumSize = new System.Drawing.Size(250, 25);
            this.panelCategoryContainer.Name = "panelCategoryContainer";
            this.panelCategoryContainer.Size = new System.Drawing.Size(250, 25);
            this.panelCategoryContainer.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.button1.Location = new System.Drawing.Point(0, 75);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove Category";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.button5.Location = new System.Drawing.Point(0, 50);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(250, 25);
            this.button5.TabIndex = 2;
            this.button5.Text = "Add Category";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.button6.Location = new System.Drawing.Point(0, 25);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(250, 25);
            this.button6.TabIndex = 1;
            this.button6.Text = "Show Categories";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // buttonCategoryManagement
            // 
            this.buttonCategoryManagement.BackColor = System.Drawing.Color.White;
            this.buttonCategoryManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCategoryManagement.FlatAppearance.BorderSize = 0;
            this.buttonCategoryManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategoryManagement.Font = new System.Drawing.Font("Raleway SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategoryManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.buttonCategoryManagement.Location = new System.Drawing.Point(0, 0);
            this.buttonCategoryManagement.Name = "buttonCategoryManagement";
            this.buttonCategoryManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonCategoryManagement.Size = new System.Drawing.Size(250, 25);
            this.buttonCategoryManagement.TabIndex = 0;
            this.buttonCategoryManagement.Text = "Category Management";
            this.buttonCategoryManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategoryManagement.UseVisualStyleBackColor = false;
            this.buttonCategoryManagement.Click += new System.EventHandler(this.buttonCategoryManagement_Click);
            // 
            // panelOrderContainer
            // 
            this.panelOrderContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.panelOrderContainer.Controls.Add(this.button8);
            this.panelOrderContainer.Controls.Add(this.button9);
            this.panelOrderContainer.Controls.Add(this.button10);
            this.panelOrderContainer.Controls.Add(this.buttonOrderManagement);
            this.panelOrderContainer.Location = new System.Drawing.Point(0, 70);
            this.panelOrderContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelOrderContainer.MaximumSize = new System.Drawing.Size(250, 100);
            this.panelOrderContainer.MinimumSize = new System.Drawing.Size(250, 25);
            this.panelOrderContainer.Name = "panelOrderContainer";
            this.panelOrderContainer.Size = new System.Drawing.Size(250, 25);
            this.panelOrderContainer.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.button8.Location = new System.Drawing.Point(0, 75);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(250, 25);
            this.button8.TabIndex = 3;
            this.button8.Text = "Remove Order";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.button9.Location = new System.Drawing.Point(0, 50);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(250, 25);
            this.button9.TabIndex = 2;
            this.button9.Text = "Add Order";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.button10.Location = new System.Drawing.Point(0, 25);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(250, 25);
            this.button10.TabIndex = 1;
            this.button10.Text = "Show Orders";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // buttonOrderManagement
            // 
            this.buttonOrderManagement.BackColor = System.Drawing.Color.White;
            this.buttonOrderManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrderManagement.FlatAppearance.BorderSize = 0;
            this.buttonOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderManagement.Font = new System.Drawing.Font("Raleway SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.buttonOrderManagement.Location = new System.Drawing.Point(0, 0);
            this.buttonOrderManagement.Name = "buttonOrderManagement";
            this.buttonOrderManagement.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonOrderManagement.Size = new System.Drawing.Size(250, 25);
            this.buttonOrderManagement.TabIndex = 0;
            this.buttonOrderManagement.Text = "Order Management";
            this.buttonOrderManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrderManagement.UseVisualStyleBackColor = false;
            this.buttonOrderManagement.Click += new System.EventHandler(this.buttonOrderManagement_Click);
            // 
            // panelDashboardContainer
            // 
            this.panelDashboardContainer.Controls.Add(this.buttonDashboard);
            this.panelDashboardContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDashboardContainer.Location = new System.Drawing.Point(0, 75);
            this.panelDashboardContainer.Name = "panelDashboardContainer";
            this.panelDashboardContainer.Size = new System.Drawing.Size(250, 50);
            this.panelDashboardContainer.TabIndex = 0;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.White;
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Raleway SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(132)))), ((int)(((byte)(240)))));
            this.buttonDashboard.Location = new System.Drawing.Point(0, 0);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(250, 50);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 75);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(84, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Inventory System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(82)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Form Control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Image = global::Flow_Control_Inventory_System.Properties.Resources.logo_120px;
            this.pictureBoxLogo.Location = new System.Drawing.Point(19, 15);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // toolStripTop
            // 
            this.toolStripTop.AutoSize = false;
            this.toolStripTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.toolStripTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRemoveProduct,
            this.toolAddProduct,
            this.toolStripSeparator1,
            this.toolRemoveCategory,
            this.toolAddCategory,
            this.toolStripSeparator2,
            this.toolRemoveOrder,
            this.toolAddOrder,
            this.toolStripSeparator3,
            this.toolRemoveCustomer,
            this.toolAddCustomer,
            this.toolStripSeparator4});
            this.toolStripTop.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripTop.Location = new System.Drawing.Point(0, 30);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripTop.Size = new System.Drawing.Size(984, 40);
            this.toolStripTop.TabIndex = 2;
            this.toolStripTop.Text = "toolStripTop";
            // 
            // toolRemoveProduct
            // 
            this.toolRemoveProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRemoveProduct.Image = global::Flow_Control_Inventory_System.Properties.Resources.package_cancelled_icon;
            this.toolRemoveProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemoveProduct.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolRemoveProduct.Name = "toolRemoveProduct";
            this.toolRemoveProduct.Size = new System.Drawing.Size(23, 20);
            this.toolRemoveProduct.Text = "Remove Product";
            // 
            // toolAddProduct
            // 
            this.toolAddProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddProduct.Image = global::Flow_Control_Inventory_System.Properties.Resources.package_add_icon;
            this.toolAddProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddProduct.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolAddProduct.Name = "toolAddProduct";
            this.toolAddProduct.Size = new System.Drawing.Size(23, 20);
            this.toolAddProduct.Text = "Add Product";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolRemoveCategory
            // 
            this.toolRemoveCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRemoveCategory.Image = global::Flow_Control_Inventory_System.Properties.Resources.remove_category_icon;
            this.toolRemoveCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemoveCategory.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolRemoveCategory.Name = "toolRemoveCategory";
            this.toolRemoveCategory.Size = new System.Drawing.Size(23, 20);
            this.toolRemoveCategory.Text = "Remove Category";
            // 
            // toolAddCategory
            // 
            this.toolAddCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddCategory.Image = global::Flow_Control_Inventory_System.Properties.Resources.add_category_icon;
            this.toolAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddCategory.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolAddCategory.Name = "toolAddCategory";
            this.toolAddCategory.Size = new System.Drawing.Size(23, 20);
            this.toolAddCategory.Text = "Add Category";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolRemoveOrder
            // 
            this.toolRemoveOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRemoveOrder.Image = global::Flow_Control_Inventory_System.Properties.Resources.remove_from_cart_icon;
            this.toolRemoveOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemoveOrder.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolRemoveOrder.Name = "toolRemoveOrder";
            this.toolRemoveOrder.Size = new System.Drawing.Size(23, 20);
            this.toolRemoveOrder.Text = "Remove Order";
            // 
            // toolAddOrder
            // 
            this.toolAddOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddOrder.Image = global::Flow_Control_Inventory_System.Properties.Resources.add_item_in_cart_icon;
            this.toolAddOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddOrder.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolAddOrder.Name = "toolAddOrder";
            this.toolAddOrder.Size = new System.Drawing.Size(23, 20);
            this.toolAddOrder.Text = "Add Order";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // toolRemoveCustomer
            // 
            this.toolRemoveCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRemoveCustomer.Image = global::Flow_Control_Inventory_System.Properties.Resources.remove_user_icon;
            this.toolRemoveCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemoveCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolRemoveCustomer.Name = "toolRemoveCustomer";
            this.toolRemoveCustomer.Size = new System.Drawing.Size(23, 20);
            this.toolRemoveCustomer.Text = "Remove Customer";
            // 
            // toolAddCustomer
            // 
            this.toolAddCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAddCustomer.Image = global::Flow_Control_Inventory_System.Properties.Resources.add_user_icon;
            this.toolAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAddCustomer.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolAddCustomer.Name = "toolAddCustomer";
            this.toolAddCustomer.Size = new System.Drawing.Size(23, 20);
            this.toolAddCustomer.Text = "Add Customer";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(132)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.labelDateDayTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 531);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 30);
            this.panel1.TabIndex = 1;
            // 
            // labelDateDayTime
            // 
            this.labelDateDayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateDayTime.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDayTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelDateDayTime.Location = new System.Drawing.Point(0, 4);
            this.labelDateDayTime.Name = "labelDateDayTime";
            this.labelDateDayTime.Size = new System.Drawing.Size(984, 23);
            this.labelDateDayTime.TabIndex = 0;
            this.labelDateDayTime.Text = "Monday, April 25 2022, 10:30:01";
            this.labelDateDayTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(132)))), ((int)(((byte)(240)))));
            this.panelTitlebar.Controls.Add(this.buttonMinimize);
            this.panelTitlebar.Controls.Add(this.buttonMaximize);
            this.panelTitlebar.Controls.Add(this.buttonExit);
            this.panelTitlebar.Controls.Add(this.labelTitle);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(984, 30);
            this.panelTitlebar.TabIndex = 0;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F);
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(894, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(30, 30);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.Text = "";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F);
            this.buttonMaximize.ForeColor = System.Drawing.Color.White;
            this.buttonMaximize.Location = new System.Drawing.Point(924, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(30, 30);
            this.buttonMaximize.TabIndex = 1;
            this.buttonMaximize.Text = "";
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(954, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Raleway", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelTitle.Location = new System.Drawing.Point(0, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(984, 23);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Flow Control Inventory System";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 10;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 1;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelParent);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flow Control Inventory System";
            this.Resize += new System.EventHandler(this.FormMenu_Resize);
            this.panelParent.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelSignoutContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelInventoryContainer.ResumeLayout(false);
            this.panelCategoryContainer.ResumeLayout(false);
            this.panelOrderContainer.ResumeLayout(false);
            this.panelDashboardContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelTitlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripButton toolRemoveProduct;
        private System.Windows.Forms.ToolStripButton toolAddProduct;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolRemoveCategory;
        private System.Windows.Forms.ToolStripButton toolAddCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolRemoveOrder;
        private System.Windows.Forms.ToolStripButton toolAddOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolRemoveCustomer;
        private System.Windows.Forms.ToolStripButton toolAddCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Label labelDateDayTime;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Panel panelInventoryContainer;
        private System.Windows.Forms.Button buttonInventoryManagement;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Panel panelOrderContainer;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonOrderManagement;
        private System.Windows.Forms.Panel panelCategoryContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonCategoryManagement;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelDashboardContainer;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelSignoutContainer;
        private System.Windows.Forms.Button buttonSignout;
    }
}