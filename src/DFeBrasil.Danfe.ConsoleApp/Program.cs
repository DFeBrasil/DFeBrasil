using System.Text;
using System.Text.Json;
using DFeBrasil.Danfe.ConsoleApp;
using DFeBrasil.Nfce.Danfe;

var nfceDummy = NfceDummy.CriarViewModel();
var jsonDummy = JsonSerializer.Serialize(nfceDummy);
File.WriteAllText("./jsondummy.json", jsonDummy, Encoding.UTF8);

var danfe = new NfceDanfe(nfceDummy);
danfe.ExportarPDF($"./nfce-{DateTime.UtcNow:ddMMyyyyHHmmss}.pdf");