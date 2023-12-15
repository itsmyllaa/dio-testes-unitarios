using Calculadora.Services;
using Xunit.Sdk;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange serve para montar o cenário
        int num1 = 5;
        int num2 = 10;

        //Act serve para executar a ação que nesse caso é a Somar
        int resultado = _calc.Somar(num1, num2);

        //Assert serve para validar se o código retorna o resultado esperado
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange serve para montar o cenário
        int num1 = 10;
        int num2 = 10;

        //Act serve para executar a ação que nesse caso é a Somar
        int resultado = _calc.Somar(num1, num2);

        //Assert serve para validar se o código retorna o resultado esperado
        Assert.Equal(20, resultado);
    }
    [Fact]
    public void DeveVerificarSeEhPareRetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }
    [Theory]
    [InlineData(new int [] { 2, 4 })]
    [InlineData(new int [] { 6, 8, 10 })]

    public void DeveVerificarSeosNumerosSaoParesEhRetornarVerdadeiro(int[] numeros)
    {
        //Act/Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
    }

}