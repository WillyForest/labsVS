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
    public partial class Form1 : Form
    {
        public static List<Faculty> facs = new List<Faculty>();
        public static List<Group> groups = new List<Group>();
        public Form1()
        {
            InitializeComponent();
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
        public Student(string fname, string sname, List<XMark> exms)
        {
            this.firstName = fname;
            this.surName = sname;
            this.exams = exms;
        }
    }

}
