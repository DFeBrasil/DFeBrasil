using System.ComponentModel;

namespace DFeBrasil.Comum;

public enum DFeTipoPagamento
{
    [Description("Dinheiro")] Dinheiro = 01,
    [Description("Cheque")] Cheque = 02,
    [Description("Cartão de Crédito")] CartaoCredito = 03,
    [Description("Cartão de Débito")] CartãoDebito = 04,
    [Description("Crédito Loja")] CréditoLoja = 05,
    [Description("Vale Alimentação")] ValeAlimentacao = 10,
    [Description("Vale Refeição")] ValeRefeiao = 11,
    [Description("Vale Presente")] ValePresente = 12,
    [Description("Vale Combustível")] ValeCombustivel = 13,
    [Description("Boleto Bancário")] BoletoBancario = 15,
    [Description("Depósito Bancário")] DepósitoBancario = 16,
    [Description("PIX")] PIX = 17,

    [Description("Transferência Bancária, Carteira Digital")]
    TransferênciaBancaria = 18,
    [Description("Carnê")] Carnê = 19,

    [Description("Programa fidelidade, Cashback, Crédito Virtual")]
    ProgramaFidelidade = 19,
    [Description("Sem pagamento")] SemPagamento = 90,
    [Description("Outros")] Outros = 99,
}