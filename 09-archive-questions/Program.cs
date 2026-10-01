List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};


// TODO: Bruk Any og Count til å svare på spørsmålene.
Console.WriteLine("Are there any artifacts with a risk greater than 90?" + (artifacts.Any(a => a.Risk > 90) ? " Yes" : " No"));

Console.WriteLine("How many artifacts are from Mars? " + artifacts.Count(a => a.Origin == "Mars"));


// forskjell mellom artifacts.Count() og artifacts.Count
// Count() er en LINQ metode som teller hvert element i listen
// Count er en egenskap av List<t> som returnerer antall elementer i listen.
// I dette tilfellet vil begge gi samme resultat, men Count() kan brukes med LINQ-spørringer, mens Count er mer direkte for List<T>.
Console.WriteLine("Total number of artifacts: " + artifacts.Count());

Console.WriteLine("Is there any artifact from Venus? " + (artifacts.Any(a => a.Origin == "Venus") ? " Yes" : " No"));