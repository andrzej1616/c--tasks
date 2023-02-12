namespace Test_3
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.rBlue = new System.Windows.Forms.RadioButton();
            this.Colors = new System.Windows.Forms.GroupBox();
            this.rBlack = new System.Windows.Forms.RadioButton();
            this.rRed = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rEllipse = new System.Windows.Forms.RadioButton();
            this.rCircle = new System.Windows.Forms.RadioButton();
            this.rLine = new System.Windows.Forms.RadioButton();
            this.rRectangle = new System.Windows.Forms.RadioButton();
            this.rPolygon = new System.Windows.Forms.RadioButton();
            this.Colors.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBlue
            // 
            this.rBlue.AutoSize = true;
            this.rBlue.Location = new System.Drawing.Point(47, 21);
            this.rBlue.Name = "rBlue";
            this.rBlue.Size = new System.Drawing.Size(55, 20);
            this.rBlue.TabIndex = 0;
            this.rBlue.TabStop = true;
            this.rBlue.Text = "Blue";
            this.rBlue.UseVisualStyleBackColor = true;
            // 
            // Colors
            // 
            this.Colors.Controls.Add(this.rBlack);
            this.Colors.Controls.Add(this.rRed);
            this.Colors.Controls.Add(this.rBlue);
            this.Colors.Location = new System.Drawing.Point(588, 191);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(200, 109);
            this.Colors.TabIndex = 1;
            this.Colors.TabStop = false;
            this.Colors.Text = "Colors";
            // 
            // rBlack
            // 
            this.rBlack.AutoSize = true;
            this.rBlack.Location = new System.Drawing.Point(47, 75);
            this.rBlack.Name = "rBlack";
            this.rBlack.Size = new System.Drawing.Size(62, 20);
            this.rBlack.TabIndex = 2;
            this.rBlack.TabStop = true;
            this.rBlack.Text = "Black";
            this.rBlack.UseVisualStyleBackColor = true;
            // 
            // rRed
            // 
            this.rRed.AutoSize = true;
            this.rRed.Location = new System.Drawing.Point(47, 48);
            this.rRed.Name = "rRed";
            this.rRed.Size = new System.Drawing.Size(54, 20);
            this.rRed.TabIndex = 1;
            this.rRed.TabStop = true;
            this.rRed.Text = "Red";
            this.rRed.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rPolygon);
            this.groupBox1.Controls.Add(this.rRectangle);
            this.groupBox1.Controls.Add(this.rLine);
            this.groupBox1.Controls.Add(this.rCircle);
            this.groupBox1.Controls.Add(this.rEllipse);
            this.groupBox1.Location = new System.Drawing.Point(588, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rEllipse
            // 
            this.rEllipse.AutoSize = true;
            this.rEllipse.Location = new System.Drawing.Point(47, 22);
            this.rEllipse.Name = "rEllipse";
            this.rEllipse.Size = new System.Drawing.Size(69, 20);
            this.rEllipse.TabIndex = 0;
            this.rEllipse.TabStop = true;
            this.rEllipse.Text = "Ellipse";
            this.rEllipse.UseVisualStyleBackColor = true;
            this.rEllipse.CheckedChanged += new System.EventHandler(this.rEllipse_CheckedChanged);
            // 
            // rCircle
            // 
            this.rCircle.AutoSize = true;
            this.rCircle.Location = new System.Drawing.Point(47, 49);
            this.rCircle.Name = "rCircle";
            this.rCircle.Size = new System.Drawing.Size(62, 20);
            this.rCircle.TabIndex = 1;
            this.rCircle.TabStop = true;
            this.rCircle.Text = "Circle";
            this.rCircle.UseVisualStyleBackColor = true;
            // 
            // rLine
            // 
            this.rLine.AutoSize = true;
            this.rLine.Location = new System.Drawing.Point(47, 76);
            this.rLine.Name = "rLine";
            this.rLine.Size = new System.Drawing.Size(53, 20);
            this.rLine.TabIndex = 2;
            this.rLine.TabStop = true;
            this.rLine.Text = "Line";
            this.rLine.UseVisualStyleBackColor = true;
            // 
            // rRectangle
            // 
            this.rRectangle.AutoSize = true;
            this.rRectangle.Location = new System.Drawing.Point(47, 103);
            this.rRectangle.Name = "rRectangle";
            this.rRectangle.Size = new System.Drawing.Size(90, 20);
            this.rRectangle.TabIndex = 3;
            this.rRectangle.TabStop = true;
            this.rRectangle.Text = "Rectangle";
            this.rRectangle.UseVisualStyleBackColor = true;
            // 
            // rPolygon
            // 
            this.rPolygon.AutoSize = true;
            this.rPolygon.Location = new System.Drawing.Point(47, 130);
            this.rPolygon.Name = "rPolygon";
            this.rPolygon.Size = new System.Drawing.Size(78, 20);
            this.rPolygon.TabIndex = 4;
            this.rPolygon.TabStop = true;
            this.rPolygon.Text = "Polygon";
            this.rPolygon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Colors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Colors.ResumeLayout(false);
            this.Colors.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rBlue;
        private System.Windows.Forms.GroupBox Colors;
        private System.Windows.Forms.RadioButton rBlack;
        private System.Windows.Forms.RadioButton rRed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rEllipse;
        private System.Windows.Forms.RadioButton rPolygon;
        private System.Windows.Forms.RadioButton rRectangle;
        private System.Windows.Forms.RadioButton rLine;
        private System.Windows.Forms.RadioButton rCircle;
    }
}

