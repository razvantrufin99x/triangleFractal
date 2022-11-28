using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace triangleFractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void drawFractal()
        { 
        Random rnd = new Random();            
        int x = 100;
        int y = 100;
        for (int i = 1; i < 100000;i++ )
        {
            int r = rnd.Next(3);
            int ux = 150;
            int uy = 30;
            if (r == 1)
            {
                ux = 30;
                uy = 1000;
            }

            if (r == 2)
            {
                ux = 1000;
                uy = 1000;
            }
            x = (x + ux) / 2;
            y = (y + uy) / 2;
            userControl11.g.DrawEllipse(userControl11.p, x, y, 1, 1);
            if (i % 1000==0)
            {
                userControl11.Refresh();
            }
        }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawFractal();
        }
    }
}
