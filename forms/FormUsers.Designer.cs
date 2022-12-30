namespace Flow_Control_Inventory_System.forms
{
    partial class FormUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowControlDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowControl_DataSet = new Flow_Control_Inventory_System.database.FlowControl_DataSet();
            this.usersTableAdapter = new Flow_Control_Inventory_System.database.FlowControl_DataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowControlDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowControl_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AllowUserToAddRows = false;
            this.dataGridViewInventory.AllowUserToDeleteRows = false;
            this.dataGridViewInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInventory.AutoGenerateColumns = false;
            this.dataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.userpasswordDataGridViewTextBoxColumn,
            this.userroleDataGridViewTextBoxColumn});
            this.dataGridViewInventory.DataSource = this.usersBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInventory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInventory.Location = new System.Drawing.Point(12, 160);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewInventory.Size = new System.Drawing.Size(710, 289);
            this.dataGridViewInventory.TabIndex = 1;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userpasswordDataGridViewTextBoxColumn
            // 
            this.userpasswordDataGridViewTextBoxColumn.DataPropertyName = "user_password";
            this.userpasswordDataGridViewTextBoxColumn.HeaderText = "Hashed Password";
            this.userpasswordDataGridViewTextBoxColumn.Name = "userpasswordDataGridViewTextBoxColumn";
            this.userpasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userroleDataGridViewTextBoxColumn
            // 
            this.userroleDataGridViewTextBoxColumn.DataPropertyName = "user_role";
            this.userroleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.userroleDataGridViewTextBoxColumn.Name = "userroleDataGridViewTextBoxColumn";
            this.userroleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.flowControlDataSetBindingSource;
            // 
            // flowControlDataSetBindingSource
            // 
            this.flowControlDataSetBindingSource.DataSource = this.flowControl_DataSet;
            this.flowControlDataSetBindingSource.Position = 0;
            // 
            // flowControl_DataSet
            // 
            this.flowControl_DataSet.DataSetName = "FlowControl_DataSet";
            this.flowControl_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.dataGridViewInventory);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(734, 461);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowControlDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowControl_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private database.FlowControl_DataSet flowControl_DataSet;
        private System.Windows.Forms.BindingSource flowControlDataSetBindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private database.FlowControl_DataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userroleDataGridViewTextBoxColumn;
    }
}