namespace DFeBrasil.AggregateNfce.DTO;

public record DFeNfceAutorizacaoDTO(DateTimeOffset DataAutorizacao, string Protocolo)
{
    public DateTimeOffset DataAutorizacao { get; } = DataAutorizacao;
    public string Protocolo { get; } = Protocolo;
}