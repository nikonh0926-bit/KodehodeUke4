Archive archive = new Archive();
archive.Add("A-1");
archive.Add("A-2");
archive.Add("A-3");

List<string> outsideList = archive.GetEntries();

outsideList.Clear(); // tømmer listen som vi fikk fra GetEntries()

Console.WriteLine($"Archive count: {archive.Count}");
