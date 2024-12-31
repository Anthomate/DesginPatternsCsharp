namespace Adapter;

public class ServeurWeb
{
    private readonly List<Document> _documents = [];

    public void AjouteDocument(Document document)
    {
        _documents.Add(document);
    }

    public void AfficheDocuments()
    {
        foreach (var document in _documents)
        {
            document.Dessine();
        }
    }

    public void ImprimeDocuments()
    {
        foreach (var document in _documents)
        {
            document.Imprime();
        }
    }
}