using System.Reflection;
using DFeBrasil.AggregateNfce.DTO;
using FastReport;
using FastReport.Data.JsonConnection;
using Newtonsoft.Json;

namespace DFeBrasil.Nfce.Danfe;

public static class ReportFactory
{
    public static Report CriarDanfe80(DFeNfceDTO nfce)
    {
        var builder = new JsonDataSourceConnectionStringBuilder
        {
            Json = JsonConvert.SerializeObject(nfce)
        };

        var report = new Report();
        report.Load(GetDanfeResourse());
        report.Dictionary.Connections[0].ConnectionString = builder.ToString();
        report.Prepare();

        return report;
    }

    private static Stream GetDanfeResourse()
    {
        return Assembly
            .GetCallingAssembly()
            .GetManifestResourceStream("DFeBrasil.Nfce.Danfe.Resources.Danfe80.frx");
    }
}