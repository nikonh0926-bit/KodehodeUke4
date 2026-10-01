List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Lag tre separate Where-queries.
var highRiskArtifacts = artifacts.Where(a => a.Risk > 50);
var moonArtifacts = artifacts.Where(a => a.Origin == "Moon");
var artifactsContaininge = artifacts.Where(a => a.Name.Contains("e"));

Console.WriteLine("High Risk Artifacts:");
foreach (var artifact in highRiskArtifacts)
{
    Console.WriteLine($"High Risk Artifact: {artifact.Name}, Origin: {artifact.Origin}, Risk: {artifact.Risk}");
}

Console.WriteLine("\nMoon Artifacts:");
foreach (var artifact in moonArtifacts)
{
    Console.WriteLine($"Moon Artifact: {artifact.Name}, Origin: {artifact.Origin}, Risk: {artifact.Risk}");
}

Console.WriteLine("\nArtifacts containing 'e':");
foreach (var artifact in artifactsContaininge)
{
    Console.WriteLine($"Artifact containing 'e': {artifact.Name}, Origin: {artifact.Origin}, Risk: {artifact.Risk}");
}
