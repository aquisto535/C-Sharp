using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;



namespace easyCareApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm 
    {
        private readonly VideoCapture capture;


        public Form1()
        {
            InitializeComponent();
            capture = new VideoCapture();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            capture.Open(0, VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {
                Close();
                return;
            }

            ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight);
            backgroundWorker1.RunWorkerAsync();
        
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            capture.Dispose();
       
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker)sender;

            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    var frameBitmap = BitmapConverter.ToBitmap(frameMat);
                    bgWorker.ReportProgress(0, frameBitmap);
                }
                Thread.Sleep(100);
            }
        
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var frameBitmap = (Bitmap)e.UserState;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = frameBitmap;
        
        }

        private void diag_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateFile()
        {
            
            String str = pat_consult.Text;

            StreamWriter sw = new StreamWriter("C:\\Users\\user\\Desktop\\consult.txt", true);
            sw.WriteLine(str);
            sw.Close();

        }

    
        


public void saveRecordBtn_Click(object sender, EventArgs e)
        {
          

            if (pat_consult.Text == "")
            {
                MessageBox.Show("상담내용을 적어주세요");
            }

            string path = "@\"C:\\Users\\user\\Desktop\\consult.txt";


            if (File.Exists(path))
            {

            }
            else
            {

                CreateFile();
            }





            try

            {

                //Creating a new Bitmap object
                Bitmap captureBitmap = new Bitmap(this.ClientRectangle.Width + 200, this.ClientRectangle.Width, PixelFormat.Format32bppArgb);
                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                //Creating a Rectangle object which will
                //capture our Current Screen
                Rectangle captureRectangle = Screen.PrimaryScreen.Bounds;
                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                //Copying Image from The Screen
                captureGraphics.CopyFromScreen(captureRectangle.X, captureRectangle.Y, 0, 0, captureRectangle.Size);
                //Saving the Image File (I am here Saving it in My E drive).
                captureBitmap.Save(@"C:\Users\user\Desktop\Capture.jpg", ImageFormat.Jpeg);
                //Displaying the Successfull Result
                MessageBox.Show("Screen Captured");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      
    }
}
