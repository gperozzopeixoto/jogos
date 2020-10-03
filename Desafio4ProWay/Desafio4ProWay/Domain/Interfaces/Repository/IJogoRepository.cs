using Desafio4ProWay.Entidades;
using System.Collections.Generic;

namespace Desafio4ProWay.Domain.Interfaces.Repository
{
    public interface IJogoRepository
    {
        void CadastrarNovoJogo(JogoBE jogo);
        List<JogoBE> ObterJogosCadastrados();
    }
}
