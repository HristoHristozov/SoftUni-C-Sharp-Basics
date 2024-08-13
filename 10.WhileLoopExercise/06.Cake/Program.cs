using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeAllPieces = cakeWidth * cakeLenght;

            int sumTakenPieces = 0;

            while (cakeAllPieces > sumTakenPieces)
            {

                string input = Console.ReadLine();
                int currentPiece;

                if (input == "STOP")
                {
                    break;
                }
                else
                {
                    currentPiece = int.Parse(input);
                    sumTakenPieces += currentPiece;
                }
            }
            if (cakeAllPieces >= sumTakenPieces)
            {
                int remainingPieces = cakeAllPieces - sumTakenPieces;
                Console.WriteLine($"{remainingPieces} pieces are left.");
            }
            else
            {
                int piecesMore = Math.Abs(cakeAllPieces - sumTakenPieces);
                Console.WriteLine($"No more cake left! You need {piecesMore} pieces more.");
            }
        }
    }
}
