using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ItemsForm
{
    public partial class ConnCheck : Form
    {
        public string connString = "Data Source=HANNA\\SQLEXPRESS;Initial Catalog=csharpConn;Integrated Security=True";

        public ConnCheck()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                MessageBox.Show("connected successfully");
                int Id = int.Parse(txtId.Text);
                string name = txtName.Text;
                string query = "insert into myUser values ('" +Id+ "', '" +name+ "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                MessageBox.Show(result.ToString());


                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("unable to connect");
            }
        
        

        }
    }
}

