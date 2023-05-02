namespace conversionMoneda
{
    partial class CasaDeMoneda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasaDeMoneda));
            this.label1 = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.TextBox();
            this.Convencion = new System.Windows.Forms.RichTextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto:";
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(94, 29);
            this.Monto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(148, 26);
            this.Monto.TabIndex = 1;
            // 
            // Convencion
            // 
            this.Convencion.Location = new System.Drawing.Point(276, 17);
            this.Convencion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Convencion.Name = "Convencion";
            this.Convencion.Size = new System.Drawing.Size(310, 317);
            this.Convencion.TabIndex = 2;
            this.Convencion.Text = "";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(94, 85);
            this.calcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(112, 39);
            this.calcular.TabIndex = 3;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // CasaDeMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 354);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.Convencion);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CasaDeMoneda";
            this.Text = "Casa  De Cambio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.RichTextBox Convencion;
        private System.Windows.Forms.Button calcular;
    }
}

