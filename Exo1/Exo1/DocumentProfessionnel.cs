namespace Exo1;

public class DocumentProfessionnel : IDocumentFactory
{
    public IRib CreerReleveIdentiteBancaire()
    {
        return new RibProfessionnel();
    }

    public IAttestation CreerAttestationDeCompte()
    {
        return new AttestationProfessionnelle();
    }
}