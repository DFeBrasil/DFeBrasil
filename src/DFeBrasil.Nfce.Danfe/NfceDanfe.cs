using DFeBrasil.AggregateNfce.DTO;
using FastReport.Export.PdfSimple;

namespace DFeBrasil.Nfce.Danfe;

public class NfceDanfe
{
    private readonly DFeNfceDTO _nfce;

    public NfceDanfe(DFeNfceDTO nfce)
    {
        _nfce = nfce;
    }

    public void Exportar(Stream stream)
    {
        using var fr = ReportFactory.CriarDanfe80(_nfce);
        var export = new PDFSimpleExport();

        export.Export(fr, stream);
    }

    public void Exportar(string file)
    {
        using var fr = ReportFactory.CriarDanfe80(_nfce);
        var export = new PDFSimpleExport();
        export.Export(fr, file);
    }
}