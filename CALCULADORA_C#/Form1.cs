using System.Configuration;

namespace CALCULADORA_C_
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado;
        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //número 5
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //número 3
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //signo sumar
            operacion = 1;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //método igual
            valor2 = Convert.ToDouble(tbDisplay.Text);

            resultado = valor1 + valor2;
            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }

            tbDisplay.Text = resultado.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //número 1
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //número 6
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //número 4
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //número 0
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //número 8
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //signo resta
            operacion = 2;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //signo multiplicación
            operacion = 3;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //número 2
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //número 7
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //número 9
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //botón borrar
            valor1 = 0;
            valor2 = 0;
            operacion = '\0';
            tbDisplay.Text = "0"; 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //signo división
            operacion = 4;
            valor1 = Convert.ToDouble(tbDisplay.Text);
            tbDisplay.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            //signoPunto
            tbDisplay.Text = tbDisplay.Text + ".";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //boton limpiar
            tbDisplay.Text = "0";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            tbDisplay.Text = "0"; 
        }
    }
}