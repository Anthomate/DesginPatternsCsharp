namespace Adapter;

public static class Program
{
    public static void Main()
    {
        ServeurWeb serveur = new ServeurWeb();

        Document docHtml = new DocumentHtml();
        docHtml.SetContenu("Document HTML");
        serveur.AjouteDocument(docHtml);

        Document docPdf = new DocumentPdf();
        docPdf.SetContenu("Document PDF");
        serveur.AjouteDocument(docPdf);

        serveur.AfficheDocuments();
        serveur.ImprimeDocuments();
    }
}