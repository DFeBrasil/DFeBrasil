using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("NFe")]
public record XR03NFe
{
    [XmlElement("infNFe")]
    public A01InfNFe InfNFe { get; set; }

    [XmlElement("infNFeSupl", IsNullable = true)]
    public ZX01InfNFeSupl InfNFeSupl { get; set; }

    [XmlElement("Signature")]
    public dynamic Singature { get; set; }
}