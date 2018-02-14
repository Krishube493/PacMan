/// PacMan 
/// Created By Kristianna H. 
/// Feb. 2018
/// A program that shows a Pac Man character moving through a partial maze.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PacMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunB_Click(object sender, EventArgs e)
        {
            //Clear
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Black);
            RunB.Visible = false;

            //Get Pen And Brush 
            Pen drawPen = new Pen(Color.PaleTurquoise, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            //Draw Path And Packman 
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 0, 60, 60, 120, 300);

            //Move Packman Down
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 20, 60, 60, 120, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 40, 60, 60, 120, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 60, 60, 60, 120, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 80, 60, 60, 120, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 100, 60, 60, 120, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 120, 60, 60, 120, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 140, 60, 60, 120, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 160, 60, 60, 120, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 180, 60, 60, 120, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 200, 60, 60, 120, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 60, 220, 60, 60, 120, 360);

            //Move Packman To The Right 
             Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 80, 220, 60, 60, 50, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 100, 220, 60, 60, 50, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 120, 220, 60, 60, 50, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 140, 220, 60, 60, 50, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 160, 220, 60, 60, 50, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 180, 220, 60, 60, 50, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 200, 220, 60, 60, 50, 300);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 220, 220, 60, 60, 50, 360);
            Thread.Sleep(300);
            g.Clear(Color.Black);
            g.DrawLine(drawPen, 50, 0, 50, 300);
            g.DrawLine(drawPen, 150, 0, 150, 200);
            g.DrawLine(drawPen, 50, 300, 300, 300);
            g.DrawLine(drawPen, 150, 200, 300, 200);
            g.FillPie(drawBrush, 240, 220, 60, 60, 50, 300);

            //Congratulations 
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.Yellow);
            g.DrawString("Congratulations!", drawFont, drawBrush2, 300, 70);
        }
    }
}
