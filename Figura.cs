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
            public List<Vertex> Puntos; // Ahora usamos Vertex en lugar de PointF

            public Figura()
            {
                Puntos = new List<Vertex>();
            }

            // Método adaptado para calcular el centroide en 3D
            public Vertex CalcularCentroide()
            {
                Vertex centroide = new Vertex(new float[] { 0, 0, 0 });
                foreach (var punto in Puntos)
                {
                    centroide += punto; // Asegúrate de que Vertex soporte la suma
                }
                centroide[0] /= Puntos.Count;
                centroide[1] /= Puntos.Count;
                centroide[2] /= Puntos.Count;

                return centroide;
            }

        // Método para rotar la figura en torno a un eje específico
        public void RotateAroundX(float angle)
        {
            RotateFigure(angle, new float[,] { { 1, 0, 0 }, { 0, (float)Math.Cos(angle), -(float)Math.Sin(angle) }, { 0, (float)Math.Sin(angle), (float)Math.Cos(angle) } });
        }

        public void RotateAroundY(float angle)
        {
            RotateFigure(angle, new float[,] { { (float)Math.Cos(angle), 0, (float)Math.Sin(angle) }, { 0, 1, 0 }, { -(float)Math.Sin(angle), 0, (float)Math.Cos(angle) } });
        }

        public void RotateAroundZ(float angle)
        {
            RotateFigure(angle, new float[,] { { (float)Math.Cos(angle), -(float)Math.Sin(angle), 0 }, { (float)Math.Sin(angle), (float)Math.Cos(angle), 0 }, { 0, 0, 1 } });
        }

        public void RotateFigure(float angle, float[,] rotationMatrix)
        {
            Rotaciones rotaciones = new Rotaciones();
            Vertex centroide = CalcularCentroide();

            // Traslada al origen
            Translate(new Vertex(new float[] { -centroide[0], -centroide[1], -centroide[2] }));

            // Aplica la rotación
            for (int i = 0; i < Puntos.Count; i++)
            {
                // Usa el método Rot con la matriz de rotación adecuada
                Mtx Mat = new Mtx(rotationMatrix);
                Puntos[i] = Mat.Mul(Puntos[i]);
            }

            // Traslada de vuelta a la posición original
            Translate(centroide);
        }

        public void TranslateToCenter()
        {
            Vertex centroide = CalcularCentroide();
            Translate(new Vertex(new float[] { -centroide[0], -centroide[1], -centroide[2] }));
        }

        // Método para trasladar la figura
        public void Translate(Vertex translation)
            {
                for (int i = 0; i < Puntos.Count; i++)
                {
                    Puntos[i] += translation;
                }
            }
      
        public void ScaleFigure(float scaleFactor)
        {
            Vertex centroide = CalcularCentroide();

            // Traslada al origen
            Translate(new Vertex(new float[] { -centroide[0], -centroide[1], -centroide[2] }));

            for (int i = 0; i < Puntos.Count; i++)
            {
                float x = Puntos[i][0] * scaleFactor;
                float y = Puntos[i][1] * scaleFactor;
                float z = Puntos[i][2] * scaleFactor;
                Puntos[i] = new Vertex(new float[] { x, y, z });
            }

            // Traslada de vuelta a la posición original
            Translate(centroide);
        }

    }
}

