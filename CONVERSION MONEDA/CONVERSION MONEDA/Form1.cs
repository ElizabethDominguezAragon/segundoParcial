using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONVERSION_MONEDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butt_calcular_Click(object sender, EventArgs e)
        {
            double dmonto = double.Parse( text_MONTO.Text);
            double resultado = 0;
            double tcdolar = 19.20;
            double tceuro = 20.09;
            double tccanadience = 13.83;
            double tcquetzal = 7.80;
            // si pidieron dolares
            if (check_dolar.Checked == true)
            {
                resultado = dmonto / tcdolar;
            }
            // euro
            if (check_euro.Checked == true)
            {
                resultado = dmonto / tceuro;
            }
            // canadience 
            if (check_dolarcanadience.Checked == true)
            {
                resultado = dmonto / tccanadience;
            }
            // quetzal
            if (check_quetzales.Checked == true)
            {
                resultado = dmonto / tcquetzal;
            }

            text_resultado.Text = resultado.ToString();
        }
    }
}
