using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace End3
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush br;
        static int x = 200;
        static int y = 200;
        static int dx=10;
        static int dy;


        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            br = new SolidBrush(Color.Red);
            timer1.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.Green);

            Point[] p =
            {
                new Point(x, y),
                
                new Point(x+100, y),
                new Point(x+100, y+30),
                new Point(x, y+30),
                new Point(x, y)
            };

            Point[] p1 =
            {
                new Point(x+20, y),
                new Point(x+30, y-20),
                new Point(x+60, y-20),
                new Point(x+70, y)
            };

            g.FillPolygon(br, p);
            g.FillPolygon(new SolidBrush(Color.Blue), p1);
            g.FillEllipse(new SolidBrush(Color.Black), x + 15, y +25, 20, 20);
            g.FillEllipse(new SolidBrush(Color.Black), x + 65, y + 25, 20, 20);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x + 120 > Width) dx *= -1;
            if (x < 2) dx *= -1;

            x +=dx;
            Refresh();
        }
    }
}
