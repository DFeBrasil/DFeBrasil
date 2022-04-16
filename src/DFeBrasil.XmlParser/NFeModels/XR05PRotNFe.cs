using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("protNFe")]
public record XR05PRotNFe
{
    [XmlAttribute("versao")]
    public string Versao { get; set; }

    [XmlElement("infProt")]
    public PR03InfProt InfProt { get; set; }
}