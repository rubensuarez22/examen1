using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones
{
    public class Rotaciones
    {
        public Vertex Rot(float angle, Vertex p)
        {
            float[,] axis;
            Mtx Mat;
            float cos = (float)Math.Cos(angle);
            float sin = (float)Math.Sin(angle);

            axis = new float[,]{

               /*  Rotacion en Y {cos, 0, sin}, {0, 1, 0}, {-sin, 0, cos},*/ 

               /* Rotacion en X*/ {1, 0, 0}, {0, cos, -sin}, {0, sin, cos }, 


               /*Rotacion en Z { cos, -sin, 0 },
                { sin, cos, 0 },
                { 0, 0, 1 }, */
            };

            Mat = new Mtx(axis);

            return Mat.Mul(p);

        }
    }
}
