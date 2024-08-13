public class Program
{
    static void Main()
    {
        var squaresToGrass = double.Parse(Console.ReadLine());
        var priceWithVat = squaresToGrass * 7.61;
        var discount = priceWithVat * 0.18;

        var finalPriceWithDiscount = priceWithVat - discount;

        Console.WriteLine($"The final price is: {finalPriceWithDiscount} lv.");
        Console.WriteLine($"The discount is: {discount} lv.");
    }
}
