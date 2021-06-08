using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class transformation
    {
        static public void translate(ref List<Point> x,int dx,int dy,ref Panel panel)
        {
            var aBrush = Brushes.Black;
            var g = panel.CreateGraphics();
            panel.Refresh();
            Point p = new Point();
            for (int i = 0; i < x.Count; i++)
            {
                p = x[i];

                g.FillRectangle(aBrush, p.X + dx, p.Y + dy, 1, 1);


            }
        }
        static public void scale(ref List<Point> x, int sx, int sy, ref Panel panel)
        {
            var aBrush = Brushes.Black;
            var g = panel.CreateGraphics();
            Point p = new Point();
            for (int i = 0; i < x.Count; i++)
            {
                p = x[i];

                g.FillRectangle(aBrush, (p.X *sx), (p.Y * sy), 1, 1);

            }
        }
        static public void rotation(ref List<Point> x, double angle, ref Panel panel)
        {
            var aBrush = Brushes.Black;
            var g = panel.CreateGraphics();
            Point p = new Point();
            for (int i = 0; i < x.Count; i++)
            {
                p = x[i];

                g.FillRectangle(aBrush,(int)Math.Round( p.X*Math.Cos(angle)- p.Y*Math.Sin(angle)) , (int)Math.Round(p.Y * Math.Cos(angle)+p.X*Math.Sin(angle)), 1, 1);

            }
        }
        static public void reflection( ref List<Point> x, int dx,int dy, ref Panel panel)
        {
            var aBrush = Brushes.Black;
            var g = panel.CreateGraphics();
            Point p = new Point();
            for (int i = 0; i < x.Count; i++)
            {
                p = x[i];

                g.FillRectangle(aBrush, p.X * dx ,p.Y *dy, 1, 1);
            }
        }

        static public void sheering(ref List<Point> x, int dx ,int dy , ref Panel panel)
        {
            var aBrush = Brushes.Black;
            var g = panel.CreateGraphics();
            Point p = new Point();
            for (int i = 0; i < x.Count; i++)
            {
                p = x[i];

                g.FillRectangle(aBrush, p.X +(dx*p.Y), p.Y+(p.X*dy), 1, 1);
            }
        }



    }
    
}
