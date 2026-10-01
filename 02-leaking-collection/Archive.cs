public class Archive
{
    private List<string> entries = new List<string>();

    public int Count => entries.Count;

    public void Add(string entry)
    {
        entries.Add(entry);
    }

    public List<string> GetEntries()
    {
        // Designfeil: Returnerer den interne listen, som kan endres av utenforstående kode.
        //return entries;


        // TODO del B: Fiks GetEntries() ved å returnere en kopi av listen i stedet for den interne listen.
        return new List<string>(entries);
    }
}
