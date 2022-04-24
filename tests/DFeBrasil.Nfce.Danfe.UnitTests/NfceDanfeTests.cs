using System.IO;
using DFeBrasil.Nfce.Danfe.UnitTests.Fixtures;
using Xunit;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public class NfceDanfeTests
{
    [Fact]
    public void Exportar_ComConsumidor_RetornaStream()
    {
        // Arrange
        var nfce = DanfeFixtures.ObterComConsumidor();
        var danfe = new NfceDanfe(nfce);
        using var memoryStream = new MemoryStream();

        // Act
        danfe.Exportar(memoryStream);

        // Assert
        Assert.NotEqual(0, memoryStream.Length);
    }

    [Fact]
    public void Exportar_ComCancelamento_RetornaStream()
    {
        // Arrange
        var nfce = DanfeFixtures.ObterNfce(cancealda: true);
        var danfe = new NfceDanfe(nfce);
        using var memoryStream = new MemoryStream();

        // Act
        danfe.Exportar(memoryStream);

        // Assert
        Assert.NotEqual(0, memoryStream.Length);
    }

    [Fact]
    public void Exportar_ComContingencia_RetornaStream()
    {
        // Arrange
        var nfce = DanfeFixtures.ObterEmContingencia();
        var danfe = new NfceDanfe(nfce);
        using var memoryStream = new MemoryStream();

        // Act
        danfe.Exportar(memoryStream);

        // Assert
        Assert.NotEqual(0, memoryStream.Length);
    }

    [Fact]
    public void Exportar_ComModeloBasico_RetornaStream()
    {
        // Arrange
        var nfce = DanfeFixtures.ObterNfce();
        var danfe = new NfceDanfe(nfce);
        using var memoryStream = new MemoryStream();

        // Act
        danfe.Exportar(memoryStream);

        // Assert
        Assert.NotEqual(0, memoryStream.Length);
    }

    [Fact]
    public void Exportar_ComFileName_CriaArquivoNoDisco()
    {
        // Arrange
        var nfce = DanfeFixtures.ObterComConsumidor();
        var danfe = new NfceDanfe(nfce);
        var arquivoEsperado = Path.GetTempFileName();

        // Act
        danfe.Exportar(arquivoEsperado);

        // Aarrange
        Assert.True(File.Exists(arquivoEsperado));
    }
}