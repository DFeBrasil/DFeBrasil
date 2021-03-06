using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("dest", IsNullable = true)]
public record E01Dest
{
    [XmlElement("CNPJ", IsNullable = true)]
    public string CNPJ { get; set; }

    [XmlElement("CPF", IsNullable = true)]
    public string CPF { get; set; }

    [XmlElement("idEstrangeiro", IsNullable = true)]
    public string IdEstrangeiro { get; set; }

    [XmlElement("xNome", IsNullable = true)]
    public string Nome { get; set; }

    [XmlElement("IE", IsNullable = true)]
    public string IE { get; set; }

    [XmlElement("ISUF", IsNullable = true)]
    public string ISUF { get; set; }

    [XmlElement("IM", IsNullable = true)]
    public string IM { get; set; }

    [XmlElement("email", IsNullable = true)]
    public string Email { get; set; }

    [XmlElement("enderDest", IsNullable = true)]
    public E05EnderDest E05EnderDest { get; set; }
}