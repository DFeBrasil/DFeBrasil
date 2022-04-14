using System.IO;
using Xunit;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public class NfceDanfeTests
{
    [Fact]
    public void CriarPDF_ModeloCompleto_RetornaMemoryStream()
    {
        // Arrange
        var nfce = DFeNfceFixture.GerarDTO("Completa");
        var danfe = new NfceDanfe(nfce);

        // Act
        using var pdf = danfe.CriarPDF();

        // Aarrange
        Assert.IsType<MemoryStream>(pdf);
        Assert.Equal(0, pdf.Position);
    }
    
    [Fact]
    public void CriarPDF_ModeloCancelado_RetornaMemoryStream()
    {
        // Arrange
        var nfce = DFeNfceFixture.GerarDTO("Canceleda");
        var danfe = new NfceDanfe(nfce);

        // Act
        using var pdf = danfe.CriarPDF();

        // Aarrange
        Assert.IsType<MemoryStream>(pdf);
        Assert.Equal(0, pdf.Position);
    }

    [Fact]
    public void CriarPDF_ModeloDefault_RetornaMemoryStream()
    {
        // Arrange
        var nfce = DFeNfceFixture.GerarDTO("Default");
        var danfe = new NfceDanfe(nfce);

        // Act
        using var pdf = danfe.CriarPDF();

        // Aarrange
        Assert.IsType<MemoryStream>(pdf);
        Assert.Equal(0, pdf.Position);
    }

    [Fact]
    public void ExportarPDF_ComFileName_CriaArquivoNoDisco()
    {
        // Arrange
        var nfce = DFeNfceFixture.ObterCompleto();
        var danfe = new NfceDanfe(nfce);
        var arquivoEsperado = Path.GetTempFileName();

        // Act
        danfe.ExportarPDF(arquivoEsperado);

        // Aarrange
        Assert.True(File.Exists(arquivoEsperado));
    }
}