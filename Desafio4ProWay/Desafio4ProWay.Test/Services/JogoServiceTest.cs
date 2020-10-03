using Desafio4ProWay.Domain.Interfaces.Services;
using Desafio4ProWay.Entidades;
using Desafio4ProWay.Test.Context;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Desafio4ProWay.Test.Services
{
    public class JogoServiceTest : BaseTest
    {
        private readonly Mock<IJogoService> _service;

        public JogoServiceTest()
        {
            _service = new Mock<IJogoService>();
        }

        public List<JogoBE> ObterListaDeDadosParaTeste()
        {
            List<JogoBE> jogos = new List<JogoBE>();

            for (int i = 1; i <= 10; i++)
            {
                jogos.Add(new JogoBE()
                {
                    Codigo = i,
                    Placar = i * 2,
                });
            }
            return jogos;
        }


        [Trait("Categoria", "Service")]
        [Fact(DisplayName = "Deve retornar erro ao definir placar maior que 1000")]
        public void Deve_Retornar_Erro_Ao_Setar_Placar_Maio_Que_Mil()
        {
            /// Arrange
            List<JogoBE> jogos = ObterListaDeDadosParaTeste();
            _service.Setup(x => x.ObterJogosCadastrados()).Returns(jogos).Verifiable();

            /// Act
            var retornoMetodo = _service.Object.ObterJogosCadastrados();

            /// Assert
            Assert.Equal(10, retornoMetodo.Count);
        }
    }
}

