namespace servicosadmfront.tests;

public class BlitzInteligenteQueryStringBuilderTests
{
    [Theory]
    [InlineData("nomecamera=1133")]
    [InlineData("placa=abc1a34")]
    [InlineData("situacao=regular")]
    [InlineData("status=abordado")]
    [InlineData("codigofaixa=1133")]
    [InlineData("datainicio=2024-01-01T23%3A10%3A20")]
    [InlineData("datafim=2024-01-02T13%3A55%3A00")]
    [InlineData("tamanhopagina=10")]
    [InlineData("pagina=3")]
    public void Build_VerificaSeQueryContemValor(string queryStringEsperada)
    {
        //arrange
        DateTime DataInicio = new(2024, 01, 01, 23, 10, 20);
        DateTime DataFim = new(2024, 01, 02, 13, 55, 00);
        ParametrosBlitzInteligente parametros = new(1, "1133", "abc1a34", "regular", "abordado", 1133, DataInicio, DataFim, 10, 3);

        //act
        string queryStringGerada = parametros.GerarQueryString();
        string[] parametrosSeparados = queryStringGerada.Split("&");

        //assert
        Assert.Contains(queryStringEsperada, parametrosSeparados);
    }

    [Fact]
    public void Build_VerificaSeQueryNaoFoiGerada()
    {
        //arrange
        DateTime DataInicio = new(2024, 01, 01, 23, 10, 20);
        DateTime DataFim = new(2024, 01, 02, 13, 55, 00);
        ParametrosBlitzInteligente parametros = new(1, "1133", null!, "regular", "abordado", 1133, DataInicio, DataFim, 10, 3);
        const string queryStringQueNaoDeveAparecer = "placa=abc1a34";

        //act
        string queryStringGerada = parametros.GerarQueryString();
        string[] parametrosSeparados = queryStringGerada.Split("&");

        //assert
        Assert.DoesNotContain(queryStringQueNaoDeveAparecer, parametrosSeparados);
    }

}