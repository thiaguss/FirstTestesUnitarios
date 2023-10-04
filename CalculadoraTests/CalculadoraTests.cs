using Calculadora.Services;

namespace Calculadoratests;

public class Calculadoratests
{
    private CalculadoraImp _calc;

    public Calculadoratests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void SomarDoisValoresERetornarResultado()
    {
        //Arrange - serve para montar o cenario
        int num1 = 5;
        int num2 = 10;

        //Act - executa a ação
        int resultado = _calc.Somar(num1 , num2);

        //Assert - valida se está com o resultado esperado
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void SubtrairDoisValoresERetornarResultado()
    {
        //Arrange - serve para montar o cenario
        int num1 = 8;
        int num2 = 4;
        //Act - executa a ação
        int resultado = _calc.Subtrair(num1, num2);
        //Assert - valida se está com o resultado esperado
        Assert.Equal(4, resultado);
    }
}