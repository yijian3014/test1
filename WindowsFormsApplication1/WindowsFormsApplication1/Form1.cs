using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("这是个GIT HUB测试程序！");
            MessageBox.Show(this.Parent, "新的测试", "这是标题");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            MessageBox.Show(c1.return_str(textBox1.Text));
        }
    }
}
