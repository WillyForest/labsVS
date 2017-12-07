using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7finv2
{
    public partial class Form1 : Form
    {
        Laba2_1Entities model = null;
        public Form1()
        {
            InitializeComponent();
            model = new Laba2_1Entities();
            //dataGridView1.DataSource = model.DcDiscipline;
            DataGridView DcDisciplineDataGridView = new DataGridView();
            DcDisciplineDataGridView.DataSource = model.DcDiscipline;
            DcDisciplineDataGridView.Location = new Point(28, 28);
            DcDisciplineDataGridView.Size = new Size(500, 250);
            this.Controls.Add(DcDisciplineDataGridView);
            

        }
    }
}
