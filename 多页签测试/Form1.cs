using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 多页签测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage2.Parent = null;
            tabPage3.Parent = null;
            tabPage4.Parent = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabPage2.Parent = tabControl1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabPage3.Parent = tabControl1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabPage4.Parent = tabControl1;
        }
    }
}
