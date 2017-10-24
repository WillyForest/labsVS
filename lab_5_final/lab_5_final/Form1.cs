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

        public void writeToFile()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("xmltext.xml");
            //объявляем необходимые переменные
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            foreach (Student stud in students)
            {
                XmlElement studentElem = xDoc.CreateElement("student");
                XmlElement courseElem = xDoc.CreateElement("course");
                XmlElement facElem = xDoc.CreateElement("faculty");
                XmlElement groupElem = xDoc.CreateElement("group");
                XmlElement studentID = xDoc.CreateElement("ID");
                XmlElement fNameElem = xDoc.CreateElement("firstName");
                XmlElement sNameElem = xDoc.CreateElement("surName");
                XmlElement marks = xDoc.CreateElement("marks");
                //строим структуру хмл документа
                
                xRoot.AppendChild(studentElem);
                studentElem.AppendChild(facElem);
                studentElem.AppendChild(courseElem);
                studentElem.AppendChild(groupElem);
                studentElem.AppendChild(studentID);
                studentElem.AppendChild(sNameElem);
                studentElem.AppendChild(fNameElem);
                studentElem.AppendChild(marks);
                foreach (XMark exam in stud.exams)
                {
                    XmlElement predmet = xDoc.CreateElement("predmet");
                    XmlElement code = xDoc.CreateElement("code");
                    XmlElement mark = xDoc.CreateElement("mark");
                    XmlElement examDate = xDoc.CreateElement("examDate");
                    marks.AppendChild(predmet);
                    predmet.AppendChild(code);
                    predmet.AppendChild(mark);
                    predmet.AppendChild(examDate);
                    code.AppendChild(xDoc.CreateTextNode(exam.predmetCode + ""));
                    mark.AppendChild(xDoc.CreateTextNode(exam.mark + ""));
                    examDate.AppendChild(xDoc.CreateTextNode(exam.examDate + ""));
                }
                courseElem.AppendChild(xDoc.CreateTextNode(stud.course + ""));
                facElem.AppendChild(xDoc.CreateTextNode(stud.fac.name + ""));
                groupElem.AppendChild(xDoc.CreateTextNode(stud.group.name + ""));
                studentID.AppendChild(xDoc.CreateTextNode(stud.studentID + ""));
                fNameElem.AppendChild(xDoc.CreateTextNode(stud.firstName));
                sNameElem.AppendChild(xDoc.CreateTextNode(stud.surName));
            }
            xDoc.Save("xmltext.xml");
        }

        public void readFromFile()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("xmltext.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            if (xRoot.HasChildNodes)
            {
                //находим все факультеты, которые есть в xml файле
                foreach (XmlElement facult in xDoc.GetElementsByTagName("faculty"))
                {
                    try
                    {
                        if (facs.Contains(facs.Where(f => f.name == facult.InnerText).First()))
                        {
                            continue; //если факультет уже есть в списке, пропускаем, если нет - ловим ошибку и добавляем его
                        }
                    } catch
                    {
                        Faculty fac = new Faculty(facult.InnerText);
                        facs.Add(fac);
                    }
                }
                foreach (XmlElement gr in xDoc.GetElementsByTagName("group"))
                {
                    try
                    {
                        if (groups.Contains(groups.Where(g => g.name == gr.InnerText).First()))
                        {
                            continue; //если группа уже есть в списке, пропускаем, если нет - 
                                        //ловим ошибку и добавляем еe
                        }
                    }
                    catch
                    {
                        Group group = new Group(gr.InnerText);
                        groups.Add(group);
                    }
                }
                foreach (XmlElement s in xDoc.GetElementsByTagName("student"))
                {
                    try
                    {
                        if (students.Contains(students.Where(st => st.studentID == int.Parse(s.GetElementsByTagName("ID")[0].InnerText)).First()))
                        {
                            continue;
                        }
                    } catch
                    {
                        List<XMark> exams = new List<XMark>();
                        foreach (XmlElement mrk in s.GetElementsByTagName("predmet"))
                        {
                            XMark mark = new XMark(int.Parse(mrk.GetElementsByTagName("code")[0].InnerText), 
                                int.Parse(mrk.GetElementsByTagName("mark")[0].InnerText), 
                                DateTime.Parse(mrk.GetElementsByTagName("examDate")[0].InnerText));
                            exams.Add(mark);
                        }
                        Student stud = new Student(s.GetElementsByTagName("firstName")[0].InnerText, 
                            s.GetElementsByTagName("surName")[0].InnerText, exams, 
                            facs.Where(f => f.name == s.GetElementsByTagName("faculty")[0].InnerText).First(), 
                            groups.Where(g => g.name == s.GetElementsByTagName("group")[0].InnerText).First(), 
                            int.Parse(s.GetElementsByTagName("course")[0].InnerText));
                        students.Add(stud);
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
            writeToFile();
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            personalTask();
        }

        public void personalTask()
        {
            
            List<Student> bestStudents = new List<Student>();
            foreach (Student student in students)
            {
                double smark = 0;
                foreach (XMark mark in student.exams)
                {
                    smark += mark.mark;
                }
                smark = smark / student.exams.Count;
                if (smark == 4.5)
                {
                    bestStudents.Add(student);
                }
            }
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("answer.xml");
            //объявляем необходимые переменные
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            foreach (Student student in bestStudents) //вариант где отобразим только то что в задании
            {
                XmlElement studentElem = xDoc.CreateElement("student");
                XmlElement courseElem = xDoc.CreateElement("course");
                XmlElement facElem = xDoc.CreateElement("faculty");
                XmlElement groupElem = xDoc.CreateElement("group");
                XmlElement studentID = xDoc.CreateElement("ID");
                XmlElement fNameElem = xDoc.CreateElement("firstName");
                XmlElement sNameElem = xDoc.CreateElement("surName");
                //строим структуру хмл документа

                xRoot.AppendChild(studentElem);
                studentElem.AppendChild(facElem);
                studentElem.AppendChild(courseElem);
                studentElem.AppendChild(groupElem);
                studentElem.AppendChild(studentID);
                studentElem.AppendChild(sNameElem);
                studentElem.AppendChild(fNameElem);
                foreach (XMark exam in student.exams)
                {
                    XmlElement predmet = xDoc.CreateElement("predmet");
                    XmlElement code = xDoc.CreateElement("code");
                    XmlElement mark = xDoc.CreateElement("mark");
                    XmlElement examDate = xDoc.CreateElement("examDate");
                    predmet.AppendChild(code);
                    predmet.AppendChild(mark);
                    predmet.AppendChild(examDate);
                    code.AppendChild(xDoc.CreateTextNode(exam.predmetCode + ""));
                    mark.AppendChild(xDoc.CreateTextNode(exam.mark + ""));
                    examDate.AppendChild(xDoc.CreateTextNode(exam.examDate + ""));
                }
                courseElem.AppendChild(xDoc.CreateTextNode(student.course + ""));
                facElem.AppendChild(xDoc.CreateTextNode(student.fac.name + ""));
                groupElem.AppendChild(xDoc.CreateTextNode(student.group.name + ""));
                studentID.AppendChild(xDoc.CreateTextNode(student.studentID + ""));
                fNameElem.AppendChild(xDoc.CreateTextNode(student.firstName));
                sNameElem.AppendChild(xDoc.CreateTextNode(student.surName));

            }
            /*foreach (Student student in bestStudents) //вариант где отобразим всю информацию
            {
                XmlElement studentElem = xDoc.CreateElement("student");
                XmlElement courseElem = xDoc.CreateElement("course");
                XmlElement facElem = xDoc.CreateElement("faculty");
                XmlElement groupElem = xDoc.CreateElement("group");
                XmlElement studentID = xDoc.CreateElement("ID");
                XmlElement fNameElem = xDoc.CreateElement("firstName");
                XmlElement sNameElem = xDoc.CreateElement("surName");
                XmlElement marks = xDoc.CreateElement("marks");
                //строим структуру хмл документа

                xRoot.AppendChild(studentElem);
                studentElem.AppendChild(facElem);
                studentElem.AppendChild(courseElem);
                studentElem.AppendChild(groupElem);
                studentElem.AppendChild(studentID);
                studentElem.AppendChild(sNameElem);
                studentElem.AppendChild(fNameElem);
                studentElem.AppendChild(marks);
                foreach (XMark exam in student.exams)
                {
                    XmlElement predmet = xDoc.CreateElement("predmet");
                    XmlElement code = xDoc.CreateElement("code");
                    XmlElement mark = xDoc.CreateElement("mark");
                    XmlElement examDate = xDoc.CreateElement("examDate");
                    marks.AppendChild(predmet);
                    predmet.AppendChild(code);
                    predmet.AppendChild(mark);
                    predmet.AppendChild(examDate);
                    code.AppendChild(xDoc.CreateTextNode(exam.predmetCode + ""));
                    mark.AppendChild(xDoc.CreateTextNode(exam.mark + ""));
                    examDate.AppendChild(xDoc.CreateTextNode(exam.examDate + ""));
                }
                courseElem.AppendChild(xDoc.CreateTextNode(student.course + ""));
                facElem.AppendChild(xDoc.CreateTextNode(student.fac.name + ""));
                groupElem.AppendChild(xDoc.CreateTextNode(student.group.name + ""));
                studentID.AppendChild(xDoc.CreateTextNode(student.studentID + ""));
                fNameElem.AppendChild(xDoc.CreateTextNode(student.firstName));
                sNameElem.AppendChild(xDoc.CreateTextNode(student.surName));
            }*/
            xDoc.Save("answer.xml");
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
        public int predmetCode;
        //  оценка по предмету
        public int mark;
        //  дата сдачи
        public DateTime examDate;
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
