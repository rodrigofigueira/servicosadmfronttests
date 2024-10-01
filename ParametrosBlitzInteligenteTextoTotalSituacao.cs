namespace servicosadmfront.tests;

public class ParametrosBlitzInteligenteTextoTotalSituacao
{
    [Fact]
    public void RetornaTextoSelecioneSituacaoQuandoCampoSituacaoVazio()
    {
        //arrange
        const string textoEsperado = "Selecione a Situação";
        ParametrosBlitzInteligente parametros = new() { Situacao = null };

        //act
        string textoGerado = parametros.TextoTotalSituacao();

        //assert
        Assert.Equal(textoEsperado, textoGerado);
    }

    [Theory]
    [InlineData("1 Selecionados", "inadimplente")]
    [InlineData("2 Selecionados", "inadimplente,furtado")]
    [InlineData("3 Selecionados", "inadimplente,furtado,regular")]
    public void RetornaTextoXSelecionadosQuandoCampoSituacaoComTexto(string textoEsperado, string situacao)
    {
        //arrange
        ParametrosBlitzInteligente parametros = new() { Situacao = situacao };

        //act
        string textoGerado = parametros.TextoTotalSituacao();

        //assert
        Assert.Equal(textoEsperado, textoGerado);
    }

}
