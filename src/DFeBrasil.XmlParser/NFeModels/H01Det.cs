using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("det")]
public record H01Det
{
    [XmlAttribute("nItem")]
    public int NumItem { get; set; }

    [XmlElement("prod")]
    public I01Prod Prod { get; set; }

    [XmlElement("imposto")]
    public dynamic Imposto { get; set; }

    [XmlElement("infAdProd")]
    public string InfAdProd { get; set; }
}