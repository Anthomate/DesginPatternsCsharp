namespace Adapter;

public class DocumentHtml : Document
{
    private string _contenu;

    public override void SetContenu(string contenu)
    {
        _contenu = contenu;
    }

    public override void Dessine()
    {
        Console.WriteLine($"Dessine un document HTML : {_contenu}");
    }

    public override void Imprime()
    {
        Console.WriteLine($"Imprime un document HTML : {_contenu}");
    }
}