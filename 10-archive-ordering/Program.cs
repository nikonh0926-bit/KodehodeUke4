List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Where -> OrderBy -> Select.
List<string> artifactsRiskOverOrEqual30 = artifacts
    .Where(a => a.Risk >= 30)
    .OrderBy(a => a.Name)
    .Select(a => $"{a.Name}: {a.Risk}")
    .ToList();

Console.WriteLine("Artifacts with risk >= 30, ordered by name:");
foreach (string artifact in artifactsRiskOverOrEqual30)
{
    Console.WriteLine(artifact);
}

// TODO: Lag også en egen OrderBy på Risk.
List<string> artifactsByRisk = artifacts
    .OrderBy(a => a.Risk)
    .Select(a => $"{a.Name}: {a.Risk}")
    .ToList();
Console.WriteLine("\nAll artifacts ordered by risk:");
foreach (string artifact in artifactsByRisk)
{
    Console.WriteLine(artifact);
}
