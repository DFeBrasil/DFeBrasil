using DFeBrasil.Nfce.Danfe.ViewModel;

namespace DFeBrasil.Danfe.ConsoleApp;

public static class NfceDummy
{
    public static NfceViewModel CriarViewModel()
    {
        var viewModel = new NfceViewModel
        {
            Chave = "12345678901234567890123456789012345678901234",
            QrCode = "![CDATA[http://homolog.sefaz.go.gov.br/nfeweb/sites/nfce/danfeNFCe" +
                     "?p=12345678901234567890123456789012345678901234|2|2|1|a64adcd1eee2a5a8e3f31feb9d4095a9d4d78b72]]",
            UrlChave = "http://homolog.sefaz.go.gov.br/nfeweb/sites/nfce/danfeNFCe",
            DataEmissao = DateTime.UtcNow,
            QuantidadeItens = 5,
            TotalDesconto = 30.00M,
            TotalOutros = 150.00M,
            TotalCupom = 200.25M,
            TotalTributosAproximado = 15M,
            ProtocoloAutorizacao = "12394219031231",
            DataAutorizacao = DateTime.UtcNow,
            EstaEmHomologacao = true,
            EstaEmContingencia = true,
            Consumidor = new("21025760000123", "AGIL4 TECNOLOGIA"),
            Cancelamento = new("123456789012345"),
            Empresa = new(
                "AGIL4 TECNOLOGIA LTDA ME",
                "AGIL4",
                "21025760000123",
                "5462697",
                "AV. GALDINO A DE MOURA, NOVA VILA, SN - JANDAIA-GO - 75950-000",
                "64999999999"
            ),
            Itens = new List<ItemViewModel>
            {
                new(1, "FEIJÃO TIO JORGE", 1.00M, 3M, 5.23M),
                new(2, "ARROZ TIO JORGE", 1.00M, 100M, 1240.23M),
                new(3, "MACARRÃO TIO JORGE", 1.00M, 1M, 8.23M)
            },
            Pagamentos = new List<PagamentoViewModel>()
            {
                new("Dinheiro", 25.00M),
                new("Cartão", 50.00M)
            }
        };

        return viewModel;
    }
}