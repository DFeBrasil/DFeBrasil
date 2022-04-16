using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("infAdic")]
public record Z01InfAdic
{
    [XmlElement("infAdFisco")]
    public string InfAdFisco { get; set; }

    [XmlElement("infCpl")]
    public string InfCpl { get; set; }
}