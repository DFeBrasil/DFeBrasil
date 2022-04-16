using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("enderEmit", IsNullable = true)]
public record C05EnderEmit
{
    [XmlElement("xLgr")]
    public string Lgr { get; set; }

    [XmlElement("nro")]
    public string Nro { get; set; }

    [XmlElement("xCpl", IsNullable = true)]
    public string Cpl { get; set; }

    [XmlElement("xBairro")]
    public string Bairro { get; set; }

    [XmlElement("cMun")]
    public long CodMun { get; set; }

    [XmlElement("xMun")]
    public string Mun { get; set; }

    [XmlElement("UF")]
    public string UF { get; set; }

    [XmlElement("CEP")]
    public string CEP { get; set; }

    [XmlElement("cPais", IsNullable = true)]
    public int? CodPais { get; set; }

    [XmlElement("xPais", IsNullable = true)]
    public string Pais { get; set; }

    [XmlElement("fone", IsNullable = true)]
    public long? Fone { get; set; }
}