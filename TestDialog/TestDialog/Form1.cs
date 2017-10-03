using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // если выбрали текст
                if (fd.FilterIndex == 1)
                    richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // если выбрали текст
                if (fd.FilterIndex == 1)
                    richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = d.Color;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FontDialog d = new FontDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = d.Font;
            }
        }

        private void создатьToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void печатьToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDialog d = new PrintDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                if (printDialog1.Document != null)
                {
                    printDialog1.Document.Print();
                }
               
            }
        }

        private void вырезатьToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставкаToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // если выбрали текст
                if (fd.FilterIndex == 1)
                    richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.LoadFile(fd.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Text format (*.txt)|*.txt|Rich Text (*.rtf)|*.rtf";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                // если выбрали текст
                if (fd.FilterIndex == 1)
                    richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.SaveFile(fd.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog d = new FontDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = d.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = d.Color;
            }
        }

        private void справкаВРазработкеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed mattis ligula posuere ultricies posuere. Pellentesque fermentum leo nec sapien viverra pharetra. In quis ullamcorper dui. Vestibulum tortor felis, dapibus sit amet ante sed, malesuada gravida odio. Sed molestie sapien sed mattis ultricies. Curabitur semper consectetur lorem, at ornare ante. Phasellus id dictum augue. Sed elit tellus, hendrerit eget dictum nec, aliquam in nibh. Etiam ut lorem ut arcu iaculis tempor eget sed risus. Nunc leo dolor, pulvinar eget leo eu, venenatis volutpat odio.";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec enim eros, cursus quis sem eget, consectetur dictum turpis. Nulla fermentum mollis sem, at sodales mauris laoreet eu. Integer nec elit ut neque luctus posuere ac in lacus. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Sed accumsan mi id mi tincidunt, vitae sagittis nulla auctor. Maecenas vitae nisi id magna cursus aliquet.Cras porttitor, mauris et lobortis ultricies, nisl dolor pellentesque velit, at imperdiet velit lectus eu libero.Sed eget tortor eget erat malesuada feugiat et vitae tortor. Duis lobortis, lacus fringilla pulvinar vestibulum, urna metus dapibus purus, id dapibus purus sem id lorem.Maecenas porttitor sit amet leo eget molestie.Fusce sit amet malesuada justo.Vivamus odio urna, tristique et dolor congue, consequat aliquet arcu. Integer condimentum molestie ipsum sit amet vestibulum.Sed neque nulla, fermentum eget est ut, varius ullamcorper mauris. Aenean dignissim orci eu diam elementum mattis.Nulla pharetra lorem ac risus mattis, id aliquet ex scelerisque.Donec malesuada lorem nec rutrum iaculis. Donec mattis, lorem quis iaculis pretium, justo sem posuere quam, et molestie ante sapien non turpis.Pellentesque luctus nec nisl et volutpat. Morbi porta, sem ac rhoncus cursus, arcu ligula luctus elit, a molestie ex neque ac quam.Proin varius ornare sollicitudin. Nulla facilisi.";
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
