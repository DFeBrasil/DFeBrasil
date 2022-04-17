using DFeBrasil.Nfce.Danfe.Builder;
using DFeBrasil.Nfce.Danfe.UnitTests.Fixtures;
using Xunit;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public class NfceDanfeBuilderTests
{
    [Fact]
    public void Build_ComXMLString_RetornaNfceDanfe()
    {
        // Arrange
        var xmlString = ResourcesFixtures.ObterFakeNfce();

        // Act
        var nfceDanfe = NfceDanfeBuilder.Configurar()
            .ComStringXML(xmlString, cancelada: false)
            .Build();

        // Assert
        Assert.NotNull(nfceDanfe);
    }

    [Fact]
    public void Build_ComModeloDados_RetornaNfceDanfe()
    {
        // Arrange
        var nfce = NfceFixtures.ObterNfce();

        // Act
        var nfceDanfe = NfceDanfeBuilder.Configurar()
            .ComNfce(nfce)
            .Build();

        // Assert
        Assert.NotNull(nfceDanfe);
    }
}