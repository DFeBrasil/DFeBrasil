namespace DFeBrasil.AggregateNfce.DTO;

public record DFeNfceItemDTO(
    int Numero,
    string Descricao,
    decimal Quantidade,
    decimal ValorUnitario,
    decimal Total
)
{
    public int Numero { get; } = Numero;
    public string Descricao { get; } = Descricao;
    public decimal Quantidade { get; } = Quantidade;
    public decimal ValorUnitario { get; } = ValorUnitario;
    public decimal Total { get; } = Total;
}