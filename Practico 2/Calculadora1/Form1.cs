using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        // Variables
        private decimal _primerValor;
        private decimal _segundoValor;
        private decimal _resultado;
        private string _operador;




        public Form1()
        {
            InitializeComponent();

            // Icicializamos las variables
            Limpiar();

        }

        /// <summary>
        /// Metodo para limpiar e inicializar
        /// </summary>
        private void Limpiar()
        {
            txtDisplay.Clear();

            _primerValor = 0m;
            _segundoValor = 0m;
            _resultado = 0m;
            _operador = string.Empty;
        }


        /// <summary>
        /// Metodo para realizar la operacion
        /// </summary>
        /// <param name="primerValor">Primer Valor</param>
        /// <param name="segundoValor">Segundo Valor</param>
        /// <returns>Retorna segun la operacion asignada</returns>
        private decimal RealizarOperacion(decimal primerValor, decimal segundoValor, string operador)
        {
            decimal resultado = 0m;

            switch (operador)
            {
                case "+":
                    resultado = _primerValor + _segundoValor;
                    break;
                case "-":
                    resultado = _primerValor - _segundoValor;
                    break;
                case "*":
                    resultado = _primerValor * _segundoValor;
                    break;
                case "/":

                    try
                    {
                        resultado = primerValor / _segundoValor;
                    }
                    catch (DivideByZeroException ex)
                    {
                        MessageBox.Show(@"No se puede dividir por cero");
                        txtDisplay.Clear();
                        _segundoValor = 0m;
                    }
                    break;
            }

            return resultado;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            // Por sender pasa el objeto/control
            // en el que hacemos un click (cuando clickeamos el borton

            txtDisplay.Text += ((Button)sender).Text; // Esto es "castear" (le digo q se comporte como un boton)
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                // 1 paso --> Se obtiene el valor y asigna a la variable
                _primerValor = decimal.Parse(txtDisplay.Text);

                // 2 paso --> Limpio el display para el otro valor
                txtDisplay.Clear();

                // 3 paso --> Guardo que operacion se va a realizar
                _operador = ((Button)sender).Text;
            }

            else
            {
                MessageBox.Show("por favor ingrese un valor");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                // 1 paso --> Obtengo el segundo valor
                _segundoValor = decimal.Parse(txtDisplay.Text);

                // 2 paso --> Operar
                _resultado = RealizarOperacion(_primerValor, _segundoValor, _operador);

                // 3 paso --> Mostrar el resultado
                txtDisplay.Text = _resultado.ToString(); // convierto a cadena de texto
            }

            else
            {
                MessageBox.Show("por favor ingrese un valor");
            }
        }
    }
}
