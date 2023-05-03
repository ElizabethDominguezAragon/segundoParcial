using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CB_AreaT_CheckedChanged(object sender, EventArgs e)
        {
            if(BaseT.ReadOnly == true) {
                BaseT.ReadOnly = false;
                AlturaT.ReadOnly = false;
            }else{
                BaseT.ReadOnly = true;
                AlturaT.ReadOnly = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio.ReadOnly == true) {
                Radio.ReadOnly = false;
            } else {
                Radio.ReadOnly = true;
            }
        }

        private void Cb_Rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (BaseR.ReadOnly == true) {
                BaseR.ReadOnly = false;
                AlturaR.ReadOnly = false;
            }else {
                BaseR.ReadOnly = true;
                AlturaR.ReadOnly = true;
            }
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (CB_Triangulo.Checked==true){ 
            AreaT.Text = ((double.Parse(BaseT.Text) * double.Parse(AlturaT.Text))/2 ).ToString();
            }
            if (Cb_Circulo.Checked == true)
            {
                AreaC.Text = ((double.Parse(Radio.Text) * double.Parse(Radio.Text)) * 3.1416).ToString();
            }
            if (CB_Triangulo.Checked == true)
            {
                AreaR.Text = (double.Parse(BaseR.Text) * double.Parse(AlturaR.Text)).ToString();
            }
        }

        private void AlturaT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

