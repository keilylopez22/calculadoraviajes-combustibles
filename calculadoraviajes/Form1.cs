using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraviajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double Vo =double.Parse(txtpuntoA.Text);
            double Vf =double.Parse(txtpuntoB.Text);
            double velocidad = double.Parse(txtvelocidad.Text);
            double tiempo = Vf - Vo;
            double resuladofinal = tiempo / velocidad;
            txttiempo.Text = resuladofinal.ToString();
            MessageBox.Show("Tiempo estimado de viaje: " + resuladofinal.ToString("0.00") + " horas", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       
    }
}
