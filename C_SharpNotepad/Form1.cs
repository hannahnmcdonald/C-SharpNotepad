using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SharpNotepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // clear text box
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Able to clear the text box with the new option
            richTextBox1.Clear();
        }
        // new text box
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openNew = new OpenFileDialog();
            openNew.Title = "Open";
            // Able to open all types of files 
            openNew.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            // if ok, load file name in the richTextBox1 (only txt files, not .doc (word)
            if (openNew.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openNew.FileName, RichTextBoxStreamType.PlainText);
            // Sets text to new File txt
            this.Text = openNew.FileName;
        }
        // Save text box
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveText = new SaveFileDialog();
            saveText.Title = "Save";
            // Able to open all types of files 
            saveText.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            // if ok, load file name in the richTextBox1 (only txt files, not .doc (word)
            if (saveText.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveText.FileName, RichTextBoxStreamType.PlainText);
            // Sets text to new File txt
            this.Text = saveText.FileName;
        }
        // Exit text box
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Set date and time
        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut(); 
        }
    }
}
