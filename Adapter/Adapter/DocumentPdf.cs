namespace Adapter;

public class DocumentPdf : Document
{
    private readonly ComposantPdf _outilPdf = new ComposantPdf();
    private string _contenu;

    public override void SetContenu(string contenu)
    {
        _contenu = contenu;
        ComposantPdf.PdfFixeContenu(contenu);
    }

    public override void Dessine()
    {
        ComposantPdf.PdfPrepareAffichage();
        ComposantPdf.PdfRafraichit();
        ComposantPdf.PdfTermineAffichage();
    }

    public override void Imprime()
    {
        ComposantPdf.PdfEnvoieImprimante();
    }
}