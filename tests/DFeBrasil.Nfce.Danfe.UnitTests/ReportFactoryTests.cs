using FastReport.Data.JsonConnection;
using Xunit;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public class ReportFactoryTests
{
    [Fact]
    public void CriarDanfe80_ComViewModel_UsaJsonDataSource()
    {
        // Arrange
        var viewModel = DFeNfceFixture.ObterViewModel();

        // Act
        using var report = ReportFactory.CriarDanfe80(viewModel);

        //
        Assert.IsType<JsonDataSourceConnection>(report.Dictionary.Connections[0]);
        Assert.Equal("JsonConnection", report.Dictionary.Connections[0].Name);
    }

    [Fact]
    public void CriarDanfe80_ComViewModelCompleta_UsaJsonDataSource()
    {
        // Arrange
        var viewModel = DFeNfceFixture.ObterViewModelCompleta();

        // Act
        using var report = ReportFactory.CriarDanfe80(viewModel);

        //
        Assert.IsType<JsonDataSourceConnection>(report.Dictionary.Connections[0]);
        Assert.Equal("JsonConnection", report.Dictionary.Connections[0].Name);
    }
    
    [Fact]
    public void CriarDanfe80_ComViewModelCancelada_UsaJsonDataSource()
    {
        // Arrange
        var viewModel = DFeNfceFixture.ObterViewModelCancelada();

        // Act
        using var report = ReportFactory.CriarDanfe80(viewModel);

        //
        Assert.IsType<JsonDataSourceConnection>(report.Dictionary.Connections[0]);
        Assert.Equal("JsonConnection", report.Dictionary.Connections[0].Name);
    }
}