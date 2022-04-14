using FastReport.Data.JsonConnection;
using Xunit;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public class ReportFactoryTests
{
    [Fact]
    public void CriarDanfe80_ComModeloValido_UsaJsonDataSource()
    {
        // Arrange
        var nfce = DFeNfceFixture.ObterDTO();

        // Act
        using var report = ReportFactory.CriarDanfe80(nfce);

        //
        Assert.IsType<JsonDataSourceConnection>(report.Dictionary.Connections[0]);
        Assert.Equal("JsonConnection", report.Dictionary.Connections[0].Name);
    }

    [Fact]
    public void CriarDanfe80_ComModeloCompleto_UsaJsonDataSource()
    {
        // Arrange
        var nfce = DFeNfceFixture.ObterCompleto();

        // Act
        using var report = ReportFactory.CriarDanfe80(nfce);

        //
        Assert.IsType<JsonDataSourceConnection>(report.Dictionary.Connections[0]);
        Assert.Equal("JsonConnection", report.Dictionary.Connections[0].Name);
    }

    [Fact]
    public void CriarDanfe80_ComCancelamento_UsaJsonDataSource()
    {
        // Arrange
        var nfce = DFeNfceFixture.ObterCancelada();

        // Act
        using var report = ReportFactory.CriarDanfe80(nfce);

        //
        Assert.IsType<JsonDataSourceConnection>(report.Dictionary.Connections[0]);
        Assert.Equal("JsonConnection", report.Dictionary.Connections[0].Name);
    }
}