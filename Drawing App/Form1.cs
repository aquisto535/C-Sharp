using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_App
{
    public partial class Form1 : Form
    {
        private int shape;
        private Point ptstar1;
        private Point ptend;
        private Pen mypen;
        private int rtwitdh;
        private int rtheight;
        private Boolean bpress;
        Graphics g;
        Rectangle rect;


        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboThick_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shape = 0;
            ptstar1 = new Point(0,0);
            ptend = new Point(0,0);
            mypen = new Pen(Color.Black);
            rtheight = 0;
            rtwitdh = 0;   
            bpress = false;
            g = Graphics.FromHwnd(this.Handle);
        }

        private void toolstripBtnLine_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bpress = true;
            ptstar1.X = e.X;
            ptstar1.Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shape == 0)
            {
                if(bpress == true)
                {
                    g.Clear(Color.White);
                    ptend = new Point(e.X, e.Y);
                    g.DrawLine(mypen, ptstar1, ptend);  
                }
            }
            else if (shape == 1)
            {
                if (bpress == true)
                {
                    g.Clear(Color.White);


                    rtwitdh = Math.Abs(e.X - ptstar1.X);
                    rtheight -= Math.Abs(e.Y - ptstar1.Y);
                    rect = new Rectangle(ptstar1.X, ptstar1.Y, rtheight, rtheight);
                    g.DrawArc(mypen, rect,0, 365);



                   
                }
            }
            else if (shape == 2)
            {
                if (bpress == true)
                {
                    g.Clear(Color.White);


                    rtwitdh = Math.Abs(e.X - ptstar1.X);
                    rtheight -= Math.Abs(e.Y - ptstar1.Y);
                    rect = new Rectangle(ptstar1.X, ptstar1.Y, rtheight, rtheight);
                    g.DrawRectangle(mypen, rect);




                }
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if(shape == 0)
            {
                ptend = new Point(e.X, e.Y);
                g.DrawLine(mypen, ptstar1, ptend);
            } else if(shape == 1) {
                rtwitdh = Math.Abs(e.X - ptstar1.X);
                rtheight -= Math.Abs(e.Y - ptstar1.Y);
                rect = new Rectangle(ptstar1.X, ptstar1.Y, rtheight, rtheight);
                g.DrawRectangle(mypen, rect);
            }
            else if (shape == 2)
            {
                rtwitdh = Math.Abs(e.X - ptstar1.X);
                rtheight -= Math.Abs(e.Y - ptstar1.Y);
                rect = new Rectangle(ptstar1.X, ptstar1.Y, rtheight, rtheight);
                g.DrawArc(mypen, rect, 0, 365);
            }
            bpress = false;
        }

        private void toolstripnew_Click(object sender, EventArgs e)
        {

        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolstripexit_Click(object sender, EventArgs e)
        {

        }

        private void toolstripline_Click(object sender, EventArgs e)
        {
            this.shape = 0;
        }

        private void toolstriprect_Click(object sender, EventArgs e)
        {
            this.shape = 1;
        }

        private void toolstripcircle_Click(object sender, EventArgs e)
        {
            this.shape = 2;
        }

        private void toolstripcolor_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == this.colorDialog.ShowDialog())
            {
                this.mypen.Color = this.colorDialog.Color;
            }
        }

        private void toolstripBtnLine_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
     
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void green_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboThick_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mypen.Width = int.Parse(toolStripComboThick.SelectedItem.ToString()) * 2; 
        }
    }
}
