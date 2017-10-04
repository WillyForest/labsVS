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
        List<String> variables = new List<String>();
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

            /*if (array[j, i] == array[j, i+1])
            {
                compared[0, 1] += 1;
                label1.Text = compared[0, 1] + "";
            }*/


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
