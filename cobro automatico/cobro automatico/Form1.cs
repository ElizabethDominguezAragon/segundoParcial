using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobro_automatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_descuento_CheckedChanged(object sender, EventArgs e)
        {
            double resultado = 0;
            double mensualidad = double.Parse(text_mensu.Text);
            double meses = double.Parse(text_mensu.Text);

            resultado = mensualidad * meses;
            if (check_descuento.Checked = true)
            {
                resultado = resultado - (resultado * .2);
            }
            MessageBox.Show(" el total a pagar es: $ " + resultado.ToString("###.##"));
        }
    }
}
