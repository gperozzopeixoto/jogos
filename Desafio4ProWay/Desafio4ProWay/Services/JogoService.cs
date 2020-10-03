using Desafio4ProWay.Entidades;
using Desafio4ProWay.Repository;
using System.Collections.Generic;

namespace Desafio4ProWay.Services
{
    public class JogoService
    {
        public void CadastrarNovoJogo(JogoBE jogo)
        {
            JogoRepository repository = new JogoRepository();
            repository.CadastrarNovoJogo(jogo);
        }

        public List<JogoBE> ObterJogosCadastrados()
        {
            JogoRepository repository = new JogoRepository();
            return repository.ObterJogosCadastrados();
        }
    }
}
