using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("infNFeSupl")]
public record ZX01InfNFeSupl
{
    [XmlElement("qrCode")]
    public string QrCode { get; set; }

    [XmlElement("urlChave")]
    public string UrlChave { get; set; }
}