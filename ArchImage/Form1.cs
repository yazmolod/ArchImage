using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ArchImage
{
    public partial class Form1 : Form
    {
        int _im_index = 0;
        int CurrentImageIndex {get => _im_index;
            set 
            {
                if (value >= ImagePaths.Count) _im_index = 0;
                else if (value < 0) _im_index = ImagePaths.Count-1;
                else _im_index = value;
            } 
        }
        double NeedSize
        {
            get
            {
                double res;
                if (double.TryParse(size_textBox.Text, out res))
                { return res; }
                else return 1.0;
            }
        }
        int clickCounter = 0;
        Point pt1;
        Point pt2;
        string Folder { get; set; }
        List<string> ImagePaths { get; set; }
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            BindEvents();
        }

        private void LoadImagePaths()
        {
            DirectoryInfo d = new DirectoryInfo(Folder);
            ImagePaths = d.GetFiles("*.jpg").Select(x => x.FullName).ToList();
            if (ImagePaths.Count > 0)
            {
                UpdateImage();
            }
        }

        private void BindEvents()
        {
            pictureBox1.MouseClick += PictureBox1_MouseClick;
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            double DPI_X, DPI_Y;
            using (Graphics g = this.CreateGraphics())
            {
                DPI_X = g.DpiX;
                DPI_Y = g.DpiY;
            }
            Point coordinates = e.Location;
            if (clickCounter == 0)
            {
                clickCounter += 1;
                pt1 = coordinates;
            }
            else
            {
                clickCounter = 0;
                pt2 = coordinates;
                double dX = (pt2.X - pt1.X) / DPI_X * 2.54;
                double dY = (pt2.Y - pt1.Y) / DPI_Y * 2.54;
                double realDistance = Math.Sqrt(Math.Pow(dX, 2.0) + Math.Pow(dY, 2.0));
                double factor = NeedSize / realDistance;
                changeImageSize(factor);
            }
        }

        private void changeImageSize(double factor)
        {
            Image im = pictureBox1.Image;
            int new_width = (int)Math.Round(im.Width * factor);
            int new_height = (int)Math.Round(im.Height * factor);
            Size size = new Size(new_width, new_height);
            pictureBox1.Image = new Bitmap(im, size);
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Folder = dialog.SelectedPath;
                LoadImagePaths();
            }
        }

        private void MyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Left)
            {

            }
            else if (e.Modifiers == Keys.Right)
            {

            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            CurrentImageIndex -= 1;
            UpdateImage();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            CurrentImageIndex += 1;
            UpdateImage();
        }

        private void UpdateImage()
        {
            Image i = new Bitmap(ImagePaths[_im_index]);
            double ow = pictureBox1.Width;
            double h = i.Height;
            double w = i.Width;
            int newHeight = (int)(ow * h / w );
            Image resize = new Bitmap(i, new Size(pictureBox1.Width, newHeight));
            pictureBox1.Image = resize;
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            changeImageSize(1.25);
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            changeImageSize(0.75);
        }
    }
}
