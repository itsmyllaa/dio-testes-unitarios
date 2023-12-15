using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private Validacoesstring _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new Validacoesstring();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string texto = "Olá";
            //Act
            int resultado = _validacoes.ContaCaracteres(texto);
            //Assert
            Assert.Equal(3, resultado);
        }
    }
}