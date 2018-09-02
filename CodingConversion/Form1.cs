using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodingConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encoding big5 = Encoding.GetEncoding("big5");
            Encoding gb2312 = Encoding.GetEncoding("gb2312");
            byte[] gb2312Ori = gb2312.GetBytes(textBox1.Text);
            byte[] big5New = Encoding.Convert(gb2312, big5, gb2312Ori);
            label1.Text = gb2312.GetString(big5New);
        }
    }
}
