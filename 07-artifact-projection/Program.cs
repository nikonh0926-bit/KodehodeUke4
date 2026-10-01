List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Bruk Select til tre ulike projeksjoner.
var names = artifacts.Select(a => a.Name);
var origins = artifacts.Select(a => a.Origin);
var risks = artifacts.Select(a => a.Risk);

Console.WriteLine("Names:");
foreach (var name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("\nOrigins:");
foreach (var origin in origins)
{
    Console.WriteLine(origin);
}
Console.WriteLine("\nRisks:");
foreach (var risk in risks)
{
    Console.WriteLine(risk);
}
