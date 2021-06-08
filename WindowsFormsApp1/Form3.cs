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
    public partial class Form3 : Form
    {
        private List<Point> points;
        public Form3()
        {
            InitializeComponent();
            this.points = new List<Point>();
        }
        private void midptellipse(double rx, double ry,
                        double xc, double yc)
        {
            Point p = new Point();

            double dx, dy, d1, d2, x, y;
            x = 0;
            y = ry;

            // Initial decision parameter of region 1
            d1 = (ry * ry) - (rx * rx * ry) +
                            (0.25f * rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;
            var aBrush = Brushes.Black;
            var g = pElipse.CreateGraphics();

            // For region 1
            while (dx < dy)
            {

                // Print points based on 4-way symmetry
                g.FillRectangle(aBrush, (int)(x + xc), (int)(y + yc), 1, 1);
                g.FillRectangle(aBrush, (int)(-x + xc), (int)(y + yc), 1, 1);
                g.FillRectangle(aBrush, (int)(x + xc), (int)(-y + yc), 1, 1);
                g.FillRectangle(aBrush, (int)(-x + xc), (int)(-y + yc), 1, 1);


                p.X = (int)(x + xc);
                p.Y = (int)(y+yc);

                points.Add(p);

                p.X = (int)(-x+xc);
                p.Y = (int)(y + yc);

                points.Add(p);

                p.X = (int)(x + xc);
                p.Y = (int)(-y + yc);

                points.Add(p);




                // Checking and updating value of
                // decision parameter based on algorithm
                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);

                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                }
            }

            // Decision parameter of region 2
            d2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f)))
                + ((rx * rx) * ((y - 1) * (y - 1)))
                - (rx * rx * ry * ry);

            // Plotting points of region 2
            while (y >= 0)
            {
                g.FillRectangle(aBrush, (int)(x + xc), (int)(y + yc), 1, 1);
                g.FillRectangle(aBrush, (int)(-x + xc), (int)(y + yc), 1, 1);
                g.FillRectangle(aBrush, (int)(x + xc), (int)(-y + yc), 1, 1);
                g.FillRectangle(aBrush, (int)(-x + xc), (int)(-y + yc), 1, 1);

                p.X = (int)(x + xc);
                p.Y = (int)(y + yc);

                points.Add(p);

                p.X = (int)(-x + xc);
                p.Y = (int)(y + yc);

                points.Add(p);

                p.X = (int)(x + xc);
                p.Y = (int)(-y + yc);

                points.Add(p);

                p.X = (int)(-x + xc);
                p.Y = (int)(-y + yc);

                points.Add(p);


                // Checking and updating parameter
                // value based on algorithm
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }
            }
        }
        private void Bline_Click(object sender, EventArgs e)
        {
            midptellipse(int.Parse(rx.Text), int.Parse(ry.Text), int.Parse(xc.Text), int.Parse(yc.Text));
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TransCButoon_Click(object sender, EventArgs e)
        {

            

            if (points.Count != 0 && transCx.Text != null && transCx.Text != null)
            {
                int dx = int.Parse(transCx.Text);
                int dy = int.Parse(transCy.Text);
                transformation.translate(ref points, dx, dy, ref pElipse);
            }
            else
            {
                MessageBox.Show("Error", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        
        private void Sheeringxc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sheering_Click(object sender, EventArgs e)
        {
            if (points.Count != 0 && sheeringxc.Text != null && sheeringyc.Text != null)
            {
                int dx = int.Parse(sheeringxc.Text);
                int dy = int.Parse(sheeringyc.Text);
                transformation.translate(ref points, dx, dy, ref pElipse);
            }
            else
            {
                MessageBox.Show("Error", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refxy_Click_1(object sender, EventArgs e)
        {
            if (points.Count != 0)
            {

                transformation.reflection(ref points, -1, 1, ref pElipse);
            }
            else
            {
                MessageBox.Show("Error", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refxc_Click_1(object sender, EventArgs e)
        {
            if (points.Count != 0)
            {

                transformation.reflection(ref points, 1, -1, ref pElipse);
            }
            else
            {
                MessageBox.Show("Error", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Brefc_Click_1(object sender, EventArgs e)
        {
            if (points.Count != 0)
            {


                transformation.reflection(ref points, -1, -1, ref pElipse);
            }
            else
            {
                MessageBox.Show("Error", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Brotatec_Click_1(object sender, EventArgs e)
        {
            if (points.Count != 0 && tRotateC.Text != null)
            {
                int dx = int.Parse(tRotateC.Text);

                transformation.rotation(ref points, dx, ref pElipse);
            }
            else
            {
                MessageBox.Show("Error", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TRotateC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bscalc_Click_1(object sender, EventArgs e)
        {
            if (points.Count != 0 && scalCx.Text != null && scalCy.Text != null)
            {
                int dx = int.Parse(scalCx.Text);
                int dy = int.Parse(scalCy.Text);
                transformation.scale(ref points, dx, dy, ref pElipse);

            }
            else
            {
                MessageBox.Show("You must enter dx and dy to scale and draw circule ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScalCy_TextChanged(object sender, EventArgs e)
        {

        }

        private void ScalCx_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransCy_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransCx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sheeringyc_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
