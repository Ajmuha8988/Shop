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
    public partial class TableProduct : Form
    {
        private System.Windows.Forms.DataGridViewColumn columnProduct;
        public TableProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUCTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopDataSet);

        }

        private void TableProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.PRODUCTS". При необходимости она может быть перемещена или удалена.
            this.pRODUCTSTableAdapter.Fill(this.shopDataSet.PRODUCTS);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            columnProduct = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    columnProduct = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    columnProduct = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    columnProduct = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    columnProduct = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    columnProduct = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
            {
                pRODUCTSDataGridView.Sort(columnProduct, System.ComponentModel.ListSortDirection.Ascending);
            }
            else
            {
                pRODUCTSDataGridView.Sort(columnProduct, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pRODUCTSBindingSource.Filter = "NAME='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pRODUCTSBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pRODUCTSDataGridView.ColumnCount - 1; i++)
            {
                for(int j = 0;j < pRODUCTSDataGridView.RowCount - 1; j++)
                {
                    pRODUCTSDataGridView[i, j].Style.BackColor = Color.White;
                    pRODUCTSDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < pRODUCTSDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < pRODUCTSDataGridView.RowCount - 1; j++)
                {
                    if (pRODUCTSDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        pRODUCTSDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        pRODUCTSDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
