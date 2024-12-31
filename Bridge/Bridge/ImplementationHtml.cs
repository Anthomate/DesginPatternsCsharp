namespace Bridge;

public class ImplementationHtml : IImplementationFormulaire
{
    public void AfficherFormulaire()
    {
        Console.WriteLine("Affichage du formulaire en HTML");
    }

    public void SoumettreFormulaire()
    {
        Console.WriteLine("Soumission du formulaire via HTML");
    }
}