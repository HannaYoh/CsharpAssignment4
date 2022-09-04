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
        public string connString = "Data Source=HANNA\\SQLEXPRESS;Initial Catalog=productdb;Integrated Security=True";
        

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
            //items.Add (this);
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                MessageBox.Show("connected successfully");
                string stmt = "insert into product values (@id, @date, @invNum, @itemName, @quantity, @price)";
                SqlCommand cmd = new SqlCommand(stmt, conn);
                cmd.Parameters.AddWithValue("id", number);
                cmd.Parameters.AddWithValue("date", date);
                cmd.Parameters.AddWithValue("invNum", inventoryNumber);
                cmd.Parameters.AddWithValue("itemName", itemName);
                cmd.Parameters.AddWithValue("quantity", quantity);
                cmd.Parameters.AddWithValue("price", price);

                var result = cmd.ExecuteNonQuery();
                MessageBox.Show(result.ToString());


                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("unable to connect");
            }

        }

        public static List<Items> getAllProducts()
        {

        List<Items> temp = new List<Items>();
            string query = "select * from product";
            SqlConnection connection = new SqlConnection("Data Source=HANNA\\SQLEXPRESS;Initial Catalog=productdb;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Items item = new Items();
                item.number = Convert.ToInt32(reader["number"]);
                item.date = reader["dates"].ToString();
                item.inventoryNumber = Convert.ToInt32(reader["invNum"]);
                item.itemName = reader["itemName"].ToString();
                item.quantity = Convert.ToDouble(reader["number"]);
                item.price = Convert.ToDouble(reader["number"]);

                temp.Add(item);
            }
            connection.Close();
            return temp;  
           
        }

        public static Items findProducts(string name)
        {
            return items.Find(p => p.itemName == name);
            
        }





    }
}
