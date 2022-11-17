internal class Program
{
    private static void Main(string[] args)
    {
        string name = null;
        
        name = name ?? "Varsayılan Ad";

        Console.WriteLine(name);
    }
}