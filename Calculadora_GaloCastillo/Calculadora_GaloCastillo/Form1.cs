using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_GaloCastillo
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "+";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            string expresion = txtPantalla.Text.Replace('×', '*').Replace('÷', '/');

            if (string.IsNullOrWhiteSpace(expresion))
            {
                MessageBox.Show("Primero ingresa un número.");
                return;
            }

            string textoNumero = "";
            char operacion = '+';
            decimal total = 0;
            decimal termino = 0;

            // Permite seguir calculando si el resultado anterior fue negativo.
            if (expresion.StartsWith("-"))
            {
                textoNumero = "-";
                expresion = expresion.Substring(1);
            }

            // El + final permite procesar el último número de la pantalla.
            foreach (char caracter in expresion + "+")
            {
                if (char.IsDigit(caracter) || caracter == ',' || caracter == '.')
                {
                    textoNumero += caracter;
                    continue;
                }

                if ("+-*/".IndexOf(caracter) == -1)
                {
                    MessageBox.Show("La operación contiene un símbolo inválido.");
                    return;
                }

                decimal numero;
                if (!decimal.TryParse(textoNumero, out numero))
                {
                    MessageBox.Show("Ingresa un número válido a cada lado del signo.");
                    return;
                }

                switch (operacion)
                {
                    case '+':
                        total += termino;
                        termino = numero;
                        break;

                    case '-':
                        total += termino;
                        termino = -numero;
                        break;

                    case '*':
                        termino *= numero;
                        break;

                    case '/':
                        if (numero == 0)
                        {
                            MessageBox.Show("No se puede dividir entre cero.");
                            return;
                        }

                        termino /= numero;
                        break;
                }

                operacion = caracter;
                textoNumero = "";
            }

            txtPantalla.Text = (total + termino).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "-";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "*";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "/";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
