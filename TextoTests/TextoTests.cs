using Calculadora.Services;

namespace TextoTests;

public class TextoTests
{
    private ValidarString _validar;

    public TextoTests()
    {
        _validar = new ValidarString();
    }

    public void Contar3CaracteresEmOla ()
    {
        // Arrange
        string texto = "Ola";

        //Act   
        var resultado = _validar.ContarCaracteres(texto);

        //Assert
        Assert.Equal(3, resultado);
    }
}