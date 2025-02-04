using System.Reflection.Metadata.Ecma335;

namespace L20250204
{
    internal class Program
    {
        static string[] MakeDeck(string[] deck)
        {
            int[] index = new int[52];
            Random random = new Random();

            for (int i = 0; i < index.Length; i++)
            {
                index[i] = i + 1;
            }

            for (int i = 0; i < index.Length; i++)
            {
                int randomNumber = random.Next(i, 52);
                (index[i], index[randomNumber]) = (index[randomNumber], index[i]);
            }

            for (int i = 0; i < deck.Length; i++)
            {

                deck[i] = TrumpSuit(index[i]) + " " + Numbering(index[i]);
            }
            return deck;
        }
        static string Numbering(int a)
        {
            if (a%13 == 1)
            {
                return "A";
            }
            else if (a%13 == 11)
            {
                return "J";
            }
            else if(a%13 == 12)
            {
                return "Q";
            }
            else if(a %13 == 0)
            {
                return "K";
            }
            else
            {
                return $"{a%13}";
            }
        }

        static string TrumpSuit(int a) 
        {
            if (a < 14&&a>0)
            {
                return "heart";
            }
            else if( a < 27&&a>13 )
            {
                return "diamond";
            }
            else if( a < 40&&a>26)
            {
                return "clover";
            }
            else if(a < 53 && a > 39)
            {
                return "spade";
            }
            else
            {
                return " ";
            }
        }
        static void Print(string[] deck, int number)
        {

            for(int i = 0;i < number; i++)
            {
                Console.WriteLine(deck[i]);
            }
        }
        static void Main(string[] args)
        {

            //1 -> 13 : heart (1 : A / 11 : J, 12 : Q, 13 : K)
            //14 -> 26 : diamond
            //27 -> 39 : clover
            //40 -> 52 : spade

            string[] deck = new string[52];

            MakeDeck(deck);

            Print(deck, 8);

        }
    }
}
