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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            modalform modal = new modalform();
            
        }

        private void btnModalists_Click(object sender, EventArgs e)
        {
            modalistForm modaless =new modalistForm();
            modaless.str = textBox1.Text;
            modaless.Show();
        }
    }
}
