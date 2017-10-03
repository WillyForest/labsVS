using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMenuToolBoxStatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void чтотоСделатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отличная идея что-то сделать!");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void выходToolStripStatusLabel1_MouseEnter(object sender, EventArgs e)
        {
            statusStrip1.Text = "Hello";
        }

        private void выходstatusStrip1_MouseEnter(object sender, EventArgs e)
        {
            statusStrip1.Text = "Hello";
        }
    }
}
