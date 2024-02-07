using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones
{
    public abstract class Figura
    {
        public PointF centroid;
        public List<PointF> Puntos;



        public Figura()
        {
            // Inicializa la lista de puntos aquí
            Puntos = new List<PointF>();
        }

        // Llamado después de que todos los puntos hayan sido inicializados en la subclase
        public void InitializeCentroid()
        {
            centroid = new PointF();

            foreach (var p in Puntos)
            {
                centroid.X += p.X;
                centroid.Y += p.Y;
            }

            centroid.X /= Puntos.Count;
            centroid.Y /= Puntos.Count;
        }


        //render(recibe el objeto graphics), traslacion, rotacion(recibe el angulo) y escalado.
        public void Render(Canvas canvas)
        {
            for (int i = 0; i < Puntos.Count; i++)
            {
                PointF a = Puntos[i];
                PointF b = Puntos[(i + 1) % Puntos.Count];
                canvas.Render(a, b);
                canvas.cruzCanvas();
            }
        }

        public void RotateFigure(float angle)
        {
            // Guarda el centroide actual antes de la traslación al origen
            PointF centroideOriginal = new PointF(centroid.X, centroid.Y);

            // Mueve la figura al origen para la rotación
            Translate(new PointF(-centroideOriginal.X, -centroideOriginal.Y));

            // Aplica la rotación a cada punto
            for (int i = 0; i < Puntos.Count; i++)
            {
                Puntos[i] = Rotate(Puntos[i], angle);
            }

            // Mueve la figura de vuelta a su posición original usando el centroide guardado
            Translate(centroideOriginal);

            // Recalcula el centroide solo después de mover la figura de vuelta a su posición
            InitializeCentroid();
        }


        private PointF Rotate(PointF a, float angle)
        {
            PointF b = new PointF();
            b.X = (float)((a.X * Math.Cos(angle)) - (a.Y * Math.Sin(angle)));
            b.Y = (float)((a.X * Math.Sin(angle)) + (a.Y * Math.Cos(angle)));

            return b;
        }

        public void TranslateToCenter()
        {
            PointF translation = new PointF(-centroid.X, -centroid.Y);

            // Aplicar la traslación
            Translate(translation);
        }


        public void Translate(PointF translation)
        {
       

            for (int i = 0; i < Puntos.Count; i++)
            {
                Puntos[i] = new PointF(Puntos[i].X + translation.X, Puntos[i].Y + translation.Y);
            }
            InitializeCentroid();
        }

        public void ScaleFigure(float scaleFactor)
        {


            // Mueve la figura al origen para la escalada
            PointF centroideOriginal = new PointF(centroid.X, centroid.Y);
            Translate(new PointF(-centroideOriginal.X, -centroideOriginal.Y));
           

            for (int i = 0; i < Puntos.Count; i++)
            {
                // Escala cada punto respecto al origen
                float newX = Puntos[i].X * scaleFactor;
                float newY = Puntos[i].Y * scaleFactor;
                Puntos[i] = new PointF(newX, newY);
            }

            // Mueve la figura de vuelta a su posición original
            Translate(centroideOriginal);

            InitializeCentroid();
        }




    }

}
