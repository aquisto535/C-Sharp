using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form // 상속 클래스, 클래스 분리 가능.
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string str = txtinput.Text;

            //if(str.CompareTo("980101") >= 0)
            //{
            //label1.Text = "형님이시네요";
            //}
            //  else
            //  {
            //   label1.Text = "내가 형이네";
            //}

            string str = txtinput.Text;
            
            string newstr = str.Replace("ㅈㅈㅈ", "www");

            label1.Text = newstr;
            txtinput.Text = newstr;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
