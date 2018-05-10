using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KH_Screen_Viewer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void _close()
        {
            this.Close();
        }

        public Image PicImage
        {
            get { return displayBox1.Image; }
            set { displayBox1.Image = value; }
        }

      
    }
}
