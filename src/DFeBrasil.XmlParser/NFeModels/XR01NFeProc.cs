using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
public record XR01NFeProc
{
    [XmlAttribute("versao")]
    public string Versao { get; set; }

    [XmlElement("NFe")]
    public XR03NFe NFe { get; set; }

    [XmlElement("protNFe")]
    public XR05PRotNFe ProtNFe { get; set; }
}