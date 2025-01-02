namespace Exo1;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Génération documents pour un client particulier ===");
        IDocumentFactory factoryParticulier = new DocumentParticulier();
        IRib ribParticulier = factoryParticulier.CreerReleveIdentiteBancaire();
        IAttestation attestationParticulier = factoryParticulier.CreerAttestationDeCompte();
        
        ribParticulier.Generer();
        attestationParticulier.Generer();

        Console.WriteLine("\n=== Génération documents pour un client professionnel ===");
        IDocumentFactory factoryProfessionnel = new DocumentProfessionnel();
        IRib ribProfessionnel = factoryProfessionnel.CreerReleveIdentiteBancaire();
        IAttestation attestationProfessionnel = factoryProfessionnel.CreerAttestationDeCompte();
        
        ribProfessionnel.Generer();
        attestationProfessionnel.Generer();
    }
}

