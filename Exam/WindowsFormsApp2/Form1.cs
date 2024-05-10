using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private ToolTip ButtonCTT;
        private ToolTip ButtonNTT;
        private CalculatorForm CalculatorForm;
        private Notepad notepad;

        public Form1()
        {
            InitializeComponent();
            toolTipFunc();
            CalculatorForm = new CalculatorForm();
            notepad = new Notepad();
        }

        private void toolTipFunc()
        {
            ButtonCTT = new ToolTip();
            ButtonCTT.SetToolTip(buttonC, "Open Calculator");
            ButtonNTT = new ToolTip();
            ButtonNTT.SetToolTip(buttonN, "Open Notepad");
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            CalculatorForm.ShowDialog();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            notepad.ShowDialog();
        }

        private void ukrainianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ukrainianToolStripMenuItem.Text = "Українською";
            englishToolStripMenuItem.Text = "Англійською";
            buttonC.Text = "Калькулятор";
            buttonN.Text = "Блокнот";
            toolStripStatusLabel1.Text = "Винничук Богдан";
            languageToolStripMenuItem.Text = "Мова";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ukrainianToolStripMenuItem.Text = "Ukrainian";
            englishToolStripMenuItem.Text = "English";
            buttonC.Text = "Calculator";
            buttonN.Text = "Notepad";
            toolStripStatusLabel1.Text = "Vynnychuk Bogdan";
            languageToolStripMenuItem.Text = "Language";
        }
    }
}
