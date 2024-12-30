namespace Builder.Models;

public abstract class Liasse
{
    protected readonly List<string> documents = [];

    public void AjouteDocument(string document)
    {
        documents.Add(document);
    }

    public abstract void Imprime();
}