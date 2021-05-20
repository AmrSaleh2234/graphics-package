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
        public Form4()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
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
          
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                g.FillRectangle(aBrush, (int)Math.Round(x), (int)Math.Round(y), 1, 1);
            }

        }

        private void Bline_Click(object sender, EventArgs e)
        {
            this.lineDDA(int.Parse(textBox1.Text), int.Parse(ty1line.Text), int.Parse(tx2line.Text), int.Parse(ty2line.Text));
        }
    }
}
