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
        public Form3()
        {
            InitializeComponent();
        }
        private void midptellipse(double rx, double ry,
                        double xc, double yc)
        {

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
    }
}
