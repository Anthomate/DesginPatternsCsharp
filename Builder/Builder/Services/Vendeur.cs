using Builder.Builders;
using Builder.Models;

namespace Builder.Services;

public class Vendeur(ConstructeurLiasseVehicule constructeurLiasseVehicule)
{
    public Liasse Construit(string client, string immatriculation)
    {
        constructeurLiasseVehicule.ConstruitBonDeCommande(client);
        constructeurLiasseVehicule.ConstruitDemandeImmatriculation(immatriculation);
        
        return constructeurLiasseVehicule.Resultat();
    }
}