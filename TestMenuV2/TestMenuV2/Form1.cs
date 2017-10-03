using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMenuV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void действиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отличный выбор!");
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

        private void действиеToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Сделаем что-то интересное";
        }

        private void выходToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выйдем из программы";
        }

        private void файлToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "А могли бы сделать что-то интересное";
        }

        private void файлToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Выберите интересное действие";
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "...";
        }

        private void выходToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "А могли бы сделать что-то интересное";
        }

        private void действиеToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "А могли бы сделать что-то интересное";
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Сюда можно ввести интересный текст";
        }
    }
}
