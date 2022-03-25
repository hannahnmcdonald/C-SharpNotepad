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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Able to clear the text box with the new option
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openNew = new OpenFileDialog();
            openNew.Title = "Open";
            // Able to open all types of files 
            openNew.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";

        }
    }
}
