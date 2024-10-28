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
    public partial class ProductGroups : Form
    {
        public ProductGroups()
        {
            InitializeComponent();
        }

        private void cATALOGSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATALOGSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void ProductGroups_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.CATALOGS". При необходимости она может быть перемещена или удалена.
            this.cATALOGSTableAdapter.Fill(this.shopDataSet.CATALOGS);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cATALOGSBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cATALOGSBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cATALOGSBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cATALOGSBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cATALOGSBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cATALOGSBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            //закрывает подключение с сервером 
            this.cATALOGSBindingSource.EndEdit();
            //обновляет данные на сервере 
            this.tableAdapterManager.UpdateAll(this.shopDataSet);
        }
    }
}
