namespace Bridge;

internal static class Program
{
    private static void Main()
    {
        IImplementationFormulaire implHtml = new ImplementationHtml();
        IImplementationFormulaire implApplet = new ImplementationApplet();

        FormulaireImmatriculation formulaireFranceHtml = new FormulaireImmatriculationFrance(implHtml);
        FormulaireImmatriculation formulaireLuxApplet = new FormulaireImmatriculationLux(implApplet);

        Console.WriteLine("Test du formulaire France HTML :");
        formulaireFranceHtml.AfficherFormulaire();
        formulaireFranceHtml.SoumettreFormulaire();

        Console.WriteLine("\nTest du formulaire Luxembourg Applet :");
        formulaireLuxApplet.AfficherFormulaire();
        formulaireLuxApplet.SoumettreFormulaire();
    }
}