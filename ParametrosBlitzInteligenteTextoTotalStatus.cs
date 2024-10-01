namespace servicosadmfront.tests;

public class ParametrosBlitzInteligenteTextoTotalStatus
{
    [Fact]
    public void RetornaTextoSelecioneoStatusQuandoCampoStatusVazio()
    {
        //arrange
        const string textoEsperado = "Selecione o Status";
        ParametrosBlitzInteligente parametros = new() { Status = null };

        //act
        string textoGerado = parametros.TextoTotalStatus();

        //assert
        Assert.Equal(textoEsperado, textoGerado);
    }

    [Theory]
    [InlineData("1 Selecionados", "abordado")]
    [InlineData("2 Selecionados", "abordado,naoabordado")]
    public void RetornaTextoXSelecionadosQuandoCampoStatusComTexto(string textoEsperado, string status)
    {
        //arrange
        ParametrosBlitzInteligente parametros = new() { Status = status };

        //act
        string textoGerado = parametros.TextoTotalStatus();

        //assert
        Assert.Equal(textoEsperado, textoGerado);
    }
}
