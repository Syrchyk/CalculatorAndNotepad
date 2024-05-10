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

namespace WindowsFormsApp2
{
    public partial class Notepad : Form
    {
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        private readonly string workFilter = "Text file (*txt)|*.txt|All file (*.*)|*.*";
        public Notepad()
        {
            InitializeComponent();
        }
        private void InitializationFileDialog()
        {
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog();
            openFile.Filter = saveFile.Filter = workFilter;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(openFile.FileName))
            {
                textBox1.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(saveFile.FileName))
            {
                File.WriteAllText(saveFile.FileName, textBox1.Text);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
