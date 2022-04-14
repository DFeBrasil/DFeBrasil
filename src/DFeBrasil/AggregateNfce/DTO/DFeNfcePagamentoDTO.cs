namespace DFeBrasil.AggregateNfce.DTO;

public record DFeNfcePagamentoDTO(string Descricao, decimal Valor)
{
    public string Descricao { get; } = Descricao;
    public decimal Valor { get; } = Valor;
}