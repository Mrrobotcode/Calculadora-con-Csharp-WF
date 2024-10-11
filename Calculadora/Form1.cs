using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using MaterialSkin.Controls;

namespace Calculadora
{
    public partial class FormCalculadora : MaterialForm
    {
        static double num1, num2, resultado;
        static string operacion;
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = double.Parse(txtPantalla.Text);
            }
            catch
            {
                txtPantalla.Text = "Debes seleccionar un numero";
            }

            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    txtPantalla.Text = Convert.ToString(resultado);
                    break;

                case "-":
                    resultado = num1 - num2;
                    txtPantalla.Text = Convert.ToString(resultado);
                    break;

                case "X":
                    resultado = num1 * num2;
                    txtPantalla.Text = Convert.ToString(resultado);
                    break;

                case "÷":
                    if (num2 == 0)
                    {
                        txtPantalla.Text = "No se puede dividir por cero";
                        break;
                    }
                    else
                    {
                        resultado = num1 / num2;
                        txtPantalla.Text = Convert.ToString(resultado);
                        break;
                    }

                case "%":
                    resultado = num1 % num2;
                    txtPantalla.Text = Convert.ToString(resultado);
                    break;
            }

        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "%";
                num1 = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
            catch
            {
                txtPantalla.Text = "Debes seleccionar un numero";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "÷";
                num1 = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
            catch
            {
                txtPantalla.Text = "Debes seleccionar un numero";
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "X";
                num1 = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
            catch
            {
                txtPantalla.Text = "Debes seleccionar un numero";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "-";
                num1 = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
            catch
            {
                txtPantalla.Text = "Debes seleccionar un numero";
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "+";
                num1 = double.Parse(txtPantalla.Text);
                txtPantalla.Clear();
            }
            catch
            {
                txtPantalla.Text = "Debes seleccionar un numero";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void btnDoblesCeros_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "00";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
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

        private void btn6_Click(object sender, EventArgs e)
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

        private void btnPI_Click(object sender, EventArgs e)
        {
            const double PI = 3.14;
            txtPantalla.Text = txtPantalla.Text + PI;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ".";
        }
    }

}