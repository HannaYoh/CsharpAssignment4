﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsForm
{
    internal class Items
    {
        public int number { get; set; }
        public string date { get; set; }
        public int inventoryNumber { get; set; }
        public string itemName { get; set; }        
        public double quantity { get; set; }
        public double price { get; set; }

        public void save()
        {
            MessageBox.Show($"Product added:- Number: {number}, Date: {date}, InventoryNumber: {inventoryNumber}, ItemName: {itemName}, Quantity: {quantity}, Price: {price}");
        }

        

        

    }
}
