using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Transformaciones
{
    public partial class Form1 : Form
    {
        //Clase figura con lista de puntos. 

        static Bitmap bmp;
        private Canvas canvas;
        private Figura figuraActual;

        private float angle = 0.0f;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            bmp = new Bitmap(PCT_CANVAS.Width, PCT_CANVAS.Height);

            canvas = new Canvas(bmp, angle);

            canvas.cruzCanvas();

      

            PCT_CANVAS.Image = bmp;

            TRACKBAR_ANGLE.Minimum = 0;
            TRACKBAR_ANGLE.Maximum = 360; // Permite una rotación completa
            TRACKBAR_ANGLE.Value = 0; // Valor inicial

     

        }

        private void Redibujar()
        {
            canvas.ClearCanvas(Color.Black); // Limpia el canvas
            figuraActual.Render(canvas); // Asegúrate de que Render use los puntos actualizados
            PCT_CANVAS.Image = bmp;
            LBL_CENTROIDE.Text = $"Centroidee: X={figuraActual.centroid.X:F2}, Y={figuraActual.centroid.Y:F2}";
       
        }



        private void BTN_ClearCanvas_Click(object sender, EventArgs e)
        {
            canvas.ClearCanvas(Color.Black);
            PCT_CANVAS.Image = bmp;
        }
        private void BTN_UP_Click(object sender, EventArgs e)
        {
            figuraActual.Translate(new PointF(0, 10));
          
            Redibujar();
        }

        private void BTN_DOWN_Click(object sender, EventArgs e)
        {
            figuraActual.Translate(new PointF(0, -10));
          
            Redibujar();
        }

        private void BTN_LEFT_Click(object sender, EventArgs e)
        {
            figuraActual.Translate(new PointF(-10, 0));
        
            Redibujar();
        }

        private void BTN_TRASLATE_Click(object sender, EventArgs e)
        {
            
            figuraActual.Translate(new PointF(10, 0));
            Redibujar();
        }
 

        private void BTN_Rotacion_Click(object sender, EventArgs e)
        {
                float angulo = float.Parse(TXTBOX_ANGULO.Text);
                float angleRadianes = angulo * (float)(Math.PI / 180.0);
                // Calcula la diferencia entre el ángulo actual y el ángulo original
                float deltaAngle = angleRadianes - angle;

                // Aplica la rotación con el ángulo especificado
                figuraActual.RotateFigure(deltaAngle);
                Redibujar();

                // Actualiza el ángulo original
                angle = angleRadianes;
        }


        private void TRACKBAR_ANGLE_Scroll(object sender, EventArgs e)
        {
            // Obtiene el valor actual del TrackBar, que representa el ángulo de rotación en grados
            float angleGrados = TRACKBAR_ANGLE.Value;

            // Convierte el ángulo de grados a radianes
            float angleRadianes = angleGrados * (float)(Math.PI / 180.0);

            // Calcula la diferencia entre el ángulo actual y el ángulo original
            float deltaAngle = angleRadianes - angle;

            // Actualiza el ángulo original para el siguiente cálculo
            angle = angleRadianes;

            // Actualiza el texto del Label con el valor del ángulo en grados
            LBL_ANGULO.Text = "ANGLE: " + angleGrados;

            // Aplica la rotación en relación con el ángulo original
            figuraActual.RotateFigure(deltaAngle);

            // Redibuja la figura con la nueva rotación aplicada
            Redibujar();
        }

        private void BTN_TranslateToCenter_Click(object sender, EventArgs e)
        {
            figuraActual.TranslateToCenter();
            Redibujar();
        }

        private void BTN_SCALE_Click(object sender, EventArgs e)
        {
            if (figuraActual != null)
            {
                figuraActual.ScaleFigure(1.1f); // Aumenta el tamaño en un 10%
                Redibujar();
            }
        }

        private void BTN_REDUCESCALE_Click(object sender, EventArgs e)
        {
            float scaleFactor = 0.9f;

            // Aplica la reducción de escala a la figura actual
            figuraActual.ScaleFigure(scaleFactor);
            Redibujar();
        }

        private void BTN_SQUARE_Click(object sender, EventArgs e)
        {
            figuraActual = new Cuadrado(50); // Asegúrate de tener una clase Square implementada similar a Triangle
            Redibujar();
        }

        private void BTN_TRIANGLE_Click(object sender, EventArgs e)
        {
            figuraActual = new Triangle(50);
            Redibujar();
        }
        private void BTN_CIRCULO_Click(object sender, EventArgs e)
        {
            figuraActual = new Circulo(50);
            Redibujar();
        }
        private void TIMER_CENTROID_Tick(object sender, EventArgs e)
        {
            figuraActual.InitializeCentroid();
        }

        private void LBL_ANGULO_Click(object sender, EventArgs e)
        {

        }

        private void PCT_CANVAS_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
