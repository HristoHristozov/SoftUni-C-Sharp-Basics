public class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();
        double side = double.Parse(Console.ReadLine());

        if (figure == "square")
        {
            double squareArea = side * side;
            Console.WriteLine("{0:F3}", squareArea);
        }

        else if (figure == "rectangle")
        {
            double rectangleSide = double.Parse(Console.ReadLine());
            double rectangleArea = side * rectangleSide;
            Console.WriteLine("{0:F3}", rectangleArea);
        }

        else if (figure == "circle")
        {
            double circleArea = Math.PI * (side * side);
            Console.WriteLine("{0:F3}", circleArea);
        }

        else if (figure == "triangle")
        {
            double triangleHeight = double.Parse(Console.ReadLine());
            double triangleArea = (side * triangleHeight) / 2;
            Console.WriteLine("{0:F3}", triangleArea);
        }
    }
}