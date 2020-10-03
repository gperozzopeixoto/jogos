using Desafio4ProWay.Entidades;
using System;
using Xunit;

namespace Desafio4ProWay.Test.Entidade
{
    public class JogoBETest
    {
        public object JogoBE { get; private set; }

        [Trait("Categoria","Entidade")]
        [Fact(DisplayName = "Deve retornar erro ao definir placar maior que 1000")]
        public void Deve_Retornar_Erro_Ao_Setar_Placar_Maio_Que_Mil()
        {
            Assert.Throws<ArgumentException>(() => new JogoBE(1001));
        }

        [Trait("Categoria", "Entidade")]
        [Fact(DisplayName = "Não Deve retornar erro ao definir placar menor que 1000")]
        public void Nao_Deve_Retornar_Erro_Ao_Setar_Placar_Menor_Que_Mil()
        {
            int esperado = 999;
            
            JogoBE jogo = new JogoBE(esperado);

            Assert.Equal(esperado, jogo.Placar);
        }

        [Trait("Categoria", "Entidade")]
        [Fact(DisplayName = "Não Deve retornar erro ao definir placar igual a 1000")]
        public void Nao_Deve_Retornar_Erro_Ao_Setar_Placar_Igual_A_Mil()
        {
            int esperado = 1000;

            JogoBE jogo = new JogoBE(esperado);

            Assert.Equal(esperado, jogo.Placar);
        }
    }
}
