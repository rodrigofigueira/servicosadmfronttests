namespace servicosadmfront.tests;

public class ParametrosBlitzInteligenteGerarClassCssCheckedParaSituacao
{
    [Theory]
    [InlineData("Regular", "regular", "checked")]
    [InlineData("furtado", "furtado", "checked")]
    [InlineData("furtado", "regular", "")]
    [InlineData("inadimplente", "InaDimplente", "checked")]
    [InlineData("valorInvalido", "", "")]
    public void RetornaClassCheckSeValorPassadoForValido(string valorNoObjeto, string valorComparacao, string classEsperada)
    {
        //arrange
        ParametrosBlitzInteligente parametros = new() { Situacao = valorNoObjeto };

        //act
        string classGerada = parametros.GeraClassCssCheckedParaSituacao(valorComparacao);

        //assert
        Assert.Equal(classEsperada, classGerada);
    }
}
