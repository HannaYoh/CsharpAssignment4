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
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();
        }
        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; lblDescription.Text = value; }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
