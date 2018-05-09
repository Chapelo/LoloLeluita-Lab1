using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2
{
    public partial class Form1 : Form
    {

        //declaro variables
        private decimal _numero1;
        private decimal _numero2;
        private decimal _resultado;
        private string _operador;
        /// <summary>
        /// Metodo para resetear las variables
        /// </summary>
        private void Limpiar()
        {
            txtResultado.Clear();
            _numero1 = 0;
            _numero2 = 0;
            _resultado = 0;
            _operador = string.Empty;

        }
        /// <summary>
        /// Metodo para obtener el resultado de la operacion
        /// </summary>
        /// <param name="numero1">Primer valor</param>
        /// <param name="numero2">Segundo Valor</param>
        /// <returns>Devuelve el resultado</returns>
        private decimal RealizarOperacion(decimal numero1, decimal numero2, string operador)
        {
            decimal resultado = 0m;
            //switch
            switch (operador)
            {
                case "+":
                    resultado = _numero1 + _numero2;
                    break;
                case "-":
                    resultado = _numero1 - _numero2;
                    break;
                case "*":
                    resultado = _numero1 * _numero2;
                    break;
                case "/":
                    try
                    {
                        resultado = _numero1 / _numero2;
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("No se puede dividir por cero");
                        txtResultado.Clear();
                        _numero2 = 0m;

                    }
                    break;



            }
            return resultado;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ((Button)sender).Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                _numero1 = decimal.Parse(txtResultado.Text);
                txtResultado.Clear();
                _operador = ((Button)sender).Text;

            }
            else
            {
                MessageBox.Show("Ingrese un valor");
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                // Se obtiene el segundo valor
                _numero2 = decimal.Parse(txtResultado.Text);
                //Se opera
                _resultado = RealizarOperacion(_numero1, _numero2, _operador);
                // Se muestra el resultado
                txtResultado.Text = _resultado.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un valor");
            }
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();


        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
        }
    }
}
