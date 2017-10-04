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
        public Form1()
        {
            InitializeComponent();
            strs.Add(generateTextbox());
            btns.Add(generateButton("Добавить", 200, 20));
            btns[0].Click += new EventHandler(btn0_Click);
            btns.Add(generateButton("Далее", 200, 50));
            btns[1].Click += new EventHandler(btn1_Click);

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
                        label1.Text += tempStr[i];
                    }
                        
                }
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
