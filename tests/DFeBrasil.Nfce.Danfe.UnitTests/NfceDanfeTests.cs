using System.IO;
using Xunit;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public class NfceDanfeTests
{
    [Theory]
    [InlineData("Completa")]
    [InlineData("Canceleda")]
    [InlineData("Default")]
    public void CriarPDF_RetornaMemoryStream(string type)
    {
        // Arrange
        var nfce = DFeNfceFixture.GerarDTO(type);
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