using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cellar
{
    public partial class Cellar : Form
    {
        public Cellar()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMain.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Shows the openFileDialog
            openFileDialog1.ShowDialog();
            //Reads the text file
            System.IO.StreamReader OpenFile = new System.IO.StreamReader(openFileDialog1.FileName);
            //Displays the text file in the textBox
            txtMain.Text = OpenFile.ReadToEnd();
            //Closes the proccess
            OpenFile.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Determines the text file to save to
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(openFileDialog1.FileName);
            //Writes the text to the file
            SaveFile.WriteLine(txtMain.Text);
            //Closes the proccess
            SaveFile.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the saveFileDialog
            saveFileDialog1.ShowDialog();
            //Determines the text file to save to
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName);
            //Writes the text to the file
            SaveFile.WriteLine(txtMain.Text);
            //Closes the proccess
            SaveFile.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //'Exit' menu item functionality
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //'Undo' menu item functionality
            txtMain.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //'Redo' menu item functionality
            txtMain.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //'Cut' menu item functionality
            txtMain.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //'Copy' menu item functionality
            txtMain.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //'Paste' menu item functionality
            txtMain.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //'Select All' menu item functionality
            txtMain.SelectAll();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //'Word Wrap' menu item functionality
            txtMain.WordWrap = wordWrapToolStripMenuItem.Checked;
        }
    }
}
