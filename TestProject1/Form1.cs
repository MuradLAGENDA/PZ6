using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (label1.Text != String.Empty)
                label1.Text = (Int32.Parse(label1.Text) + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (label1.Text != String.Empty)
                label1.Text = (Int32.Parse(label1.Text) - 1).ToString();
            else label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
