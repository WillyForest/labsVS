using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progamm1
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

            myBtn.Click += new EventHandler(myBtn_Click);
        }

        private void myBtn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
