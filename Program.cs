public class HaloGeneric
{
    public static void SapaUser<T>(T X)
    {
        Console.WriteLine("Halo user " + X);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric.SapaUser<string>("Muhammad Iqbal Nurhaq");
    }
}