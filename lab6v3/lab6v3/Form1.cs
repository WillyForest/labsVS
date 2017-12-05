using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6v3
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

        private void button4_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dataGridView1.DataSource = dv;
            dv.RowFilter = textBox2.Text;
        }

        private void Создать_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                d.Tables.Add(dt);
                DataColumn dc1 = new DataColumn("height", System.Type.GetType("System.Int32"));
                DataColumn dc2 = new DataColumn("name", System.Type.GetType("System.String"));
                dt.Columns.Add(dc1);
                dt.Columns.Add(dc2);
                DataRow dr = dt.NewRow();
                dr["height"] = 180;
                dr["name"] = "Ivan";
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                dr["height"] = 160;
                dr["name"] = "Petr";
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;
                DataView dv = dt.DefaultView;
                dataGridView1.DataSource = dv;
                dv.RowFilter = textBox2.Text;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                dataGridView2.DataSource = md;
                dataGridView2.DataMember = "Order";
                dataGridView3.DataSource = md;
                dataGridView3.DataMember = "OrderLines";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dt.Rows[dataGridView1.CurrentCell.RowIndex][dataGridView1.CurrentCell.ColumnIndex].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dataGridView1.DataSource = dv;
            dv.Sort = textBox1.Text;
        }
    }
}
