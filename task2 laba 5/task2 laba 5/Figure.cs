using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace task2_laba_5
{
    abstract class Figure
    {
        public int x_coordinate { get; set; }
        public int y_coordinate { get; set; }

        public Color сolourOfFigure { get; set; }
        public Color ColourOfBackground { get; set; }

        public Figure(int x, int y)
        {
            this.x_coordinate = x;
            this.y_coordinate = y;
        }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();


        public void MoveRight(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackGround();
                x_coordinate++;
            }
        }

        public override string ToString()
        {
            return "x = " + x_coordinate + " y = " + y_coordinate;
        }
    }
}
