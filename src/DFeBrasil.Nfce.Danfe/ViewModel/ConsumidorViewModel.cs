namespace DFeBrasil.Nfce.Danfe.ViewModel;

public record ConsumidorViewModel(string CpfCnpj, string Nome)
{
    public string CpfCnpj { get; } = CpfCnpj;
    public string Nome { get; } = Nome;
}