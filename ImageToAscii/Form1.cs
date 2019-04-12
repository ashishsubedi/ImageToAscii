using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToAscii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string imagePath = "";
        int asciiWidth;
        string _content;
        private string[] _AsciiChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", " " };

        private void button1_Click(object sender, EventArgs e)
        {
            openFile.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";

            DialogResult result = openFile.ShowDialog();

            if(result == DialogResult.OK)
            {
                imagePath = path.Text = openFile.FileName;
                convertBtn.Enabled = true;
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            convertBtn.Enabled = false;

            Bitmap image = new Bitmap(imagePath);
            asciiWidth = this.trackBar.Value;
            image = GetResizedImage(image, asciiWidth);
            _content = ConvertToAscii(image);
            data.Text = _content;
            save.Enabled = true;

        }

        private Bitmap GetResizedImage(Bitmap image, int asciiWidth)
        {
            int asciiHeight = 0 ;

            asciiHeight = (int)Math.Ceiling((double)image.Width * asciiWidth / image.Height);

            Bitmap newImage = new Bitmap(asciiWidth, asciiHeight);
            Graphics g = Graphics.FromImage((Image)newImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, asciiWidth, asciiHeight);
            g.Dispose();
            return newImage;

        }
        private string ConvertToAscii(Bitmap image)
        {
            //bool toogle = false;
            //StringBuilder sb = new StringBuilder();

            //for(int h=0; h<image.Height; h++)
            //{
            //    for (int w = 0; w < image.Width; w++)
            //    {
            //        Color pixelColor = image.GetPixel(w, h);
            //        int average;
            //        average = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

            //        Color gray = Color.FromArgb(average);

            //        if (!toogle)
            //        {
            //            int index = (gray.R * 10) / 255;
            //            sb.Append(_AsciiChars[index]);
            //        }
            //    }
            //    if (!toogle)
            //    {
            //        sb.Append("\n");
            //        toogle = true;
            //    }
            //    else
            //    {
            //        toogle = false;
            //    }
            //}
            //return sb.ToString();

            Boolean toggle = false;

            StringBuilder sb = new StringBuilder();



            for (int h = 0; h < image.Height; h++)

            {

                for (int w = 0; w < image.Width; w++)

                {

                    Color pixelColor = image.GetPixel(w, h);

                    //Average out the RGB components to find the Gray Color

                    int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    Color grayColor = Color.FromArgb(red, green, blue);



                    //Use the toggle flag to minimize height-wise stretch

                    if (!toggle)

                    {

                        int index = (grayColor.R * 10) / 255;

                        sb.Append(_AsciiChars[index]);

                    }

                }

                if (!toggle)

                {

                    sb.Append("\n");

                    toggle = true;

                }

                else

                {

                    toggle = false;

                }

            }

            return sb.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File (*.txt)|.txt";

            DialogResult diag = saveFileDialog1.ShowDialog();

            if (diag == DialogResult.OK)

            {              

                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                sw.Write(_content);

                sw.Flush();

                sw.Close();

            }
        }
    }
}
