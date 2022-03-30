using System;
using System.Collections.Generic;
using DFeBrasil.Nfce.Danfe.ViewModel;

namespace DFeBrasil.Nfce.Danfe.UnitTests;

public static class NfceViewModelFixture
{
    public static NfceViewModel ObterViewModel(
        ConsumidorViewModel consumer = null,
        CancelamentoViewModel cancelation = null,
        bool emContingencia = false
    )
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
            EstaEmContingencia = emContingencia,
            Consumidor = consumer,
            Cancelamento = cancelation,
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

    public static NfceViewModel ObterViewModelCompleta()
    {
        return ObterViewModel(new("68492125080", "João Pedro da Silva"));
    }

    public static NfceViewModel ObterViewModelCancelada()
    {
        return ObterViewModel(cancelation: new("123456789012345"));
    }

    public static NfceViewModel CriarViewModel(string type)
    {
        return type switch
        {
            "Completa" => ObterViewModelCompleta(),
            "Cancelada" => ObterViewModelCancelada(),
            _ => ObterViewModel()
        };
    }
}