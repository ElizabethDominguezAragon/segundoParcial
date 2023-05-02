using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutricion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int P_Pollo = 90, P_Res = 150, P_Puerco = 250, P_Pescado = 150, P_Queso = 100;
            int F_Manzana = 60, F_Platano = 100, F_Naranja = 80;
            int B_limonada = 200, B_Cola = 300, B_Jamaica = 200;
            int Total = 0;
            if (Pollo_CB.Checked == true){
                Total += P_Pollo;
            }if (Res.Checked == true){
                Total += P_Res;
            }if (Puerco.Checked == true) {
                Total += P_Puerco;
            }if (Pescado.Checked == true){
                Total += P_Pescado;
            }if (Queso.Checked == true){
                Total += P_Queso;
            }if (Manzana.Checked == true){
                Total += F_Manzana;
            }if (Platano.Checked == true){
                Total += F_Platano;
            }if (Naranja.Checked == true){
                Total += F_Naranja;
            }if (Limonada.Checked == true){
                Total += B_limonada;
            }if (BCola.Checked == true){
                Total += B_Cola;
            }if (Jamaica.Checked == true){
                Total += B_Jamaica;
            }
            // -----------------------------
            double Peso = double.Parse(txt_Peso.Text);
            if(Peso >0 && Peso<=54){
                if (Total > 600){
                    MessageBox.Show("Exede el total de calorias para su peso");
                }else if (Total == 600){
                    MessageBox.Show("felicidades, sigue comienso sano");
                }else{
                    MessageBox.Show("Necesitas seleccionar mas alimentos, \ntu cantidad de calorias es menor a la recomendada.");
                }
            }
            if (Peso > 54 && Peso <= 75)
            {
                if (Total > 480)
                {
                    MessageBox.Show("Exede el total de calorias para su peso");
                }
                else if (Total == 480)
                {
                    MessageBox.Show("felicidades, sigue comienso sano");
                }
                else
                {
                    MessageBox.Show("Necesitas seleccionar mas alimentos, \ntu cantidad de calorias es menor a la recomendada.");
                }
            }
            if ( Peso > 75)
            {
                if (Total > 420)
                {
                    MessageBox.Show("Exede el total de calorias para su peso");
                }
                else if (Total == 420)
                {
                    MessageBox.Show("felicidades, sigue comienso sano");
                }
                else
                {
                    MessageBox.Show("Necesitas seleccionar mas alimentos, \ntu cantidad de calorias es menor a la recomendada.");
                }
            }



        }
    }
}
