namespace Bridge;

public class FormulaireImmatriculationFrance(IImplementationFormulaire implementation)
    : FormulaireImmatriculation(implementation)
{
    public override void AfficherFormulaire()
    {
        Console.WriteLine("Formulaire d'immatriculation France");
        base.AfficherFormulaire();
    }

    public override void SoumettreFormulaire()
    {
        Console.WriteLine("Soumission formulaire français");
        base.SoumettreFormulaire();
    }
}