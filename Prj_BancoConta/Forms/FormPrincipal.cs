using Prj_BancoConta.Forms;

namespace Prj_BancoConta
{
    public partial class Form_GestãodeContas : Form
    {
        public Form_GestãodeContas()
        {
            InitializeComponent();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Fizemos o link MDI
            //estanciado o objeto p/guardar na memória
            FormCriarConta formCriarConta = new FormCriarConta();
            //usando a variável (formCriarConta) e
            //(MdiParent)usando a propriedade MDI que vai definir que é o pai
            //(this) faz referência a classe FormPrincipal
            formCriarConta.MdiParent = this;
            formCriarConta.Show();
        }

        private void fecharContaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PerfilCorrentistaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}