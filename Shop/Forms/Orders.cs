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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.ViewORDER". При необходимости она может быть перемещена или удалена.
            this.viewORDERTableAdapter.Fill(this.shopDataSet.ViewORDER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewORDERBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewORDERBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewORDERBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewORDERBindingSource.MoveLast();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            viewORDERBindingSource.RemoveCurrent();
        }
    }
}
