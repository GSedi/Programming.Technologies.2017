using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace End1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Font f;
        Font f2;
        SolidBrush black;


        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            f = new Font(FontFamily.GenericSansSerif, 20);
            f2 = new Font(FontFamily.GenericSansSerif, 12);
            black = new SolidBrush(Color.Black);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawString("Authorization", f, black, 330, 30);
            g.DrawString("Login:", f2, black, 160, 120);
            g.DrawString("Password:", f2, black, 160, 175);

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "password123!" )
            {
                MessageBox.Show("SUCCESS Autarization!!!");
            }
            else if(textBox1.Text == "admin" && textBox2.Text.Length <= 8)
            {
                MessageBox.Show("Error!!!\nPassword too short or wrong");
            }
            else if(textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Error!!!\nLogin and password texts are empty");
            }
            else
            {
                MessageBox.Show("Error!!!\nWrong Login or Passwor");
            }
        }
    }
}
