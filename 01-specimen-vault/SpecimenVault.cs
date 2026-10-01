public class SpecimenVault
{
    private List<string> specimens = new List<string>();

    public void Add(string specimen)
    {
        specimens.Add(specimen);
        Console.WriteLine($"\nSpecimen '{specimen}' added to the vault.");
    }

    public bool Remove(string specimen)
    {
        foreach (var s in specimens)
        {
            if (s == specimen)
            {
                specimens.Remove(s);
                return true;
            }
        }
        Console.WriteLine($"\nSpecimen '{specimen}' not found in the vault.");
        return false;
    }

    public void PrintAll()
    {
        Console.WriteLine("\nSpecimens in the vault:");
        foreach (var specimen in specimens)
        {
            Console.WriteLine(specimen);
        }
    }
}
