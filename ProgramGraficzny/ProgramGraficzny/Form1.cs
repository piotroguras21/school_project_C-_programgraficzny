using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace ProgramGraficzny
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point p = Point.Empty;
        private Pen pioro;

        public Form1()
        {
            InitializeComponent();
            imgObrazek.Image = new Bitmap(400, 400);
            g = Graphics.FromImage(imgObrazek.Image);
            pioro = new Pen(Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imgObrazek_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                p = e.Location;
        }

        private void imgObrazek_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                g.DrawLine(pioro, p, e.Location);
                p = e.Location;

                imgObrazek.Refresh();
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            imgObrazek.Refresh();
        }

        private void buttoncolour_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = Kolor.BackColor;
            dialog.ShowDialog();
            Kolor.BackColor = dialog.Color;
            pioro.Color = dialog.Color;
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bmp|*.bmp";
            dialog.ShowDialog();
            if (dialog.FileName != "")
                imgObrazek.Image.Save(dialog.FileName);
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
