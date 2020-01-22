using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaWinForms4
{
    public partial class Form1 : Form
    {
        double v1, v2;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            operador = "";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            v2 = Convert.ToDouble(txtValor.Text);
            label1.Text = "=";
            if (operador == "soma")
            {
                Soma clickSoma = new Soma();
                txtValor.Text = Convert.ToString(clickSoma.Calcular(v1, v2));
            }
            else if ( operador == "subtracao")
            {
                Subtração clickSubtracao = new Subtração();
                txtValor.Text = Convert.ToString(clickSubtracao.Calcular(v1, v2));
            }
            else if (operador == "multiplicacao")
            {
                Multiplicacão clickMultiplicacao = new Multiplicacão();
                txtValor.Text = Convert.ToString(clickMultiplicacao.Calcular(v1, v2));
            }
            else if (operador == "divisao")
            {
                if ( v2 != 0)
                {
                    Divisão clickdivisao = new Divisão();
                    txtValor.Text = Convert.ToString(clickdivisao.Calcular(v1, v2));
                }
                else
                {
                    MessageBox.Show("ERRO!\nDivisão por zero!");
                }
            }

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(txtValor.Text);
            label1.Text = "-";
            txtValor.Text = "";
            operador = "subtracao";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(txtValor.Text);
            label1.Text = "*";
            txtValor.Text = "";
            operador = "multiplicacao";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(txtValor.Text);
            label1.Text = "/";
            txtValor.Text = "";
            operador = "divisao";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(txtValor.Text);
            label1.Text = "+";
            txtValor.Text = "";
            operador = "soma";
        }
    }
    abstract class OperaçãoMatemática
    {
        public abstract double Calcular(double x, double y);
    }
    class Soma : OperaçãoMatemática
    {
        public override double Calcular(double x, double y)
        {
            return (double)x + y;
        }
    }
    class Subtração : OperaçãoMatemática
    {
        public override double Calcular(double x, double y)
        {
            return (double)x - y;
        }
    }
    class Multiplicacão : OperaçãoMatemática
    {
        public override double Calcular(double x, double y)
        {
            return (double)x * y;
        }
    }
    class Divisão : OperaçãoMatemática
    {
        public override double Calcular(double x, double y)
        {
            return (double)x / y;
        }
    }
}
