using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quarters
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image File (*.jpg, *.bmp)|*.jpg; *.bmp";
            of.Title = "Open an Image";
            of.ShowDialog();
            if (of.FileName != null)
            {
                p1.Image = new Bitmap(of.FileName);
                p1.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image File (*.jpg, *.bmp)|*.jpg; *.bmp";
            of.Title = "Open an Image";
            of.ShowDialog();
            if (of.FileName != null)
            {
                p2.Image = new Bitmap(of.FileName);
                p2.SizeMode = PictureBoxSizeMode.StretchImage;
               
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p1.SizeMode = PictureBoxSizeMode.StretchImage;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            p3.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap n1 = new Bitmap(p1.Image);
            Bitmap n2 = new Bitmap(p2.Image);
            Bitmap n3 = new Bitmap(n1.Width, n1.Height);
            //--------------------------------------------------------------------------------
            //part1 from image1
            for (int i = 0; i < n1.Width / 2; i++)
            {
                for (int j = 0; j < n1.Height / 2; j++)
                {
                    n3.SetPixel(i, j, n1.GetPixel(i, j));
                }

            }
            /////////////////////////////////////////////////////////
            //part4 from image1
            for (int i = n1.Width / 2; i < (n1.Width); i++)
            {

                for (int j = n1.Height / 2; j < n1.Height; j++)
                {
                    n3.SetPixel(i, j, n1.GetPixel(i, j));

                }

            }

            ////////////////////////////////////////////////////////////////
            //part2 from image2
            for (int i = n2.Width / 2; i < n2.Width; i++)
            {

                for (int j = 0; j < n2.Height / 2; j++)
                {

                    n3.SetPixel(i, j, n2.GetPixel(i, j));

                }

            }
            /////////////////////////////////////////////////////////////////////
            //part3 from image2
            for (int i = 0; i < n2.Width / 2; i++)
            {

                for (int j = n2.Height / 2; j < n2.Height; j++)
                {
                    n3.SetPixel(i, j, n2.GetPixel(i, j));

                }

            }

            p3.Image = n3;


        }
    }
}
