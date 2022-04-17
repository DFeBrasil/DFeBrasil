using DFeBrasil.AggregateNfce.DTO;

namespace DFeBrasil.Nfce.Danfe.Builder;

public interface IWorkFlowData
{
    public IBuild ComStringXML(string xmlString, bool cancelada = false);
    public IBuild ComNfce(DFeNfceDTO nfce);
}