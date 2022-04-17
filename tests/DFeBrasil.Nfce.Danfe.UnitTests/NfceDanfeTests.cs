using System.IO;
using DFeBrasil.Nfce.Danfe.UnitTests.Fixtures;
using Xunit;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public class NfceDanfeTests
{
    [Fact]
    public void CriarPDF_ComConsumidor_RetornaMemoryStream()
    {
        // Arrange
        var nfce = NfceFixtures.ObterComConsumidor();
        var danfe = new NfceDanfe(nfce);

        // Act
        using var pdf = danfe.CriarPDF();

        // Aarrange
        Assert.IsType<MemoryStream>(pdf);
        Assert.Equal(0, pdf.Position);
    }

    [Fact]
    public void CriarPDF_ComCancelamento_RetornaMemoryStream()
    {
        // Arrange
        var nfce = NfceFixtures.ObterNfce(cancealda: true);
        var danfe = new NfceDanfe(nfce);

        // Act
        using var pdf = danfe.CriarPDF();

        // Aarrange
        Assert.IsType<MemoryStream>(pdf);
        Assert.Equal(0, pdf.Position);
    }

    [Fact]
    public void CriarPDF_ComContingencia_RetornaMemoryStream()
    {
        // Arrange
        var nfce = NfceFixtures.ObterEmContingencia();
        var danfe = new NfceDanfe(nfce);

        // Act
        using var pdf = danfe.CriarPDF();

        // Aarrange
        Assert.IsType<MemoryStream>(pdf);
        Assert.Equal(0, pdf.Position);
    }

    [Fact]
    public void CriarPDF_ComModeloBasico_RetornaMemoryStream()
    {
        // Arrange
        var nfce = NfceFixtures.ObterNfce();
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
        var nfce = NfceFixtures.ObterComConsumidor();
        var danfe = new NfceDanfe(nfce);
        var arquivoEsperado = Path.GetTempFileName();

        // Act
        danfe.ExportarPDF(arquivoEsperado);

        // Aarrange
        Assert.True(File.Exists(arquivoEsperado));
    }
}