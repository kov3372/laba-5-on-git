using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace task2_laba_5
{
    class Rhomb : Figure
    {
        protected Form1 form1;


        public int horDiag { get; }
        public int verDiag { get; }

        

        public Rhomb(int x,int y, int horDiag, int verDiag,Form1 form1) : base (x,y)
        {
            this.form1 = form1;
            this.horDiag = horDiag;
            this.verDiag = verDiag;
           
        }

        public override void DrawBlack()
        {
            Graphics gr = this.form1.CreateGraphics();
            gr.DrawPolygon(new Pen(Color.Black), new PointF[] {new PointF(x_coordinate - (verDiag / 2), y_coordinate),
                new PointF(x_coordinate, y_coordinate - (horDiag / 2)),
                new PointF(x_coordinate + (verDiag / 2), y_coordinate),
                new PointF(x_coordinate, y_coordinate + (horDiag / 2))} );
            
        }

        public override void HideDrawingBackGround()
        {
            Graphics gr = this.form1.CreateGraphics();
            gr.DrawPolygon(new Pen(form1.BackColor), new PointF[] {new PointF(x_coordinate - (verDiag / 2), y_coordinate),
                new PointF(x_coordinate, y_coordinate - (horDiag / 2)),
                new PointF(x_coordinate + (verDiag / 2), y_coordinate),
                new PointF(x_coordinate, y_coordinate + (horDiag / 2))});
        }
    }
}
