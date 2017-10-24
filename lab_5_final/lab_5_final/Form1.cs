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

namespace lab_5_final
{
    public partial class Form1 : Form
    {
        public static List<Faculty> facs = new List<Faculty>();
        public static List<Group> groups = new List<Group>();
        public static List<Student> students = new List<Student>();
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
                //находим все факультеты, которые есть в xml файле
                foreach (XmlElement s in xDoc.GetElementsByTagName("faculty"))
                {
                    try
                    {
                        if (facs.Contains(facs.Where(f => f.name == s.InnerText).First()))
                        {
                            continue; //если факультет уже есть в списке, пропускаем, если нет - ловим ошибку и добавляем его
                        }
                    } catch
                    {
                        Faculty fac = new Faculty(s.InnerText);
                        facs.Add(fac);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Faculty
    {
        public string name;
        public Faculty(string name)
        {
            this.name = name;
        }
    }
    public class Group
    {
        public string name;
        public Group(string name)
        {
            this.name = name;
        }
    }
    public class XPredmetList
    {
        public static string[] GetNames()
        {
            return items.ToArray();
        }

        public static List<string> items;

        // конструктор класса, кот. устанавливает список предметов
        static XPredmetList()
        {
            items.AddRange(new string[] { "Высшая математика", "Английский язык", "Программирование" });
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
        public XMark(int pcode, int mrk, DateTime exDate)
        {
            this.predmetCode = pcode;
            this.mark = mrk;
            this.examDate = exDate;
        }
    }
    public class Student
    {
        public int studentID;
        static int studentCounter = 0;
        // Имя студента
        public string firstName;
        public Faculty fac;
        public Group group;
        public int course;
        // Фамилия студента
        public string surName;
        // Оценки данного студента
        public List<XMark> exams = new List<XMark>();
        public Student(string fname, string sname, List<XMark> exms, Faculty fac, Group group, int course)
        {
            this.group = group;
            this.fac = fac;
            this.course = course;
            this.studentID = studentCounter;
            this.firstName = fname;
            this.surName = sname;
            this.exams = exms;
            studentCounter++;
        }
    }

}
