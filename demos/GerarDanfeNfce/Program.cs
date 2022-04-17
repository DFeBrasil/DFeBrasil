using System.Text;
using System.Text.Json;
using DFeBrasil.Nfce.Danfe.Builder;
using GerarDanfeNfce;

var nfceExemplo = DadosExemplo.Gerar();
var jsonExmeplo = JsonSerializer.Serialize(nfceExemplo);

// Gera arquivo json no diretório de build do projeto para ser utilizado
// na edição do FRX; para isso só copiar o conteudo do arquivo e posteriormente
// na edição em modo DESIGN adicionar o json Paylod na connection
File.WriteAllText("./jsondummy.json", jsonExmeplo, Encoding.UTF8);

// Com o DTO da NFC-e Criado só solicitar a exportação do PDF para o Disco
// ou utiliza-lo em MemoryStream
var danfeDto = NfceDanfeBuilder.Configurar()
    .ComNfce(nfceExemplo)
    .Build();

danfeDto.ExportarPDF($"./nfce-dto-{DateTime.UtcNow:ddMMyyyyHHmmss}.pdf");

// Com o XML da NFC-e Criado só solicitar a exportação do PDF para o Disco
// ou utiliza-lo em MemoryStream
var danfeXml = NfceDanfeBuilder.Configurar()
    .ComStringXML(File.ReadAllText("./fake-nfce.xml"), cancelada: false)
    .Build();

danfeXml.ExportarPDF($"./nfce-xml-{DateTime.UtcNow:ddMMyyyyHHmmss}.pdf");