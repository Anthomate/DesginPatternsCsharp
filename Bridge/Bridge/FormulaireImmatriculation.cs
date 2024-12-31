namespace Bridge;

public abstract class FormulaireImmatriculation(IImplementationFormulaire implementation)
{
    public virtual void AfficherFormulaire()
    {
        implementation.AfficherFormulaire();
    }

    public virtual void SoumettreFormulaire()
    {
        implementation.SoumettreFormulaire();
    }
}