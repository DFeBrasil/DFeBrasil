using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

public record W02ICMSTot
{
    [XmlElement("vBC")]
    public decimal ValorBC { get; set; }

    [XmlElement("vICMS")]
    public decimal ValorICMS { get; set; }

    [XmlElement("vICMSDeson")]
    public decimal ValoralorICMSDeson { get; set; }

    [XmlElement("vFCPUFDest")]
    public decimal ValorFCPUFDest { get; set; }

    [XmlElement("vICMSUFDest")]
    public decimal ValorICMSUFDest { get; set; }

    [XmlElement("VICMSUFRemt")]
    public decimal ValorICMSUFRemet { get; set; }

    [XmlElement("vFCP")]
    public decimal ValorFCP { get; set; }

    [XmlElement("vBCST")]
    public decimal ValorBCST { get; set; }

    [XmlElement("vST")]
    public decimal ValorST { get; set; }

    [XmlElement("vFCPST")]
    public decimal ValorFCPST { get; set; }

    [XmlElement("vFCPSTRet")]
    public decimal ValorFCPSTRet { get; set; }

    [XmlElement("vProd")]
    public decimal ValorProd { get; set; }

    [XmlElement("vFrete")]
    public decimal ValorFrete { get; set; }

    [XmlElement("vSeg")]
    public decimal ValorSeg { get; set; }

    [XmlElement("vDesc")]
    public decimal ValorDesc { get; set; }

    [XmlElement("vII")]
    public decimal ValorII { get; set; }

    [XmlElement("vIPI")]
    public decimal ValorIPI { get; set; }

    [XmlElement("vIPIDevol")]
    public decimal ValorIPIDevol { get; set; }

    [XmlElement("vPIS")]
    public decimal ValorPIS { get; set; }

    [XmlElement("vCOFINS")]
    public decimal ValorCOFINS { get; set; }

    [XmlElement("vOutro")]
    public decimal ValorOutro { get; set; }

    [XmlElement("vNF")]
    public decimal ValorNF { get; set; }

    [XmlElement("TotTrib")]
    public decimal ValorTotTrib { get; set; }
}