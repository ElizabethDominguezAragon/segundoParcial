using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cable_Nogales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Adulto_Mayor_CheckedChanged(object sender, EventArgs e)
        {
            if (Extra.ReadOnly == true) {
                Extra.ReadOnly = false;
                
            }
            else {
                Extra.ReadOnly = true;
                Extra.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dias = int.Parse(Dia.Text), descuento = 0, D_extra;
            double total = 0;
            if (dias >= 1 && dias <= 5) {
                if (Adulto_Mayor.Checked == true) {
                    D_extra = int.Parse(Extra.Text);
                    total = 440 - (440 * 0.1) - ((440 * D_extra) / 100);
                    descuento = 10 + D_extra;
                } else {
                    total = 440 - (440 * 0.1);
                    descuento = 10;
                }
            }
            if (dias >= 6 && dias <= 10)
            {
                if (Adulto_Mayor.Checked == true)
                {
                    D_extra = int.Parse(Extra.Text);
                    total = 440 - (440 * 0.07) - ((440 * D_extra) / 100);
                    descuento = 7 + D_extra;
                }
                else
                {
                    total = 440 - (440 * 0.7);
                    descuento = 7;
                }

            }
            MessageBox.Show("Total a pagar:" + total.ToString() + "\nDescuento total: %" + descuento.ToString());
        }
    }
}
