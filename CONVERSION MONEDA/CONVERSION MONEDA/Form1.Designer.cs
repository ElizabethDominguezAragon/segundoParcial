namespace CONVERSION_MONEDA
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_MONTO = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.text_resultado = new System.Windows.Forms.TextBox();
            this.check_dolar = new System.Windows.Forms.CheckBox();
            this.check_euro = new System.Windows.Forms.CheckBox();
            this.check_dolarcanadience = new System.Windows.Forms.CheckBox();
            this.check_quetzales = new System.Windows.Forms.CheckBox();
            this.butt_calcular = new System.Windows.Forms.Button();
            this.butt_limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "monto";
            // 
            // text_MONTO
            // 
            this.text_MONTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_MONTO.Location = new System.Drawing.Point(129, 69);
            this.text_MONTO.Name = "text_MONTO";
            this.text_MONTO.Size = new System.Drawing.Size(100, 31);
            this.text_MONTO.TabIndex = 1;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(29, 145);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(58, 25);
            this.lab.TabIndex = 2;
            this.lab.Text = "total";
            // 
            // text_resultado
            // 
            this.text_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_resultado.Location = new System.Drawing.Point(129, 145);
            this.text_resultado.Name = "text_resultado";
            this.text_resultado.ReadOnly = true;
            this.text_resultado.Size = new System.Drawing.Size(311, 31);
            this.text_resultado.TabIndex = 3;
            // 
            // check_dolar
            // 
            this.check_dolar.AutoSize = true;
            this.check_dolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_dolar.Location = new System.Drawing.Point(446, 37);
            this.check_dolar.Name = "check_dolar";
            this.check_dolar.Size = new System.Drawing.Size(84, 29);
            this.check_dolar.TabIndex = 4;
            this.check_dolar.Text = "dolar";
            this.check_dolar.UseVisualStyleBackColor = true;
            // 
            // check_euro
            // 
            this.check_euro.AutoSize = true;
            this.check_euro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_euro.Location = new System.Drawing.Point(446, 72);
            this.check_euro.Name = "check_euro";
            this.check_euro.Size = new System.Drawing.Size(80, 29);
            this.check_euro.TabIndex = 5;
            this.check_euro.Text = "Euro";
            this.check_euro.UseVisualStyleBackColor = true;
            // 
            // check_dolarcanadience
            // 
            this.check_dolarcanadience.AutoSize = true;
            this.check_dolarcanadience.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_dolarcanadience.Location = new System.Drawing.Point(446, 107);
            this.check_dolarcanadience.Name = "check_dolarcanadience";
            this.check_dolarcanadience.Size = new System.Drawing.Size(219, 29);
            this.check_dolarcanadience.TabIndex = 6;
            this.check_dolarcanadience.Text = "Dolar Canadience";
            this.check_dolarcanadience.UseVisualStyleBackColor = true;
            // 
            // check_quetzales
            // 
            this.check_quetzales.AutoSize = true;
            this.check_quetzales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_quetzales.Location = new System.Drawing.Point(446, 147);
            this.check_quetzales.Name = "check_quetzales";
            this.check_quetzales.Size = new System.Drawing.Size(112, 29);
            this.check_quetzales.TabIndex = 7;
            this.check_quetzales.Text = "Quetzal";
            this.check_quetzales.UseVisualStyleBackColor = true;
            // 
            // butt_calcular
            // 
            this.butt_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_calcular.Location = new System.Drawing.Point(96, 238);
            this.butt_calcular.Name = "butt_calcular";
            this.butt_calcular.Size = new System.Drawing.Size(133, 67);
            this.butt_calcular.TabIndex = 8;
            this.butt_calcular.Text = "calcular";
            this.butt_calcular.UseVisualStyleBackColor = true;
            this.butt_calcular.Click += new System.EventHandler(this.butt_calcular_Click);
            // 
            // butt_limpiar
            // 
            this.butt_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_limpiar.Location = new System.Drawing.Point(296, 238);
            this.butt_limpiar.Name = "butt_limpiar";
            this.butt_limpiar.Size = new System.Drawing.Size(133, 67);
            this.butt_limpiar.TabIndex = 9;
            this.butt_limpiar.Text = "limpiar";
            this.butt_limpiar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 351);
            this.Controls.Add(this.butt_limpiar);
            this.Controls.Add(this.butt_calcular);
            this.Controls.Add(this.check_quetzales);
            this.Controls.Add(this.check_dolarcanadience);
            this.Controls.Add(this.check_euro);
            this.Controls.Add(this.check_dolar);
            this.Controls.Add(this.text_resultado);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.text_MONTO);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CONVERSION DE MONEDA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_MONTO;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox text_resultado;
        private System.Windows.Forms.CheckBox check_dolar;
        private System.Windows.Forms.CheckBox check_euro;
        private System.Windows.Forms.CheckBox check_dolarcanadience;
        private System.Windows.Forms.CheckBox check_quetzales;
        private System.Windows.Forms.Button butt_calcular;
        private System.Windows.Forms.Button butt_limpiar;
    }
}

