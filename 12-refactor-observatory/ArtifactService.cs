public class ArtifactService
{
    private List<Artifact> artifacts = new List<Artifact>();

   public void Add(Artifact artifact)
    {
        artifacts.Add(artifact);
    }
    public void ShowAllArtifacts()
    {
        foreach (var artifact in artifacts)
        {
            Console.WriteLine($"{artifact.Name} | {artifact.Origin} | {artifact.Risk}");
        }
    }
    public void ShowHighRiskArtifacts()
    {
        List<Artifact> highRisk = artifacts.Where(a => a.Risk >= 60).ToList();
        foreach (Artifact artifact in highRisk)
        {
            Console.WriteLine($"{artifact.Name} | {artifact.Risk}");
        }
    }
    public void SearchOrigin()
    {
        Console.Write("Origin: ");
        string? origin = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(origin))
        {
            List<Artifact> matches = artifacts
                .Where(a => a.Origin.Equals(origin, StringComparison.OrdinalIgnoreCase))
                .ToList();

            foreach (Artifact artifact in matches)
            {
                Console.WriteLine(artifact.Name);
            }
        }
    }
}
