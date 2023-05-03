namespace cobro_automatico
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
            this.text_mensu = new System.Windows.Forms.TextBox();
            this.text_meses = new System.Windows.Forms.TextBox();
            this.lab_mensualidad = new System.Windows.Forms.Label();
            this.lab_meses = new System.Windows.Forms.Label();
            this.check_descuento = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // text_mensu
            // 
            this.text_mensu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_mensu.Location = new System.Drawing.Point(210, 100);
            this.text_mensu.Name = "text_mensu";
            this.text_mensu.Size = new System.Drawing.Size(100, 31);
            this.text_mensu.TabIndex = 0;
            // 
            // text_meses
            // 
            this.text_meses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_meses.Location = new System.Drawing.Point(210, 166);
            this.text_meses.Name = "text_meses";
            this.text_meses.Size = new System.Drawing.Size(100, 31);
            this.text_meses.TabIndex = 1;
            // 
            // lab_mensualidad
            // 
            this.lab_mensualidad.AutoSize = true;
            this.lab_mensualidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_mensualidad.Location = new System.Drawing.Point(45, 100);
            this.lab_mensualidad.Name = "lab_mensualidad";
            this.lab_mensualidad.Size = new System.Drawing.Size(145, 25);
            this.lab_mensualidad.TabIndex = 2;
            this.lab_mensualidad.Text = "mensualidad";
            // 
            // lab_meses
            // 
            this.lab_meses.AutoSize = true;
            this.lab_meses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_meses.Location = new System.Drawing.Point(45, 169);
            this.lab_meses.Name = "lab_meses";
            this.lab_meses.Size = new System.Drawing.Size(80, 25);
            this.lab_meses.TabIndex = 3;
            this.lab_meses.Text = "meses";
            // 
            // check_descuento
            // 
            this.check_descuento.AutoSize = true;
            this.check_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_descuento.Location = new System.Drawing.Point(403, 144);
            this.check_descuento.Name = "check_descuento";
            this.check_descuento.Size = new System.Drawing.Size(226, 29);
            this.check_descuento.TabIndex = 4;
            this.check_descuento.Text = "20% de descuento";
            this.check_descuento.UseVisualStyleBackColor = true;
            this.check_descuento.CheckedChanged += new System.EventHandler(this.check_descuento_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.check_descuento);
            this.Controls.Add(this.lab_meses);
            this.Controls.Add(this.lab_mensualidad);
            this.Controls.Add(this.text_meses);
            this.Controls.Add(this.text_mensu);
            this.Name = "Form1";
            this.Text = "pagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_mensu;
        private System.Windows.Forms.TextBox text_meses;
        private System.Windows.Forms.Label lab_mensualidad;
        private System.Windows.Forms.Label lab_meses;
        private System.Windows.Forms.CheckBox check_descuento;
    }
}

