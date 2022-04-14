using System.Text;
using System.Text.Json;
using DFeBrasil.Nfce.Danfe;
using GerarDanfeNfce;

var nfceDummy = NfceDummy.Gerar();
var jsonDummy = JsonSerializer.Serialize(nfceDummy);

// Gera arquivo dummy json no diretório de build do projeto para ser utilizado
// na edição do FRX; para isso só copiar o conteudo do arquivo e posteriormente
// na edição em modo DESIGN adicionar o json Paylod na connection
File.WriteAllText("./jsondummy.json", jsonDummy, Encoding.UTF8);

// Com o DTO da NFC-e Criado só solicitar a exportação do PDF para o Disco
// ou utiliza-lo em MemoryStream
var danfe = new NfceDanfe(nfceDummy);
danfe.ExportarPDF($"./nfce-{DateTime.UtcNow:ddMMyyyyHHmmss}.pdf");