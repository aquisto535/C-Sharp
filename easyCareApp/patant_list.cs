using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace easyCareApp
{
    
    public partial class pats_lists : MetroFramework.Forms.MetroForm
    {
        public pats_lists()
        {
            InitializeComponent();
        }

        private void diag_button_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dig_startBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(); 
            form.Width = 1200;
            form.Height = 658;
        }

        private void patient_addBtn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || phoneTextBox.Text == " " || addressTextBox.Text == "")
            {
                MessageBox.Show("정보를 입력하지 않았습니다");
            }
            else
            {
                String[] strArr = new String[]
                {
                    nameTextBox.Text, phoneTextBox.Text, addressTextBox.Text
                };

                ListViewItem lvt = new ListViewItem(strArr);
                listView1.Items.Add(lvt);

                nameTextBox.Clear();
                phoneTextBox.Clear();
                addressTextBox.Clear();
            }
        }

        private void patient_deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = listView1.FocusedItem.Index;
            listView1.Items.RemoveAt(selectedIndex);
        }
    }
}
