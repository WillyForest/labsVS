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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            foreach (Faculty fac in Form1.facs)
            {
                comboBox1.Items.Add(fac.name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Faculty fac = new Faculty(textBox1.Text);
                comboBox1.Items.Add(textBox1.Text);
                Form1.facs.Add(fac);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                try
                {
                    Form1.facs.Where(f => f.name == comboBox1.SelectedItem + "").First().name = textBox2.Text;
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    comboBox1.Items.Add(textBox2.Text);
                } catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.facs.Remove(Form1.facs.Where(f => f.name == comboBox1.SelectedItem + "").First());
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            } catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
