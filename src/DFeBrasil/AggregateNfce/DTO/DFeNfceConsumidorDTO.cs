namespace DFeBrasil.AggregateNfce.DTO;

public record DFeNfceConsumidorDTO(string CpfCnpj, string Nome)
{
    public string CpfCnpj { get; } = CpfCnpj;
    public string Nome { get; } = Nome;
}