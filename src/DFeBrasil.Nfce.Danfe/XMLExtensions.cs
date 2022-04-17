using System.ComponentModel;
using DFeBrasil.AggregateNfce.DTO;
using DFeBrasil.Comum;
using DFeBrasil.XmlParser.NFeModels;
using EnumsNET;

namespace DFeBrasil.Nfce.Danfe;

public static class XMLExtensions
{
    public static DFeNfceDTO ToDFeNfceDTO(this XR01NFeProc nfeProc)
    {
        var model = new DFeNfceDTO
        {
            Chave = nfeProc.ProtNFe.InfProt.ChNFe,
            DataEmissao = nfeProc.NFe.InfNFe.Ide.DhEmi,
            QrCode = nfeProc.NFe.InfNFeSupl.QrCode,
            UrlChave = nfeProc.NFe.InfNFeSupl.UrlChave,
            TotalDesconto = nfeProc.NFe.InfNFe.Total.ICMSTotal.ValorDesc,
            TotalOutros = nfeProc.NFe.InfNFe.Total.ICMSTotal.ValorOutro,
            TotalCupom = nfeProc.NFe.InfNFe.Total.ICMSTotal.ValorNF,
            TributosAproximado = nfeProc.NFe.InfNFe.Total.ICMSTotal.ValorTotTrib,
            EhContingencia = nfeProc.NFe.InfNFe.Ide.TpEmis == 9,
            EhHomologacao = nfeProc.NFe.InfNFe.Ide.TpAmb == 2,
            Emitente = CovnertEmit(nfeProc.NFe.InfNFe.Emit),
            Consumidor = ConvertDest(nfeProc.NFe.InfNFe.Dest),
            QuantidadeItens = nfeProc.NFe.InfNFe.Det.Count,
            Itens = ConvertDet(nfeProc.NFe.InfNFe.Det),
            Pagamentos = ConvertPag(nfeProc.NFe.InfNFe.Pag),
            Autorizacao = new(
                nfeProc.ProtNFe.InfProt.DhRecbto,
                nfeProc.ProtNFe.InfProt.Prot
            ),
        };

        return model;
    }

    private static DFeNfceEmitenteDTO CovnertEmit(C01Emit emit)
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

    private static DFeNfceConsumidorDTO ConvertDest(E01Dest dest)
    {
        if (dest == null) return null;
        var documento = dest.CPF ?? dest.CNPJ;

        return new(documento, dest.Nome ?? string.Empty);
    }

    private static IEnumerable<DFeNfceItemDTO> ConvertDet(IEnumerable<H01Det> det)
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

    private static IEnumerable<DFeNfcePagamentoDTO> ConvertPag(YA01Pag pag)
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