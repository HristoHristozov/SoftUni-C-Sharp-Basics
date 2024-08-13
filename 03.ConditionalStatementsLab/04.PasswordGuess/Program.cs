public class Program
{
    static void Main()
    {
        const string password = "s3cr3t!P@ssw0rd";

        var inputPassword = Console.ReadLine();

        if (inputPassword == password)
        {
            Console.WriteLine("Welcome");
            return;
        }
        Console.WriteLine("Wrong password!");
    }
}