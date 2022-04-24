using System.Globalization;
using System.Xml.Serialization;

namespace DFeBrasil.XmlParser.NFeModels;

[XmlRoot("ide")]
public class B01Ide
{
    [XmlElement("cUF")]
    public int CodUF { get; set; }

    [XmlElement("cNF")]
    public string CodNF { get; set; }

    [XmlElement("natOp")]
    public string NatOp { get; set; }

    [XmlElement("indPag")]
    public int IndPag { get; set; }

    [XmlElement("mod")]
    public int Mod { get; set; }

    [XmlElement("serie")]
    public int Serie { get; set; }

    [XmlElement("nNF")]
    public long Numero { get; set; }

    [XmlIgnore]
    public DateTimeOffset DhEmi =>
        DateTimeOffset.ParseExact(DhEmiString, "yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture);

    [XmlElement("dhEmi")]
    public string DhEmiString { get; set; }

    [XmlIgnore]
    public DateTimeOffset? DhSaiEnt => DhSaiEntString is not null
        ? DateTimeOffset.ParseExact(DhSaiEntString, "yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture)
        : null;

    [XmlElement("dhSaiEnt", IsNullable = true)]
    public string DhSaiEntString { get; set; }

    [XmlElement("tpNF")]
    public int TipoNF { get; set; }

    [XmlElement("idDest")]
    public int IdDest { get; set; }

    [XmlElement("cMunFG")]
    public long CodMunFG { get; set; }

    [XmlElement("tpImp")]
    public int TpImp { get; set; }

    [XmlElement("tpEmis")]
    public int TpEmis { get; set; }

    [XmlElement("cDV")]
    public int DV { get; set; }

    [XmlElement("tpAmb")]
    public int TpAmb { get; set; }

    [XmlElement("finNFe")]
    public int FinNFe { get; set; }

    [XmlElement("indFinal")]
    public int IndFinal { get; set; }

    [XmlElement("indPres")]
    public int IndPres { get; set; }

    [XmlElement("indIntermed")]
    public int IndIntermed { get; set; }

    [XmlElement("procEmi")]
    public int ProcEmi { get; set; }

    [XmlElement("verProc")]
    public string VerProc { get; set; }

    [XmlIgnore]
    public DateTimeOffset? DhCont => DhContString is not null
        ? DateTimeOffset.ParseExact(DhContString, "yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture)
        : null;

    [XmlElement("dhCont", IsNullable = true)]
    public string DhContString { get; set; }

    [XmlElement("xJust", IsNullable = true)]
    public string JustCont { get; set; }
}