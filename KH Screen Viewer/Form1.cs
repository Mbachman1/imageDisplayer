using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace KH_Screen_Viewer
{

    public partial class Form1 : Form
    {
        public void takeAScreeshot() //This function takes a screenshot of the primary screen and puts it in the pictureBox.
        {
            var mon2 = Screen.AllScreens[0];
            var bmpScreenshot = new Bitmap(mon2.Bounds.Width, mon2.Bounds.Height);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            gfxScreenshot.CopyFromScreen(mon2.Bounds.X, mon2.Bounds.Y, 0, 0, mon2.Bounds.Size, CopyPixelOperation.SourceCopy);
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Screen Screen2 = new object() as Screen;
        public object secondaryScreen()     //This finds the first non primary screen and sets it as Screen2.
        {
            if (Screen.AllScreens.Length > 0)
            {
                for (int i = 0; i < Screen.AllScreens.Length; i++)
                {
                    if (Screen.AllScreens[i].Primary == false)
                    {
                      Screen2 = Screen.AllScreens[i];
                    }
                }
            }
            return(Screen.PrimaryScreen);
        }
        private void ImageButton1_Click(object sender, EventArgs e)
        {
            if (ImageButton1.BackgroundImage == null)
            {
                return;
            }
            if (Application.OpenForms["Form2"] == null)
            {
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = ImageButton1.BackgroundImage;
            }
            else if (Application.OpenForms["Form2"] != null)
            {
                Application.OpenForms["Form2"].Close();
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = ImageButton1.BackgroundImage;
            }

        }
        private void setFormLocation(Form form, Screen screen)
        {
            Rectangle bounds = screen.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
        }

        public void new_Form()
        {
            Form2 n = new Form2();

        }

        private void black_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["Form2"] == null)
            {
                secondaryScreen();
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = KH_Screen_Viewer.Properties.Resources.download;
            }
            else if (Application.OpenForms["Form2"] != null)
            {
                Application.OpenForms["Form2"].Close();
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = KH_Screen_Viewer.Properties.Resources.download;

            }

        }
        private void closeDisplay_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form2"] != null)
            {
                Application.OpenForms["Form2"].Close();
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

            if (e.Data.GetDataPresent(DataFormats.FileDrop))

                e.Effect = DragDropEffects.Copy;

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

            if (e.Data.GetDataPresent(DataFormats.FileDrop))

                e.Effect = DragDropEffects.Copy;

        }
        private void ImageButton2_Click(object sender, EventArgs e)
        {
            if (ImageButton2.BackgroundImage == null)
            {
                return;
            }
                if (Application.OpenForms["Form2"] == null)
            {
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = ImageButton2.BackgroundImage;
            }
            else if (Application.OpenForms["Form2"] != null)
            {
                Application.OpenForms["Form2"].Close();
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = ImageButton2.BackgroundImage;
            }
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

            if (e.Data.GetDataPresent(DataFormats.FileDrop))

                e.Effect = DragDropEffects.Copy;

        }
        private void ImageButton3_Click(object sender, EventArgs e)
        {
            if (ImageButton3.BackgroundImage == null)
            {
                return;
            }
            if (Application.OpenForms["Form2"] == null)
            {
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = ImageButton3.BackgroundImage;
            }
            else if (Application.OpenForms["Form2"] != null)
            {
                Application.OpenForms["Form2"].Close();
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = ImageButton3.BackgroundImage;
            }
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

            if (e.Data.GetDataPresent(DataFormats.FileDrop))

                e.Effect = DragDropEffects.Copy;

        }
        private void ImageButton4_Click(object sender, EventArgs e)
        {
            if (ImageButton4.BackgroundImage == null)
            {
                return;
            }
            if (Application.OpenForms["Form2"] == null)
            {
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = ImageButton4.BackgroundImage;
            }
            else if (Application.OpenForms["Form2"] != null)
            {
                Application.OpenForms["Form2"].Close();
                Form2 n = new Form2();
                setFormLocation(n, Screen2);
                n.Show();
                n.displayBox1.Image = ImageButton4.BackgroundImage;
            }
        }
    }
}