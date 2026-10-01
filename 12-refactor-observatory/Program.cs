

ArtifactService artifacts = new ArtifactService();
artifacts.Add(new Artifact("Echo Stone", "Moon", 73));
artifacts.Add(new Artifact("Broken Compass", "Earth", 12));
artifacts.Add(new Artifact("Glass Seed", "Mars", 48));
artifacts.Add(new Artifact("Signal Cube", "Moon", 91));
    new Artifact("Cold Lens", "Europa", 28)
;

while (true)
{
    string? choice = Menu();

    if (choice == "1")
    {
        artifacts.ShowAllArtifacts();
    }
    else if (choice == "2")
    {
        artifacts.ShowHighRiskArtifacts();
    }
    else if (choice == "3")
    {
        artifacts.SearchOrigin();
    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}

static string Menu()
{
    Console.WriteLine();
    Console.WriteLine("1 - Show all");
    Console.WriteLine("2 - Show high risk");
    Console.WriteLine("3 - Search origin");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");

    return Console.ReadLine();
}