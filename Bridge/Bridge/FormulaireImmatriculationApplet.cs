namespace Bridge;

public class FormulaireImmatriculationLux(IImplementationFormulaire implementation)
    : FormulaireImmatriculation(implementation)
{
    public override void AfficherFormulaire()
    {
        Console.WriteLine("Formulaire d'immatriculation Luxembourg");
        base.AfficherFormulaire();
    }

    public override void SoumettreFormulaire()
    {
        Console.WriteLine("Soumission formulaire luxembourgeois");
        base.SoumettreFormulaire();
    }
}