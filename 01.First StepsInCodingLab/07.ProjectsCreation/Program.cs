public class Program
{
    static void Main()
    {
        var architectName = Console.ReadLine();
        var projectsNumber = int.Parse(Console.ReadLine());
        int hoursToComplete = projectsNumber * 3;
        Console.WriteLine($"The architect {architectName} will need {hoursToComplete} hours to complete {projectsNumber} project/s.");
    }
}
