using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Game_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int x, y;
            int i = 50, o = 100, r = 30;
            x = button1.Location.X;  //storing value of button location x in a variable  
            y = button1.Location.Y;  //storing value of button location y in a variable  

            //above for y-axis
            if ((y - i) <= e.Y && e.Y <= (y))
            {
                //above for x-axis
                if ((x - i) <= e.X && (x) >= e.X || (x + i + o) >= e.X && (x) <= e.X)   //first x counter for spaces from left and second to counter spaces from right and button above spaces
                {
                    button1.Location = new Point(x, y + i);
                }
            }

            //bottom for y-axis
            if ((y + i + r) >= e.Y && e.Y >= (y + r))
            {
                //above for x-axis
                if ((x - i) <= e.X && (x) >= e.X || (x + i + o) >= e.X && (x) <= e.X)   //first x counter for spaces from left and second to counter spaces from right and button below spaces
                {
                    button1.Location = new Point(x, y - i);
                }
            }

            //left for x - axis
            if ((x - i) <= e.X && e.X <= (x))
            {
                if ((y) <= e.Y && (y + r) >= e.Y)
                {
                    button1.Location = new Point(x + i, y);
                }
            }

            //right for x-axis
            if ((x + i + o) >= e.X && e.X >= (x + o))
            {
                if ((y) <= e.Y && (y + r) >= e.Y)
                {
                    button1.Location = new Point(x - i, y);
                }
            }

            if (button1.Location.X < 0 || button1.Location.X > 880 || button1.Location.Y < 0 || button1.Location.Y > 530)
            {
                Random rand = new Random();

                int q = rand.Next(100, 800);
                int p = rand.Next(100, 400);

                button1.Location = new Point(q, p);
            }
        }
    }
}