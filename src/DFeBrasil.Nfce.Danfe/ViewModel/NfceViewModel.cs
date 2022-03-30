namespace DFeBrasil.Nfce.Danfe.ViewModel;

public record NfceViewModel
{
    public string Chave { get; set; }
    public string QrCode { get; set; }
    public string UrlChave { get; set; }
    public DateTime DataEmissao { get; set; }
    public int QuantidadeItens { get; set; }
    public decimal TotalDesconto { get; set; }
    public decimal TotalOutros { get; set; }
    public decimal TotalCupom { get; set; }
    public decimal TotalTributosAproximado { get; set; }
    public string ProtocoloAutorizacao { get; set; }
    public bool EstaEmContingencia { get; set; }
    public bool EstaEmHomologacao { get; set; }
    public DateTime DataAutorizacao { get; set; }
    public EmpresaViewModel Empresa { get; set; }
    public ConsumidorViewModel Consumidor { get; set; }
    public CancelamentoViewModel Cancelamento { get; set; }
    public IList<ItemViewModel> Itens { get; set; } = new List<ItemViewModel>();
    public IList<PagamentoViewModel> Pagamentos { get; set; } = new List<PagamentoViewModel>();
}