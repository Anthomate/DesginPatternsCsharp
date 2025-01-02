namespace Exo2;

public class ContractManager
{
    private readonly ContractPrototype _registry = new();

    public void Initialize()
    {
        var homePrototype = new HomeInsurance 
        { 
            StandardClauses = ["Clause habitation standard"]
        };
        _registry.RegisterPrototype("home", homePrototype);
    }

    public InsuranceContract CreateContract(string type)
    {
        var contract = _registry.GetPrototype(type);
        return contract;
    }

    public InsuranceContract CreateContractVariation(InsuranceContract baseContract)
    {
        return baseContract.Clone();
    }
}