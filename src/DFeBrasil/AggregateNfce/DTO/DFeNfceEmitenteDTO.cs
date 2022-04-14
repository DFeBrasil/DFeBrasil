namespace DFeBrasil.AggregateNfce.DTO;

public record DFeNfceEmitenteDTO(
    string Nome,
    string NomeFantasia,
    string Cnpj,
    string Ie,
    string Endereco,
    string Telefone
)
{
    public string Nome { get; } = Nome;
    public string NomeFantasia { get; } = NomeFantasia;
    public string Cnpj { get; } = Cnpj;
    public string Ie { get; } = Ie;
    public string Endereco { get; } = Endereco;
    public string Telefone { get; } = Telefone;
}