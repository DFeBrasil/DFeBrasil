using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("total")]
public record W01Total
{
    [XmlElement("ICMSTot")]
    public W02ICMSTot ICMSTotal { get; set; }
}