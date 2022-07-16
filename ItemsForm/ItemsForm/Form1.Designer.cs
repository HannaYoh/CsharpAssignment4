namespace ItemsForm
{
    partial class Form1
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
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Inventory = new System.Windows.Forms.Label();
            this.lbl_Item = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Inventory = new System.Windows.Forms.TextBox();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.dt_RegisteredDate = new System.Windows.Forms.DateTimePicker();
            this.dt_displayItems = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dt_displayItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(75, 65);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(55, 16);
            this.lbl_Number.TabIndex = 0;
            this.lbl_Number.Text = "Number";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(306, 65);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(36, 16);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Inventory
            // 
            this.lbl_Inventory.AutoSize = true;
            this.lbl_Inventory.Location = new System.Drawing.Point(568, 65);
            this.lbl_Inventory.Name = "lbl_Inventory";
            this.lbl_Inventory.Size = new System.Drawing.Size(112, 16);
            this.lbl_Inventory.TabIndex = 2;
            this.lbl_Inventory.Text = "Inventory Number";
            // 
            // lbl_Item
            // 
            this.lbl_Item.AutoSize = true;
            this.lbl_Item.Location = new System.Drawing.Point(78, 176);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(32, 16);
            this.lbl_Item.TabIndex = 3;
            this.lbl_Item.Text = "Item";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(78, 272);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(55, 16);
            this.lbl_Quantity.TabIndex = 4;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(306, 272);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(38, 16);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Price";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(78, 379);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(228, 379);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(393, 379);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(67, 112);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(141, 22);
            this.txt_Number.TabIndex = 9;
            // 
            // txt_Inventory
            // 
            this.txt_Inventory.Location = new System.Drawing.Point(548, 112);
            this.txt_Inventory.Name = "txt_Inventory";
            this.txt_Inventory.Size = new System.Drawing.Size(141, 22);
            this.txt_Inventory.TabIndex = 10;
            // 
            // txt_Item
            // 
            this.txt_Item.Location = new System.Drawing.Point(67, 209);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(392, 22);
            this.txt_Item.TabIndex = 11;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(67, 302);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(125, 22);
            this.txt_Quantity.TabIndex = 12;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(250, 302);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(130, 22);
            this.txt_Price.TabIndex = 13;
            // 
            // dt_RegisteredDate
            // 
            this.dt_RegisteredDate.Location = new System.Drawing.Point(250, 110);
            this.dt_RegisteredDate.Name = "dt_RegisteredDate";
            this.dt_RegisteredDate.Size = new System.Drawing.Size(243, 22);
            this.dt_RegisteredDate.TabIndex = 14;
            // 
            // dt_displayItems
            // 
            this.dt_displayItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_displayItems.Location = new System.Drawing.Point(484, 165);
            this.dt_displayItems.Name = "dt_displayItems";
            this.dt_displayItems.RowHeadersWidth = 51;
            this.dt_displayItems.RowTemplate.Height = 24;
            this.dt_displayItems.Size = new System.Drawing.Size(503, 258);
            this.dt_displayItems.TabIndex = 15;
            this.dt_displayItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.dt_displayItems);
            this.Controls.Add(this.dt_RegisteredDate);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Item);
            this.Controls.Add(this.txt_Inventory);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Item);
            this.Controls.Add(this.lbl_Inventory);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Number);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dt_displayItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Inventory;
        private System.Windows.Forms.Label lbl_Item;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_Inventory;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.DateTimePicker dt_RegisteredDate;
        private System.Windows.Forms.DataGridView dt_displayItems;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

