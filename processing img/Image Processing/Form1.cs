using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            DialogResult dr = open.ShowDialog();
            if (dr==DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(open.FileName);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(pictureBox1.Image);

            Bitmap bt2 = new Bitmap(bt.Width,bt.Height);

            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    bt2.SetPixel(bt.Width - 1 - x,y,c);
                }
            }
            pictureBox7.Image = bt2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(pictureBox1.Image);
            int th = int.Parse(textBox1.Text);

            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    if(avg<th)
                    {
                        bt.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        bt.SetPixel(x, y, Color.Black);
                    }
                }
            }
            pictureBox6.Image = bt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(pictureBox1.Image);
            for(int y = 0; y < bt.Height; y++)
            {
                for(int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    Color tempc = Color.FromArgb(avg, avg, avg);
                    bt.SetPixel(x, y, tempc);
                }
            }
            pictureBox2.Image = bt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    Color tempc = Color.FromArgb(255, avg, avg);
                    bt.SetPixel(x, y, tempc);
                }
            }
            pictureBox3.Image = bt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    Color tempc = Color.FromArgb(avg, 255, avg);
                    bt.SetPixel(x, y, tempc);
                }
            }
            pictureBox4.Image = bt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(pictureBox1.Image);
            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    int avg = (r + g + b) / 3;
                    Color tempc = Color.FromArgb(avg, avg, 255);
                    bt.SetPixel(x, y, tempc);
                }
            }
            pictureBox5.Image = bt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bt = new Bitmap(pictureBox1.Image);

            Bitmap bt2 = new Bitmap(bt.Width, bt.Height);

            for (int y = 0; y < bt.Height; y++)
            {
                for (int x = 0; x < bt.Width; x++)
                {
                    Color c = bt.GetPixel(x, y);
                    bt2.SetPixel(bt.Width - 1 - x, y, c);
                }
            }
            pictureBox7.Image = bt2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
