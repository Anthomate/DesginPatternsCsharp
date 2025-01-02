namespace Exo1;

public class DocumentParticulier : IDocumentFactory
{
    public IRib CreerReleveIdentiteBancaire()
    {
        return new RibParticulier();
    }

    public IAttestation CreerAttestationDeCompte()
    {
        return new AttestationParticulier();
    }
}