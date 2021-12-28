using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = ".html|*.html";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate(OPF.FileName);
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            float x = 0;
            float y = 0;
            string result = "";
            float.TryParse(tb1, out x);
            float.TryParse(tb2, out y);
            if((y > 3 && y < 5 && x > -2 && x < 3) || (y > 2 && y < 3 && x > -2 && x < 5))
            {
                result = "Точка находится внутри закрашенной области.";
            } else if ((y==3 || y==5 && x==-2 || x==3) || (y==2 || y==3 && x==-2 || x==5))
            {
                result = "Точка находится на границе закрашенной области.";
            }
            else
            {
                result = "Точка находится вне закрашенной области.";
            }

            Form3 newForm = new Form3(result);
            newForm.Show();
            ToolStripLabel dateLabel = new ToolStripLabel(result);
            //toolStripStatusLabel2.(result);
        }

    }
}
