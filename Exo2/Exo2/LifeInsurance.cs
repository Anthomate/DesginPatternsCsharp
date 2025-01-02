namespace Exo2;

public class LifeInsurance : InsuranceContract
{
    public override InsuranceContract Clone()
    {
        var clone = new LifeInsurance();
        CopyTo(clone);
        return clone;
    }
}