using Desafio4ProWay.Services;
using System;
using System.Windows.Forms;

namespace Desafio4ProWay
{
    public partial class frmListagemJogos : Form
    {
        public frmListagemJogos()
        {
            Database x = new Database();
            x.CriarTabelasBancoDeDados();
            InitializeComponent();
            CarregarListaJogos();
        }

        public void CarregarListaJogos()
        {
            JogoService service = new JogoService();
            dgJogos.DataSource =  service.ObterJogosCadastrados();
        }

        private void btnAdicionarJogo_Click(object sender, EventArgs e)
        {
            frmCadastroJogos frm = new frmCadastroJogos(this);
            frm.Show();
        }
    }
}
