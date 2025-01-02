namespace Exo2;

public class HomeInsurance : InsuranceContract
{
    public override InsuranceContract Clone()
    {
        var clone = new HomeInsurance();
        CopyTo(clone);
        return clone;
    }
}