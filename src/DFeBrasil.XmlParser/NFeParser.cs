using System.Xml.Serialization;
using DFeBrasil.XmlParser.NFeModels;

namespace DFeBrasil.XmlParser;

public static class NFeParser
{
    private static XmlSerializer _nfeProcSerializer;
    private static XmlSerializer _nfeSerializer;

    public static XR01NFeProc ParseText(string xmlString)
    {
        using var stream = new MemoryStream();
        using var sw = new StreamWriter(stream);
        sw.Write(xmlString);
        sw.Flush();

        return ParseStream(stream);
    }

    private static XR01NFeProc ParseStream(Stream stream)
    {
        try
        {
            stream.Position = 0;
            _nfeProcSerializer ??= new(typeof(XR01NFeProc));
            return (XR01NFeProc)_nfeProcSerializer.Deserialize(stream);
        }
        catch (Exception)
        {
            stream.Position = 0;
            _nfeSerializer ??= new(typeof(XR03NFe));
            var nfe = (XR03NFe)_nfeSerializer.Deserialize(stream);

            return new()
            {
                Versao = nfe.InfNFe.Versao,
                NFe = nfe
            };
        }
    }
}