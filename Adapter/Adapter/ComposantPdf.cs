namespace Adapter;

public class ComposantPdf
{
    public static void PdfFixeContenu(string contenu)
    {
        Console.WriteLine($"Fixe le contenu PDF : {contenu}");
    }

    public static void PdfPrepareAffichage()
    {
        Console.WriteLine("Prépare l'affichage PDF");
    }

    public static void PdfRafraichit()
    {
        Console.WriteLine("Rafraîchit l'affichage PDF");
    }

    public static void PdfTermineAffichage()
    {
        Console.WriteLine("Termine l'affichage PDF");
    }

    public static void PdfEnvoieImprimante()
    {
        Console.WriteLine("Envoie le PDF à l'imprimante");
    }
}