using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog
{
    public partial class modalistForm : Form
    {
        public string str;
        public modalistForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (str.Contains(txtSearch.Text))
            {
                MessageBox.Show("문자열 찾았음");
            }
            else
            {
                MessageBox.Show("문자열 못 찾았음");
            }
        }
    }
}
