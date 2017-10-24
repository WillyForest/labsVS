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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //int i = 0;
            foreach (Faculty fac in Form1.facs)
            {
                comboBox1.Items.Add(fac.name);
            }
            comboBox2.Items.Add("1");
            comboBox2.Items.Add("2");
            comboBox2.Items.Add("3");
            comboBox2.Items.Add("4");
            foreach (Group gr in Form1.groups)
            {
                comboBox3.Items.Add(gr.name);
            }
            label7.Text = "Высшая математика";
            label8.Text = "Английский язык";
            label9.Text = "Программирование";
            comboBox5.Items.Add("1");
            comboBox5.Items.Add("2");
            comboBox5.Items.Add("3");
            comboBox5.Items.Add("4");
            comboBox5.Items.Add("5");
            comboBox6.Items.Add("1");
            comboBox6.Items.Add("2");
            comboBox6.Items.Add("3");
            comboBox6.Items.Add("4");
            comboBox6.Items.Add("5");
            comboBox8.Items.Add("1");
            comboBox8.Items.Add("2");
            comboBox8.Items.Add("3");
            comboBox8.Items.Add("4");
            comboBox8.Items.Add("5");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<XMark> exms = new List<XMark>();
            if (comboBox5.SelectedItem + "" != "")
            {
                XMark mark = new XMark(0, Int32.Parse(comboBox5.SelectedItem + ""),
                    DateTime.Parse(dateTimePicker1.Text));
                exms.Add(mark);
            }
            if (comboBox6.SelectedItem + "" != "")
            {
                XMark mark = new XMark(1, Int32.Parse(comboBox6.SelectedItem + ""),
                    DateTime.Parse(dateTimePicker2.Text));
                exms.Add(mark);
            }
            if (comboBox8.SelectedItem + "" != "")
            {
                XMark mark = new XMark(2, Int32.Parse(comboBox8.SelectedItem + ""),
                    DateTime.Parse(dateTimePicker3.Text));
                exms.Add(mark);
            }
            if (textBox1.Text != "" && textBox2.Text != "" && (comboBox1.SelectedItem + "") != "" &&
                (comboBox2.SelectedItem + "") != "" && (comboBox3.SelectedItem + "") != "" &&
                ((comboBox5.SelectedItem + "") != "" || (comboBox6.SelectedItem + "") != "" ||
                (comboBox8.SelectedItem + "") != ""))
            {
                Student stud = new Student(textBox2.Text, textBox1.Text, exms, Form1.facs.Where(f => f.name == comboBox1.SelectedItem+ "").First(),
                    Form1.groups.Where(g => g.name == comboBox3.SelectedItem + "").First(), Int32.Parse(comboBox2.SelectedItem + ""));
                Form1.students.Add(stud);
                Hide();
            }
        }
    }
}
