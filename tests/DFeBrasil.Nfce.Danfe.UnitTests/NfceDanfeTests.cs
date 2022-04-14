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
        var viewModel = DFeNfceFixture.CriarViewModel(type);
        var danfe = new NfceDanfe(viewModel);

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
        var viewModel = DFeNfceFixture.ObterViewModelCompleta();
        var danfe = new NfceDanfe(viewModel);
        var expectedFileName = Path.GetTempFileName();

        // Act
        danfe.ExportarPDF(expectedFileName);

        // Aarrange
        Assert.True(File.Exists(expectedFileName));
    }
}