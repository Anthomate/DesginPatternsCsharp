namespace Exo1;

public interface IDocumentFactory
{
    IRib CreerReleveIdentiteBancaire();
    IAttestation CreerAttestationDeCompte();
}