ArtifactArchive archive = new ArtifactArchive();
archive.Add(new Artifact("Echo Stone", "Moon", 73));
archive.Add(new Artifact("Broken Compass", "Earth", 12));
archive.Add(new Artifact("Glass Seed", "Mars", 48));
archive.Add(new Artifact("Signal Cube", "Moon", 91));

// TODO: Kall FindArtifacts med minst tre forskjellige lambdas.
var artifactsFromMoon = archive.FindArtifacts(a => a.Origin == "Moon");
var artifactsWithHighRisk = archive.FindArtifacts(a => a.Risk > 50);
var artifactsByName = archive.FindArtifacts(a => a.Name.Contains("C"));

Console.WriteLine("Artifacts from Moon:");
foreach (var artifact in artifactsFromMoon)
{
    Console.WriteLine($"{artifact.Name}, Risk: {artifact.Risk}");
}

Console.WriteLine("\nArtifacts with high risk:");
foreach (var artifact in artifactsWithHighRisk)
{
    Console.WriteLine($"{artifact.Name}, Risk: {artifact.Risk}");
}

Console.WriteLine("\nArtifacts with 'C' in name:");
foreach (var artifact in artifactsByName)
{
    Console.WriteLine($"{artifact.Name}, Risk: {artifact.Risk}");
}