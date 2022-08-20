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
        Login loginPage = new Login();
        Items item = new Items();
        public Form1()
        {
            InitializeComponent();
            //lblUsername.Text = username;
            //loginPage = login;
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
     
            Regex r = new Regex(@"^[0-9]{3}$");

            try
            {
                item.number = int.Parse(txt_Number.Text);
                item.date = dt_RegisteredDate.Text;
                item.inventoryNumber = int.Parse(txt_Inventory.Text);
                item.itemName = txt_Item.Text;
                item.quantity = Double.Parse(txt_Quantity.Text);
                item.price = Double.Parse(txt_Price.Text);
                item.isAvailable = chk_isAvailable.Checked;
                item.option = groupBox1.Text;
                
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

                String items = " ";
                foreach(var itemList in chklistcheker.CheckedItems)
                {
                    items += itemList.ToString();
                }
                MessageBox.Show(items);              

            }
            else
            {
                errorProvider1.SetError(txt_Inventory, "Enter valid value");
                
            }
                string name = txt_Item.Text;
               int invNum = int.Parse(txt_Inventory.Text);
               double price = Double.Parse(txt_Price.Text);
                double quantity = Double.Parse(txt_Quantity.Text);
            NewForm newform = new NewForm(name, invNum, price, quantity);
            newform.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            loginPage.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            var product = Items.findProducts(name);
            if(product == null)
            {
                MessageBox.Show("product not found");
            }
            else
            {
                MessageBox.Show("product found");
                txt_Item.Text = item.itemName;
                txt_Number.Text = item.number.ToString();
                txt_Inventory.Text = item.inventoryNumber.ToString();
                txt_Quantity.Text = item.quantity.ToString();
                txt_Price.Text = item.price.ToString();
            }
            
        }
    }
}
