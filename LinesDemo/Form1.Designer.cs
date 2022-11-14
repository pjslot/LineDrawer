
namespace LinesDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bPoints = new System.Windows.Forms.Button();
            this.bParams = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bCurve = new System.Windows.Forms.Button();
            this.bMove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericMadness = new System.Windows.Forms.NumericUpDown();
            this.radioMad = new System.Windows.Forms.RadioButton();
            this.radioPhysics = new System.Windows.Forms.RadioButton();
            this.lInfo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bPolygone = new System.Windows.Forms.Button();
            this.bBezie = new System.Windows.Forms.Button();
            this.bFilled = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMadness)).BeginInit();
            this.SuspendLayout();
            // 
            // bPoints
            // 
            this.bPoints.Location = new System.Drawing.Point(16, 21);
            this.bPoints.Name = "bPoints";
            this.bPoints.Size = new System.Drawing.Size(94, 39);
            this.bPoints.TabIndex = 0;
            this.bPoints.Text = "ТОЧКИ";
            this.bPoints.UseVisualStyleBackColor = true;
            this.bPoints.Click += new System.EventHandler(this.bPoints_Click);
            // 
            // bParams
            // 
            this.bParams.Location = new System.Drawing.Point(16, 82);
            this.bParams.Name = "bParams";
            this.bParams.Size = new System.Drawing.Size(94, 39);
            this.bParams.TabIndex = 1;
            this.bParams.Text = "ПАРАМЕТРЫ";
            this.bParams.UseVisualStyleBackColor = true;
            this.bParams.Click += new System.EventHandler(this.bParams_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(140, 504);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(94, 38);
            this.bClear.TabIndex = 2;
            this.bClear.Text = "ОЧИСТИТЬ";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bCurve
            // 
            this.bCurve.Location = new System.Drawing.Point(16, 321);
            this.bCurve.Name = "bCurve";
            this.bCurve.Size = new System.Drawing.Size(94, 38);
            this.bCurve.TabIndex = 3;
            this.bCurve.Text = "КРИВАЯ";
            this.bCurve.UseVisualStyleBackColor = true;
            this.bCurve.Click += new System.EventHandler(this.bCurve_Click);
            // 
            // bMove
            // 
            this.bMove.Location = new System.Drawing.Point(16, 144);
            this.bMove.Name = "bMove";
            this.bMove.Size = new System.Drawing.Size(94, 39);
            this.bMove.TabIndex = 4;
            this.bMove.Text = "ДВИЖЕНИЕ";
            this.bMove.UseVisualStyleBackColor = true;
            this.bMove.Click += new System.EventHandler(this.bMove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericMadness);
            this.groupBox1.Controls.Add(this.radioMad);
            this.groupBox1.Controls.Add(this.radioPhysics);
            this.groupBox1.Location = new System.Drawing.Point(21, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип движения";
            // 
            // numericMadness
            // 
            this.numericMadness.Enabled = false;
            this.numericMadness.Location = new System.Drawing.Point(93, 44);
            this.numericMadness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMadness.Name = "numericMadness";
            this.numericMadness.Size = new System.Drawing.Size(44, 23);
            this.numericMadness.TabIndex = 2;
            this.numericMadness.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // radioMad
            // 
            this.radioMad.AutoSize = true;
            this.radioMad.Location = new System.Drawing.Point(20, 48);
            this.radioMad.Name = "radioMad";
            this.radioMad.Size = new System.Drawing.Size(67, 19);
            this.radioMad.TabIndex = 1;
            this.radioMad.Text = "Рандом";
            this.radioMad.UseVisualStyleBackColor = true;
            this.radioMad.CheckedChanged += new System.EventHandler(this.radioMad_CheckedChanged);
            // 
            // radioPhysics
            // 
            this.radioPhysics.AutoSize = true;
            this.radioPhysics.Checked = true;
            this.radioPhysics.Location = new System.Drawing.Point(20, 23);
            this.radioPhysics.Name = "radioPhysics";
            this.radioPhysics.Size = new System.Drawing.Size(65, 19);
            this.radioPhysics.TabIndex = 0;
            this.radioPhysics.TabStop = true;
            this.radioPhysics.Text = "Физика";
            this.radioPhysics.UseVisualStyleBackColor = true;
            this.radioPhysics.CheckedChanged += new System.EventHandler(this.radioPhysics_CheckedChanged);
            // 
            // lInfo1
            // 
            this.lInfo1.AutoSize = true;
            this.lInfo1.Location = new System.Drawing.Point(555, 516);
            this.lInfo1.Name = "lInfo1";
            this.lInfo1.Size = new System.Drawing.Size(177, 15);
            this.lInfo1.TabIndex = 6;
            this.lInfo1.Text = "Пробел - старт/стоп движения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ESC - очистка точек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "+/- ускорение/замедление движения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ctrl+Стрелки - ручное смещение точек";
            // 
            // bPolygone
            // 
            this.bPolygone.Location = new System.Drawing.Point(18, 385);
            this.bPolygone.Name = "bPolygone";
            this.bPolygone.Size = new System.Drawing.Size(92, 38);
            this.bPolygone.TabIndex = 10;
            this.bPolygone.Text = "ЛОМАНАЯ";
            this.bPolygone.UseVisualStyleBackColor = true;
            this.bPolygone.Click += new System.EventHandler(this.bPolygone_Click);
            // 
            // bBezie
            // 
            this.bBezie.Location = new System.Drawing.Point(21, 447);
            this.bBezie.Name = "bBezie";
            this.bBezie.Size = new System.Drawing.Size(89, 38);
            this.bBezie.TabIndex = 11;
            this.bBezie.Text = "БЕЗЬЕ";
            this.bBezie.UseVisualStyleBackColor = true;
            this.bBezie.Click += new System.EventHandler(this.bBezie_Click);
            // 
            // bFilled
            // 
            this.bFilled.Location = new System.Drawing.Point(21, 504);
            this.bFilled.Name = "bFilled";
            this.bFilled.Size = new System.Drawing.Size(89, 38);
            this.bFilled.TabIndex = 12;
            this.bFilled.Text = "ЗАПОЛН.";
            this.bFilled.UseVisualStyleBackColor = true;
            this.bFilled.Click += new System.EventHandler(this.bFilled_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.bFilled);
            this.Controls.Add(this.bBezie);
            this.Controls.Add(this.bPolygone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lInfo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bMove);
            this.Controls.Add(this.bCurve);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bParams);
            this.Controls.Add(this.bPoints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(200, 200, 0, 0);
            this.Text = "Line Drawer (C) v.0.1 by Kabluchkov D.S.";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMadness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPoints;
        private System.Windows.Forms.Button bParams;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bCurve;
        private System.Windows.Forms.Button bMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMad;
        private System.Windows.Forms.RadioButton radioPhysics;
        private System.Windows.Forms.NumericUpDown numericMadness;
        private System.Windows.Forms.Label lInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bPolygone;
        private System.Windows.Forms.Button bBezie;
        private System.Windows.Forms.Button bFilled;
    }
}
