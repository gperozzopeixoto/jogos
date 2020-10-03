using Desafio4ProWay.Entidades;
using System.Collections.Generic;

namespace Desafio4ProWay.Domain.Interfaces.Services
{
    public interface IJogoService
    {
        void CadastrarNovoJogo(JogoBE jogo);
        List<JogoBE> ObterJogosCadastrados();
    }
}
