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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
        }

        
        private void productCard2_Load(object sender, EventArgs e)
        {

        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Controls.Clear();
            List<Items> items = new List<Items>();
            foreach (var myItem in Items.getAllProducts())
            {
                ProductCard card = new ProductCard();
                //card.Title = items.itemName;
                //card.Description = items.inventoryNumber;
                //card.Price = items.price;
                
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
