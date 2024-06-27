namespace DelegateExample;

public class Program
{
    //match method signature to ConvertsIntToString.
    private static string HiThere(int i)
    {
        return "Hi there! #" + (i * 100);
    }

    private static void Main(string[] args)
    {
        // convertation is a var whose type is ConvertsIntToString.
        // it is a lot like reference variable, except instead of
        // putting a label on an obj on the heap, putting label on a method.
        ConvertsIntToString convertation = new(HiThere);
        // can set just like any other var. When calling it like a method,
        // it calls whatever method it happens to point to.
        string msg = convertation(5);
        Console.WriteLine(msg);
        Console.ReadKey();
    }

}