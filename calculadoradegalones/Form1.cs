using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoradegalones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double Kilometros = double.Parse(txtkilometros.Text);
            double  rendimiento= double.Parse(txtdinero.Text);



            double Galonesconsumidos = Kilometros / rendimiento * 1;
            
            txttotal.Text= Galonesconsumidos.ToString();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
