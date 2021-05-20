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
        public Form2()
        {
            InitializeComponent();
        }
       private void midPointCircleDraw(int x_centre,
                            int y_centre, int r)
        {

            int x = r, y = 0;

        
            var aBrush = Brushes.Black;
            var g = pcircule.CreateGraphics();
            g.FillRectangle(aBrush, (x + x_centre), (y + y_centre), 1, 1);
            

           
            if (r > 0)
            {
                g.FillRectangle(aBrush, (x + x_centre), (-y + y_centre), 1, 1);
                g.FillRectangle(aBrush, (y + x_centre), (x + y_centre), 1, 1);
                g.FillRectangle(aBrush, (-y + x_centre), (x + y_centre), 1, 1);

             
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
               

                
                if (x != y)
                {
                    g.FillRectangle(aBrush, (y + x_centre), (x + y_centre), 1, 1);
                    g.FillRectangle(aBrush, (-y + x_centre), (x + y_centre), 1, 1);
                    g.FillRectangle(aBrush, (y + x_centre), (-x + y_centre), 1, 1);
                    g.FillRectangle(aBrush, (-y + x_centre), (-x + y_centre), 1, 1);
                    
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
    }
}
