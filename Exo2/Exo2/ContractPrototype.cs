namespace Exo2;

public class ContractPrototype
{
    private readonly Dictionary<string, InsuranceContract> _prototypes = new();

    public void RegisterPrototype(string type, InsuranceContract prototype)
    {
        _prototypes[type] = prototype;
    }

    public InsuranceContract GetPrototype(string type)
    {
        return _prototypes[type]?.Clone() ?? throw new InvalidOperationException();
    }
}