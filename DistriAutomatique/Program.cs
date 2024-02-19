using DistriAutomatique.BLL;

public class Program
{
    static void Main(string[] args)
    {
        DistriBoissons machine = new DistriBoissons();
        string Recette = Console.ReadLine();
        Console.WriteLine($"Prix de {Recette}: {machine.GetRecettePrix(Recette)}");
    }
}