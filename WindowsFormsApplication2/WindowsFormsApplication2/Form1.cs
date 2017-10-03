using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int x = 0;
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

        private void MyBtn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = 1;
            label1.Text = "Loaded, x = " + x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 2;
            label1.Text = "Button pressed, x = " + x;
            Hide();
            Show();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            x = 3;
            label1.Text = "Activated, x = " + x;
        }
        private void Form1_Deactivated(object sender, EventArgs e)
        {
            x = 4;
            label1.Text = "Deactivated, x = " + x;
        }
    }
}
