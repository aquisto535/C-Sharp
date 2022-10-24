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

        private void btnevent_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("버튼을 클릭하였습니다");

            string strorder = "";
            lblorder.Text = "";

            if (ckbame.Checked == true)
            {
                strorder += ckbame.Text + "\n";
            }

            if (ckblatte.Checked == true)
            {
                strorder += ckblatte.Text + "\n";
            }
            if (ckbmoca.Checked == true)
            {
                strorder += ckbmoca.Text + "\n";
            }
            if (ckbgreen.Checked == true)
            {
                strorder += ckbgreen.Text + "\n";
            }

            lblorder.Text = strorder + "를 주문하셨습니다.";

            lblpay.Text = cbpay.Text + "\n으로" + lbInfo.Text + "결제방법을\n선택하였습니다";

            string strText = txtOrder.Text + "\n라고 접수되었습니다.";
            MessageBox.Show(strText);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            if(radioagree1.Checked == true)
            {
                MessageBox.Show("개인정보 동의 하셨습니다");
            }
            else
            {
                MessageBox.Show("개인정보 동의하지 않으셨습니다");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbpay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            if(cbpay.SelectedIndex == 0)
            {
                lbInfo.Items.Add("일시불");
                lbInfo.Items.Add("3개월 할부");
                lbInfo.Items.Add("6개월 할부");
            } else if(cbpay.SelectedIndex == 1)
            {
                lbInfo.Items.Add("하루은행");
                lbInfo.Items.Add("실망은행");
                lbInfo.Items.Add("국물은행");
            } else if( cbpay.SelectedIndex == 2)
            {
                lbInfo.Items.Add("N포인트");
                lbInfo.Items.Add("중요포인트");
                lbInfo.Items.Add("레이저포인트");
            }
        }
    }
}
