using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public partial class Form1 : Form
    {
        public int bar1_x = 110;         // user bar start variable.
        public int bar2_x = 110;
        public bool ball_live = false; // ball live flag
        public int ball_x, ball_y, add_x, add_y;
        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightGreen);
            System.Drawing.SolidBrush myBrushGreen = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            System.Drawing.Graphics panelGraphics;

            panelGraphics = this.panel1.CreateGraphics();
            //panelGraphics.FillRectangle(myBrush, new Rectangle(150, 0, panel1.Width, panel1.Height));
            panelGraphics.FillRectangle(myBrushGreen, new Rectangle(bar2_x, 30, 50, 8));
            panelGraphics.FillRectangle(myBrushGreen, new Rectangle(bar1_x, panel1.Height - 20, 50, 8));

            if (ball_live)
                panelGraphics.FillEllipse(myBrushGreen, new Rectangle(ball_x, ball_y, 10, 10));

            myBrushGreen.Dispose();
            myBrush.Dispose();
            panelGraphics.Dispose();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) bar1_x -= 5;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.S) bar1_x += 5;
            panel1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ball_live) // ball moving
            {
                ball_x += add_x;
                ball_y += add_y;
                // collision check.
                if (add_y > 0)
                {
                    if (ball_y > (panel1.Height - 30) && ball_y < (panel1.Height - 20))
                    {
                        if (ball_x > bar1_x && ball_x < (bar1_x + 50)) add_y = -add_y;
                    }
                }
                else
                {
                    if (ball_y < 40 && ball_y > 30)
                    {
                        if (ball_x > bar2_x && ball_x < (bar2_x + 50)) add_y = -add_y;
                    }
                }
                // computer move
                if (rnd.Next(4) != 0) // 25% dump
                {
                    if ((ball_x - 25) > bar2_x) bar2_x += 5;
                    else if ((ball_x - 25) < bar2_x) bar2_x -= 5;
                }
                // ball die check
                if (ball_y > panel1.Height || ball_y < 10) ball_live = false;
                // wall collision check
                if (ball_x > panel1.Width || ball_x < 0) add_x = -add_x;
                panel1.Invalidate();
            }
            else // ball create
            {

                ball_x = rnd.Next(200);
                ball_y = 50;
                add_x = 4 + rnd.Next(4);
                add_y = 5;
                ball_live = true;
                Console.Beep();
            }
        }
    }
}
}
