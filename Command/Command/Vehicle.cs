namespace Command;

public class Vehicle(string id, string model, DateTime stockDate, decimal price)
{
    public string Id { get; set; } = id;
    public string Model { get; set; } = model;
    public DateTime StockDate { get; set; } = stockDate;
    public decimal Price { get; set; } = price;
}