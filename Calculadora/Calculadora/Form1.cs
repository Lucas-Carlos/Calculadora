using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Instanciação.
        Calculadora calculadora = new Calculadora();


        //Botão de somar.
        private void btnsoma_Click(object sender, EventArgs e)
        {
            try
            {                
                calculadora.Numero1 = Convert.ToDouble(txtn1.Text);
                calculadora.Numero2 = Convert.ToDouble(txtn2.Text);
                txtresult.Text = Convert.ToString(calculadora.Somar());
            }
            catch (Exception)
            {
                MessageBox.Show("Digite somente números válidos!");
            }
        }


        //Botão de subtrair.
        private void btnsub_Click(object sender, EventArgs e)
        {
            try
            {
                calculadora.Numero1 = Convert.ToDouble(txtn1.Text);
                calculadora.Numero2 = Convert.ToDouble(txtn2.Text);
                txtresult.Text = Convert.ToString(calculadora.Subtrair());
            }
            catch (Exception)
            {
                MessageBox.Show("Digite somente números válidos!");
            }
        }

        //Botão de multiplicar.
        private void btnmult_Click(object sender, EventArgs e)
        {
            try
            {
                calculadora.Numero1 = Convert.ToDouble(txtn1.Text);
                calculadora.Numero2 = Convert.ToDouble(txtn2.Text);
                txtresult.Text = Convert.ToString(calculadora.Multiplicar());
            }
            catch (Exception)
            {
                MessageBox.Show("Digite somente números válidos!");
            }
        }

        //Botão de dividir.
        private void btndiv_Click(object sender, EventArgs e)
        {
            try
            {
                calculadora.Numero1 = Convert.ToDouble(txtn1.Text);
                calculadora.Numero2 = Convert.ToDouble(txtn2.Text);
                txtresult.Text = Convert.ToString(calculadora.Dividir());
            }
            catch (Exception)
            {
                MessageBox.Show("Digite somente números válidos!");
            }
        }

        //Botão de calcular a porcentagem.
        private void btnporc_Click(object sender, EventArgs e)
        {
            try
            {
                calculadora.Numero1 = Convert.ToDouble(txtn1.Text);
                calculadora.Numero2 = Convert.ToDouble(txtn2.Text);
                txtresult.Text = Convert.ToString(calculadora.Porcentagem());
            }
            catch (Exception)
            {
                MessageBox.Show("Digite somente números válidos!");
            }
        }

        //Botão de elevar.
        private void btnelev_Click(object sender, EventArgs e)
        {
            try
            {
                calculadora.Numero1 = Convert.ToDouble(txtn1.Text);
                calculadora.Numero2 = Convert.ToDouble(txtn2.Text);
                txtresult.Text = Convert.ToString(calculadora.Elevar());
            }
            catch (Exception)
            {
                MessageBox.Show("Digite somente números válidos!");
            }
        }
    }
}