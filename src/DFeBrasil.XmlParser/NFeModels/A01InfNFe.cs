using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("infNFe")]
public record A01InfNFe
{
    [XmlAttribute("versao")]
    public string Versao { get; set; }

    [XmlElement("Id")]
    public string Id { get; set; }

    [XmlElement("ide")]
    public B01Ide Ide { get; set; }

    [XmlElement("emit")]
    public C01Emit Emit { get; set; }

    [XmlElement("dest", IsNullable = true)]
    public E01Dest Dest { get; set; }

    [XmlElement("det")]
    public List<H01Det> Det { get; set; }

    [XmlElement("total")]
    public W01Total Total { get; set; }

    [XmlElement("pag")]
    public YA01Pag Pag { get; set; }

    [XmlElement("infAdic")]
    public Z01InfAdic InfAdic { get; set; }
}