using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseListAndCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (textBox1.Text != "")
            {
                comboBox1.Items.Add(textBox1.Text);
            } else
            {
                label1.Text = "Это поле нужно заполнить!";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            } catch
            {
                label1.Text = "Выберите какой-то элемент!";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            try
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            } catch
            {
                label1.Text = "Выберите какой-то элемент!";
            }
        }
    }
}
