using System.Globalization;
using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("infProt")]
public record PR03InfProt
{
    [XmlElement("tpAmb")]
    public string TpAmb { get; set; }

    [XmlElement("verAplic")]
    public string VerAplic { get; set; }

    [XmlElement("chNFe")]
    public string ChNFe { get; set; }

    [XmlIgnore]
    public DateTimeOffset DhRecbto =>
        DateTimeOffset.ParseExact(DhRecbtoString, "yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture);

    [XmlElement("dhRecbto")]
    public string DhRecbtoString { get; set; }

    [XmlElement("nProt")]
    public string Prot { get; set; }

    [XmlElement("digVal")]
    public string DigVal { get; set; }

    [XmlElement("cStat")]
    public string Stat { get; set; }

    [XmlElement("xMotivo")]
    public string Motivo { get; set; }
}