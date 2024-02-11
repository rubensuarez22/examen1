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
        private Graphics g;

        public Canvas(Bitmap bmp)
        {
            Bmp = bmp;
            g = Graphics.FromImage(bmp);
        }

        // Método general para renderizar cualquier figura
        public void RenderFigura(Figura figura)
        {
            int Sx = Bmp.Width / 2;
            int Sy = Bmp.Height / 2;

            if (figura.Puntos.Count > 0)
            {
                for (int i = 0; i < figura.Puntos.Count - 1; i++)
                {
                    RenderLine(figura.Puntos[i], figura.Puntos[i + 1], Sx, Sy);
                }
                // Conecta el último punto con el primero para cerrar la figura
                RenderLine(figura.Puntos[figura.Puntos.Count - 1], figura.Puntos[0], Sx, Sy);
            }
        }

        // Método auxiliar para dibujar una línea entre dos Vertex, trasladando al centro del Canvas
        private void RenderLine(Vertex a, Vertex b, int Sx, int Sy)
        {
            PointF pointA = new PointF(Sx + a[0], Sy - a[1]);
            PointF pointB = new PointF(Sx + b[0], Sy - b[1]);

            g.DrawLine(Pens.Gray, pointA, pointB);
        }

        public void cruzCanvas()
        {
            int Sx = Bmp.Width / 2;
            int Sy = Bmp.Height / 2;
            g.DrawLine(Pens.Yellow, 0, Sy, Bmp.Width, Sy);
            g.DrawLine(Pens.Yellow, Sx, 0, Sx, Bmp.Height);
        }

        public void ClearCanvas(Color color)
        {
            g.Clear(color);
        }
    }

}
