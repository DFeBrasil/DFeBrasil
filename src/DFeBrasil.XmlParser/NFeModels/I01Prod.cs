using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("prod")]
public record I01Prod
{
    [XmlElement("cProd")]
    public string CodProd { get; set; }

    [XmlElement("cEAN")]
    public string CodEAN { get; set; }

    [XmlElement("xProd")]
    public string Prod { get; set; }

    [XmlElement("NCM")]
    public string NCM { get; set; }

    [XmlElement("CEST")]
    public string CEST { get; set; }

    [XmlElement("indEscala")]
    public string IndEscala { get; set; }

    [XmlElement("CNPJFab")]
    public string CNPJFab { get; set; }

    [XmlElement("cBenef")]
    public string CodBenef { get; set; }

    [XmlElement("CFOP")]
    public int CFOP { get; set; }

    [XmlElement("uCom")]
    public string UnCom { get; set; }

    [XmlElement("qCom")]
    public decimal QtdCom { get; set; }

    [XmlElement("vUnCom")]
    public decimal ValorUnCom { get; set; }

    [XmlElement("vProd")]
    public decimal ValorProd { get; set; }

    [XmlElement("cEANTrib")]
    public string CodEANTrib { get; set; }

    [XmlElement("uTrib")]
    public string UnTrib { get; set; }

    [XmlElement("qTrib")]
    public decimal QtdTrib { get; set; }

    [XmlElement("vUnTrib")]
    public decimal ValorUnTrib { get; set; }

    [XmlElement("vFrete", IsNullable = true)]
    public decimal? ValorFrete { get; set; }

    [XmlElement("vSeg", IsNullable = true)]
    public decimal? ValorSeg { get; set; }

    [XmlElement("vDesc", IsNullable = true)]
    public decimal? ValorDesc { get; set; }

    [XmlElement("vOutro", IsNullable = true)]
    public decimal? ValorOutro { get; set; }
}