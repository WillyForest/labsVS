using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
            writeToFile();
        }

        private void writeToFile()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("xmltext.xml");
            //объявляем необходимые переменные
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement studentElem = xDoc.CreateElement("student");
            XmlElement courseElem = xDoc.CreateElement("course");
            XmlElement facElem = xDoc.CreateElement("faculty");
            XmlElement groupElem = xDoc.CreateElement("group");
            XmlElement fNameElem = xDoc.CreateElement("firstName");
            XmlElement sNameElem = xDoc.CreateElement("surName");
            XmlElement marks = xDoc.CreateElement("marks");
            XmlElement predmet = xDoc.CreateElement("predmet");
            XmlElement code = xDoc.CreateElement("code");
            XmlElement mark = xDoc.CreateElement("mark");
            XmlElement examDate = xDoc.CreateElement("examDate");
            //строим структуру хмл документа
            xRoot.AppendChild(studentElem);
            studentElem.AppendChild(facElem);
            studentElem.AppendChild(courseElem);
            studentElem.AppendChild(groupElem);
            studentElem.AppendChild(sNameElem);
            studentElem.AppendChild(fNameElem);
            studentElem.AppendChild(marks);
            marks.AppendChild(predmet);
            predmet.AppendChild(code);
            predmet.AppendChild(mark);
            predmet.AppendChild(examDate);
            //заполняем примером
            courseElem.AppendChild(xDoc.CreateTextNode("1"));
            facElem.AppendChild(xDoc.CreateTextNode("FICT"));
            groupElem.AppendChild(xDoc.CreateTextNode("IK-51"));
            fNameElem.AppendChild(xDoc.CreateTextNode("Максим"));
            sNameElem.AppendChild(xDoc.CreateTextNode("Козоріз"));
            code.AppendChild(xDoc.CreateTextNode("1"));
            mark.AppendChild(xDoc.CreateTextNode("4"));
            examDate.AppendChild(xDoc.CreateTextNode("21/01/2017"));
            xDoc.Save("xmltext.xml");

            /*foreach (Faculty f in facs)
            {
                XmlText nameText = xDoc.CreateTextNode(f.getName());
                XmlText courseText = xDoc.CreateTextNode(f.getCourse() + "");
                int i = 0;
                foreach (string gr in f.getGroups())
                {
                    XmlElement temp = xDoc.CreateElement("group");
                    courseElem.AppendChild(temp);
                    temp.AppendChild(xDoc.CreateTextNode(gr));
                }
                if (xRoot.HasChildNodes)
                {
                    foreach(XmlElement s in xRoot.ChildNodes)
                    {
                        if (s.Name == "Faculties")
                        {
                            foreach(XmlElement x in s.ChildNodes)
                            {
                                if (x.Name == "Faculty")
                                {
                                   if (x.GetAttribute("name") == f.getName())
                                    {
                                        x.AppendChild(xDoc.CreateTextNode(f.getCourse() + ""));
                                    }
                                }
                            }
                        }
                        
                    }
                }*/

            /*foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int age = int.Parse(node["Age"].InnerText);
                bool programmer = bool.Parse(node["Programmer"].InnerText);
                listBox1.Items.Add(new Employee(name, age, programmer));
            }*/
        }
    }
}
