namespace Flow_Control_Inventory_System.forms
{
    partial class FormInventory
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
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productaddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowControl_DataSet = new Flow_Control_Inventory_System.database.FlowControl_DataSet();
            this.inventoryTableAdapter = new Flow_Control_Inventory_System.database.FlowControl_DataSetTableAdapters.inventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
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
            this.dataGridViewInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productdescriptionDataGridViewTextBoxColumn,
            this.category_name,
            this.productquantityDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn,
            this.productaddedDataGridViewTextBoxColumn});
            this.dataGridViewInventory.DataSource = this.inventoryBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
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
            this.dataGridViewInventory.TabIndex = 0;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productdescriptionDataGridViewTextBoxColumn
            // 
            this.productdescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productdescriptionDataGridViewTextBoxColumn.DataPropertyName = "product_description";
            this.productdescriptionDataGridViewTextBoxColumn.HeaderText = "Product Description";
            this.productdescriptionDataGridViewTextBoxColumn.Name = "productdescriptionDataGridViewTextBoxColumn";
            this.productdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // category_name
            // 
            this.category_name.DataPropertyName = "category_name";
            this.category_name.HeaderText = "Category";
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            // 
            // productquantityDataGridViewTextBoxColumn
            // 
            this.productquantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productquantityDataGridViewTextBoxColumn.DataPropertyName = "product_quantity";
            this.productquantityDataGridViewTextBoxColumn.HeaderText = "Product Quantity";
            this.productquantityDataGridViewTextBoxColumn.Name = "productquantityDataGridViewTextBoxColumn";
            this.productquantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "Product Price";
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            this.productpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productaddedDataGridViewTextBoxColumn
            // 
            this.productaddedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productaddedDataGridViewTextBoxColumn.DataPropertyName = "product_added";
            this.productaddedDataGridViewTextBoxColumn.HeaderText = "Product Added";
            this.productaddedDataGridViewTextBoxColumn.Name = "productaddedDataGridViewTextBoxColumn";
            this.productaddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.flowControl_DataSet;
            // 
            // flowControl_DataSet
            // 
            this.flowControl_DataSet.DataSetName = "FlowControl_DataSet";
            this.flowControl_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.dataGridViewInventory);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(734, 461);
            this.Name = "FormInventory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormInventory";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowControl_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private database.FlowControl_DataSet flowControl_DataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn productquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productaddedDataGridViewTextBoxColumn;
        private database.FlowControl_DataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
    }
}