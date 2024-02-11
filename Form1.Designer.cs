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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cuadrado");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Triangulo");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Circulo");
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LBL_TRASLATION = new System.Windows.Forms.Label();
            this.BTN_DOWN = new System.Windows.Forms.Button();
            this.BTN_TRASLATE = new System.Windows.Forms.Button();
            this.BTN_LEFT = new System.Windows.Forms.Button();
            this.BTN_UP = new System.Windows.Forms.Button();
            this.LBL_TranslateToCenter = new System.Windows.Forms.Label();
            this.BTN_TranslateToCenter = new System.Windows.Forms.Button();
            this.LBL_SCALE = new System.Windows.Forms.Label();
            this.TRACKBAR_ANGLE = new System.Windows.Forms.TrackBar();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.BTN_Rotacion = new System.Windows.Forms.Button();
            this.TXTBOX_ANGULO = new System.Windows.Forms.TextBox();
            this.BTN_ClearCanvas = new System.Windows.Forms.Button();
            this.LBL_CENTROIDE = new System.Windows.Forms.Label();
            this.CHECKBOX_RotacionX = new System.Windows.Forms.CheckBox();
            this.TIMER1 = new System.Windows.Forms.Timer(this.components);
            this.CHECKBOX_RotacionY = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_RotacionZ = new System.Windows.Forms.CheckBox();
            this.TRACKBAR_SCALE = new System.Windows.Forms.TrackBar();
            this.TRACKBAR_TIME = new System.Windows.Forms.TrackBar();
            this.BTN_PLAY = new System.Windows.Forms.Button();
            this.BTN_KEYFRAME = new System.Windows.Forms.Button();
            this.LBL_KEYFRAMES = new System.Windows.Forms.Label();
            this.LBL_AMOMENT = new System.Windows.Forms.Label();
            this.LBL_BMOMENT = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.LBL_ROTATE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TRACKBAR_ANGLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACKBAR_SCALE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACKBAR_TIME)).BeginInit();
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
            this.LBL_TRASLATION.Location = new System.Drawing.Point(553, 347);
            this.LBL_TRASLATION.Name = "LBL_TRASLATION";
            this.LBL_TRASLATION.Size = new System.Drawing.Size(94, 13);
            this.LBL_TRASLATION.TabIndex = 25;
            this.LBL_TRASLATION.Text = "Traslation Keys";
            // 
            // BTN_DOWN
            // 
            this.BTN_DOWN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DOWN.Location = new System.Drawing.Point(587, 395);
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
            this.BTN_TRASLATE.Location = new System.Drawing.Point(618, 395);
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
            this.BTN_LEFT.Location = new System.Drawing.Point(556, 395);
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
            this.BTN_UP.Location = new System.Drawing.Point(587, 366);
            this.BTN_UP.Name = "BTN_UP";
            this.BTN_UP.Size = new System.Drawing.Size(25, 25);
            this.BTN_UP.TabIndex = 22;
            this.BTN_UP.Text = "^";
            this.BTN_UP.UseVisualStyleBackColor = true;
            this.BTN_UP.Click += new System.EventHandler(this.BTN_UP_Click);
            // 
            // LBL_TranslateToCenter
            // 
            this.LBL_TranslateToCenter.AutoSize = true;
            this.LBL_TranslateToCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TranslateToCenter.Location = new System.Drawing.Point(435, 347);
            this.LBL_TranslateToCenter.Name = "LBL_TranslateToCenter";
            this.LBL_TranslateToCenter.Size = new System.Drawing.Size(112, 13);
            this.LBL_TranslateToCenter.TabIndex = 28;
            this.LBL_TranslateToCenter.Text = "TranslateToCenter";
            // 
            // BTN_TranslateToCenter
            // 
            this.BTN_TranslateToCenter.Location = new System.Drawing.Point(452, 363);
            this.BTN_TranslateToCenter.Name = "BTN_TranslateToCenter";
            this.BTN_TranslateToCenter.Size = new System.Drawing.Size(75, 23);
            this.BTN_TranslateToCenter.TabIndex = 29;
            this.BTN_TranslateToCenter.Text = "CENTER";
            this.BTN_TranslateToCenter.UseVisualStyleBackColor = true;
            this.BTN_TranslateToCenter.Click += new System.EventHandler(this.BTN_TranslateToCenter_Click);
            // 
            // LBL_SCALE
            // 
            this.LBL_SCALE.AutoSize = true;
            this.LBL_SCALE.Location = new System.Drawing.Point(707, 344);
            this.LBL_SCALE.Name = "LBL_SCALE";
            this.LBL_SCALE.Size = new System.Drawing.Size(41, 13);
            this.LBL_SCALE.TabIndex = 32;
            this.LBL_SCALE.Text = "SCALE";
            // 
            // TRACKBAR_ANGLE
            // 
            this.TRACKBAR_ANGLE.CausesValidation = false;
            this.TRACKBAR_ANGLE.LargeChange = 1;
            this.TRACKBAR_ANGLE.Location = new System.Drawing.Point(659, 34);
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
            this.PCT_CANVAS.Location = new System.Drawing.Point(134, 34);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(2);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(520, 308);
            this.PCT_CANVAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            // 
            // BTN_Rotacion
            // 
            this.BTN_Rotacion.Location = new System.Drawing.Point(249, 347);
            this.BTN_Rotacion.Name = "BTN_Rotacion";
            this.BTN_Rotacion.Size = new System.Drawing.Size(98, 21);
            this.BTN_Rotacion.TabIndex = 4;
            this.BTN_Rotacion.Text = "Rotar";
            this.BTN_Rotacion.UseVisualStyleBackColor = true;
            this.BTN_Rotacion.Click += new System.EventHandler(this.BTN_Rotacion_Click);
            // 
            // TXTBOX_ANGULO
            // 
            this.TXTBOX_ANGULO.Location = new System.Drawing.Point(260, 373);
            this.TXTBOX_ANGULO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTBOX_ANGULO.Name = "TXTBOX_ANGULO";
            this.TXTBOX_ANGULO.Size = new System.Drawing.Size(74, 20);
            this.TXTBOX_ANGULO.TabIndex = 2;
            this.TXTBOX_ANGULO.Text = "90";
            this.TXTBOX_ANGULO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_ClearCanvas
            // 
            this.BTN_ClearCanvas.Location = new System.Drawing.Point(149, 347);
            this.BTN_ClearCanvas.Margin = new System.Windows.Forms.Padding(2);
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
            this.LBL_CENTROIDE.Location = new System.Drawing.Point(150, 184);
            this.LBL_CENTROIDE.Name = "LBL_CENTROIDE";
            this.LBL_CENTROIDE.Size = new System.Drawing.Size(52, 13);
            this.LBL_CENTROIDE.TabIndex = 27;
            this.LBL_CENTROIDE.Text = "Centroide";
            // 
            // CHECKBOX_RotacionX
            // 
            this.CHECKBOX_RotacionX.AutoSize = true;
            this.CHECKBOX_RotacionX.Location = new System.Drawing.Point(353, 347);
            this.CHECKBOX_RotacionX.Name = "CHECKBOX_RotacionX";
            this.CHECKBOX_RotacionX.Size = new System.Drawing.Size(76, 17);
            this.CHECKBOX_RotacionX.TabIndex = 36;
            this.CHECKBOX_RotacionX.Text = "RotacionX";
            this.CHECKBOX_RotacionX.UseVisualStyleBackColor = true;
            // 
            // TIMER1
            // 
            this.TIMER1.Interval = 10;
            // 
            // CHECKBOX_RotacionY
            // 
            this.CHECKBOX_RotacionY.AutoSize = true;
            this.CHECKBOX_RotacionY.Location = new System.Drawing.Point(353, 371);
            this.CHECKBOX_RotacionY.Name = "CHECKBOX_RotacionY";
            this.CHECKBOX_RotacionY.Size = new System.Drawing.Size(79, 17);
            this.CHECKBOX_RotacionY.TabIndex = 37;
            this.CHECKBOX_RotacionY.Text = "Rotacion Y";
            this.CHECKBOX_RotacionY.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_RotacionZ
            // 
            this.CHECKBOX_RotacionZ.AutoSize = true;
            this.CHECKBOX_RotacionZ.Location = new System.Drawing.Point(353, 395);
            this.CHECKBOX_RotacionZ.Name = "CHECKBOX_RotacionZ";
            this.CHECKBOX_RotacionZ.Size = new System.Drawing.Size(76, 17);
            this.CHECKBOX_RotacionZ.TabIndex = 38;
            this.CHECKBOX_RotacionZ.Text = "RotacionZ";
            this.CHECKBOX_RotacionZ.UseVisualStyleBackColor = true;
            // 
            // TRACKBAR_SCALE
            // 
            this.TRACKBAR_SCALE.Location = new System.Drawing.Point(710, 34);
            this.TRACKBAR_SCALE.Name = "TRACKBAR_SCALE";
            this.TRACKBAR_SCALE.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TRACKBAR_SCALE.Size = new System.Drawing.Size(45, 308);
            this.TRACKBAR_SCALE.TabIndex = 39;
            this.TRACKBAR_SCALE.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TRACKBAR_SCALE.Scroll += new System.EventHandler(this.TRACKBAR_SCALE_Scroll);
            // 
            // TRACKBAR_TIME
            // 
            this.TRACKBAR_TIME.Location = new System.Drawing.Point(99, 440);
            this.TRACKBAR_TIME.Name = "TRACKBAR_TIME";
            this.TRACKBAR_TIME.Size = new System.Drawing.Size(656, 45);
            this.TRACKBAR_TIME.TabIndex = 40;
            // 
            // BTN_PLAY
            // 
            this.BTN_PLAY.BackColor = System.Drawing.Color.Red;
            this.BTN_PLAY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_PLAY.ForeColor = System.Drawing.Color.White;
            this.BTN_PLAY.Location = new System.Drawing.Point(23, 440);
            this.BTN_PLAY.Name = "BTN_PLAY";
            this.BTN_PLAY.Size = new System.Drawing.Size(70, 33);
            this.BTN_PLAY.TabIndex = 41;
            this.BTN_PLAY.Text = "PLAY";
            this.BTN_PLAY.UseVisualStyleBackColor = false;
            this.BTN_PLAY.Click += new System.EventHandler(this.BTN_PLAY_Click);
            // 
            // BTN_KEYFRAME
            // 
            this.BTN_KEYFRAME.Location = new System.Drawing.Point(761, 440);
            this.BTN_KEYFRAME.Name = "BTN_KEYFRAME";
            this.BTN_KEYFRAME.Size = new System.Drawing.Size(55, 28);
            this.BTN_KEYFRAME.TabIndex = 42;
            this.BTN_KEYFRAME.Text = "KEY";
            this.BTN_KEYFRAME.UseVisualStyleBackColor = true;
            this.BTN_KEYFRAME.Click += new System.EventHandler(this.BTN_KEYFRAME_Click);
            // 
            // LBL_KEYFRAMES
            // 
            this.LBL_KEYFRAMES.AutoSize = true;
            this.LBL_KEYFRAMES.Location = new System.Drawing.Point(289, 11);
            this.LBL_KEYFRAMES.Name = "LBL_KEYFRAMES";
            this.LBL_KEYFRAMES.Size = new System.Drawing.Size(74, 13);
            this.LBL_KEYFRAMES.TabIndex = 43;
            this.LBL_KEYFRAMES.Text = "Key Frames: 0";
            // 
            // LBL_AMOMENT
            // 
            this.LBL_AMOMENT.AutoSize = true;
            this.LBL_AMOMENT.Location = new System.Drawing.Point(369, 11);
            this.LBL_AMOMENT.Name = "LBL_AMOMENT";
            this.LBL_AMOMENT.Size = new System.Drawing.Size(71, 13);
            this.LBL_AMOMENT.TabIndex = 44;
            this.LBL_AMOMENT.Text = "a moment = 0";
            // 
            // LBL_BMOMENT
            // 
            this.LBL_BMOMENT.AutoSize = true;
            this.LBL_BMOMENT.Location = new System.Drawing.Point(444, 11);
            this.LBL_BMOMENT.Name = "LBL_BMOMENT";
            this.LBL_BMOMENT.Size = new System.Drawing.Size(71, 13);
            this.LBL_BMOMENT.TabIndex = 45;
            this.LBL_BMOMENT.Text = "b moment = 0";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.treeView1.Location = new System.Drawing.Point(23, 34);
            this.treeView1.Name = "treeView1";
            treeNode4.Name = "NODE_CUADRADO";
            treeNode4.Text = "Cuadrado";
            treeNode5.Name = "NODE_Triangulo";
            treeNode5.Text = "Triangulo";
            treeNode6.Name = "NODE_CIRCULO";
            treeNode6.Text = "Circulo";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(106, 59);
            this.treeView1.TabIndex = 46;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // LBL_ROTATE
            // 
            this.LBL_ROTATE.AutoSize = true;
            this.LBL_ROTATE.Location = new System.Drawing.Point(653, 344);
            this.LBL_ROTATE.Name = "LBL_ROTATE";
            this.LBL_ROTATE.Size = new System.Drawing.Size(51, 13);
            this.LBL_ROTATE.TabIndex = 47;
            this.LBL_ROTATE.Text = "ROTATE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(828, 524);
            this.Controls.Add(this.LBL_ROTATE);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.LBL_BMOMENT);
            this.Controls.Add(this.LBL_AMOMENT);
            this.Controls.Add(this.LBL_KEYFRAMES);
            this.Controls.Add(this.BTN_KEYFRAME);
            this.Controls.Add(this.BTN_PLAY);
            this.Controls.Add(this.TRACKBAR_TIME);
            this.Controls.Add(this.TRACKBAR_SCALE);
            this.Controls.Add(this.CHECKBOX_RotacionZ);
            this.Controls.Add(this.CHECKBOX_RotacionY);
            this.Controls.Add(this.CHECKBOX_RotacionX);
            this.Controls.Add(this.LBL_SCALE);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TRACKBAR_ANGLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACKBAR_SCALE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRACKBAR_TIME)).EndInit();
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
        private System.Windows.Forms.Label LBL_TranslateToCenter;
        private System.Windows.Forms.Button BTN_TranslateToCenter;
        private System.Windows.Forms.Label LBL_SCALE;
        private System.Windows.Forms.TrackBar TRACKBAR_ANGLE;
        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.Button BTN_Rotacion;
        private System.Windows.Forms.TextBox TXTBOX_ANGULO;
        private System.Windows.Forms.Button BTN_ClearCanvas;
        private System.Windows.Forms.Label LBL_CENTROIDE;
        private System.Windows.Forms.CheckBox CHECKBOX_RotacionX;
        private System.Windows.Forms.Timer TIMER1;
        private System.Windows.Forms.CheckBox CHECKBOX_RotacionY;
        private System.Windows.Forms.CheckBox CHECKBOX_RotacionZ;
        private System.Windows.Forms.TrackBar TRACKBAR_SCALE;
        private System.Windows.Forms.TrackBar TRACKBAR_TIME;
        private System.Windows.Forms.Button BTN_PLAY;
        private System.Windows.Forms.Button BTN_KEYFRAME;
        private System.Windows.Forms.Label LBL_KEYFRAMES;
        private System.Windows.Forms.Label LBL_AMOMENT;
        private System.Windows.Forms.Label LBL_BMOMENT;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label LBL_ROTATE;
    }
}

