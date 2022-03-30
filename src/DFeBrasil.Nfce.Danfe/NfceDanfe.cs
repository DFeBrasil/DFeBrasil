using DFeBrasil.Nfce.Danfe.ViewModel;
using FastReport.Export.PdfSimple;

namespace DFeBrasil.Nfce.Danfe;

public class NfceDanfe
{
    private readonly NfceViewModel _viewModel;

    public NfceDanfe(NfceViewModel viewModel)
    {
        _viewModel = viewModel;
    }

    public Stream CriarPDF()
    {
        using var fr = ReportFactory.CriarDanfe80(_viewModel);

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