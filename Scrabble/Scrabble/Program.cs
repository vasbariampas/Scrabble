namespace Scrabble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scrabbleService = new ScrabbleService();
            var player1 = new Player();
            var player2 = new Player();

            scrabbleService.DealSomeLetters(player1);
            scrabbleService.DealSomeLetters(player2);

            Console.Write("Game Started!\n------------\n");
            Console.WriteLine($"Player 1 : {string.Join(",", player1.Rack)}");
            Console.WriteLine($"Player 2 : {string.Join(",", player2.Rack)}");
            Console.ReadLine();
            Console.Write("\nFind the Words\n-----------------\n");
            Console.WriteLine($"Player 1: {string.Join(" ", scrabbleService.FindAllPossibleTwoWords(player1))}");
            Console.WriteLine($"Player 2: {string.Join(" ", scrabbleService.FindAllPossibleTwoWords(player2))}");
            Console.ReadLine();
        }
    }
}
