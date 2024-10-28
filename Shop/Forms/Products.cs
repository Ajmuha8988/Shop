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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void pRODUCTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUCTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.CATALOGS". При необходимости она может быть перемещена или удалена.
            this.cATALOGSTableAdapter.Fill(this.shopDataSet.CATALOGS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.ORDERS". При необходимости она может быть перемещена или удалена.
            this.oRDERSTableAdapter.Fill(this.shopDataSet.ORDERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.PRODUCTS". При необходимости она может быть перемещена или удалена.
            this.pRODUCTSTableAdapter.Fill(this.shopDataSet.PRODUCTS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pRODUCTSBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pRODUCTSBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pRODUCTSBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pRODUCTSBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pRODUCTSBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pRODUCTSBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            //закрывает подключение с сервером 
            this.pRODUCTSBindingSource.EndEdit();
            //обновляет данные на сервере 
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            TableProduct table = new TableProduct();
            table.Visible = true;
        }

        private void iD_CATALOGTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
