public class Program
{
    static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine(a);
            return;
        }
        Console.WriteLine(b);
    }
}