namespace Command;

public class DiscountCommand(List<Vehicle> vehicles, decimal discountRate, TimeSpan minStockDuration)
    : ICommand
{
    private readonly Dictionary<string, decimal> _originalPrices = new();

    public void Execute()
    {
        var now = DateTime.Now;
        foreach (var vehicle in vehicles.Where(vehicle => now - vehicle.StockDate >= minStockDuration))
        {
            _originalPrices[vehicle.Id] = vehicle.Price;
            vehicle.Price *= (1 - discountRate);
        }
    }

    public void Undo()
    {
        foreach (var kvp in _originalPrices)
        {
            var vehicle = vehicles.Find(v => v.Id == kvp.Key);
            if (vehicle != null)
            {
                vehicle.Price = kvp.Value;
            }
        }
    }
}