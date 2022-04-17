using System.IO;

namespace DFeBrasil.Nfce.Danfe.UnitTests.Fixtures;

public static class ResourcesFixtures
{
    public static string ObterFakeNfce()
    {
        return File.ReadAllText("./Resources/fake-nfce.xml");
    }
}