using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Transformaciones
{
    public partial class Form1 : Form
    {

        static Bitmap bmp;
        private Canvas canvas;
        private Figura figuraActual;

        private float angle = 0.0f;
        private float deltaAngle = 2.0f;
        List<KeyFrame> keyFrames = new List<KeyFrame>();

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            bmp = new Bitmap(PCT_CANVAS.Width, PCT_CANVAS.Height);

            canvas = new Canvas(bmp);

            canvas.cruzCanvas();
            


            PCT_CANVAS.Image = bmp;


            CHECKBOX_RotacionX.CheckedChanged += Checkbox_Rotacion_CheckedChanged;
            CHECKBOX_RotacionY.CheckedChanged += Checkbox_Rotacion_CheckedChanged;
            CHECKBOX_RotacionZ.CheckedChanged += Checkbox_Rotacion_CheckedChanged;

            TRACKBAR_ANGLE.Minimum = -10;
            TRACKBAR_ANGLE.Maximum = 10; 
            TRACKBAR_ANGLE.Value = 0;
            TRACKBAR_ANGLE.Scroll += TRACKBAR_ANGLE_Scroll;
            TRACKBAR_ANGLE.MouseUp += TRACKBAR_MouseUp;


            TRACKBAR_SCALE.Minimum = -10;  
            TRACKBAR_SCALE.Maximum = 10;   
            TRACKBAR_SCALE.Value = 0;      
            TRACKBAR_SCALE.TickFrequency = 1; 
            TRACKBAR_SCALE.SmallChange = 1;  
            TRACKBAR_SCALE.LargeChange = 1;
            TRACKBAR_SCALE.Scroll += TRACKBAR_SCALE_Scroll;
            TRACKBAR_SCALE.MouseUp += TRACKBAR_MouseUp;






            TIMER1.Interval = 10; 
            TIMER1.Tick += RotarFigura;

        }

        private void Redibujar()
        {
            canvas.ClearCanvas(Color.Black); 
            canvas.cruzCanvas();
            if (figuraActual != null)
            {
                canvas.RenderFigura(figuraActual);
            }
            PCT_CANVAS.Image = bmp;

            Vertex centroide = figuraActual.CalcularCentroide(); 
                                                                
            LBL_CENTROIDE.Text = $"Centroide: X={centroide[0]:F2}, Y={centroide[1]:F2}, Z={centroide[2]:F2}";
        }


        private void TRACKBAR_MouseUp(object sender, MouseEventArgs e)
        {
            // Restablece el valor del TrackBar al centro (0) cuando se suelta el botón del mouse
            TRACKBAR_ANGLE.Value = 0;
            TRACKBAR_SCALE.Value = 0;
        }

        private void BTN_ClearCanvas_Click(object sender, EventArgs e)
        {
            canvas.ClearCanvas(Color.Black);
            PCT_CANVAS.Image = bmp;
        }
        private void BTN_UP_Click(object sender, EventArgs e)
        {
            
            figuraActual.Translate(new Vertex(new float[] { 0, 10, 0 }));
            Redibujar();
        }

        private void BTN_DOWN_Click(object sender, EventArgs e)
        {
            
            figuraActual.Translate(new Vertex(new float[] { 0, -10, 0 }));
            Redibujar();
        }

        private void BTN_LEFT_Click(object sender, EventArgs e)
        {
            
            figuraActual.Translate(new Vertex(new float[] { -10, 0, 0 }));
            Redibujar();
        }

        private void BTN_TRASLATE_Click(object sender, EventArgs e)
        {
         
            figuraActual.Translate(new Vertex(new float[] { 10, 0, 0 }));
            Redibujar();
        }



        private void BTN_Rotacion_Click(object sender, EventArgs e)
        {
            float angulo = float.Parse(TXTBOX_ANGULO.Text); // Ángulo en grados
            float angleRadianes = angulo * (float)(Math.PI / 180.0); // Convierte a radianes

            // Define la matriz de rotación para el eje Z
            float[,] rotationMatrixZ = new float[,]
                {
            { (float)Math.Cos(angleRadianes), -(float)Math.Sin(angleRadianes), 0 },
            { (float)Math.Sin(angleRadianes), (float)Math.Cos(angleRadianes), 0 },
            { 0, 0, 1 }
                };

            // Aplica la rotación con la matriz de rotación
            figuraActual.RotateFigure(angleRadianes, rotationMatrixZ);
            Redibujar();
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
            float[,] rotationMatrixZ = new float[,]
                {
            { (float)Math.Cos(angleRadianes), -(float)Math.Sin(angleRadianes), 0 },
            { (float)Math.Sin(angleRadianes), (float)Math.Cos(angleRadianes), 0 },
            { 0, 0, 1 }
                };
            // Aplica la rotación en relación con el ángulo original
            figuraActual.RotateFigure(angleRadianes, rotationMatrixZ);

            // Redibuja la figura con la nueva rotación aplicada
            Redibujar();
        }

        private void BTN_TranslateToCenter_Click(object sender, EventArgs e)
        {
            figuraActual.TranslateToCenter();
            Redibujar();
        }

        private void Checkbox_Rotacion_CheckedChanged(object sender, EventArgs e)
        {
            
            TIMER1.Enabled = CHECKBOX_RotacionX.Checked || CHECKBOX_RotacionY.Checked || CHECKBOX_RotacionZ.Checked;
        }

        private void RotarFigura(object sender, EventArgs e)
        {
            if (figuraActual != null)
            {
                // Convertir deltaAngle a radianes una sola vez
                float deltaAngleRadians = deltaAngle * (float)(Math.PI / 180);

                // Rotar figura alrededor del eje X 
                if (CHECKBOX_RotacionX.Checked)
                {
                    figuraActual.RotateAroundX(deltaAngleRadians);
                }

                // Rotar figura alrededor del eje Y 
                if (CHECKBOX_RotacionY.Checked)
                {
                    figuraActual.RotateAroundY(deltaAngleRadians);
                }

                // Rotar figura alrededor del eje Z 
                if (CHECKBOX_RotacionZ.Checked)
                {
                    figuraActual.RotateAroundZ(deltaAngleRadians);
                }

                // Redibujar la figura después de aplicar las rotaciones
                Redibujar();
            }
        }
        private void TRACKBAR_SCALE_Scroll(object sender, EventArgs e)
        {
            if (figuraActual != null)
            {
                
                float scaleFactor = 1 + (TRACKBAR_SCALE.Value / 20.0f);

                figuraActual.ScaleFigure(scaleFactor);
                Redibujar();
            }
        }

        private void BTN_KEYFRAME_Click(object sender, EventArgs e)
        {
            float currentTime = TRACKBAR_TIME.Value; // Asumiendo que TRACKBAR_TIME mide el tiempo en segundos
            var currentVertices = figuraActual.Puntos; // Asume que tienes una forma de obtener los vértices actuales de la figura

            keyFrames.Add(new KeyFrame(currentTime, currentVertices));
            LBL_KEYFRAMES.Text = $"KeyFrames: {keyFrames.Count}";
        }


        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            // Decide la acción basada en el texto del nodo
            switch (selectedNode.Text)
            {
                case "Cuadrado":
                   
                    figuraActual = new Cuadrado(50);
                    break;
                case "Circulo":
                   
                    figuraActual = new Circulo(50); 
                    break;
                case "Triangulo":
                   
                    figuraActual = new Triangle(50);
                    break;
            }

            // Finalmente, redibuja la figura seleccionada
            Redibujar();
        }

        private void BTN_PLAY_Click(object sender, EventArgs e)
        {
            if (keyFrames.Count < 2)
            {
                MessageBox.Show("Necesitas al menos 2 KeyFrames para la animación.");
                return;
            }

            // Ordena los KeyFrames por tiempo para asegurarte de que estén en el orden correcto
            keyFrames = keyFrames.OrderBy(kf => kf.Time).ToList();

          
            PlayAnimation();
        }

        private Vertex Interpolate(Vertex start, Vertex end, float t)
        {
            float x = start[0] + (end[0] - start[0]) * t;
            float y = start[1] + (end[1] - start[1]) * t;
            float z = start[2] + (end[2] - start[2]) * t;

            return new Vertex(new float[] { x, y, z });
        }



        private void PlayAnimation()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < keyFrames.Count - 1; i++)
            {
                var startFrame = keyFrames[i];
                var endFrame = keyFrames[i + 1];
                float frameDuration = endFrame.Time - startFrame.Time;

                while (stopwatch.Elapsed.TotalSeconds < endFrame.Time)
                {
                    float t = (float)((stopwatch.Elapsed.TotalSeconds - startFrame.Time) / frameDuration);
                    List<Vertex> interpolatedVertices = new List<Vertex>();

                    for (int j = 0; j < startFrame.Vertices.Count; j++)
                    {
                        interpolatedVertices.Add(Interpolate(startFrame.Vertices[j], endFrame.Vertices[j], t));
                    }

                    figuraActual.Puntos = interpolatedVertices;
                    Redibujar();

                    Application.DoEvents(); // Mantén la UI responsiva
                }
            }

            stopwatch.Stop();
        }

    }
}
