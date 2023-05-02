using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversionMoneda
{
    public partial class CasaDeMoneda : Form
    {
        public CasaDeMoneda()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Convencion.Text = "Total en yuanes: $" + Cambio(double.Parse(Monto.Text), 2.60) + "\n";
            CambioDollar();
            CambioEuro();
            CambioLibras();

        }
        //mi obcion puede sacar el cambio de cualquier con las variables
        public string Cambio(double X,double Y){
            double total = X / Y;
            return total.ToString("####.##");
        }
        //profe
        public void CambioDollar() {
            double totalDolar, cambioDolar = 18.65;
            totalDolar = double.Parse(Monto.Text) / cambioDolar;
            Convencion.Text += "Total en dolares: $" + totalDolar.ToString("####.##") + "\n";
        }
        public void CambioEuro() {
            double totalEuro,cambioEURO = 26.58;
            totalEuro = double.Parse(Monto.Text) / cambioEURO;
            Convencion.Text += "Total en EURO: $" + totalEuro.ToString("####.##") + "\n";
        }
        public void CambioLibras() {
            double totalLibra, cambiolibra = 20.90;
            totalLibra = double.Parse(Monto.Text) / cambiolibra;
            Convencion.Text += "Total en Libras: $" + totalLibra.ToString("####.##");
        }
    }
}
