namespace servicosadmfront.tests;

public class ParametrosBlitzInteligenteGerarClassCssCheckedParaStatus
{
    [Theory]
    [InlineData("abordado", "abordado", "checked")]
    [InlineData("naoabordado", "abordado", "")]
    [InlineData("valorInvalido", "", "")]
    public void RetornaClassCheckSeValorPassadoForValido(string valorNoObjeto, string valorComparacao, string classEsperada)
    {
        //arrange
        ParametrosBlitzInteligente parametros = new() { Status = valorNoObjeto };

        //act
        string classGerada = parametros.GeraClassCssCheckedParaStatus(valorComparacao);

        //assert
        Assert.Equal(classEsperada, classGerada);
    }
}
