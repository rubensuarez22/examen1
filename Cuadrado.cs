﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones
{
    public class Cuadrado : Figura
    {
        public Cuadrado(int lado)
        {
            int L = lado / 2;
            Puntos.Add(new Vertex(new float[] { -L, L, 0 }));
            Puntos.Add(new Vertex(new float[] { L, L, 0 }));
            Puntos.Add(new Vertex(new float[] { L, -L, 0 }));
            Puntos.Add(new Vertex(new float[] { -L, -L, 0 }));

            //InitializeCentroid();
        }


    }
}
