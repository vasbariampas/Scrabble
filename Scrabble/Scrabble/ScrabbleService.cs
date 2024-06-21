namespace Scrabble
{
    public class ScrabbleService
    {
        private static IDictionary<string, int> PointsLookup;
        private static List<string> AllTwoPossibleWords;
        private static ICollection<string> BagOfLetters = [];
        private static string BlankDetails = "BLANK,2,0";

        public ScrabbleService()
        {
            Initialize();
        }

        private static void Initialize()
        {
            PointsLookup = new Dictionary<string, int>();
            BagOfLetters = [];
            AllTwoPossibleWords = File.ReadAllLines("C:\\Development\\Scrabble\\Scrabble\\Resources\\AllTwoPossibleWords.csv").ToList();

            var scrabbleLetters = File.ReadAllLines("C:\\Development\\Scrabble\\Scrabble\\Resources\\ScrabbleLetters.csv").Skip(1);
            var letters = new List<string>();
            foreach (var row in scrabbleLetters)
            {
                var rowData = row.Split(',');
                PointsLookup.Add(rowData[0].ToLower(), int.Parse(rowData[2]));

                for (var i = 0; i < int.Parse(rowData[1]); i++)
                {
                    letters.Add(rowData[0]);
                }
            }

            Random rng = new Random();
            BagOfLetters = letters.OrderBy(a => rng.Next()).ToList();
        }

        public void DealSomeLetters(Player player)
        {
            var lettersToDeal = BagOfLetters.Take(7).ToList();
            player.Rack = lettersToDeal;
            BagOfLetters = BagOfLetters.Except(lettersToDeal).ToList();
        }

        public List<string> FindAllPossibleTwoWords(Player player)
        {
            var words = new List<string>();

            foreach (var word in AllTwoPossibleWords)
            {
                if(CanCreateWord(word, player.Rack))
                {
                    words.Add(GetWordWithPoints(word));
                }
            }
            return words;
        }

        private static bool CanCreateWord(string word, List<string> letters)
        {
            var lettersFromWord = word.ToCharArray();
            return letters.Contains(lettersFromWord[0].ToString(), StringComparer.CurrentCultureIgnoreCase) && letters.Contains(lettersFromWord[1].ToString(), StringComparer.CurrentCultureIgnoreCase);
        }

        private static string GetWordWithPoints(string word)
        {
            var points = 0;
            foreach (var letter in word.ToCharArray())
            {
                points += PointsLookup[letter.ToString()];
            }
            return $"{word} ({points})";
        }
    }
}
