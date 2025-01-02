namespace Exo2;

public abstract class InsuranceContract
{
    public List<string> StandardClauses { get; set; } = [];
    public Dictionary<string, string> CustomInfo { get; set; } = new();
    private List<string> Annexes { get; set; } = [];

    public abstract InsuranceContract Clone();

    protected void CopyTo(InsuranceContract target)
    {
        target.StandardClauses = [..StandardClauses];
        target.CustomInfo = new Dictionary<string, string>(CustomInfo);
        target.Annexes = [..Annexes];
    }
}