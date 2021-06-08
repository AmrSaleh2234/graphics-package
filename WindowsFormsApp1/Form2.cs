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
    public partial class Form2 : Form
    {
       private List<Point> points;
      
        public Form2()
        {
            InitializeComponent();
            this.points=new List<Point>() ;
           



        }
       private void midPointCircleDraw(int x_centre,
                            int y_centre, int r)
        {
            Point p = new Point();
            int x = r, y = 0;

        
            var aBrush = Brushes.Black;
            var g = pcircule.CreateGraphics();
            g.FillRectangle(aBrush, (x + x_centre), (y + y_centre), 1, 1);
            p.X = (x + x_centre);
            p.Y = (y + y_centre);

            points.Add(p );
            

           
            if (r > 0)
            {
                g.FillRectangle(aBrush, (x + x_centre), (-y + y_centre), 1, 1);
                g.FillRectangle(aBrush, (y + x_centre), (x + y_centre), 1, 1);
                g.FillRectangle(aBrush, (-y + x_centre), (x + y_centre), 1, 1);

                p.X = (x + x_centre);
                p.Y = (-y + y_centre);

                points.Add(p);

                p.X = (y+ x_centre);
                p.Y = (x + y_centre);

                points.Add(p);

                p.X = (-y + x_centre);
                p.Y = (x + y_centre);

                points.Add(p);

            }

            // Initialising the value of P
            int P = 1 - r;
            while (x > y)
            {

                y++;

                // Mid-point is inside or on the perimeter
                if (P <= 0)
                    P = P + 2 * y + 1;

                // Mid-point is outside the perimeter
                else
                {
                    x--;
                    P = P + 2 * y - 2 * x + 1;
                }

                
                if (x < y)
                    break;
                g.FillRectangle(aBrush, (x + x_centre), (y + y_centre), 1, 1);
                g.FillRectangle(aBrush, (-x + x_centre), (y + y_centre), 1, 1);
                g.FillRectangle(aBrush, (x + x_centre), (-y + y_centre), 1, 1);
                g.FillRectangle(aBrush, (-x + x_centre), (-y + y_centre), 1, 1);

                p.X = (x + x_centre);
                p.Y = (y + y_centre);

                points.Add(p);

                p.X = (-x + x_centre);
                p.Y = (y + y_centre);

                points.Add(p);

                p.X = (x + x_centre);
                p.Y = (-y + y_centre);

                points.Add(p);


                p.X = (-x + x_centre);
                p.Y = (-y + y_centre);

                points.Add(p);



                if (x != y)
                {
                    g.FillRectangle(aBrush, (y + x_centre), (x + y_centre), 1, 1);
                    g.FillRectangle(aBrush, (-y + x_centre), (x + y_centre), 1, 1);
                    g.FillRectangle(aBrush, (y + x_centre), (-x + y_centre), 1, 1);
                    g.FillRectangle(aBrush, (-y + x_centre), (-x + y_centre), 1, 1);

                    p.X = (y + x_centre);
                    p.Y = (x + y_centre);

                    points.Add(p);

                    p.X = (-y + x_centre);
                    p.Y = (x + y_centre);

                    points.Add(p);

                    p.X = (y + x_centre);
                    p.Y = (-x + y_centre);

                    points.Add(p);


                    p.X = (-y + x_centre);
                    p.Y = (-x + y_centre);

                    points.Add(p);

                }
            }
        }



        private void Bcircule_Click(object sender, EventArgs e)
        {
            midPointCircleDraw(int.Parse(txc.Text), int.Parse(tyc.Text), int.Parse(trc.Text));
        }

        private void Pcircule_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TransCButoon_Click(object sender, EventArgs e)
        {
           
            
       
            if (points.Count!=0 && transCx.Text!=null && transCx.Text != null)
            {
                int dx=int.Parse( transCx.Text);
                 int dy=int.Parse( transCy.Text);
                transformation.translate(ref points, dx, dy, ref pcircule);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void Bscalc_Click(object sender, EventArgs e)
        {

           
            if (points.Count != 0 && scalCx.Text != null && scalCy.Text != null)
                {
                   int dx = int.Parse(scalCx.Text);
                    int dy = int.Parse(scalCy.Text);
                    transformation.scale(ref points, dx, dy, ref pcircule);
                }
                else
                {
                    MessageBox.Show("Error ", "translate error ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void Brotatec_Click(object sender, EventArgs e)
        {
            if (points.Count != 0 && tRotateC.Text != null )
            {
                int dx = int.Parse(tRotateC.Text);
               
                transformation.rotation(ref points, dx, ref pcircule);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Brefc_Click(object sender, EventArgs e)
        {

            if (points.Count != 0 )
            {


                transformation.reflection(ref points, -1, -1, ref pcircule);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refxy_Click(object sender, EventArgs e)
        {
            if (points.Count != 0 )
            {

                transformation.reflection(ref points, -1,1, ref pcircule);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Refxc_Click(object sender, EventArgs e)
        {
            if (points.Count != 0 )
            {

                transformation.reflection(ref points, 1, -1, ref pcircule);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (points.Count != 0 && sheeringxc.Text != null && sheeringyc.Text != null)
            {
                int dx = int.Parse(sheeringxc.Text);
                int dy = int.Parse(sheeringyc.Text);
                transformation.translate(ref points, dx, dy, ref pcircule);
            }
            else
            {
                MessageBox.Show("Error ", "translate error ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
