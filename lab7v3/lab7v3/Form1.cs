using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7v3
{
    public partial class Form1 : Form
    {
        Laba2_1Entities model = null;
        public Form1()
        {
            InitializeComponent();

            model = new Laba2_1Entities();
            dataGridView1.DataSource = model.DcDiscipline;   
        }
    }
}
