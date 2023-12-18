using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImplementacao _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImplementacao();
    }


    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange - Serve para podermos montar o cenário de teste. Iremos somar 5 com 10. Então, devemos disponibilizar esse números para ele e preparar todo o cenário.
        //Act - Já temos o cenário, agora falta agir! Vamos chamar ele para saber o que ele deve fazer. Se já preparamos o 5 e o 10, vamos executar a ação 'Somar'
        //Assert - Serve para validar tudo isso acima possui o resultado esperado, que nesse caso é 15.

        //Arrange
        int n1 = 5;
        int n2 = 10;

        //Act
        int resultado = _calc.Somar(n1, n2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange
        int n1 = 10;
        int n2 = 10;

        //Act
        int resultado = _calc.Somar(n1, n2);

        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void VerificaSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //Act
        bool resultado = _calc.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }
}