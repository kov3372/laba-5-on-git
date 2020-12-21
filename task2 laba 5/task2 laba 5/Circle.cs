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
    class Circle : Figure
    {
        public int radius { get; }
        protected Form1 formC;

       
        public Circle( int x,int y,int r,Form1 formC) :base(x,y)
        {
            this.radius = r;
            this.formC = formC;
        }

        public override void DrawBlack()
        {
            Graphics graphics = formC.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, x_coordinate, y_coordinate, this.radius, this.radius);
        }
        public override void HideDrawingBackGround()
        {
            Graphics graphics = formC.CreateGraphics();
            graphics.DrawEllipse(new Pen(formC.BackColor), x_coordinate, y_coordinate, this.radius, this.radius);
        }





    }
}
