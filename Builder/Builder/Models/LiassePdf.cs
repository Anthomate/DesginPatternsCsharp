namespace Builder.Models;

public class LiassePdf : Liasse
{
    public override void Imprime()
    {
        Console.WriteLine("Liasse PDF:");
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
    }
}