using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7v11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dcDisciplineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dcDisciplineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba2_1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba2_1DataSet.DcDiscipline". При необходимости она может быть перемещена или удалена.
            this.dcDisciplineTableAdapter.Fill(this.laba2_1DataSet.DcDiscipline);

        }
    }
}
