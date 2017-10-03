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
        public Form1()
        {
            InitializeComponent();
            strs.Add(generateTextbox());
            btns.Add(generateButtons());
            btns[0].Click += new EventHandler(btn0_Click);

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

        private Button generateButtons()
        {
            Button btn = new Button();
            btn.Text = "Добавить";
            btn.Size = new Size(80, 20);
            btn.Location = new Point(200, 20);
            this.Controls.Add(btn);
            return btn;
        }

        private TextBox generateTextbox()
        {
            TextBox txtbx = new TextBox();
            txtbx.Text = "";
            txtbx.Size = new Size(160, 20);
            txtbx.Location = new Point(20, 20 + 20*strs.Count);
            this.Controls.Add(txtbx);
            return txtbx;
        }
    }
}
