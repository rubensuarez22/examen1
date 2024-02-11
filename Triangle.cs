using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones
{
    internal class Triangle : Figura
    {
        public Triangle(int lado)
        {
            float L = lado; // La longitud del lado del triángulo equilátero
            float h = (float)(Math.Sqrt(3) / 2 * L); // Altura del triángulo equilátero

            Puntos.Add(new Vertex(new float[] { 0, 2 * h / 3, 0 }));
            Puntos.Add(new Vertex(new float[] { -L / 2, -h / 3, 0 }));
            Puntos.Add(new Vertex(new float[] { L / 2, -h / 3, 0 }));

            //InitializeCentroid();
        }
    }


}

