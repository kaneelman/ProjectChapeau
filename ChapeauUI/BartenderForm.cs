using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class BartenderForm : Form
    {
        public BartenderForm()
        {
            InitializeComponent();
            
        }

        private void BartenderForm_Load(object sender, EventArgs e)
        {
            string[] images = new string[] { "403347_1_1_1.jpg", "SmilingCat 4.2.png", "SmilingCat_=3.jpg", "tumblr_piah3njiRB1xoyw8po1_1280.jpg" };
            var image = imageList1.Images;
            foreach (var item in images)
            {
                image.Add(Image.FromFile(item));
            }

            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[1];
            pictureBox3.Image = imageList1.Images[2];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
