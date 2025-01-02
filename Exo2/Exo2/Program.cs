namespace Exo2;

internal static class Program
{
    private static void Main(string[] args)
    {
        var manager = new ContractManager();
        manager.Initialize();

        var homeContract = manager.CreateContract("home");
        homeContract.CustomInfo["ClientName"] = "Jean Dupont";
        homeContract.CustomInfo["StartDate"] = "2025-01-02";
        
        var homeContractVariation = manager.CreateContractVariation(homeContract);
        homeContractVariation.CustomInfo["Franchise"] = "1000€";
        
        Console.WriteLine($"Contrat original - Client: {homeContract.CustomInfo["ClientName"]}");
        Console.WriteLine($"Variation - Franchise: {homeContractVariation.CustomInfo["Franchise"]}");
    }
}