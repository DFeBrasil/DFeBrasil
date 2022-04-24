using DFeBrasil.AggregateNfce.DTO;
using DFeBrasil.XmlParser;

namespace DFeBrasil.Nfce.Danfe.Builder;

public class NfceDanfeBuilder :
    IWorkFlowInicio,
    IBuild
{
    private DFeNfceDTO _dto;

    private NfceDanfeBuilder()
    {
        _dto = new();
    }

    public static IWorkFlowInicio Configurar()
    {
        return new NfceDanfeBuilder();
    }

    public IBuild ComNfce(DFeNfceDTO nfce)
    {
        _dto = nfce;

        return this;
    }

    public IBuild ComStringXML(string xmlString, bool cancelada = false)
    {
        var xNFe = NFeParser.ParseText(xmlString);
        _dto = xNFe.ConverteParaNfceDTO();
        _dto.Cancelada = cancelada;

        return this;
    }

    public NfceDanfe Build()
    {
        return new(_dto);
    }
}