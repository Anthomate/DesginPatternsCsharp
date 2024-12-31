namespace Bridge;

public class ImplementationApplet : IImplementationFormulaire
{
    public void AfficherFormulaire()
    {
        Console.WriteLine("Affichage du formulaire en Applet");
    }

    public void SoumettreFormulaire()
    {
        Console.WriteLine("Soumission du formulaire via Applet");
    }
}