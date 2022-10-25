using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

     
    }
}
