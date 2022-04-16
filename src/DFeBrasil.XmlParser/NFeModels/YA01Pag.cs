using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("pag")]
public record YA01Pag
{
    [XmlElement("detPag")]
    public List<YA01DetPag> DetPag { get; set; }

    [XmlElement("vTroco")]
    public decimal ValorTroco { get; set; }
}