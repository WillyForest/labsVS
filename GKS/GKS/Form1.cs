using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GKS
{
    public partial class Form1 : Form
    {
        private int cols;
        private int rows;
        TextBox[,] txtbx;
        bool[,] array;
        int[,] compared;
        public Form1()
        {
            InitializeComponent();
            
            /*Button myBtn = new Button();
            myBtn.Text = "Вызов второй формы";
            myBtn.Size = new Size(135, 23);
            myBtn.Location = new Point(12, 238);
            this.Controls.Add(myBtn);
            myBtn.Click += MyBtn_Click;*/
        }
        /*private void MyBtn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }*/

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cols = Int32.Parse(textBox1.Text);
            rows = Int32.Parse(textBox2.Text);
            this.Size = new Size(600, 600);
            this.Text = "Matrix";
            txtbx = new TextBox[cols, rows];
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    txtbx[i, j] = new TextBox();
                    txtbx[i, j].Text = "0";
                    txtbx[i, j].Size = new Size(20, 20);
                    txtbx[i, j].Location = new Point(300 + 25 * i, 20 + 25 * j);
                    this.Controls.Add(txtbx[i, j]);

                }
            }
            Button applyBtn = new Button();
            applyBtn.Size = new Size(135, 23);
            applyBtn.Text = "Сохранить массив";
            applyBtn.Location = new Point(300 + 6*cols, 40 + 25*rows);
            this.Controls.Add(applyBtn);
            applyBtn.Click += ApplyBtn_Click;
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            setArr(txtbx);
            setCompared();
            int maxElem = findMaxElem();
            int maxI = findMaxI();
            int maxJ = findMaxJ();
            label5.Text += "\nМаксимальный элемент: " + maxElem + 
                " \nЕго координаты: " + maxI + " " + maxJ;
            //ArrayList groups = new ArrayList();
            //groups.Add(rowsWhereMaxElem(maxElem) + "");
            label5.Text += "\nГруппы:";
            /*while(maxElem >= 0)
            {
                label5.Text += "\n" + rowsWhereMaxElem(maxElem);
                maxElem--;
            } */
            int[] rowNums = new int[rows];
            for (int i = 0; i < rows; i++)
                rowNums[i] = -1;
            string rowList = "", oldRowList = "";
            while (maxElem >= 0)
            {
                rowNums = rowsWhereMaxElem(maxElem, rowNums);
                rowList = "";
                for (int i = 0; i < rows; i++)
                {
                    if (rowNums[i] != -1)
                        rowList += "" + rowNums[i];
                }
                if (rowList != oldRowList)
                    label5.Text += "\n" + rowList;
                oldRowList = rowList;
                maxElem--;
            }
        }

        private int[] rowsWhereMaxElem(int maxElem, int[] rowsNums)
        {
            //int[] rowsNums = new int[rows];
            bool contains;
            int ind = 0;
            string rowsNumb = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (compared[i, j] == maxElem)
                    {
                        contains = false;
                        for (int k = 0; k < rows; k++)
                        {
                            if (rowsNums[k] == j)
                            {
                                contains = true;
                            }
                        }
                        if (!contains)
                        {
                            rowsNums[ind] = j;
                            rowsNumb += j+ ", ";
                            ind++;
                        }
                    }
                }
            }
            for (int i = ind; i < rows; i++)
                rowsNums[i] = -1;
            return rowsNums;
        }

        private int findMaxI()
        {
            int maxElem = 0;
            int maxI = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (compared[i, j] > maxElem)
                    {
                        maxElem = compared[i, j];
                        maxI = i;
                    }

                }
            }
            return maxI;
        }

        private int findMaxJ()
        {
            int maxElem = 0;
            int maxJ = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (compared[i, j] > maxElem)
                    {
                        maxElem = compared[i, j];
                        maxJ = j;
                    }
                        
                }
            }
            return maxJ;
        }

        private int findMaxElem()
        {
            int maxElem = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (compared[i, j] > maxElem)
                        maxElem = compared[i, j];
                }
            }
            return maxElem;
        }

        private void setCompared()
        {
            compared = new int[rows, rows];
            for(int y = 0; y < rows; y++) 
            {
                compared[y, y] = -1;
            }
            int i = 0, j = 0, k = 1;
            int lim = rows;
            while (true)
            {
                if (array[j, i] == array[j, i + k])
                {
                    compared[i, i + k] += 1;
                }
                j++;
                if (j==cols)
                {
                    j = 0;
                    k += 1;
                    if (k==lim)
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
                        compared[j, i] = compared[i, j];
                    }
                }
            }
            label5.Text = "Полученный массив:\n";
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < rows; j++)
                {
                    label5.Text += compared[i, j].ToString() + " ";
                }
                label5.Text += "\n";
            }

            /*if (array[j, i] == array[j, i+1])
            {
                compared[0, 1] += 1;
                label1.Text = compared[0, 1] + "";
            }*/


        }

        private void setArr(TextBox[,] arr)
        {
            array = new bool[cols, rows];
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (arr[i, j].Text == "0")
                        array[i, j] = false;
                    if (arr[i, j].Text == "1")
                        array[i, j] = true;
                }
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                button1.Enabled = false;
                label4.Text = "Введите значения!";
            }
                
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                button1.Enabled = true;
            }
                
            
        }
    }
}
