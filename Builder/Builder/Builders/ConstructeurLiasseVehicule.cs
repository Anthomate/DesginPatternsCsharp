using Builder.Models;

namespace Builder.Builders;

public abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse;

    public abstract void ConstruitBonDeCommande(string client);
    public abstract void ConstruitDemandeImmatriculation(string informations);

    public Liasse Resultat()
    {
        return liasse;
    }
}