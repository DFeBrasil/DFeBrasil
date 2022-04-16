using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("detPag")]
public record YA01DetPag
{
    [XmlElement("indPag")]
    public int IndPag { get; set; }

    [XmlElement("tPag")]
    public int TipoPag { get; set; }

    [XmlElement("vPag")]
    public decimal ValorPag { get; set; }

    [XmlElement("card", IsNullable = true)]
    public dynamic Card { get; set; }
}