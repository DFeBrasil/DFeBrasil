using DFeBrasil.Nfce.Danfe.UnitTests.Fixtures;
using DFeBrasil.XmlParser;
using Xunit;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public class XMLExtensionsTests
{
    [Fact]
    public void ConverteParaNfceDTO_ComXml_RetornaDto()
    {
        // Arrange
        var xmlString = ResourcesFixtures.ObterRsource("fake-nfce-cpf-dest.xml");
        var nfeProc = NFeParser.ParseText(xmlString);

        // Act
        var dto = nfeProc.ConverteParaNfceDTO();

        // Assert
        Assert.NotNull(dto);
    }

    [Fact]
    public void ConverteParaNfceDTO_ComXml_RetornaDataEmissao()
    {
        // Arrange
        var xmlString = ResourcesFixtures.ObterRsource("fake-nfce-cpf-dest.xml");
        var nfeProc = NFeParser.ParseText(xmlString);

        // Act
        var dto = nfeProc.ConverteParaNfceDTO();

        // Assert
        Assert.Equal("2022-04-14T17:06:53+00:00", dto.DataEmissao.ToString("yyyy-MM-ddTHH:mm:sszzz"));
    }

    [Fact]
    public void ConverteParaNfceDTO_ComXml_RetornaDataAutorizacao()
    {
        // Arrange
        var xmlString = ResourcesFixtures.ObterRsource("fake-nfce-cpf-dest.xml");
        var nfeProc = NFeParser.ParseText(xmlString);

        // Act
        var dto = nfeProc.ConverteParaNfceDTO();

        // Assert
        Assert.Equal("2022-04-14T14:06:54-03:00", dto.Autorizacao.DataAutorizacao.ToString("yyyy-MM-ddTHH:mm:sszzz"));
    }

}