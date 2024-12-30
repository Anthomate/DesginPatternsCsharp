using Builder.Models;

namespace Builder.Builders;

public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculeHtml()
    {
        liasse = new LiasseHtml();
    }

    public override void ConstruitBonDeCommande(string client)
    {
        liasse.AjouteDocument($"Bon de commande HTML pour {client}.");
    }

    public override void ConstruitDemandeImmatriculation(string informations)
    {
        liasse.AjouteDocument($"Demande d'immatriculation HTML avec les informations : {informations}.");
    }
}