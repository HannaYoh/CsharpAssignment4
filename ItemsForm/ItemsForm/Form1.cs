using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Items item = new Items
            {
                number = int.Parse(txt_Number.Text),
                date = dt_RegisteredDate.Text,
                inventoryNumber = int.Parse(txt_Inventory.Text),
                itemName = txt_Item.Text,
                quantity = Double.Parse(txt_Quantity.Text),
                price = Double.Parse(txt_Price.Text),
            };
            item.save();
        }
    }
}
