using Prj_BancoConta.Forms;

namespace Prj_BancoConta
{
    public partial class Form_Gest�odeContas : Form
    {
        public Form_Gest�odeContas()
        {
            InitializeComponent();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Fizemos o link MDI
            //estanciado o objeto p/guardar na mem�ria
            FormCriarConta formCriarConta = new FormCriarConta();
            //usando a vari�vel (formCriarConta) e
            //(MdiParent)usando a propriedade MDI que vai definir que � o pai
            //(this) faz refer�ncia a classe FormPrincipal
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