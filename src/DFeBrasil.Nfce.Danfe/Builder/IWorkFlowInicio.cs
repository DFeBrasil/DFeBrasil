using DFeBrasil.AggregateNfce.DTO;

namespace DFeBrasil.Nfce.Danfe.Builder;

public interface IWorkFlowInicio
{
    public IBuild ComStringXML(string xmlString, bool cancelada = false);
    public IBuild ComNfce(DFeNfceDTO nfce);
}