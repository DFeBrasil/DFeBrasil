namespace DFeBrasil.Nfce.Danfe.ViewModel;

public record PagamentoViewModel(string Descricao, decimal Valor)
{
    public string Descricao { get; } = Descricao;
    public decimal Valor { get; } = Valor;
}