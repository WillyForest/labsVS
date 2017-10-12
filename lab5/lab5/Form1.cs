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
        public static List<Faculty> facs = new List<Faculty>();
        List<Student> students = new List<Student>();
        XPredmetList predmets = new XPredmetList();
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
                foreach (XmlElement s in xDoc.GetElementsByTagName("student"))
                {
                    bool founded = false;
                    foreach (Faculty fac in facs)
                    {
                        if (fac.getName() == s.FirstChild.InnerText)
                        {
                            founded = true;
                        }
                    }
                    if (!founded)
                    {
                        Faculty fac = new Faculty(s.FirstChild.InnerText);
                        facs.Add(fac);
                    }
                }
            }
            if (xRoot.HasChildNodes)
            {
                foreach (XmlElement s in xDoc.GetElementsByTagName("student"))
                {
                    Student student = new Student(Int32.Parse(s.ChildNodes[3].InnerText), 
                        s.ChildNodes[4].InnerText, s.ChildNodes[5].InnerText);
                    List<XMark> exams = new List<XMark>();
                    foreach(XmlElement ex in s.GetElementsByTagName("predmet"))
                    {
                        XMark exam = new XMark();
                        exam.setPredmetCode(Int32.Parse(ex.FirstChild.InnerText));
                        exam.setExamDate(DateTime.Parse(ex.ChildNodes[2].InnerText));
                        exam.setMark(Int32.Parse(ex.ChildNodes[1].InnerText));
                        predmets.setItem(ex.ChildNodes[0].InnerText, ex.ChildNodes[3].InnerText);
                        exams.Add(exam);
                    }
                    student.setExams(exams);
                    students.Add(student);

                    foreach (XmlElement f in s.GetElementsByTagName("course"))
                    {
                        if ((f.InnerText + "") == ("1"))
                        {
                            List<string> groups = new List<string>();
                            foreach (XmlElement g in s.GetElementsByTagName("group"))
                            {
                                groups.Add(g.InnerText);
                            }
                            facs.Where(child => child.getName() == s.FirstChild.InnerText).First().setGroups(groups, 1);
                        }
                        if (((f.InnerText + "") == ("2")))
                        {
                            List<string> groups = new List<string>();
                            foreach (XmlElement g in s.GetElementsByTagName("group"))
                            {
                                groups.Add(g.InnerText);
                            }
                            facs.Where(child => child.getName() == s.FirstChild.InnerText).First().setGroups(groups, 2);
                        }
                        if (((f.InnerText + "") == ("3")))
                        {
                            List<string> groups = new List<string>();
                            foreach (XmlElement g in s.GetElementsByTagName("group"))
                            {
                                groups.Add(g.InnerText);
                            }
                            facs.Where(child => child.getName() == s.FirstChild.InnerText).First().setGroups(groups, 3);
                        }
                        if (((f.InnerText + "") == ("4")))
                        {
                            List<string> groups = new List<string>();
                            foreach (XmlElement g in s.GetElementsByTagName("group"))
                            {
                                groups.Add(g.InnerText);
                            }
                            facs.Where(child => child.getName() == s.FirstChild.InnerText).First().setGroups(groups, 4);
                        }
                    }
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
        List<string>[] groups = new List<string>[5];
        public void setGroups(List<string> grps, int course)
        {
            foreach (string group in grps)
            {
                if (!(groups[course].Contains(group)))
                {
                    groups[course].Add(group);
                }
                    
            }
        }
        public List<string> getGroups(int course)
        {
            return groups[course];
        }
        public Faculty(string name)
        {
            this.name = name;
            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = new List<string>();
            }
        }

        public string getName()
        {
            return name;
        }    
    }
    public class XPredmetList
    {
        public string GetName(string key)
        {
            return items[key];
        }

        //static List<string> items;
        Dictionary<string, string> items = new Dictionary<string, string>();
        public void setItem(string key, string value)
        {
            if (!(items.ContainsKey(key) && items[key] == value))
            {
                items.Add(key, value);
            }
        }
        // конструктор класса, кот. устанавливает список предметов
        //static XPredmetList()
        //{
        //    items.Add(.AddRange(new string[] { "Math", "English", "Programming" });
        //}
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
        //public string GetPredmetName()
        //{
        //    return XPredmetList.GetNames()[this.predmetCode];
        //}
        public void setPredmetCode(int pCode)
        {
            this.predmetCode = pCode;
        }
        public void setMark(int pMark)
        {
            this.mark = pMark;
        }
        public void setExamDate(DateTime eDate)
        {
            this.examDate = eDate;
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
        public void setExams(List<XMark> exms)
        {
            foreach (XMark exam in exams)
            {
                exams.Add(exam);
            }
        }
        public Student(int stID, string sName, string fName)
        {
            this.studentID = stID;
            this.firstName = fName;
            this.surName = sName;
        }
    }



}
