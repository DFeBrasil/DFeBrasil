using DFeBrasil.Nfce.Danfe.UnitTests.Fixtures;
using FastReport.Data.JsonConnection;
using Xunit;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public class ReportFactoryTests
{
    [Fact]
    public void CriarDanfe80_ComNfce_ConfiguraJsonDataSource()
    {
        // Arrange
        var nfce = DanfeFixtures.ObterNfce();

        // Act
        using var report = ReportFactory.CriarDanfe80(nfce);

        // Assert
        Assert.IsType<JsonDataSourceConnection>(report.Dictionary.Connections[0]);
        Assert.Equal("JsonConnection", report.Dictionary.Connections[0].Name);
    }
}