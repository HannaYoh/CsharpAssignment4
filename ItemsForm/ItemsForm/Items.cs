using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ItemsForm
{
    internal class Items
    {
        public string conString = "Data Source=HANNA\\SQLEXPRESS;Initial Catalog=productdb;Integrated Security=True";
        

        static List<Items> items = new List<Items> ();
        public int number { get; set; }
        public string date { get; set; }
        public int inventoryNumber { get; set; }
        public string itemName { get; set; }        
        public double quantity { get; set; }
        public double price { get; set; }

        public bool isAvailable { get; set; }

        public string option { get; set; }

        public void save()
        {
            items.Add (this);
            /*try
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                MessageBox.Show("connected successfully");
                string stmt = "insert into product values ('" +number+ "', '" +date+ "', '" +inventoryNumber+ "', '" + itemName + "', '" + quantity + "', '" + price + "' )";
                SqlCommand comd = new SqlCommand(stmt, con);
                var result = comd.ExecuteNonQuery();
                MessageBox.Show(result.ToString());


                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("unable to connect");
            }*/

        }

        public static List<Items> getAllProducts()
        {
           
            return items;            
        }

        public static Items findProducts(string name)
        {
            return items.Find(p => p.itemName == name);
            
        }





    }
}
