
namespace LinesDemo
{
    partial class Form2
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
            this.bParamApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericPointDiam = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericLineTolsh = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPointColor = new System.Windows.Forms.Label();
            this.labelLineColor = new System.Windows.Forms.Label();
            this.bChoosePointColor = new System.Windows.Forms.Button();
            this.bChooseLineColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPointDiam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineTolsh)).BeginInit();
            this.SuspendLayout();
            // 
            // bParamApply
            // 
            this.bParamApply.Location = new System.Drawing.Point(191, 133);
            this.bParamApply.Name = "bParamApply";
            this.bParamApply.Size = new System.Drawing.Size(101, 38);
            this.bParamApply.TabIndex = 0;
            this.bParamApply.Text = "ПРИМЕНИТЬ";
            this.bParamApply.UseVisualStyleBackColor = true;
            this.bParamApply.Click += new System.EventHandler(this.bParamApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Диаметр точки";
            // 
            // numericPointDiam
            // 
            this.numericPointDiam.Location = new System.Drawing.Point(136, 28);
            this.numericPointDiam.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericPointDiam.Name = "numericPointDiam";
            this.numericPointDiam.Size = new System.Drawing.Size(45, 23);
            this.numericPointDiam.TabIndex = 2;
            this.numericPointDiam.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Толщина линии";
            // 
            // numericLineTolsh
            // 
            this.numericLineTolsh.Location = new System.Drawing.Point(136, 76);
            this.numericLineTolsh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLineTolsh.Name = "numericLineTolsh";
            this.numericLineTolsh.Size = new System.Drawing.Size(45, 23);
            this.numericLineTolsh.TabIndex = 4;
            this.numericLineTolsh.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цвет точки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цвет линии";
            // 
            // labelPointColor
            // 
            this.labelPointColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPointColor.Location = new System.Drawing.Point(310, 27);
            this.labelPointColor.Name = "labelPointColor";
            this.labelPointColor.Size = new System.Drawing.Size(50, 24);
            this.labelPointColor.TabIndex = 7;
            // 
            // labelLineColor
            // 
            this.labelLineColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLineColor.Location = new System.Drawing.Point(308, 74);
            this.labelLineColor.Name = "labelLineColor";
            this.labelLineColor.Size = new System.Drawing.Size(52, 23);
            this.labelLineColor.TabIndex = 8;
            // 
            // bChoosePointColor
            // 
            this.bChoosePointColor.Location = new System.Drawing.Point(378, 28);
            this.bChoosePointColor.Name = "bChoosePointColor";
            this.bChoosePointColor.Size = new System.Drawing.Size(75, 23);
            this.bChoosePointColor.TabIndex = 9;
            this.bChoosePointColor.Text = "ВЫБРАТЬ";
            this.bChoosePointColor.UseVisualStyleBackColor = true;
            this.bChoosePointColor.Click += new System.EventHandler(this.bChoosePointColor_Click);
            // 
            // bChooseLineColor
            // 
            this.bChooseLineColor.Location = new System.Drawing.Point(378, 74);
            this.bChooseLineColor.Name = "bChooseLineColor";
            this.bChooseLineColor.Size = new System.Drawing.Size(75, 23);
            this.bChooseLineColor.TabIndex = 10;
            this.bChooseLineColor.Text = "ВЫБРАТЬ";
            this.bChooseLineColor.UseVisualStyleBackColor = true;
            this.bChooseLineColor.Click += new System.EventHandler(this.bChooseLineColor_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 192);
            this.Controls.Add(this.bChooseLineColor);
            this.Controls.Add(this.bChoosePointColor);
            this.Controls.Add(this.labelLineColor);
            this.Controls.Add(this.labelPointColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericLineTolsh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericPointDiam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bParamApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Параметры";
            ((System.ComponentModel.ISupportInitialize)(this.numericPointDiam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineTolsh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bParamApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericPointDiam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericLineTolsh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPointColor;
        private System.Windows.Forms.Label labelLineColor;
        private System.Windows.Forms.Button bChoosePointColor;
        private System.Windows.Forms.Button bChooseLineColor;
    }
}