using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace main7
{
    public partial class Form1_封面 : Form
    {
        public Form1_封面()
        {
            InitializeComponent();
        }

        private void button1_前方_Click(object sender, EventArgs e)
        {//窗口跳转
            this.Hide();
            Form2_前方交会 fr2=new Form2_前方交会();
            fr2.Show();
            
        }

        private void button_后方_Click(object sender, EventArgs e)
        {
          //窗口跳转
            this.Hide();
            Form3_后方交会 fr3 = new Form3_后方交会();
            fr3.Show();
        }

        private void button_结束程序_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
