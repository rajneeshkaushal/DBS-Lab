using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        string fName;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open";
            // openFileDialog.Filter = "Text Document(*.txt)*|.txt|All Files(*.*)|*.*";
            openFileDialog.ShowDialog();
            //txtContent.LoadFile(openFileDialog.FileName);
            //string fName = openFileDialog1.FileName;
            string fName = openFileDialog.FileName;
            if (String.IsNullOrEmpty(fName))
                txtContent.Text = "";
            else
            {
                StreamReader sr = new StreamReader(fName);
                txtContent.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            fName = saveFileDialog.FileName;
            StreamWriter sw = new StreamWriter(fName);
            sw.Write(txtContent.Text);
            sw.Flush();
            sw.Close();
            this.Text = fName;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = txtContent.SelectionFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtContent.SelectionFont = fontDialog.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = txtContent.SelectionColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                txtContent.SelectionColor = colorDialog.Color;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.SelectAll();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed and Maintained by Anuraag Baishya");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fName))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ShowDialog();
                fName = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(txtContent.Text);
                sw.Flush();
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(txtContent.Text);
                sw.Flush();
                sw.Close();
            }
            this.Text = fName;
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Untitled";
        }
    }
}
