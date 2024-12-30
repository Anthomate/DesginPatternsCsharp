using Builder.Models;

namespace Builder.Builders;

public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculePdf()
    {
        liasse = new LiasseHtml();
    }

    public override void ConstruitBonDeCommande(string client)
    {
        liasse.AjouteDocument($"Bon de commande PDF pour {client}.");
    }

    public override void ConstruitDemandeImmatriculation(string informations)
    {
        liasse.AjouteDocument($"Demande d'immatriculation PDF avec les informations : {informations}.");
    }
}