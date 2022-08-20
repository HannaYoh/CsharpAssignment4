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
        string iName;
        int iNum;
        double iPrice;
        double iQuantity;
        public NewForm(string name, int invNum, double price, double quantity)
        {
            InitializeComponent();
            iName = name;
            iNum = invNum;
            iPrice = price;
            iQuantity = quantity;
        }

        
        private void productCard2_Load(object sender, EventArgs e)
        {

        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
           // List<Items> items = new List<Items>();
            
            foreach (var myItem in Items.getAllProducts())
            {
                ProductCard card = new ProductCard();
                card.Title = myItem.itemName;
                card.Description = myItem.inventoryNumber.ToString();
                card.Price = myItem.price.ToString();
                card.Click += ProductCard_Click;


                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void ProductCard_Click(object sender, EventArgs e)
        {
            
            DetailPage page = new DetailPage(iName, iNum, iPrice, iQuantity);
            page.Show();

        }
    }
}
