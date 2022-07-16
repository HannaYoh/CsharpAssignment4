using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ItemsForm
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Number.Text = "";
            txt_Inventory.Text = "";
            txt_Item.Text = "";
            txt_Quantity.Text = "";
            txt_Price.Text = "";

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Items item = new Items();
            Regex r = new Regex(@"^[0-9]{3}$");

            try
            {
                item.number = int.Parse(txt_Number.Text);
                item.date = dt_RegisteredDate.Text;
                item.inventoryNumber = int.Parse(txt_Inventory.Text);
                item.itemName = txt_Item.Text;
                item.quantity = Double.Parse(txt_Quantity.Text);
                item.price = Double.Parse(txt_Price.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            /*if (string.IsNullOrEmpty(txt_Number.Text))
            {
                errorProvider1.SetError(txt_Number, "This field is required");
            }*/

            /*if(txt_Item.Text.Length < 3)
            {
                MessageBox.Show("Item not available");
            }*/

            if (r.IsMatch(txt_Inventory.Text))
            {
                errorProvider1.Clear();
                item.save();
                dt_displayItems.DataSource = null;
                dt_displayItems.DataSource = Items.getAllProducts();

            }
            else
            {
                errorProvider1.SetError(txt_Inventory, "Enter valid value");
                
            }

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
