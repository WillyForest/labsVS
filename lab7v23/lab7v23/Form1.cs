using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7v23
{
    public partial class Form1 : Form
    {
        Laba7Entities model = null;
        public Form1()
        {
            InitializeComponent();
            model = new Laba7Entities();
            this.dcDisciplineTableAdapter.Fill(this.laba7DataSet.DcDiscipline);
        }

        private void dcDisciplineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.dcDisciplineBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.laba7DataSet);
            int sel = dcDisciplineDataGridView.CurrentRow.Index;
            DcDiscipline dd = new DcDiscipline();
            dd = model.DcDiscipline.ElementAt(sel);//  .Where(p => p.DcDisciplineId == 0);
            model.DcDiscipline.Remove(dd);
                //model.DcDiscipline.Where(p => p.DcDisciplineId == 0);//Int32.Parse(dcDisciplineDataGridView.CurrentCell.Value)));// [0, sel].Value)));
            model.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "laba7DataSet.DcDiscipline". При необходимости она может быть перемещена или удалена.
            

        }
    }
}
