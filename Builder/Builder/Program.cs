using Builder.Builders;
using Builder.Services;

namespace Builder;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Choisissez le type de liasse - 1: HTML ou 2: PDF :");
        var choix = Console.ReadLine();

        ConstructeurLiasseVehicule constructeur;

        switch (choix)
        {
            case "1":
                constructeur = new ConstructeurLiasseVehiculeHtml();
                break;
            case "2":
                constructeur = new ConstructeurLiasseVehiculePdf();
                break;
            default:
                Console.WriteLine("Veuillez choisir une option valide.");
                return;
        }

        var vendeur = new Vendeur(constructeur);

        Console.WriteLine("Entrez le nom du client:");
        var client = Console.ReadLine();

        Console.WriteLine("Entrez l'immatriculation:");
        var immatriculation = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(client) || string.IsNullOrWhiteSpace(immatriculation))
        {
            Console.WriteLine("Le nom du client ou l'immatriculation est invalide.");
            return;
        }

        var liasse = vendeur.Construit(client, immatriculation);
        liasse.Imprime();
    }
}