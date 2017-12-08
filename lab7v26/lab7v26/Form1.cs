using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7v26
{
    public partial class Form1 : Form
    {
        Laba7Entities model;
        BindingSource bs;
        public Form1()
        {
            InitializeComponent();
            model = new Laba7Entities();
            bs = new BindingSource();
            bs.DataSource = model.DcDiscipline.ToList();
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            model.SaveChanges();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //DcDiscipline dc = new DcDiscipline();
            //dc = model.DcDiscipline.ElementAt(e.ColumnIndex);
            //model.DcDiscipline.Remove(dc);
            //model.DcDiscipline.Add(dc);
        }
    }
}
