using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones
{
    public class KeyFrame
    {
        public float Time { get; set; } // Tiempo en segundos
        public List<Vertex> Vertices { get; set; } // Estado de la figura

        public KeyFrame(float time, List<Vertex> vertices)
        {
            Time = time;
            Vertices = new List<Vertex>(vertices);
        }
    }

}
