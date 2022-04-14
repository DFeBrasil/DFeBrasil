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

    public Stream CriarPDF()
    {
        using var fr = ReportFactory.CriarDanfe80(_nfce);

        var export = new PDFSimpleExport();
        var memoryStream = new MemoryStream();

        export.Export(fr, memoryStream);
        memoryStream.Position = 0;

        return memoryStream;
    }

    public void ExportarPDF(string fileName)
    {
        using var pdf = CriarPDF();
        using var fs = new FileStream(fileName, FileMode.OpenOrCreate);
        pdf.CopyTo(fs);
    }
}