using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;//Biblioteca p/trabalhar c/internacionalizaçãp

namespace Prj_BancoConta.Demo
{
    public partial class FrmDemo : Form
    {
        public FrmDemo()
        {
            InitializeComponent();
        }

        private void FrmDemo_Load(object sender, EventArgs e)
        {

        }

        private void lblNumBruto_Click(object sender, EventArgs e)
        {

        }

        private void btnFormata_Click(object sender, EventArgs e)
        {
            //decimal preco = 199;
            //txtNumFormatado.Text = $"O número formatado é {preco:C}"; //"C:" funciona como um formatador de saída para valores monetários,
            //txtNumFormatado.Text = $"O número formatado é {preco:N1}"; // "N:1" Qtde de casas decimais
            //txtNumFormatado.Text = $"O número formatado é {preco:N5}"; // "N:5" Qtde de casas decimais

            //double fatorPercentual = .70;
            //txtNumFormatado.Text = $" Percentual: {fatorPercentual.ToString("P")}";   //O método ToString("P") converte o valor da variável
            //fatorPercentual para uma string formatada como porcentagem.
            //Como o valor de fatorPercentual é 0.70,
            //o método ToString("P") o multiplica por 100 e adiciona
            //o símbolo de porcentagem(%), resultando em 70 %.

            //Manipulando a localização do sistema p/ inglês/Americano
            //CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-UK");
            //decimal preco = 1999 * (decimal)Math.PI;
            //txtNumFormatado.Text = $"Preço do produto {preco:C}"; //Formatar em dinheiro

            //DateTime dataHoje = DateTime.Now;
            //txtNumFormatado2.Text = dataHoje.ToString();

            //*Manipulando Saída
            //txtNumFormatado2.Text = preco.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));

            long cpf = 12345677788; //tipo log é um "int" como maior capacidade númerica
                                    //txtNumFormatado2.Text = preco.ToString("C", CultureInfo.CreateSpecificCulture("000.000.000-00"));

            DateTime data = DateTime.Now;
            txtNumFormatado2.Text = data.ToString("dd \\de MMMM \\de yyyy hh:mm"); // "\\" Qdo colocamos  \\ é para escapar o formato
        }
        /* d - dia
         * M - mês
         * y - ano
         * h - hora
         * m - minutos
         * s - segundo
         */

    }
}
