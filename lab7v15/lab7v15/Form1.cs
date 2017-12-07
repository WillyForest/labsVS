using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7v15
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
            this.tableAdapterManager.UpdateAll(this.laba7DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba7DataSet.DcDiscipline". При необходимости она может быть перемещена или удалена.
            this.dcDisciplineTableAdapter.Fill(this.laba7DataSet.DcDiscipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba7DataSet1.DcDiscipline". При необходимости она может быть перемещена или удалена.
            this.dcDisciplineTableAdapter.Fill(this.laba7DataSet1.DcDiscipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba7DataSet1.DcDiscipline". При необходимости она может быть перемещена или удалена.
            this.dcDisciplineTableAdapter1.Fill(this.laba7DataSet1.DcDiscipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba7DataSet.DcDiscipline". При необходимости она может быть перемещена или удалена.
            this.dcDisciplineTableAdapter.Fill(this.laba7DataSet.DcDiscipline);

        }

        private void dcDisciplineBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dcDisciplineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba7DataSet1);

        }

        private void dcDisciplineBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.dcDisciplineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.laba7DataSet);

        }
    }
}
