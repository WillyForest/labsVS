using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6v3var2
{
    public partial class Form1 : Form
    {
        DataSet d = new DataSet();
        DataTable dt = new DataTable();
        MyData md = new MyData();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = md;
            dataGridView2.DataMember = "Order";
            dataGridView3.DataSource = md;
            dataGridView3.DataMember = "Payment";
            dataGridView1.DataSource = md;
            dataGridView1.DataMember = "Dish";
        }
    }
}
