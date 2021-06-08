using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        private List<Point> points;
        public Form4()
        {
            InitializeComponent();
            this.points = new List<Point>();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            Point p = new Point();
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            double xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;
            var aBrush = Brushes.Black;
            var g = pLine.CreateGraphics();
            g.FillRectangle(aBrush,(int) Math.Round(x),(int) Math.Round(y), 1, 1);
            p.X = (int)(x );
            p.Y = (int)(y );

            points.Add(p);

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                g.FillRectangle(aBrush, (int)Math.Round(x), (int)Math.Round(y), 1, 1);
                p.X = (int)(x );
                p.Y = (int)(y );

                points.Add(p);
            }

        }


        private void Bline_Click(object sender, EventArgs e)
        {
            this.lineDDA(int.Parse(textBox1.Text), int.Parse(ty1line.Text), int.Parse(tx2line.Text), int.Parse(ty2line.Text));
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Ty2line_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransCButoon_Click(object sender, EventArgs e)
        {

            if (points.Count != 0 && transCx.Text != null && transCx.Text != null)
            {
                int dx = int.Parse(transCx.Text);
                int dy = int.Parse(transCy.Text);
                transformation.translate(ref points, dx, dy, ref pLine);
            }
            else
            {
                MessageBox.Show("Error", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bscalc_Click(object sender, EventArgs e)
        {
            if (points.Count != 0 && scalCx.Text != null && scalCy.Text != null)
            {
                int dx = int.Parse(scalCx.Text);
                int dy = int.Parse(scalCy.Text);
                transformation.scale(ref points, dx, dy, ref pLine);

            }
            else
            {
                MessageBox.Show("error", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sheering_Click(object sender, EventArgs e)
        {
            if (points.Count != 0 && sheeringxc.Text != null && sheeringyc.Text != null)
            {
                int dx = int.Parse(sheeringxc.Text);
                int dy = int.Parse(sheeringyc.Text);
                transformation.translate(ref points, dx, dy, ref pLine);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Brotatec_Click(object sender, EventArgs e)
        {
            if (points.Count != 0 && tRotateC.Text != null)
            {
                int dx = int.Parse(tRotateC.Text);

                transformation.rotation(ref points, dx, ref pLine);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refxy_Click(object sender, EventArgs e)
        {
            if (points.Count != 0)
            {

                transformation.reflection(ref points, -1, 1, ref pLine);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refxc_Click(object sender, EventArgs e)
        {
            if (points.Count != 0)
            {

                transformation.reflection(ref points, 1, -1, ref pLine);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Brefc_Click(object sender, EventArgs e)
        {
            if (points.Count != 0)
            {


                transformation.reflection(ref points, -1, -1, ref pLine);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
