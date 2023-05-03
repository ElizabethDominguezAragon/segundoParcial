namespace Area
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CB_Triangulo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BaseT = new System.Windows.Forms.TextBox();
            this.AlturaT = new System.Windows.Forms.TextBox();
            this.AreaT = new System.Windows.Forms.TextBox();
            this.Cb_Circulo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AreaC = new System.Windows.Forms.TextBox();
            this.Radio = new System.Windows.Forms.TextBox();
            this.Cb_Rectangulo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BaseR = new System.Windows.Forms.TextBox();
            this.AlturaR = new System.Windows.Forms.TextBox();
            this.AreaR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Triangulo
            // 
            this.CB_Triangulo.AutoSize = true;
            this.CB_Triangulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Triangulo.Location = new System.Drawing.Point(34, 13);
            this.CB_Triangulo.Name = "CB_Triangulo";
            this.CB_Triangulo.Size = new System.Drawing.Size(117, 23);
            this.CB_Triangulo.TabIndex = 0;
            this.CB_Triangulo.Text = "Area Triangulo";
            this.CB_Triangulo.UseVisualStyleBackColor = true;
            this.CB_Triangulo.CheckedChanged += new System.EventHandler(this.CB_AreaT_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Area";
            // 
            // BaseT
            // 
            this.BaseT.BackColor = System.Drawing.SystemColors.Control;
            this.BaseT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseT.Location = new System.Drawing.Point(83, 40);
            this.BaseT.Name = "BaseT";
            this.BaseT.ReadOnly = true;
            this.BaseT.Size = new System.Drawing.Size(100, 26);
            this.BaseT.TabIndex = 4;
            // 
            // AlturaT
            // 
            this.AlturaT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlturaT.Location = new System.Drawing.Point(83, 75);
            this.AlturaT.Name = "AlturaT";
            this.AlturaT.ReadOnly = true;
            this.AlturaT.Size = new System.Drawing.Size(100, 26);
            this.AlturaT.TabIndex = 5;
            this.AlturaT.TextChanged += new System.EventHandler(this.AlturaT_TextChanged);
            // 
            // AreaT
            // 
            this.AreaT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaT.Location = new System.Drawing.Point(83, 106);
            this.AreaT.Name = "AreaT";
            this.AreaT.ReadOnly = true;
            this.AreaT.Size = new System.Drawing.Size(100, 26);
            this.AreaT.TabIndex = 6;
            // 
            // Cb_Circulo
            // 
            this.Cb_Circulo.AutoSize = true;
            this.Cb_Circulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Circulo.Location = new System.Drawing.Point(265, 12);
            this.Cb_Circulo.Name = "Cb_Circulo";
            this.Cb_Circulo.Size = new System.Drawing.Size(106, 23);
            this.Cb_Circulo.TabIndex = 7;
            this.Cb_Circulo.Text = "Area Circulo";
            this.Cb_Circulo.UseVisualStyleBackColor = true;
            this.Cb_Circulo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Radio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Area";
            // 
            // AreaC
            // 
            this.AreaC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaC.Location = new System.Drawing.Point(312, 106);
            this.AreaC.Name = "AreaC";
            this.AreaC.ReadOnly = true;
            this.AreaC.Size = new System.Drawing.Size(100, 26);
            this.AreaC.TabIndex = 10;
            // 
            // Radio
            // 
            this.Radio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio.Location = new System.Drawing.Point(312, 40);
            this.Radio.Name = "Radio";
            this.Radio.ReadOnly = true;
            this.Radio.Size = new System.Drawing.Size(100, 26);
            this.Radio.TabIndex = 11;
            // 
            // Cb_Rectangulo
            // 
            this.Cb_Rectangulo.AutoSize = true;
            this.Cb_Rectangulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cb_Rectangulo.Location = new System.Drawing.Point(522, 13);
            this.Cb_Rectangulo.Name = "Cb_Rectangulo";
            this.Cb_Rectangulo.Size = new System.Drawing.Size(129, 23);
            this.Cb_Rectangulo.TabIndex = 12;
            this.Cb_Rectangulo.Text = "Area Rectangulo";
            this.Cb_Rectangulo.UseVisualStyleBackColor = true;
            this.Cb_Rectangulo.CheckedChanged += new System.EventHandler(this.Cb_Rectangulo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Altura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(519, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Base";
            // 
            // BaseR
            // 
            this.BaseR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseR.Location = new System.Drawing.Point(564, 40);
            this.BaseR.Name = "BaseR";
            this.BaseR.ReadOnly = true;
            this.BaseR.Size = new System.Drawing.Size(100, 26);
            this.BaseR.TabIndex = 15;
            // 
            // AlturaR
            // 
            this.AlturaR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlturaR.Location = new System.Drawing.Point(564, 74);
            this.AlturaR.Name = "AlturaR";
            this.AlturaR.ReadOnly = true;
            this.AlturaR.Size = new System.Drawing.Size(100, 26);
            this.AlturaR.TabIndex = 16;
            // 
            // AreaR
            // 
            this.AreaR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaR.Location = new System.Drawing.Point(564, 106);
            this.AreaR.Name = "AreaR";
            this.AreaR.ReadOnly = true;
            this.AreaR.Size = new System.Drawing.Size(100, 26);
            this.AreaR.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(519, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Area";
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calcular.Location = new System.Drawing.Point(312, 252);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(100, 30);
            this.Calcular.TabIndex = 19;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AreaR);
            this.Controls.Add(this.AlturaR);
            this.Controls.Add(this.BaseR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cb_Rectangulo);
            this.Controls.Add(this.Radio);
            this.Controls.Add(this.AreaC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cb_Circulo);
            this.Controls.Add(this.AreaT);
            this.Controls.Add(this.AlturaT);
            this.Controls.Add(this.BaseT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Triangulo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Areas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Triangulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BaseT;
        private System.Windows.Forms.TextBox AlturaT;
        private System.Windows.Forms.TextBox AreaT;
        private System.Windows.Forms.CheckBox Cb_Circulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AreaC;
        private System.Windows.Forms.TextBox Radio;
        private System.Windows.Forms.CheckBox Cb_Rectangulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BaseR;
        private System.Windows.Forms.TextBox AlturaR;
        private System.Windows.Forms.TextBox AreaR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Calcular;
    }
}

