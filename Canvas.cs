using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones
{
    public class Canvas
    {
        public Bitmap Bmp;
        public Graphics g;
        private double angle;


        //CANVAS TIENE EL OBJETO GRAPHICS Y LA CLASE RENDER.
        public Canvas(Bitmap bmp, double angle)
        {
            Bmp = bmp;
            g = Graphics.FromImage(bmp);
            this.angle = angle;
            
        }

            public void Render(PointF a, PointF b)
        {
            PointF a2, b2;
            int Sx = (Bmp.Width / 2);
            int Sy = (Bmp.Height / 2);

            //Creo que modificando Sx puedo mover el cuadrado a gusto.

            a2 = new PointF(Sx + a.X, Sy - a.Y);
             b2 = new PointF(Sx + b.X, Sy - b.Y);


            a2.X = Sx + (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            a2.Y = Sy - (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));


            b2.X = Sx + (float)((b.X * Math.Cos(angle)) - (b.Y * Math.Sin(angle)));
            b2.Y = Sy - (float)((b.X * Math.Sin(angle)) + (b.Y * Math.Cos(angle)));

            g.DrawLine(Pens.Gray, a2, b2);




        }

            public void cruzCanvas()
        {
            int Sx = (Bmp.Width / 2);
            int Sy = (Bmp.Height / 2);
            // Dibuja la línea horizontal (Eje X)
            g.DrawLine(Pens.Yellow, 0, Sy, Bmp.Width, Sy);
            // Dibuja la línea vertical (Eje Y)
            g.DrawLine(Pens.Yellow, Sx, 0, Sx, Bmp.Height);
        }

            public void ClearCanvas(Color color)
        {
            g.Clear(color);
        }
    }
}
