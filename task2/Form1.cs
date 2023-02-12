using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_3
{
    public partial class Form1 : Form
    {
        int x, y, a, b;
        PointF[] points;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightGray;
        }
        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            PointF point = new PointF(e.X, e.Y);

            if (points == null)
            {
                points = new PointF[] { point };
            }
            else
            {
                PointF[] newPoints = new PointF[points.Length + 1];
                Array.Copy(points, newPoints, points.Length);
                newPoints[newPoints.Length - 1] = point;
                points = newPoints;
            }

        }

        private void Form1_MouseUpOne(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            a = e.X - x;
            b = e.Y - y;

            Graphics g = this.CreateGraphics();

            Color color;

            if (rBlack.Checked)
            {
                color = Color.Black;
            }
            else if (rRed.Checked)
            {
                color = Color.Red;
            }
            else
            {
                color = Color.Blue;
            }

            Pen p = new Pen(color, 2);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

            if (rEllipse.Checked)
            {
                g.DrawEllipse(p, x, y, a, b);
            }
            else if (rCircle.Checked)
            {
                g.DrawEllipse(p, x, y, a, a);
            }
            else if (rLine.Checked)
            {
                g.DrawLine(p, x, y, e.X, e.Y);
            }
            else if (rRectangle.Checked)
            {
                g.DrawRectangle(p, x, y, a, a);
            }
            else if (rPolygon.Checked)
            {
                g.DrawPolygon(p, points);
            }
        }

        private void rEllipse_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

