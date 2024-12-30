namespace Builder.Models;

public class LiasseHtml : Liasse
{
    public override void Imprime()
    {
        Console.WriteLine("Liasse HTML:");
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
    }
}