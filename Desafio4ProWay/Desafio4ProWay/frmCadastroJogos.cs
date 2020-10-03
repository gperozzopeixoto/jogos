using Desafio4ProWay.Entidades;
using Desafio4ProWay.Services;
using System;
using System.Windows.Forms;

namespace Desafio4ProWay
{
    public partial class frmCadastroJogos : Form
    {

        private readonly frmListagemJogos _frmListagemJogos;
        public frmCadastroJogos()
        {
            InitializeComponent();
        }

        public frmCadastroJogos(frmListagemJogos frmListagemJogos)
        {
            InitializeComponent();
            _frmListagemJogos = frmListagemJogos;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            JogoService service = new JogoService();
            
            int placar = Convert.ToInt32(txtPlacar.Text);
            JogoBE novoJogo = new JogoBE(placar);

            service.CadastrarNovoJogo(novoJogo);
            _frmListagemJogos.CarregarListaJogos();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
