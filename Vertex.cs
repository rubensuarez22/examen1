using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones
{
    public class Vertex
    {
        const int X = 0;
        const int Y = 1;
        const int Z = 2;
        public float[] Values;

        public float this[int i]
        {
            get { return Values[i]; }
            set { Values[i] = value; }
        }
        public Vertex(float[] values)
        {
            this.Values = values;
        }

        public static Vertex operator *(Vertex a, Vertex b)
        {
            return new Vertex(new float[] { a[X] * b[X], a[Y] * b[Y], a[Z] * b[Z] });
        }

        public static Vertex operator +(Vertex a, Vertex b)
        {
            return new Vertex(new float[] { a[X] + b[X], a[Y] + b[Y], +a[Z] + b[Z] });
        }

        public override string ToString()
        {
            return this[X] + ", " + this[Y] + ", " + this[Z] + " ";
        }


    }
}
