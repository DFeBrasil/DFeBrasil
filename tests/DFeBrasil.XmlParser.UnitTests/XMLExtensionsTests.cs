using System.IO;
using System.Text;
using Xunit;

namespace DFeBrasil.XmlParser.UnitTests;

public class XMLExtensionsTests
{
    private static string ObterXmlFakeNfceNFeProc()
        => File.ReadAllText("./Resources/fake-nfce-nfeproc.xml", Encoding.UTF8);


    [Fact]
    public void ConverteParaNfceDTO_ComXml_RetornaDto()
    {
        // Arrange
        var xmlString = ObterXmlFakeNfceNFeProc();
        var nfeProc = NFeParser.ParseText(xmlString);

        // Act
        var dto = nfeProc.ConverteParaNfceDTO();

        // Assert
        Assert.NotNull(dto);
    }

    [Fact]
    public void ConverteParaNfceDTO_ComXml_RetornaDadosXml()
    {
        // Arrange
        var xmlString = ObterXmlFakeNfceNFeProc();
        var nfeProc = NFeParser.ParseText(xmlString);

        // Act
        var dto = nfeProc.ConverteParaNfceDTO();

        // Assert
        var expedQrCode =
            "http://homolog.sefaz.go.gov.br/nfeweb/sites/nfce/danfeNFCe?p=12345678901234567890123456789012345678901234|2|2|1|2e2ebbb42c03ccb75ab6fe9c6a07058e8a7c13e9";

        Assert.Equal(44, dto.Serie);
        Assert.Equal(4444, dto.Numero);
        Assert.Equal("12345678901234567890123456789012345678901234", dto.Chave);
        Assert.Equal(50M, dto.TotalDesconto);
        Assert.Equal(15M, dto.TotalOutros);
        Assert.Equal(1404.98M, dto.TotalCupom);
        Assert.Equal(expedQrCode, dto.QrCode);
    }

    [Fact]
    public void ConverteParaNfceDTO_ComXml_RetornaDataEmissao()
    {
        // Arrange
        var xmlString = ObterXmlFakeNfceNFeProc();
        var nfeProc = NFeParser.ParseText(xmlString);

        // Act
        var dto = nfeProc.ConverteParaNfceDTO();

        // Assert
        Assert.Equal("2022-04-17T17:31:26-03:00", dto.DataEmissao.ToString("yyyy-MM-ddTHH:mm:sszzz"));
    }

    [Fact]
    public void ConverteParaNfceDTO_ComXml_RetornaDataAutorizacao()
    {
        // Arrange
        var xmlString = ObterXmlFakeNfceNFeProc();
        var nfeProc = NFeParser.ParseText(xmlString);

        // Act
        var dto = nfeProc.ConverteParaNfceDTO();

        // Assert
        Assert.Equal("2022-04-14T14:06:54-03:00", dto.Autorizacao.DataAutorizacao.ToString("yyyy-MM-ddTHH:mm:sszzz"));
    }

}