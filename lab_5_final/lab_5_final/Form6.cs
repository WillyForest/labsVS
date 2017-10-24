using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5_final
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            foreach (Student stud in Form1.students)
            {
                comboBox1.Items.Add(stud.studentID + " " + stud.firstName + " " + stud.surName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem + "" != "")
            {
                Form1.students.Remove(Form1.students.Where(s => s.studentID == 
                Int32.Parse((comboBox1.SelectedItem + "").Split(' ')[0])).First());
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                Hide();
            }
        }
    }
}
