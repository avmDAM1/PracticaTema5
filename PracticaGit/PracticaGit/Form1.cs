using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGit
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cambios realizados al código
            string textoTelegrama = "";
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste = 0;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = textoTelegrama.Length;
            char[] separador = new char[1];
            separador[0] = ' ';
            numPalabras = textoTelegrama.Split(separador).Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama != 'O')
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + (0.5 * (numPalabras - 10));
            else
            //Si el telegrama es urgente
            if (tipoTelegrama == 'u')
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";

        }
    }
}
