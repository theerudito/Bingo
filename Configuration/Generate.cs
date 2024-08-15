using Bingo.Model;

namespace Bingo.Configuration
{
    public class Generate
    {
        public static List<Card> GenerateNumbers(int card, int num, string _title)
        {
            List<Card> cards = new List<Card>();

            for (int i = 0; i < card; i++)
            {
                Card c = new Card();
                c.IdCard = i + 1;
                c.Bingo = "BINGO";
                c.City = _title;
                c.Developer = "Hecho por Between Byte Software";
                c.Phone = "0960806054";
                c.Data = GenerateCard(card, num);
                cards.Add(c);
            }

            return cards;
        }

        private static List<string> GenerateCard(int card, int num)
        {
            List<string> data = new List<string>();
            HashSet<int> usedNumbers = new HashSet<int>();
            var random = new Random();

            for (int i = 0; i < num - 1; i++)
            {
                int number;
                do
                {
                    number = random.Next(1 + (i % 5) * 15, 16 + (i % 5) * 15);
                } while (usedNumbers.Contains(number));
                usedNumbers.Add(number);
                data.Add(number.ToString());
            }

            data.Insert(12, "X");

            return data;
        }
    }
}