using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop.Forms
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet1.USERS". При необходимости она может быть перемещена или удалена.
            this.uSERSTableAdapter1.Fill(this.shopDataSet1.USERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.USERS". При необходимости она может быть перемещена или удалена.


        }

        private void sURNAMELabel_Click(object sender, EventArgs e)
        {

        }

        private void uSERSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void pRODUCTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void uSERSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERSBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.shopDataSet1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uSERSBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERSBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.shopDataSet1);
        }
    }
}
