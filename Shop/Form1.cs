using Shop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Form1 : Form
    {
        private ProductGroups catalogs;
        private Users users;
        private Products products;
        private Orders orders;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            users = new Users();
            users.Visible = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            catalogs = new ProductGroups();
            catalogs.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            products = new Products();
            products.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orders = new Orders();
            orders.Visible = true;
           
        }

        private void pRODUCTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
