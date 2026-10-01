DroneVault vault = new DroneVault();
vault.Add(new Drone("Delta"));
vault.Add(new Drone("Echo"));

List<Drone> copy = vault.GetDrones();

// TODO: Eksperimenter med RemoveAt og deretter endring av Name.
copy.RemoveAt(0); // fjerner Delta fra kopien, men ikke fra vault
copy.Add(new Drone("Foxtrot")); // legger til Foxtrot i kopien, men ikke i vault
copy[0].Name = "CHANGED"; // endrer navnet på Echo til Gamma, men det endrer også navnet i vault, fordi det er samme objekt.

Console.WriteLine($"Vault count: {vault.Count}");
vault.PrintAll();
