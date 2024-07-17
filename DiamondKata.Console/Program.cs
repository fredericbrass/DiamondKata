using DiamondKata.Console;

public static class Program
{
    static void Main(string[] args)
    {
        var diamond = Diamond.Create(args);
        Console.WriteLine(diamond);
    }
}