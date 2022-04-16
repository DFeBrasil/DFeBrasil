using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("emit")]
public record C01Emit
{
    [XmlElement("CNPJ")]
    public string CNPJ { get; set; }

    [XmlElement("CPF")]
    public string CPF { get; set; }

    [XmlElement("xNome")]
    public string Nome { get; set; }

    [XmlElement("xFant")]
    public string Fant { get; set; }

    [XmlElement("IE")]
    public string IE { get; set; }

    [XmlElement("IEST")]
    public string IEST { get; set; }

    [XmlElement("IM")]
    public string IM { get; set; }

    [XmlElement("CNAE")]
    public string CNAE { get; set; }

    [XmlElement("CRT")]
    public int CRT { get; set; }

    [XmlElement("enderEmit")]
    public C05EnderEmit EnderEmit { get; set; }
}