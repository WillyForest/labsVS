using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Button myBtn = new Button();
            myBtn.Text = "Вызов второй формы";
            myBtn.Size = new Size(135, 23);
            myBtn.Location = new Point(12, 238);
            this.Controls.Add(myBtn);
            myBtn.Click += MyBtn_Click;
           
        }
        int x = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            x = 1;
            label1.Text = "x = " + x;
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            x = 2;
            label1.Text = "x = " + x;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "FFFFFFFFf";
        }
        private void MyBtn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
