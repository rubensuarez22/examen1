namespace Transformaciones
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LBL_TRASLATION = new System.Windows.Forms.Label();
            this.BTN_DOWN = new System.Windows.Forms.Button();
            this.BTN_TRASLATE = new System.Windows.Forms.Button();
            this.BTN_LEFT = new System.Windows.Forms.Button();
            this.BTN_UP = new System.Windows.Forms.Button();
            this.BTN_CIRCULO = new System.Windows.Forms.Button();
            this.LBL_TranslateToCenter = new System.Windows.Forms.Label();
            this.BTN_SQUARE = new System.Windows.Forms.Button();
            this.BTN_TranslateToCenter = new System.Windows.Forms.Button();
            this.BTN_REDUCESCALE = new System.Windows.Forms.Button();
            this.BTN_TRIANGLE = new System.Windows.Forms.Button();
            this.LBL_SCALE = new System.Windows.Forms.Label();
            this.TRACKBAR_ANGLE = new System.Windows.Forms.TrackBar();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.BTN_Rotacion = new System.Windows.Forms.Button();
            this.BTN_SCALE = new System.Windows.Forms.Button();
            this.TXTBOX_ANGULO = new System.Windows.Forms.TextBox();
            this.BTN_ClearCanvas = new System.Windows.Forms.Button();
            this.LBL_CENTROIDE = new System.Windows.Forms.Label();
            this.LBL_ANGULO = new System.Windows.Forms.Label();
            this.CHECKBOX_RotacionX = new System.Windows.Forms.CheckBox();
            this.TIMER1 = new System.Windows.Forms.Timer(this.components);
            this.CHECKBOX_RotacionY = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_RotacionZ = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TRACKBAR_ANGLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 524);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // LBL_TRASLATION
            // 
            this.LBL_TRASLATION.AutoSize = true;
            this.LBL_TRASLATION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TRASLATION.Location = new System.Drawing.Point(457, 351);
            this.LBL_TRASLATION.Name = "LBL_TRASLATION";
            this.LBL_TRASLATION.Size = new System.Drawing.Size(94, 13);
            this.LBL_TRASLATION.TabIndex = 25;
            this.LBL_TRASLATION.Text = "Traslation Keys";
            // 
            // BTN_DOWN
            // 
            this.BTN_DOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DOWN.Location = new System.Drawing.Point(491, 399);
            this.BTN_DOWN.Name = "BTN_DOWN";
            this.BTN_DOWN.Size = new System.Drawing.Size(25, 25);
            this.BTN_DOWN.TabIndex = 24;
            this.BTN_DOWN.Text = "V";
            this.BTN_DOWN.UseVisualStyleBackColor = true;
            this.BTN_DOWN.Click += new System.EventHandler(this.BTN_DOWN_Click);
            // 
            // BTN_TRASLATE
            // 
            this.BTN_TRASLATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_TRASLATE.Location = new System.Drawing.Point(522, 399);
            this.BTN_TRASLATE.Name = "BTN_TRASLATE";
            this.BTN_TRASLATE.Size = new System.Drawing.Size(25, 25);
            this.BTN_TRASLATE.TabIndex = 21;
            this.BTN_TRASLATE.Text = ">";
            this.BTN_TRASLATE.UseVisualStyleBackColor = true;
            this.BTN_TRASLATE.Click += new System.EventHandler(this.BTN_TRASLATE_Click);
            // 
            // BTN_LEFT
            // 
            this.BTN_LEFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LEFT.Location = new System.Drawing.Point(460, 399);
            this.BTN_LEFT.Name = "BTN_LEFT";
            this.BTN_LEFT.Size = new System.Drawing.Size(25, 25);
            this.BTN_LEFT.TabIndex = 23;
            this.BTN_LEFT.Text = "<";
            this.BTN_LEFT.UseVisualStyleBackColor = true;
            this.BTN_LEFT.Click += new System.EventHandler(this.BTN_LEFT_Click);
            // 
            // BTN_UP
            // 
            this.BTN_UP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UP.Location = new System.Drawing.Point(491, 370);
            this.BTN_UP.Name = "BTN_UP";
            this.BTN_UP.Size = new System.Drawing.Size(25, 25);
            this.BTN_UP.TabIndex = 22;
            this.BTN_UP.Text = "^";
            this.BTN_UP.UseVisualStyleBackColor = true;
            this.BTN_UP.Click += new System.EventHandler(this.BTN_UP_Click);
            // 
            // BTN_CIRCULO
            // 
            this.BTN_CIRCULO.Location = new System.Drawing.Point(452, 6);
            this.BTN_CIRCULO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_CIRCULO.Name = "BTN_CIRCULO";
            this.BTN_CIRCULO.Size = new System.Drawing.Size(76, 23);
            this.BTN_CIRCULO.TabIndex = 35;
            this.BTN_CIRCULO.Text = "CIRCLE";
            this.BTN_CIRCULO.UseVisualStyleBackColor = true;
            this.BTN_CIRCULO.Click += new System.EventHandler(this.BTN_CIRCULO_Click);
            // 
            // LBL_TranslateToCenter
            // 
            this.LBL_TranslateToCenter.AutoSize = true;
            this.LBL_TranslateToCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TranslateToCenter.Location = new System.Drawing.Point(339, 351);
            this.LBL_TranslateToCenter.Name = "LBL_TranslateToCenter";
            this.LBL_TranslateToCenter.Size = new System.Drawing.Size(112, 13);
            this.LBL_TranslateToCenter.TabIndex = 28;
            this.LBL_TranslateToCenter.Text = "TranslateToCenter";
            // 
            // BTN_SQUARE
            // 
            this.BTN_SQUARE.Location = new System.Drawing.Point(290, 6);
            this.BTN_SQUARE.Name = "BTN_SQUARE";
            this.BTN_SQUARE.Size = new System.Drawing.Size(75, 23);
            this.BTN_SQUARE.TabIndex = 33;
            this.BTN_SQUARE.Text = "SQUARE";
            this.BTN_SQUARE.UseVisualStyleBackColor = true;
            this.BTN_SQUARE.Click += new System.EventHandler(this.BTN_SQUARE_Click);
            // 
            // BTN_TranslateToCenter
            // 
            this.BTN_TranslateToCenter.Location = new System.Drawing.Point(356, 367);
            this.BTN_TranslateToCenter.Name = "BTN_TranslateToCenter";
            this.BTN_TranslateToCenter.Size = new System.Drawing.Size(75, 23);
            this.BTN_TranslateToCenter.TabIndex = 29;
            this.BTN_TranslateToCenter.Text = "CENTER";
            this.BTN_TranslateToCenter.UseVisualStyleBackColor = true;
            this.BTN_TranslateToCenter.Click += new System.EventHandler(this.BTN_TranslateToCenter_Click);
            // 
            // BTN_REDUCESCALE
            // 
            this.BTN_REDUCESCALE.Location = new System.Drawing.Point(259, 366);
            this.BTN_REDUCESCALE.Name = "BTN_REDUCESCALE";
            this.BTN_REDUCESCALE.Size = new System.Drawing.Size(25, 25);
            this.BTN_REDUCESCALE.TabIndex = 31;
            this.BTN_REDUCESCALE.Text = "-";
            this.BTN_REDUCESCALE.UseVisualStyleBackColor = true;
            this.BTN_REDUCESCALE.Click += new System.EventHandler(this.BTN_REDUCESCALE_Click);
            // 
            // BTN_TRIANGLE
            // 
            this.BTN_TRIANGLE.Location = new System.Drawing.Point(371, 6);
            this.BTN_TRIANGLE.Name = "BTN_TRIANGLE";
            this.BTN_TRIANGLE.Size = new System.Drawing.Size(75, 23);
            this.BTN_TRIANGLE.TabIndex = 34;
            this.BTN_TRIANGLE.Text = "TRIANGLE";
            this.BTN_TRIANGLE.UseVisualStyleBackColor = true;
            this.BTN_TRIANGLE.Click += new System.EventHandler(this.BTN_TRIANGLE_Click);
            // 
            // LBL_SCALE
            // 
            this.LBL_SCALE.AutoSize = true;
            this.LBL_SCALE.Location = new System.Drawing.Point(234, 347);
            this.LBL_SCALE.Name = "LBL_SCALE";
            this.LBL_SCALE.Size = new System.Drawing.Size(41, 13);
            this.LBL_SCALE.TabIndex = 32;
            this.LBL_SCALE.Text = "SCALE";
            // 
            // TRACKBAR_ANGLE
            // 
            this.TRACKBAR_ANGLE.CausesValidation = false;
            this.TRACKBAR_ANGLE.LargeChange = 1;
            this.TRACKBAR_ANGLE.Location = new System.Drawing.Point(751, 32);
            this.TRACKBAR_ANGLE.Name = "TRACKBAR_ANGLE";
            this.TRACKBAR_ANGLE.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TRACKBAR_ANGLE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TRACKBAR_ANGLE.Size = new System.Drawing.Size(45, 308);
            this.TRACKBAR_ANGLE.TabIndex = 26;
            this.TRACKBAR_ANGLE.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TRACKBAR_ANGLE.Scroll += new System.EventHandler(this.TRACKBAR_ANGLE_Scroll);
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PCT_CANVAS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PCT_CANVAS.Location = new System.Drawing.Point(245, 33);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(501, 308);
            this.PCT_CANVAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            // 
            // BTN_Rotacion
            // 
            this.BTN_Rotacion.Location = new System.Drawing.Point(108, 343);
            this.BTN_Rotacion.Name = "BTN_Rotacion";
            this.BTN_Rotacion.Size = new System.Drawing.Size(98, 21);
            this.BTN_Rotacion.TabIndex = 4;
            this.BTN_Rotacion.Text = "Rotar";
            this.BTN_Rotacion.UseVisualStyleBackColor = true;
            this.BTN_Rotacion.Click += new System.EventHandler(this.BTN_Rotacion_Click);
            // 
            // BTN_SCALE
            // 
            this.BTN_SCALE.Location = new System.Drawing.Point(228, 365);
            this.BTN_SCALE.Name = "BTN_SCALE";
            this.BTN_SCALE.Size = new System.Drawing.Size(25, 25);
            this.BTN_SCALE.TabIndex = 30;
            this.BTN_SCALE.Text = "+";
            this.BTN_SCALE.UseVisualStyleBackColor = true;
            this.BTN_SCALE.Click += new System.EventHandler(this.BTN_SCALE_Click);
            // 
            // TXTBOX_ANGULO
            // 
            this.TXTBOX_ANGULO.Location = new System.Drawing.Point(121, 367);
            this.TXTBOX_ANGULO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TXTBOX_ANGULO.Name = "TXTBOX_ANGULO";
            this.TXTBOX_ANGULO.Size = new System.Drawing.Size(74, 20);
            this.TXTBOX_ANGULO.TabIndex = 2;
            this.TXTBOX_ANGULO.Text = "90";
            this.TXTBOX_ANGULO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_ClearCanvas
            // 
            this.BTN_ClearCanvas.Location = new System.Drawing.Point(8, 343);
            this.BTN_ClearCanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ClearCanvas.Name = "BTN_ClearCanvas";
            this.BTN_ClearCanvas.Size = new System.Drawing.Size(95, 21);
            this.BTN_ClearCanvas.TabIndex = 1;
            this.BTN_ClearCanvas.Text = "LimpiarCanvas";
            this.BTN_ClearCanvas.UseVisualStyleBackColor = true;
            this.BTN_ClearCanvas.Click += new System.EventHandler(this.BTN_ClearCanvas_Click);
            // 
            // LBL_CENTROIDE
            // 
            this.LBL_CENTROIDE.AutoSize = true;
            this.LBL_CENTROIDE.Location = new System.Drawing.Point(55, 167);
            this.LBL_CENTROIDE.Name = "LBL_CENTROIDE";
            this.LBL_CENTROIDE.Size = new System.Drawing.Size(52, 13);
            this.LBL_CENTROIDE.TabIndex = 27;
            this.LBL_CENTROIDE.Text = "Centroide";
            // 
            // LBL_ANGULO
            // 
            this.LBL_ANGULO.AutoSize = true;
            this.LBL_ANGULO.Location = new System.Drawing.Point(20, 11);
            this.LBL_ANGULO.Name = "LBL_ANGULO";
            this.LBL_ANGULO.Size = new System.Drawing.Size(46, 13);
            this.LBL_ANGULO.TabIndex = 5;
            this.LBL_ANGULO.Text = "ANGLE:";
            this.LBL_ANGULO.Click += new System.EventHandler(this.LBL_ANGULO_Click);
            // 
            // CHECKBOX_RotacionX
            // 
            this.CHECKBOX_RotacionX.AutoSize = true;
            this.CHECKBOX_RotacionX.Location = new System.Drawing.Point(160, 33);
            this.CHECKBOX_RotacionX.Name = "CHECKBOX_RotacionX";
            this.CHECKBOX_RotacionX.Size = new System.Drawing.Size(76, 17);
            this.CHECKBOX_RotacionX.TabIndex = 36;
            this.CHECKBOX_RotacionX.Text = "RotacionX";
            this.CHECKBOX_RotacionX.UseVisualStyleBackColor = true;

            // 
            // TIMER1
            // 
            this.TIMER1.Interval = 10;
            this.TIMER1.Tick += new System.EventHandler(this.TIMER1_Tick);
            // 
            // CHECKBOX_RotacionY
            // 
            this.CHECKBOX_RotacionY.AutoSize = true;
            this.CHECKBOX_RotacionY.Location = new System.Drawing.Point(160, 57);
            this.CHECKBOX_RotacionY.Name = "CHECKBOX_RotacionY";
            this.CHECKBOX_RotacionY.Size = new System.Drawing.Size(79, 17);
            this.CHECKBOX_RotacionY.TabIndex = 37;
            this.CHECKBOX_RotacionY.Text = "Rotacion Y";
            this.CHECKBOX_RotacionY.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_RotacionZ
            // 
            this.CHECKBOX_RotacionZ.AutoSize = true;
            this.CHECKBOX_RotacionZ.Location = new System.Drawing.Point(160, 81);
            this.CHECKBOX_RotacionZ.Name = "CHECKBOX_RotacionZ";
            this.CHECKBOX_RotacionZ.Size = new System.Drawing.Size(76, 17);
            this.CHECKBOX_RotacionZ.TabIndex = 38;
            this.CHECKBOX_RotacionZ.Text = "RotacionZ";
            this.CHECKBOX_RotacionZ.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(828, 524);
            this.Controls.Add(this.CHECKBOX_RotacionZ);
            this.Controls.Add(this.CHECKBOX_RotacionY);
            this.Controls.Add(this.CHECKBOX_RotacionX);
            this.Controls.Add(this.LBL_ANGULO);
            this.Controls.Add(this.BTN_CIRCULO);
            this.Controls.Add(this.BTN_TRIANGLE);
            this.Controls.Add(this.BTN_SQUARE);
            this.Controls.Add(this.LBL_SCALE);
            this.Controls.Add(this.BTN_REDUCESCALE);
            this.Controls.Add(this.BTN_SCALE);
            this.Controls.Add(this.BTN_TranslateToCenter);
            this.Controls.Add(this.LBL_TranslateToCenter);
            this.Controls.Add(this.LBL_CENTROIDE);
            this.Controls.Add(this.LBL_TRASLATION);
            this.Controls.Add(this.BTN_DOWN);
            this.Controls.Add(this.BTN_LEFT);
            this.Controls.Add(this.BTN_UP);
            this.Controls.Add(this.BTN_TRASLATE);
            this.Controls.Add(this.TRACKBAR_ANGLE);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.BTN_Rotacion);
            this.Controls.Add(this.TXTBOX_ANGULO);
            this.Controls.Add(this.BTN_ClearCanvas);
            this.Controls.Add(this.PCT_CANVAS);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TRACKBAR_ANGLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label LBL_TRASLATION;
        private System.Windows.Forms.Button BTN_DOWN;
        private System.Windows.Forms.Button BTN_TRASLATE;
        private System.Windows.Forms.Button BTN_LEFT;
        private System.Windows.Forms.Button BTN_UP;
        private System.Windows.Forms.Button BTN_CIRCULO;
        private System.Windows.Forms.Label LBL_TranslateToCenter;
        private System.Windows.Forms.Button BTN_SQUARE;
        private System.Windows.Forms.Button BTN_TranslateToCenter;
        private System.Windows.Forms.Button BTN_REDUCESCALE;
        private System.Windows.Forms.Button BTN_TRIANGLE;
        private System.Windows.Forms.Label LBL_SCALE;
        private System.Windows.Forms.TrackBar TRACKBAR_ANGLE;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Button BTN_Rotacion;
        private System.Windows.Forms.Button BTN_SCALE;
        private System.Windows.Forms.TextBox TXTBOX_ANGULO;
        private System.Windows.Forms.Button BTN_ClearCanvas;
        private System.Windows.Forms.Label LBL_CENTROIDE;
        private System.Windows.Forms.Label LBL_ANGULO;
        private System.Windows.Forms.CheckBox CHECKBOX_RotacionX;
        private System.Windows.Forms.Timer TIMER1;
        private System.Windows.Forms.CheckBox CHECKBOX_RotacionY;
        private System.Windows.Forms.CheckBox CHECKBOX_RotacionZ;
    }
}

