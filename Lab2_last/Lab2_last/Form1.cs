using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_last
{
    public partial class Form1 : Form
    {
        private string lifeTimeInfo;

        public Form1()
        {
            InitializeComponent();

            Closing += new CancelEventHandler(Form1_Closing);
            Load += new EventHandler(Form1_Load);
            Closed += new EventHandler(Form1_Closed);
            Activated += new EventHandler(Form1_Activated);
            Deactivate += new EventHandler(Form1_Deactivate);

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            lifeTimeInfo += "Событие Deactivate\n";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lifeTimeInfo += "Событие Activated\n";
        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            lifeTimeInfo += "Событие Closed\n";
            MessageBox.Show(lifeTimeInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lifeTimeInfo += "Событие Load\n";
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите закрыть приложение?", 
                "Событие closing", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            } else
            {
                e.Cancel = false;
            }

        }
    }
}
