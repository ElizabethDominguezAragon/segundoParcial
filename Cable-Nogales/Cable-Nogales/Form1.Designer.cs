namespace Cable_Nogales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dia = new System.Windows.Forms.ComboBox();
            this.Adulto_Mayor = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Extra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adulto mayor";
            // 
            // Dia
            // 
            this.Dia.FormattingEnabled = true;
            this.Dia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Dia.Location = new System.Drawing.Point(120, 88);
            this.Dia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(98, 30);
            this.Dia.TabIndex = 2;
            // 
            // Adulto_Mayor
            // 
            this.Adulto_Mayor.AutoSize = true;
            this.Adulto_Mayor.Location = new System.Drawing.Point(402, 91);
            this.Adulto_Mayor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Adulto_Mayor.Name = "Adulto_Mayor";
            this.Adulto_Mayor.Size = new System.Drawing.Size(15, 14);
            this.Adulto_Mayor.TabIndex = 3;
            this.Adulto_Mayor.UseVisualStyleBackColor = true;
            this.Adulto_Mayor.CheckedChanged += new System.EventHandler(this.Adulto_Mayor_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "% extra";
            // 
            // Extra
            // 
            this.Extra.Location = new System.Drawing.Point(544, 86);
            this.Extra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Extra.Name = "Extra";
            this.Extra.ReadOnly = true;
            this.Extra.Size = new System.Drawing.Size(90, 26);
            this.Extra.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Extra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Adulto_Mayor);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cable-Nogales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Dia;
        private System.Windows.Forms.CheckBox Adulto_Mayor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Extra;
        private System.Windows.Forms.Button button1;
    }
}

