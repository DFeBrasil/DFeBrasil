namespace DFeBrasil.AggregateNfce.DTO;

public record DFeNfceAutorizacaoDTO(DateTime DataAutorizacao, string Protocolo)
{
    public DateTime DataAutorizacao { get; } = DataAutorizacao;
    public string Protocolo { get; } = Protocolo;
}