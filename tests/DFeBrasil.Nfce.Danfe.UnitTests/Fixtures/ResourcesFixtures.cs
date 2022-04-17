using System.IO;

namespace DFeBrasil.Nfce.Danfe.UnitTests.Fixtures;

public static class ResourcesFixtures
{
    public static string ObterFakeNfce()
    {
        return File.ReadAllText("./Resources/fake-nfce.xml");
    }

    public static string ObterFakeNfceSemDest()
    {
        return File.ReadAllText("./Resources/fake-nfce-sem-dest.xml");
    }

    public static string ObterRsource(string nome)
    {
        return File.ReadAllText($"./Resources/{nome}");
    }
}