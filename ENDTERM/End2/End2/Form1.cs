using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace End2
{
    public partial class Form1 : Form
    {

        Graphics g;
        Font f;
        SolidBrush br;
        
        public Form1()
        {
            InitializeComponent();

            g = CreateGraphics();
            
            br = new SolidBrush(Color.Black);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            f = new Font(FontFamily.GenericMonospace, trackBar1.Value + 50);
            g.DrawString("Some Text", f, br, 200, 200);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
            Refresh();
        }
    }
}
