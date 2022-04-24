using DFeBrasil.AggregateNfce.DTO;

namespace GerarDanfeNfce;

public static class DadosExemplo
{
    public static DFeNfceDTO Gerar()
    {
        var dto = new DFeNfceDTO
        {
            Serie = 55,
            Numero = 123,
            Chave = "12345678901234567890123456789012345678901234",
            QrCode =
                "http://homolog.sefaz.go.gov.br/nfeweb/sites/nfce/danfeNFCe?p=12345678901234567890123456789012345678901234|2|2|1|a64adcd1eee2a5a8e3f31feb9d4095a9d4d78b72",
            UrlChave = "http://homolog.sefaz.go.gov.br/nfeweb/sites/nfce/danfeNFCe",
            DataEmissao = DateTimeOffset.Parse("2022-04-17T17:31:26-03:00"),
            QuantidadeItens = 5,
            TotalDesconto = 30.00M,
            TotalOutros = 150.00M,
            TotalCupom = 200.25M,
            TributosAproximado = 15M,
            EhHomologacao = true,
            EhContingencia = true,
            Consumidor = new("21025760000123", "AGIL4 TECNOLOGIA"),
            Autorizacao = new(DateTimeOffset.Parse("2022-04-14T14:06:54-03:00"), "12394219031231"),
            Emitente = new(
                "AGIL4 TECNOLOGIA LTDA ME",
                "AGIL4",
                "21025760000123",
                "5462697",
                "AV. GALDINO A DE MOURA, NOVA VILA, SN - JANDAIA-GO - 75950-000",
                "64999999999"
            ),
            Itens = new List<DFeNfceItemDTO>
            {
                new(1, "FEIJÃO TIO JORGE", 1.00M, 3M, 5.23M),
                new(2, "ARROZ TIO JORGE", 1.00M, 100M, 1240.23M),
                new(3, "MACARRÃO TIO JORGE", 1.00M, 1M, 8.23M)
            },
            Pagamentos = new List<DFeNfcePagamentoDTO>()
            {
                new("Dinheiro", 25.00M),
                new("Cartão", 50.00M)
            }
        };

        return dto;
    }
}