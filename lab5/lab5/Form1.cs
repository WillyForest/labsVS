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
    public partial class Form1 : Form
    {
        List<Faculty> facs = new List<Faculty>();
        public Form1()
        {
            InitializeComponent();
            readFromFile();
        }

        public void readFromFile()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("xmltext.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            
            if (xRoot.HasChildNodes)
            {
                int i = 0;
                foreach (XmlElement s in xDoc.GetElementsByTagName("student"))
                {
                    if (!((s.FirstChild.InnerText + "") == facs[i].getName()))
                    {
                        //продумать архитектуру
//                        Faculty fac = new Faculty(s.FirstChild.InnerText, 1, s.ChildNodes);
                    }
                    i++;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
    public class Faculty
    {
        string name;
        List<string> groups = new List<string>();
        int course;

        public Faculty(string name, int course, List<string> groups)
        {
            this.name = name;
            this.course = course;
            foreach (string group in groups)
            {
                this.groups.Add(group);
            }
        }

        public string getName()
        {
            return name;
        }
        public int getCourse()
        {
            return course;
        }
        public List<string> getGroups()
        {
            return groups;
        }
        
        
    }
    public class XPredmetList
    {
        public static string[] GetNames()
        {
            return items.ToArray();
        }

        static List<string> items;

        // конструктор класса, кот. устанавливает список предметов
        static XPredmetList()
        {
            items.AddRange(new string[] { "p1", "p2", "p3" });
        }
    }
    public class XMark
    {
        //  код предмета
        int predmetCode;
        //  оценка по предмету
        int mark;
        //  дата сдачи
        DateTime examDate;
        // метод получения названия предмета
        public string GetPredmetName()
        {
            return XPredmetList.GetNames()[this.predmetCode];
        }
    }
    public class Student
    {
        int studentID;
        // Имя студента
        string firstName;
        // Фамилия студента
        string surName;
        // Оценки данного студента
        List<XMark> exams = new List<XMark>();
    }



}
