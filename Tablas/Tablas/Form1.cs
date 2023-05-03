using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CB_1_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_1.Checked == true)
            {
                CB_2.Checked = false;
                CB_3.Checked = false;
                CB_4.Checked = false;
                CB_5.Checked = false;
                CB_6.Checked = false;
                CB_7.Checked = false;
            }

        }

        private void CB_2_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_2.Checked == true)
            {
                CB_1.Checked = false;
                CB_3.Checked = false;
                CB_4.Checked = false;
                CB_5.Checked = false;
                CB_6.Checked = false;
                CB_7.Checked = false;
            }
        }

        private void CB_3_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_3.Checked == true)
            {
                CB_1.Checked = false;
                CB_2.Checked = false;
                CB_4.Checked = false;
                CB_5.Checked = false;
                CB_6.Checked = false;
                CB_7.Checked = false;
            }

        }

        private void CB_4_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_4.Checked == true)
            {
                CB_1.Checked = false;
                CB_2.Checked = false;
                CB_3.Checked = false;
                CB_5.Checked = false;
                CB_6.Checked = false;
                CB_7.Checked = false;
            }

        }

        private void CB_5_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_5.Checked == true)
            {
                CB_1.Checked = false;
                CB_2.Checked = false;
                CB_3.Checked = false;
                CB_4.Checked = false;
                CB_6.Checked = false;
                CB_7.Checked = false;
            }
        }

        private void CB_6_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_6.Checked == true)
            {
                CB_1.Checked = false;
                CB_2.Checked = false;
                CB_3.Checked = false;
                CB_4.Checked = false;
                CB_5.Checked = false;
                CB_7.Checked = false;
            }
        }

        private void CB_7_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_7.Checked == true)
            {
                CB_1.Checked = false;
                CB_2.Checked = false;
                CB_3.Checked = false;
                CB_4.Checked = false;
                CB_5.Checked = false;
                CB_6.Checked = false;
            }

        }

        private void TABLA_Click(object sender, EventArgs e)
        {
            int x;
            string texto = "Tabla del ";
            for (int i = 1; i <= 10; i++)
            {
                if (CB_1.Checked == true)
                {
                    x = 1;
                    texto += "x:";
                    texto += "\n" + "1 x " + i.ToString() + " = " + (1 * i).ToString();

                }
                if (CB_2.Checked == true)
                {
                    x = 2;
                    texto += x.ToString() + ":";
                    texto += "\n" + x.ToString() + " x " + i.ToString() + " = " + (x * i).ToString();
                }
                if (CB_3.Checked == true)
                {
                    x = 3;
                    texto += x.ToString() + ":";
                    texto += "\n" + x.ToString() + " x " + i.ToString() + " = " + (x * i).ToString();
                }
                if (CB_4.Checked == true)
                {
                    x = 4;
                    texto += x.ToString() + ":";
                    texto += "\n" + x.ToString() + " x " + i.ToString() + " = " + (x * i).ToString();

                }
                if (CB_5.Checked == true)
                {
                    x = 5;
                    texto += x.ToString() + ":";
                    texto += "\n" + x.ToString() + " x " + i.ToString() + " = " + (x * i).ToString();
                }
                if (CB_6.Checked == true)
                {
                    x = 6;
                    texto += x.ToString() + ":";
                    texto += "\n" + x.ToString() + " x " + i.ToString() + " = " + (x * i).ToString();
                    }
                 if (CB_7.Checked == true)
                 {
                     x = 7;
                     texto += x.ToString() + ":";
                     texto += "\n" + x.ToString() + " x " + i.ToString() + " = " + (x * i).ToString();
                    }
                }
                MessageBox.Show(texto);
            }
        }
    }
}
