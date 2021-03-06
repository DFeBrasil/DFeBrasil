using System;
using System.Collections.Generic;
using DFeBrasil.AggregateNfce.DTO;

namespace DFeBrasil.Nfce.Danfe.UnitTests.Fixtures;

public static class DanfeFixtures
{
    public static DFeNfceDTO ObterNfce(
        DFeNfceConsumidorDTO? consumidor = null,
        bool emContingencia = false,
        bool cancealda = false
    )
    {
        var dto = new DFeNfceDTO
        {
            Serie = 3,
            Numero = 563,
            Chave = "12345678901234567890123456789012345678901234",
            QrCode = "http://homolog.sefaz.go.gov.br/nfeweb/sites/nfce/danfeNFCe?p=12345678901234567890123456789012345678901234|2|2|1|a64adcd1eee2a5a8e3f31feb9d4095a9d4d78b72",
            UrlChave = "http://homolog.sefaz.go.gov.br/nfeweb/sites/nfce/danfeNFCe",
            DataEmissao = DateTimeOffset.Now,
            QuantidadeItens = 5,
            TotalDesconto = 30.00M,
            TotalOutros = 150.00M,
            TotalCupom = 200.25M,
            TributosAproximado = 15M,
            EhHomologacao = true,
            EhContingencia = emContingencia,
            Cancelada = cancealda,
            Consumidor = consumidor!,
            Autorizacao = new(DateTimeOffset.Now, "12394219031231"),
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

    public static DFeNfceDTO ObterComConsumidor()
    {
        return ObterNfce(new("68492125080", "João Pedro da Silva"));
    }

    public static DFeNfceDTO ObterEmContingencia()
    {
        return ObterNfce(emContingencia: true);
    }
}