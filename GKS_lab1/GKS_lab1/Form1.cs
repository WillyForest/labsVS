using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GKS_lab1
{
    public partial class Form1 : Form
    {
        List<TextBox> strs = new List<TextBox>();
        List<Button> btns = new List<Button>();
        List<string> variables = new List<string>();
        List<string> alreadyUsedVars = new List<string>();
        List<string> notUsedVars = new List<string>();
        List<string> allVars = new List<string>();
        List<List<string>> groups = new List<List<string>>();
        List<List<string>> newGroups = new List<List<string>>();
        List<List<string>> sortedNewGroups = new List<List<string>>();
        List<List<string>> sortedGroups = new List<List<string>>();
        List<List<string>> rangedGroups = new List<List<string>>();
        bool[,] matrix;
        int[,] compared;
        public Form1()
        {
            InitializeComponent();
            strs.Add(generateTextbox());
            btns.Add(generateButton("Добавить", 200, 20));
            btns[0].Click += new EventHandler(btn0_Click);
            btns.Add(generateButton("Матрица", 200, 50));
            btns[1].Click += new EventHandler(btn1_Click);
            label1.AutoSize = true;
            label2.AutoSize = true;
            label3.AutoSize = true;
        }

        private int findMaxElem()
        {
            int maxElem = 0;
            for (int i = 0; i < strs.Count; i++)
            {
                for (int j = 0; j < strs.Count; j++)
                {
                    if (compared[i, j] > maxElem)
                        maxElem = compared[i, j];
                }
            }
            return maxElem;
        }

        private void showMatrix()
        {

            label2.Location = new Point(20, 30 + 30 * strs.Count);
            label2.Text = "   ";
            foreach (string s in variables)
            {
                label2.Text += s + " ";
            }

            for (int i = 0; i < strs.Count; i++)
            {
                label2.Text += "\n" + (i + 1) + "  ";
                for (int j = 0; j < variables.Count; j++)
                {
                    if (matrix[i, j])
                        label2.Text += " 1  ";
                    else
                        if (!matrix[i, j])
                        label2.Text += " 0  ";
                }
                
            }
        }

        private void setMatrix()
        {
            int j = 0;
            foreach (TextBox s in strs)
            {
                string[] tempStr = new String[s.Text.Length];
                tempStr = s.Text.Split(' ');
                for (int i = 0; i < variables.Count; i++)
                {
                    if (tempStr.Contains(variables[i]))
                    {
                        matrix[j, i] = true;
                    } else
                    {
                        matrix[j, i] = false;
                    }

                }
                j++;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (strs[strs.Count - 1].Text == "") //если последнее поле является пустым - удаляем его
            {                                       
                strs[strs.Count - 1].Dispose();
                this.Controls.Remove(strs[strs.Count - 1]);
                strs.RemoveAt(strs.Count - 1); 
            }
            foreach(TextBox s in strs)
            {
                string[] tempStr = new String[s.Text.Length];
                tempStr = s.Text.Split(' ');
                for (int i = 0; i < tempStr.Length; i++)
                {
                    if (!variables.Contains(tempStr[i]))
                    {
                        variables.Add(tempStr[i]);
                    }
                        
                }
            }
            matrix = new bool[strs.Count, variables.Count];
            setMatrix();
            showMatrix();
            btns.Add(generateButton("Далeе", 200, 80));
            btns[2].Click += new EventHandler(btn2_Click);
        }

        private void btn2_Click(object sender, EventArgs e)
        {   /* функция удаления всех элементов с формы
            foreach(TextBox tb in strs)
            {
                this.Controls.Remove(tb);
                tb.Dispose();
            }
            foreach(Button bt in btns)
            {
                this.Controls.Remove(bt);
                bt.Dispose();
            }
            label1.Text = "";
            label2.Text = "";
            for (int i = 0; i < btns.Count; i++)
            {
                btns.RemoveAt(0);
            }
            for (int i = 0; i < strs.Count; i++)
            {
                strs.RemoveAt(0);
            }*/
            this.Size = new Size(600, 600);
            setComparedMatrix();
            label3.Location = new Point(300, 20);
            label1.Text = findMaxElem() + "";
            setGroups();

            btns.Add(generateButton("Далeе", 200, 110));
            btns[3].Click += new EventHandler(btn3_Click);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            setNewGroups();
            sortGroupsInNewGroups();
            rangeSortedNewGroups();
            rangeGroups();
        }

        private void rangeGroups()
        {
            List<string> elemsOfGroup1 = new List<string>();
            List<string> elemsOfGroup2 = new List<string>();
            for (int i = 0; i < sortedGroups.Count - 1; i++) //берем до предпоследней строчки, чтобы сравнить
            {                                               //с последней
                for (int k = i + 1; k < sortedGroups.Count; k++)
                {
                    int lim = sortedGroups[k].Count;
                    for (int j = 0; j < lim; j++)
                    {
                        if (sortedGroups[k].Count > 0)
                        {
                            elemsOfGroup1 = getElemsFromGroups(sortedGroups[i]);//берем все элементы всех строчек 1 группы
                            try
                            {
                                elemsOfGroup2 = getElemsFromGroup(sortedGroups[k][j]); //берем все элементы 1 строчки 2 группы
                            } catch
                            {
                                j--;
                                elemsOfGroup2 = getElemsFromGroup(sortedGroups[k][j]);
                            }
                            if (doesContain(elemsOfGroup1, elemsOfGroup2))
                            {
                                sortedGroups[i].Add(sortedGroups[k][j]);
                                sortedGroups[k].RemoveAt(j);
                                j--;
                            }
                        }
                    }
                }
            }
            label2.Text += "После ренжирования:\n";
            foreach (List<string> group in sortedGroups)
            {
                foreach (string el in group)
                {
                    label2.Text += (Int32.Parse(el) + 1) + " ";
                }
                label2.Text += "\n";
            }
        }

        private bool doesContain(List<string> elemsOfGroup1, List<string> elemsOfGroup2)
        {
            bool contains = true;
            foreach(string elem in elemsOfGroup2)
            {
                if (!elemsOfGroup1.Contains(elem))
                {
                    contains = false;
                }
            }
            return contains;
        }

        private List<string> getElemsFromGroup(string group)
        {
            List<string> answer = new List<string>();
            string[] tempStr = new String[strs[Int32.Parse(group)].Text.Length];
            tempStr = strs[Int32.Parse(group)].Text.Split(' ');
            foreach (string el in tempStr)
            {
                answer.Add(el);
            }
            return answer;
        }

        private List<string> getElemsFromGroups(List<string> list)
        {
            List<string> answer = new List<string>();
            foreach (string group in list)
            {
                string[] tempStr = new String[strs[Int32.Parse(group)].Text.Length];
                tempStr = strs[Int32.Parse(group)].Text.Split(' ');
                foreach(string el in tempStr)
                {
                    answer.Add(el);
                }
            }
            return answer;
        }

        private void rangeSortedNewGroups()
        {/*
            int first = 0;
            while (first < sortedGroups.Count)// - 1)
            {
                
                bool contain = true;
                for (int i = first + 1; i < sortedGroups.Count; i++)//проходим по элементам массива групп (группа)
                {
                    for (int j = 0; j < sortedGroups[i].Count; j++)//проходим по элементам группы (номера групп)
                    {
                        contain = true;
                        string[] tempStr = new String[strs[Int32.Parse(sortedGroups[i][j])].Text.Length];
                        tempStr = strs[Int32.Parse(sortedGroups[i][j])].Text.Split(' '); //достаем элементы для каждой группы
                        for (int k = 0; k < tempStr.Length; k++)//для каждого элемента конкретной группы
                        {
                            if (!sortedNewGroups[first].Contains(tempStr[k]) && tempStr[k] != "")
                            {
                                contain = false;
                            }
                        }
                        if (contain && !sortedGroups[first].Contains(sortedGroups[i][j]))
                        {
                            sortedGroups[first].Add(sortedGroups[i][j]);
                            sortedGroups[i].Remove(sortedGroups[i][j]);
                        }//РАБОТАЕТ, на каждом шаге добавляет элемент в первую группу, если нужно.
                         ///TODO цикл, чтобы всё на автомате
                        label2.Text += "\nПосле ренж\n";
                        foreach (List<string> group in sortedGroups)
                        {
                            foreach (string el in group)
                            {
                                label2.Text += (Int32.Parse(el) + 1) + " ";
                            }
                            label2.Text += "\n";
                        }
                    }
                }

                /*List<string> rangedGroup = new List<string>();
                rangedGroup = sortedGroups[first]; //сохраняем первую группу после ренжирования
                sortedGroups.RemoveAt(first); //удаляем ее из временного массива
                rangedGroups.Add(rangedGroup);
                if (sortedGroups.Count < 2)
                {
                    rangedGroup = new List<string>();
                    rangedGroup = sortedGroups[first]; //Если не осталось элементов для сравнения
                    sortedGroups.RemoveAt(first); //перепишем последние в новую группу
                    rangedGroups.Add(rangedGroup);
                }
                first++;
            }*/
            /*label2.Text += "\nПосле ренжирования:\n";
            foreach (List<string> group in rangedGroups)
            {
                foreach (string el in group)
                {
                    label2.Text += (Int32.Parse(el) + 1) + " ";
                }
                label2.Text += "\n";
            }*/
            //int j = 0;
            /*
            foreach (List<string> gr in sortedGroups)
            {
                bool fullContaining = true;
                int index = 0;
                foreach (string elOfGroup in gr)
                {
                    foreach (TextBox tb in strs)
                    {
                        string[] tempStr = new String[strs[Int32.Parse(elOfGroup)].Text.Length];
                        tempStr = strs[Int32.Parse(elOfGroup)].Text.Split(' ');
                        for (int i = 0; i < tempStr.Length; i++)
                        {
                            if (!sortedNewGroups[j].Contains(tempStr[i]))
                            {
                                fullContaining = false;
                                break;
                            } else
                            {
                                index = sortedGroups.IndexOf(gr);
                            }

                        }
                    }
                } //если все элементы конкретной строчки группы содержатся в первой - 
                 //добавляем ее индекс в 1
                 if (fullContaining && !sortedGroups[j].Contains(index + ""))
                {
                    sortedGroups[j].Add(index + "");
                }
            }
            
            //и так на каждом шагу
            foreach (string sngel in sortedNewGroups[1])
            {
                if (sortedNewGroups[0].Contains(sngel))
                {
                    continue;
                    //флажок, если элемент есть, то 1
                    //потом если осталась 1, добавляем в группу эту группу, иначе - оставляем
                } else
                {
                    break;
                }
            }
            //хз
            foreach (List<string> group in sortedGroups)
            {
                foreach (string el in group)
                {
                    label2.Text += (Int32.Parse(el) + 1) + " ";
                }
                label2.Text += "\n";
            }*/
        }

        private void sortGroupsInNewGroups()
        {
            do
            {
                int maxElem = 0;
                int posOfMaxEl = 0;
                int i = 0;
                foreach (List<string> ng in newGroups)
                {
                    if (ng.Count > maxElem)
                    {
                        maxElem = ng.Count;
                        posOfMaxEl = i;
                    }
                    i++;
                }
                //if (newGroups.Where(ngroup => ngroup.Count == maxElem).) 
                    //если несколько одинаковых по величине групп
                sortedNewGroups.Add(newGroups[posOfMaxEl]);
                sortedGroups.Add(groups[posOfMaxEl]);
                newGroups.RemoveAt(posOfMaxEl);
            } while (newGroups.Count > 0);

            label2.Text = "Новые отсортированные группы: \n";
            foreach (List<string> sng in sortedNewGroups)
            {
                foreach (string s in sng)
                {
                    label2.Text += s + " ";
                }
                label2.Text += "Всего элементов : " + sng.Count + "\n";
            }
            foreach (List<string> group in sortedGroups)
            {
                foreach (string el in group)
                {
                    label2.Text += (Int32.Parse(el)+1) + " ";
                }
                label2.Text += "\n";
            }
            
            
        }

        private void setNewGroups()
        {
            label2.Location = new Point(20, 130 + 30 * strs.Count);
            label2.Text = "Новые группы: \n";
            foreach(List<string> group in groups)
            {
                List<string> newGroup = new List<string>();
                foreach (string elemOfGroup in group)
                {
                    string[] tempStr = new String[strs[Int32.Parse(elemOfGroup)].Text.Length];
                    tempStr = strs[Int32.Parse(elemOfGroup)].Text.Split(' ');
                    for (int i = 0; i < tempStr.Length; i++)
                    {
                        if (!newGroup.Contains(tempStr[i]))
                        {
                            newGroup.Add(tempStr[i]);
                        }

                    }
                }
                foreach (string g in newGroup)
                {
                    label2.Text += g + " ";
                }
                label2.Text += "Всего элементов : " + newGroup.Count + "\n";
                newGroups.Add(newGroup);
            }
        }

        private void setGroups()
        {
            int elem = findMaxElem();
            List<string> group = new List<string>();
            int i = -1;
            while (true)
            {
                i++;
                groups.Add(group);
                groups[i] = findRowsWith(elem);
                while (groups[i].Count < 2)
                {
                    elem--;
                    List<string> tempGroup = new List<string>();
                    tempGroup = findRowsWith(elem);
                    foreach(string tg in tempGroup)
                    {
                        groups[i].Add(tg);
                    }
                    if (elem < 0)
                    {
                        label1.Text = "WARNING";
                        break;
                    }
                    
                }
                
                if (strs.Count - alreadyUsedVars.Count == 1)
                {
                    checkNotUsedVars();
                    groups[i].Add(notUsedVars[0]);
                    alreadyUsedVars.Add(notUsedVars[0]);
                }
                label4.Location = new Point(300, strs.Count * 30 + 30);
                label4.Text += "Группа №" + (i + 1) + "\n";
                foreach (string s in groups[i])
                {
                    label4.Text += (Int32.Parse(s) + 1) + ", ";// s + ", ";
                }
                label4.Text += "\n";
                label1.Text = "";

                if (strs.Count == alreadyUsedVars.Count)
                {
                    break;
                }
                
                
                elem--;
            }
            
            
        }

        private void checkNotUsedVars()
        {
            int i = 0;
            foreach (TextBox str in strs)
            {
                allVars.Add(i + "");
                i++;
            }
            foreach (string var in allVars)
            {
                if (!alreadyUsedVars.Contains(var))
                {
                    notUsedVars.Add(var);
                }
            }
        }

        private List<string> findRowsWith(int elem)
        {
            List<string> group = new List<string>();
            for (int i = 0; i < strs.Count; i++)
            {
                for (int j = 0; j < strs.Count; j++)
                {
                    if (compared[i, j] == elem && !alreadyUsedVars.Contains(i + ""))
                    {
                        group.Add(i + "");
                        alreadyUsedVars.Add(i + "");
                    }
                }
            }
            return group;
        }

        private void setComparedMatrix()
        {
            int rows = strs.Count;
            compared = new int[rows, rows];
            for (int y = 0; y < rows; y++)
            {
                compared[y, y] = -1;
            }


            int i = 0, j = 0, k = 1;
            int lim = rows;
            while (true)
            {
                if (matrix[i, j] == matrix[i + k, j])
                {
                    compared[i + k, i] += 1;
                }
                j++;
                if (j == variables.Count)
                {
                    j = 0;
                    k += 1;
                    if (k == lim)
                    {
                        k = 1;
                        i++;
                        lim--;
                        if (i == rows - 1)
                        {
                            break;
                        }
                    }
                }

            }
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < rows; j++)
                {
                    if (i != j)
                    {
                        compared[i, j] = compared[j, i];
                    }
                }
            }
            label3.Text = "Полученный массив:\n";
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < rows; j++)
                {
                    label3.Text += compared[i, j].ToString() + " ";
                }
                label3.Text += "\n";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (strs[strs.Count - 1].Text != "")
            {
                strs.Add(generateTextbox());
            } else
            {
                label1.Text = "Сначала введите значение";
            }
        }

        private Button generateButton(string name, int x, int y)
        {
            Button btn = new Button();
            btn.Text = name;
            btn.Size = new Size(80, 20);
            btn.Location = new Point(x, y);
            this.Controls.Add(btn);
            return btn;
        }

        private TextBox generateTextbox()
        {
            TextBox txtbx = new TextBox();
            txtbx.Text = "";
            txtbx.Size = new Size(160, 20);
            txtbx.Location = new Point(20, 20 + 30*strs.Count);
            this.Controls.Add(txtbx);
            return txtbx;
        }
    }
}
