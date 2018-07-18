using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace KH_Screen_Viewer
{
    
    public partial class Form1 : Form
    {
        public void takeAScreeshot() //This function takes a screenshot of the primary screen and puts it in the pictureBox.
        {
            var bmpScreenshot = new Bitmap(Screen2.Bounds.Width, Screen2.Bounds.Height);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            gfxScreenshot.CopyFromScreen(Screen2.Bounds.X, Screen2.Bounds.Y, 0, 0, Screen2.Bounds.Size, CopyPixelOperation.SourceCopy);
            pictureBox1.Image = bmpScreenshot;
        }
        private Timer timer1;
        public void ShowScreenshotOnProgramLive() //this essentially runs takeAScreenshot() 30 times a second.
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 200;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            takeAScreeshot();
        }

        public Form1()
        {
            InitializeComponent();
            secondaryScreen();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e) //this runs the screenshot program when the checkbox is checked.
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = true;
                ShowScreenshotOnProgramLive();
            }
            else
            {
                checkBox1.Checked = false;
                pictureBox1.Image = null;
                timer1.Stop();
            }

        }

        public Form2 backform = new Form2();
        public Screen Screen2 = new object() as Screen;
        public object secondaryScreen()     //This finds the first non primary screen and sets it as Screen2. If there is only one screen then a message box will appear to determine what the user wants to do next
        {

            
            if (Screen.AllScreens.Length > 1)
            {
                for (int i = 0; i < Screen.AllScreens.Length; i++)
                {
                    if (Screen.AllScreens[i].Primary == false)
                    {
                        Screen2 = Screen.AllScreens[i];
                        setFormLocation(backform, Screen2);
                        break;
                    }
                }

            }
            else
            {
               var result = MessageBox.Show("No secondary screen detected. Click OK to use primary screen(not recomended) or cancel to close.","KH Screen Viewer", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Screen2 = Screen.PrimaryScreen;
                    setFormLocation(backform, Screen2);
                    backform.TopMost = false;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            return(Screen2);
        }
        private void ImageButton1_Click(object sender, EventArgs e)
        {
            if (ImageButton1.BackgroundImage == null)
            {
                return;
            }
            else
            {
                backform.Show();
                backform.displayBox1.Image = ImageButton1.BackgroundImage;
            }
        }
            private void setFormLocation(Form form, Screen Screen2)
        {
            Rectangle bounds = Screen2.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
        }
        private void black_Click(object sender, EventArgs e)
        {
            
          
            
                backform.Show();
                backform.displayBox1.Image = KH_Screen_Viewer.Properties.Resources.download;
            
            

        }
        private void closeDisplay_Click(object sender, EventArgs e)
        {
            if (backform.Visible == true)
            {
                backform.Hide();
                backform.displayBox1.Image = null;
            }
        }
        public Bitmap img = null;
        private void ImageButton1_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            Image img = new Bitmap(Bitmap.FromFile(files[0]));
            ImageButton1.BackgroundImage = img;
            Console.WriteLine(files[0]);
        }

        private void ImageButton1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                if (files[0].ToLower().EndsWith(".jpg") || (files[0].EndsWith(".png")) || (files[0].EndsWith(".jpeg")) || (files[0].EndsWith(".bmp")))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void ImageButton2_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            Image img = new Bitmap(Bitmap.FromFile(files[0]));
            ImageButton2.BackgroundImage = img;
            Console.WriteLine(files[0]);
        }

        private void ImageButton2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                if (files[0].ToLower().EndsWith(".jpg") || (files[0].EndsWith(".png")) || (files[0].EndsWith(".jpeg")) || (files[0].EndsWith(".bmp")))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }
        private void ImageButton2_Click(object sender, EventArgs e)
        {
            if (ImageButton2.BackgroundImage == null)
            {
                return;
            }
                backform.Show();
                backform.displayBox1.Image = ImageButton2.BackgroundImage;
        }
        private void ImageButton3_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            Image img = new Bitmap(Bitmap.FromFile(files[0]));
            ImageButton3.BackgroundImage = img;
            Console.WriteLine(files[0]);
        }

        private void ImageButton3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                if (files[0].ToLower().EndsWith(".jpg") || (files[0].EndsWith(".png")) || (files[0].EndsWith(".jpeg")) || (files[0].EndsWith(".bmp")))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }
        private void ImageButton3_Click(object sender, EventArgs e)
        {
 
            
            if (ImageButton3.BackgroundImage == null)
                {
                    return;
                }
            backform.Show();
            backform.displayBox1.Image = ImageButton3.BackgroundImage;
        }
        private void ImageButton4_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            Image img = new Bitmap(Bitmap.FromFile(files[0]));
            ImageButton4.BackgroundImage = img;
            Console.WriteLine(files[0]);
        }

        private void ImageButton4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                if (files[0].ToLower().EndsWith(".jpg") || (files[0].EndsWith(".png")) || (files[0].EndsWith(".jpeg")) || (files[0].EndsWith(".bmp")))
                {
                    e.Effect = DragDropEffects.Copy;
                 }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }
        private void ImageButton4_Click(object sender, EventArgs e)
        {
            {
                if (ImageButton4.BackgroundImage == null)
                {
                    return;
                }
                else
                {
                    backform.Show();
                    backform.displayBox1.Image = ImageButton4.BackgroundImage;
                }
            }
        }



        private void ClearButton1_Click(object sender, EventArgs e)
        {
            if (backform.displayBox1.Image == ImageButton1.BackgroundImage)
            {
                return;
            }
            else
            {
                ImageButton1.BackgroundImage = null;
            }
        }

        private void ClearButton2_Click(object sender, EventArgs e)
        {
            if (backform.displayBox1.Image == ImageButton2.BackgroundImage)
            {
                return;
            }
            else
            {
                ImageButton2.BackgroundImage = null;
            }
        }

        private void ClearButton3_Click(object sender, EventArgs e)
        {
            if (backform.displayBox1.Image == ImageButton3.BackgroundImage)
            {
                return;
            }
            else
            {
                ImageButton3.BackgroundImage = null;
            }
        }

        private void ClearButton4_Click(object sender, EventArgs e)
        {
            if (backform.displayBox1.Image == ImageButton4.BackgroundImage)
            {
                return;
            }
            else
            {
                ImageButton4.BackgroundImage = null;
            }
        }
    }
}