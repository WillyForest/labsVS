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
        List<List<string>> elements = new List<List<string>>();
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
                    int j = 0;
                    do
                    {
                        if (j < sortedGroups[k].Count)
                        {
                            elemsOfGroup1 = getElemsFromGroups(sortedGroups[i]);//берем все элементы всех строчек 1 группы
                            elemsOfGroup2 = getElemsFromGroup(sortedGroups[k][j]); //берем все элементы 1 строчки 2 группы
                            if (doesContain(elemsOfGroup1, elemsOfGroup2))
                            {
                                sortedGroups[i].Add(sortedGroups[k][j]);
                                sortedGroups[k].RemoveAt(j);
                                j--;
                            }
                            j++;
                        }
                    } while (sortedGroups[k].Count > 0 && j < sortedGroups[k].Count);
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
                sortedGroups.Add(groups[posOfMaxEl]);//отут хуйня
                newGroups.RemoveAt(posOfMaxEl);
                groups.RemoveAt(posOfMaxEl);
                //группа не меняется, записывает одинаковые
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
            List<string> group = new List<string>();
            if (strs.Count == 2)
            {
                group = new List<string>();
                group.Add(0 + "");
                group.Add(1 + "");
                groups.Add(group);
            }
            int maxElement = findMaxElem();
            int indexOfMaxElI, indexOfMaxElJ;
            for (int i = 0; i < strs.Count; i++)
            {
                notUsedVars.Add(i + ""); // выгрузили все строки в неиспользованные переменные
            }
            do
            {
                group = new List<string>();
                do
                {
                    for (int i = 0; i < strs.Count; i++)
                    {
                        for (int j = 0; j < strs.Count; j++)
                        {
                            if (compared[i, j] == maxElement)
                            {
                                group = new List<string>();
                                indexOfMaxElI = i;
                                indexOfMaxElJ = j;
                                if (!alreadyUsedVars.Contains(i + "") || !alreadyUsedVars.Contains(j + ""))
                                {
                                    compared[i, j] = -2;
                                }
                                if (!alreadyUsedVars.Contains(indexOfMaxElI + ""))
                                {
                                    group.Add(indexOfMaxElI + "");
                                    alreadyUsedVars.Add(indexOfMaxElI + "");
                                    notUsedVars.Remove(indexOfMaxElI + "");
                                }
                                if (!alreadyUsedVars.Contains(indexOfMaxElJ + ""))
                                {
                                    group.Add(indexOfMaxElJ + "");
                                    alreadyUsedVars.Add(indexOfMaxElJ + "");
                                    notUsedVars.Remove(indexOfMaxElJ + "");
                                }

                                for (int l = 0; l < group.Count; l++)
                                {
                                    for (int k = 0; k < strs.Count; k++)
                                    {
                                        if (compared[Int32.Parse(group[l]), k] == maxElement && !alreadyUsedVars.Contains(k + ""))
                                        {
                                            group.Add(k + "");
                                            alreadyUsedVars.Add(k + "");
                                            notUsedVars.Remove(k + "");
                                            compared[Int32.Parse(group[l]), k] = -2;
                                        }
                                    }
                                }
                                if (group.Count > 0)
                                    groups.Add(group);
                            }
                        }
                    }
                } while (findRowsWith(maxElement).Count > 0);
                maxElement--;
            } while (maxElement > -1);
            if (groups.Where(g => g.Count == 1).Count() > 1)
            {
                group = new List<string>();
                foreach (List<string> gr in groups.Where(g => g.Count == 1))
                {
                    group.Add(gr[0]);
                }
                for (int i = 0; i < group.Count; i++)
                {
                    groups.Remove(groups.Where(g => g.Count == 1).First());
                }
                groups.Add(group);
            }
            
            label4.Location = new Point(300, strs.Count * 30 + 30);
            label4.Text += "Группа\n";
            foreach (List<string> g in groups)
            {
                foreach (string s in g)
                {
                    label4.Text += (Int32.Parse(s) + 1) + ", ";
                }
                label4.Text += "\n";
            }
            label1.Text = "";
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
                if (matrix[i, j] == matrix[i + k, j] && matrix[i,j] != false) //HERE
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
