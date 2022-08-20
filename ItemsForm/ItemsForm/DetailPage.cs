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
    public partial class DetailPage : Form
    {
        public DetailPage(string name, int invNum, double price, double quantity)
        {
            InitializeComponent();
            txtProductName.Text = name;
            txtInventoryNumber.Text = invNum.ToString();
            txtPrice.Text = price.ToString();
            txtQuantity.Text = quantity.ToString();


        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
