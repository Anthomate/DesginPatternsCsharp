namespace Exo2;

public class CarInsurance : InsuranceContract
{
    public override InsuranceContract Clone()
    {
        var clone = new CarInsurance();
        CopyTo(clone);
        return clone;
    }
}