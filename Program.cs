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
<<<<<<< HEAD
=======

        DataGeneric<string> Data = new DataGeneric<string>("1302223050");
        Data.PrintData();
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T InputData)
    {
        this.data = InputData;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + this.data);
>>>>>>> generic-class
    }
}