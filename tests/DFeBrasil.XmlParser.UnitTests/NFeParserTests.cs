using System.IO;
using System.Text;
using Xunit;

namespace DFeBrasil.XmlParser.UnitTests;

public class NFeParserTests
{
    private static string ObterXmlFakeNfceNFeProc()
        => File.ReadAllText("./Resources/fake-nfce-nfeproc.xml", Encoding.UTF8);

    private static string ObterXmlFakeNfceNFe()
        => File.ReadAllText("./Resources/fake-nfce-nfe.xml", Encoding.UTF8);

    [Fact]
    public void ParseText_ComStringNFeProc_RetornaXNFeProc()
    {
        // Arrange
        var xmlString = ObterXmlFakeNfceNFeProc();

        // Act
        var result = NFeParser.ParseText(xmlString);

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void ParseText_ComStringNFe_RetornaXNFeProc()
    {
        // Arrange
        var xmlString = ObterXmlFakeNfceNFe();

        // Act
        var result = NFeParser.ParseText(xmlString);

        // Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void ParseText_ComStringXML_RetornaElementosFilhos()
    {
        // Assert
        var xmlString = ObterXmlFakeNfceNFeProc();

        // Act
        var result = NFeParser.ParseText(xmlString);

        // Assert
        Assert.NotNull(result.NFe);
        Assert.NotNull(result.NFe.InfNFe.Emit);
        Assert.NotNull(result.NFe.InfNFe.Emit.EnderEmit);
        Assert.NotNull(result.NFe.InfNFe.Dest);
        Assert.NotNull(result.NFe.InfNFe.Dest.E05EnderDest);
        Assert.NotNull(result.NFe.InfNFe.Total);
        Assert.NotNull(result.NFe.InfNFe.Total.ICMSTotal);
        Assert.NotNull(result.ProtNFe.InfProt);
    }

    [Fact]
    public void ParseText_ComStringXML_RetornaDatasCorretas()
    {
        // Arrange
        var xmlString = ObterXmlFakeNfceNFeProc();

        // Act
        var result = NFeParser.ParseText(xmlString);

        // Assert
        Assert.Equal("2022-04-17T17:31:26-03:00", result.NFe.InfNFe.Ide.DhEmi.ToString("yyyy-MM-ddTHH:mm:sszzz"));
        Assert.Equal("2022-04-14T14:06:54-03:00", result.ProtNFe.InfProt.DhRecbto.ToString("yyyy-MM-ddTHH:mm:sszzz"));
    }
}