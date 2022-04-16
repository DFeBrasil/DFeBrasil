using System.IO;
using System.Text;
using DFeBrasil.XmlParser.NFeModels;
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
        var xmlString = ObterXmlFakeNfceNFeProc();
        var result = NFeParser.ParseText(xmlString);

        Assert.NotNull(result);
    }

    [Fact]
    public void ParseText_ComStringNFe_RetornaXNFeProc()
    {
        var xmlString = ObterXmlFakeNfceNFe();
        var result = NFeParser.ParseText(xmlString);

        Assert.NotNull(result);
    }

    [Fact]
    public void ParseText_ComStringXML_RetornaElementosFilhos()
    {
        var xmlString = ObterXmlFakeNfceNFeProc();
        var result = NFeParser.ParseText(xmlString);

        Assert.NotNull(result.NFe);
        Assert.NotNull(result.NFe.InfNFe.Emit);
        Assert.NotNull(result.NFe.InfNFe.Emit.EnderEmit);
        Assert.NotNull(result.NFe.InfNFe.Dest);
        Assert.NotNull(result.NFe.InfNFe.Dest.E05EnderDest);
        Assert.NotNull(result.NFe.InfNFe.Total);
        Assert.NotNull(result.NFe.InfNFe.Total.ICMSTotal);
        Assert.NotNull(result.ProtNFe.InfProt);
    }
}