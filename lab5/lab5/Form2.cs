using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form2 : Form
    {
        List<Faculty> facs = new List<Faculty>();
        public Form2()
        {
            InitializeComponent();
            comboBox2.Items.Add('1');
            comboBox2.Items.Add('2');
            comboBox2.Items.Add('3');
            comboBox2.Items.Add('4');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> tGroups = new List<string>();
            foreach(string cb in comboBox3.Items)
            {
                tGroups.Add(cb);
            }
            Faculty fac = new Faculty(comboBox1.SelectedItem.ToString(), 
                Int32.Parse(comboBox2.SelectedItem.ToString()), tGroups);
            facs.Add(fac);
            Hide();

        }
    }
}
