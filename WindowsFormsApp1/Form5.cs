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
    public partial class Form5 : Form
    {
        private List<Point> points;
        public Form5()
        {
            InitializeComponent();
            this.points = new List<Point>();

        }
        void lineBres(int x0, int y0, int xEnd, int yEnd)
        {
            Point po = new Point();
            int dx = Math.Abs(xEnd - x0), dy = Math.Abs(yEnd - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);
            var aBrush = Brushes.Black;
            var g = pLineBres.CreateGraphics();
           
            /* Determine which endpoint to use as start position.  */
            if (x0 > xEnd)
            {
                x = xEnd; y = yEnd; xEnd = x0;
            }
            else
            {
                x = x0; y = y0;
            }
           // setPixel(x, y);
            g.FillRectangle(aBrush, x, y, 1, 1);
            po.X = (int)(x);
            po.Y = (int)(y);

            points.Add(po);
            while (x < xEnd)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                
                g.FillRectangle(aBrush, x, y, 1, 1);
                po.X = (int)(x);
                po.Y = (int)(y);

                points.Add(po);
            }
        }

        private void BlineBres_Click(object sender, EventArgs e)
        {
            this.lineBres(int.Parse(tx1LineBres.Text), int.Parse(ty1lineBres.Text), int.Parse(tx2lineBres.Text), int.Parse(ty2lineBres.Text));

        }

        private void Tx2lineBres_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ty2lineBres_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransCButoon_Click(object sender, EventArgs e)
        {
            if (points.Count != 0 && transCx.Text != null && transCx.Text != null)
            {
                int dx = int.Parse(transCx.Text);
                int dy = int.Parse(transCy.Text);
                transformation.translate(ref points, dx, dy, ref pLineBres);
            }
            else
            {
                MessageBox.Show("You must enter dx and dy to translate and draw circule ", "translate error ",
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
                transformation.translate(ref points, dx, dy, ref pLineBres);
            }
            else
            {
                MessageBox.Show("You must enter dx and dy to translate and draw circule ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refxy_Click(object sender, EventArgs e)
        {

            if (points.Count != 0)
            {

                transformation.reflection(ref points, -1, 1, ref pLineBres);
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

                transformation.reflection(ref points, 1, -1, ref pLineBres);
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


                transformation.reflection(ref points, -1, -1, ref pLineBres);
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

                transformation.rotation(ref points, dx, ref pLineBres);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TRotateC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bscalc_Click(object sender, EventArgs e)
        {
            if (points.Count != 0 && scalCx.Text != null && scalCy.Text != null)
            {
                int dx = int.Parse(scalCx.Text);
                int dy = int.Parse(scalCy.Text);
                transformation.scale(ref points, dx, dy, ref pLineBres);

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
