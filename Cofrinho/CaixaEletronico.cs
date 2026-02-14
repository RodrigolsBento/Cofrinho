using Cofrinho.Core;

namespace Cofrinho
{
    public partial class CaixaEletronico : Form
    {

        private string _operacaoAtual;
        private bool _deveLimparVisor;
        private decimal _valor1;
        private decimal _saldo;


        public CaixaEletronico()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            _saldo = Convert.ToDecimal(txtVisor.Text);

            OperacoesBancaria.Depositar(_saldo);
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            _saldo = Convert.ToDecimal(txtVisor.Text);

            OperacoesBancaria.Sacar(_saldo);
        }

            
    }
}
