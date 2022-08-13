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
    public partial class DockForm : Form
    {
        public DockForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Aqua;
            panel3.Top = 110;
            panel3.BackColor = Color.Aqua;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Thistle;
            panel3.Top = 160;
            panel3.BackColor = Color.Thistle;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Teal;
            panel3.Top = 210;
            panel3.BackColor = Color.Teal;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Tomato;
            panel3.Top = 270;
            panel3.BackColor = Color.Tomato;
        }
    }
}
