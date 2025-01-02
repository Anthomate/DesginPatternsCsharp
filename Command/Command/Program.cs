namespace Command;

internal static class Program
{
    private static void Main()
    {
        var vehicles = new List<Vehicle>
        {
            new Vehicle("1", "Renault Clio", DateTime.Now.AddMonths(-6), 10000),
            new Vehicle("2", "Peugeot 208", DateTime.Now.AddMonths(-4), 12000),
            new Vehicle("3", "Citroën C3", DateTime.Now.AddMonths(-2), 11000)
        };

        var invoker = new CommandInvoker();

        var discountCommand = new DiscountCommand(vehicles, 0.1m, TimeSpan.FromDays(150));
        Console.WriteLine("Prix de base :");
        PrintVehicles(vehicles);

        Console.WriteLine("\nApplication d'une remise de 10% sur les véhicules en stock depuis plus de 5 mois :");
        invoker.ExecuteCommand(discountCommand);
        PrintVehicles(vehicles);

        Console.WriteLine("\nAnnulation de la dernière remise :");
        invoker.UndoLastCommand();
        PrintVehicles(vehicles);

        Console.WriteLine("\nRétablissement de la remise :");
        invoker.RedoLastCommand();
        PrintVehicles(vehicles);

        Console.ReadLine();
    }

    private static void PrintVehicles(List<Vehicle> vehicles)
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"{vehicle.Model} : {vehicle.Price:C} (En stock depuis : {vehicle.StockDate:d})");
        }
    }
}