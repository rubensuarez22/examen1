using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Transformaciones
{
    internal class Circulo : Figura
    {
        public Circulo(int radio)
        {
            int numberOfSegments = 360; 
            float angleIncrement = (float)(2 * Math.PI / numberOfSegments);

            for (int i = 0; i < numberOfSegments; i++)
            {
                float x = radio * (float)Math.Cos(i * angleIncrement);
                float y = radio * (float)Math.Sin(i * angleIncrement);
             
                Puntos.Add(new Vertex(new float[] { x, y, 0 })); 
            }

          
        }
    }
}

