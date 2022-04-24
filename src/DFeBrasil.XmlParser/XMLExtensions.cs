using System.ComponentModel;
using DFeBrasil.AggregateNfce.DTO;
using DFeBrasil.Comum;
using DFeBrasil.XmlParser.NFeModels;
using EnumsNET;

namespace DFeBrasil.XmlParser;

public static class XMLExtensions
{
    public static DFeNfceDTO ConverteParaNfceDTO(this XR01NFeProc nfeProc)
    {
        var model = new DFeNfceDTO
        {
            Serie = nfeProc.NFe.InfNFe.Ide.Serie,
            Numero = nfeProc.NFe.InfNFe.Ide.Numero,
            Chave = nfeProc.ProtNFe.InfProt.ChNFe,
            DataEmissao = nfeProc.NFe.InfNFe.Ide.DhEmi,
            QrCode = nfeProc.NFe.InfNFeSupl.QrCode,
            UrlChave = nfeProc.NFe.InfNFeSupl.UrlChave,
            TotalDesconto = nfeProc.NFe.InfNFe.Total.ICMSTotal.ValorDesc,
            TotalOutros = CalculaTotalOutros(nfeProc.NFe.InfNFe.Total.ICMSTotal),
            TotalCupom = nfeProc.NFe.InfNFe.Total.ICMSTotal.ValorNF,
            TributosAproximado = nfeProc.NFe.InfNFe.Total.ICMSTotal.ValorTotTrib,
            EhContingencia = nfeProc.NFe.InfNFe.Ide.TpEmis == 9,
            EhHomologacao = nfeProc.NFe.InfNFe.Ide.TpAmb == 2,
            Emitente = ConvertEmit(nfeProc.NFe.InfNFe.Emit),
            Consumidor = ConverteDest(nfeProc.NFe.InfNFe.Dest),
            QuantidadeItens = nfeProc.NFe.InfNFe.Det.Count,
            Itens = ConverteDet(nfeProc.NFe.InfNFe.Det),
            Pagamentos = ConvertePag(nfeProc.NFe.InfNFe.Pag),
            Autorizacao = new(
                nfeProc.ProtNFe.InfProt.DhRecbto,
                nfeProc.ProtNFe.InfProt.Prot
            ),
        };

        return model;
    }

    private static decimal CalculaTotalOutros(W02ICMSTot tot)
    {
        return tot.ValorFrete + tot.ValorOutro + tot.ValorSeg;
    }

    private static DFeNfceEmitenteDTO ConvertEmit(C01Emit emit)
    {
        var documento = emit.CPF ?? emit.CNPJ;

        var endereco = $"{emit.EnderEmit.Lgr}"
                       + $", {emit.EnderEmit.Nro}"
                       + $", {emit.EnderEmit.Bairro}"
                       + $", {emit.EnderEmit.UF}-{emit.EnderEmit.Mun}"
                       + $", {emit.EnderEmit.CEP}";

        return new(
            emit.Nome,
            emit.Fant,
            documento,
            emit.IE,
            endereco,
            emit.EnderEmit.Fone?.ToString() ?? ""
        );
    }

    private static DFeNfceConsumidorDTO ConverteDest(E01Dest dest)
    {
        if (dest == null) return null;
        var documento = dest.CPF ?? dest.CNPJ;

        return new(documento, dest.Nome ?? string.Empty);
    }

    private static IEnumerable<DFeNfceItemDTO> ConverteDet(IEnumerable<H01Det> det)
    {
        return det.Select(i => new DFeNfceItemDTO(
                i.NumItem,
                i.Prod.Prod,
                i.Prod.QtdCom,
                i.Prod.ValorUnCom,
                i.Prod.ValorProd
            )
        );
    }

    private static IEnumerable<DFeNfcePagamentoDTO> ConvertePag(YA01Pag pag)
    {
        return pag?.DetPag?.Select(i =>
            {
                var tipoPag = (DFeTipoPagamento)i.TipoPag;
                var descricao = tipoPag.GetAttributes()?.Get<DescriptionAttribute>();

                if (descricao == null)
                    throw new ArgumentException("Descrição tipo de pagamento não pode ser nula.");

                return new DFeNfcePagamentoDTO(
                    descricao.Description,
                    i.ValorPag
                );
            }
        );
    }
}