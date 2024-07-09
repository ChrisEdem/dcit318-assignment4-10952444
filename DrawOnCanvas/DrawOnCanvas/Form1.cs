using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawOnCanvas
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint = new Point(0, 0);
        private Point endPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            endPoint = e.Location;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                e.Graphics.DrawLine(Pens.Black, startPoint, endPoint);
            }
        }
    }
}


