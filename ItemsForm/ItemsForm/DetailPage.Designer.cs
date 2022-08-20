namespace ItemsForm
{
    partial class DetailPage
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblInventoryNumber = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductionDescription = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtInventoryNumber = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(93, 145);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(148, 25);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblInventoryNumber
            // 
            this.lblInventoryNumber.AutoSize = true;
            this.lblInventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryNumber.Location = new System.Drawing.Point(93, 195);
            this.lblInventoryNumber.Name = "lblInventoryNumber";
            this.lblInventoryNumber.Size = new System.Drawing.Size(182, 25);
            this.lblInventoryNumber.TabIndex = 1;
            this.lblInventoryNumber.Text = "Inventory Number";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(93, 251);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(93, 305);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(93, 25);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductionDescription
            // 
            this.lblProductionDescription.AutoSize = true;
            this.lblProductionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionDescription.Location = new System.Drawing.Point(202, 59);
            this.lblProductionDescription.Name = "lblProductionDescription";
            this.lblProductionDescription.Size = new System.Drawing.Size(281, 32);
            this.lblProductionDescription.TabIndex = 4;
            this.lblProductionDescription.Text = "Product Description";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(333, 145);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(231, 22);
            this.txtProductName.TabIndex = 6;
            // 
            // txtInventoryNumber
            // 
            this.txtInventoryNumber.Location = new System.Drawing.Point(333, 199);
            this.txtInventoryNumber.Name = "txtInventoryNumber";
            this.txtInventoryNumber.Size = new System.Drawing.Size(231, 22);
            this.txtInventoryNumber.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(333, 255);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(231, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(333, 309);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(231, 22);
            this.txtQuantity.TabIndex = 9;
            // 
            // DetailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInventoryNumber);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductionDescription);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblInventoryNumber);
            this.Controls.Add(this.lblProductName);
            this.Name = "DetailPage";
            this.Text = "DetailPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblInventoryNumber;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductionDescription;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtInventoryNumber;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}