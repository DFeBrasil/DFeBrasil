namespace DFeBrasil.AggregateNfce.DTO;

public record DFeNfceDTO
{
    public int Serie { get; set; }
    public long Numero { get; set; }
    public string Chave { get; set; }
    public string QrCode { get; set; }
    public string UrlChave { get; set; }
    public DateTimeOffset DataEmissao { get; set; }
    public int QuantidadeItens { get; set; }
    public decimal TotalDesconto { get; set; }
    public decimal TotalOutros { get; set; }
    public decimal TotalCupom { get; set; }
    public decimal TributosAproximado { get; set; }
    public bool EhContingencia { get; set; }
    public bool EhHomologacao { get; set; }
    public bool Cancelada { get; set; }
    public DFeNfceEmitenteDTO Emitente { get; set; }
    public DFeNfceConsumidorDTO Consumidor { get; set; }
    public IEnumerable<DFeNfceItemDTO> Itens { get; set; } = new List<DFeNfceItemDTO>();
    public IEnumerable<DFeNfcePagamentoDTO> Pagamentos { get; set; } = new List<DFeNfcePagamentoDTO>();
    public DFeNfceAutorizacaoDTO Autorizacao { get; set; }
}