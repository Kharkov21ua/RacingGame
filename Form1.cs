using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool dragging, loose = false;
        public Form1()
        {
            InitializeComponent();

            //bg1.MouseDown += MouseClickDown;
            //bg1.MouseUp += MouseClickUp;
            //bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;
            bg3.MouseDown += MouseClickDown;
            bg3.MouseUp += MouseClickUp;
            bg3.MouseMove += MouseClickMove;

            labelloos.Visible = false;
            btmRestart.Visible = false;
            btmclose.Visible = false;
            KeyPreview = true;
        }
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.Y, currPoint.Y - pos.Y + bg2.Top);            
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 10;
            bg2.Top += speed;
            bg3.Top += speed;


            int carSpeed = 5;
            enemy1.Top += carSpeed;
            enemy2.Top += carSpeed;

            if (bg2.Top >+ 650)
            {
                bg2.Top = 0;
                bg3.Top = -650;
            }

            if (enemy1.Top >= 650)
            {
                enemy1.Top = -130;
                Random rand = new Random();
                enemy1.Left = rand.Next(150, 300);
            }
            if (enemy2.Top >= 650)
            {
                enemy2.Top = -400;
                Random rand = new Random();
                enemy2.Left = rand.Next(300, 560);
            }

            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds))
                {
                timer.Enabled = false;
                labelloos.Visible = true;
                btmRestart.Visible = true;
                btmclose.Visible = true;
                loose = true;
                }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(loose) return;
            int speed = 5;
            if ((e.KeyCode ==Keys.Left ||  e.KeyCode == Keys.A) && player.Left > 150)
                player.Left -= speed;
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 700)
                player.Left += speed;
        }

        private void btmclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmRestart_Click(object sender, EventArgs e)
        {
            enemy1.Top = -130;
            enemy2.Top = -400;
            labelloos.Visible = false;
            btmRestart.Visible = false;
            timer.Enabled = true;
            loose = false;
            player.Left = 363;
            btmclose.Visible = false;


        }
    }
}
