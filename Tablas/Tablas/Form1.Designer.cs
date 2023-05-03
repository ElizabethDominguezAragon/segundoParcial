namespace Tablas
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
            this.CB_1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_2 = new System.Windows.Forms.CheckBox();
            this.CB_3 = new System.Windows.Forms.CheckBox();
            this.CB_4 = new System.Windows.Forms.CheckBox();
            this.CB_6 = new System.Windows.Forms.CheckBox();
            this.CB_7 = new System.Windows.Forms.CheckBox();
            this.CB_5 = new System.Windows.Forms.CheckBox();
            this.TABLA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_1
            // 
            this.CB_1.AutoSize = true;
            this.CB_1.Location = new System.Drawing.Point(49, 61);
            this.CB_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_1.Name = "CB_1";
            this.CB_1.Size = new System.Drawing.Size(37, 26);
            this.CB_1.TabIndex = 0;
            this.CB_1.Text = "1";
            this.CB_1.UseVisualStyleBackColor = true;
            this.CB_1.CheckedChanged += new System.EventHandler(this.CB_1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla";
            // 
            // CB_2
            // 
            this.CB_2.AutoSize = true;
            this.CB_2.Location = new System.Drawing.Point(49, 100);
            this.CB_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_2.Name = "CB_2";
            this.CB_2.Size = new System.Drawing.Size(37, 26);
            this.CB_2.TabIndex = 2;
            this.CB_2.Text = "2";
            this.CB_2.UseVisualStyleBackColor = true;
            this.CB_2.CheckedChanged += new System.EventHandler(this.CB_2_CheckedChanged);
            // 
            // CB_3
            // 
            this.CB_3.AutoSize = true;
            this.CB_3.Location = new System.Drawing.Point(49, 139);
            this.CB_3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_3.Name = "CB_3";
            this.CB_3.Size = new System.Drawing.Size(37, 26);
            this.CB_3.TabIndex = 3;
            this.CB_3.Text = "3";
            this.CB_3.UseVisualStyleBackColor = true;
            this.CB_3.CheckedChanged += new System.EventHandler(this.CB_3_CheckedChanged);
            // 
            // CB_4
            // 
            this.CB_4.AutoSize = true;
            this.CB_4.Location = new System.Drawing.Point(49, 178);
            this.CB_4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_4.Name = "CB_4";
            this.CB_4.Size = new System.Drawing.Size(37, 26);
            this.CB_4.TabIndex = 4;
            this.CB_4.Text = "4";
            this.CB_4.UseVisualStyleBackColor = true;
            this.CB_4.CheckedChanged += new System.EventHandler(this.CB_4_CheckedChanged);
            // 
            // CB_6
            // 
            this.CB_6.AutoSize = true;
            this.CB_6.Location = new System.Drawing.Point(49, 256);
            this.CB_6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_6.Name = "CB_6";
            this.CB_6.Size = new System.Drawing.Size(37, 26);
            this.CB_6.TabIndex = 5;
            this.CB_6.Text = "6";
            this.CB_6.UseVisualStyleBackColor = true;
            this.CB_6.CheckedChanged += new System.EventHandler(this.CB_6_CheckedChanged);
            // 
            // CB_7
            // 
            this.CB_7.AutoSize = true;
            this.CB_7.Location = new System.Drawing.Point(49, 295);
            this.CB_7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_7.Name = "CB_7";
            this.CB_7.Size = new System.Drawing.Size(37, 26);
            this.CB_7.TabIndex = 6;
            this.CB_7.Text = "7";
            this.CB_7.UseVisualStyleBackColor = true;
            this.CB_7.CheckedChanged += new System.EventHandler(this.CB_7_CheckedChanged);
            // 
            // CB_5
            // 
            this.CB_5.AutoSize = true;
            this.CB_5.Location = new System.Drawing.Point(49, 217);
            this.CB_5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB_5.Name = "CB_5";
            this.CB_5.Size = new System.Drawing.Size(37, 26);
            this.CB_5.TabIndex = 7;
            this.CB_5.Text = "5";
            this.CB_5.UseVisualStyleBackColor = true;
            this.CB_5.CheckedChanged += new System.EventHandler(this.CB_5_CheckedChanged);
            // 
            // TABLA
            // 
            this.TABLA.Location = new System.Drawing.Point(211, 139);
            this.TABLA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TABLA.Name = "TABLA";
            this.TABLA.Size = new System.Drawing.Size(148, 39);
            this.TABLA.TabIndex = 8;
            this.TABLA.Text = "MostrarTabla";
            this.TABLA.UseVisualStyleBackColor = true;
            this.TABLA.Click += new System.EventHandler(this.TABLA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 386);
            this.Controls.Add(this.TABLA);
            this.Controls.Add(this.CB_5);
            this.Controls.Add(this.CB_7);
            this.Controls.Add(this.CB_6);
            this.Controls.Add(this.CB_4);
            this.Controls.Add(this.CB_3);
            this.Controls.Add(this.CB_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tabla";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_2;
        private System.Windows.Forms.CheckBox CB_3;
        private System.Windows.Forms.CheckBox CB_4;
        private System.Windows.Forms.CheckBox CB_6;
        private System.Windows.Forms.CheckBox CB_7;
        private System.Windows.Forms.CheckBox CB_5;
        private System.Windows.Forms.Button TABLA;
    }
}

