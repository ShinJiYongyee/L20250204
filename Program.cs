using System.Reflection.Metadata.Ecma335;

namespace L20250204
{
    internal class Program
    {
        //블랙잭
        //ai와 플레이어가 카드 3장씩을 뽑아
        //점수가 높은 쪽이 승리

        static int Score(int a)
        {
            //A = 11
            //2~10 = 2~10
            //J, K, Q = 10
            switch (a % 13)
            {
                case 1:
                    return 11;  //A
                case 11:
                    return 10;  //J
                case 12:
                    return 10;  //Q
                case 0:
                    return 10;  //K
                default:
                    return a%13;   //2~9
            }
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
        static void Print(int[] deckScore, int[] deckName)
        {
            int computerScore=deckScore[0]+deckScore[1]+deckScore[2];
            int playerScore = deckScore[3] + deckScore[4]+deckScore[5];


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(TrumpSuit(deckName[i]) + " " + Numbering(deckName[i]) + " "+ deckScore[i]);

            }

            Console.WriteLine($"computerScore: {computerScore}");
            Console.WriteLine($"playerScore: {playerScore}");
            if (computerScore > playerScore)
            {
                Console.WriteLine("computer win!");
            }
            else 
            {
                Console.WriteLine("player win!");
            }


        }
        static int[] MakeDeck(int[] deckScore, int[] deckName)
        {
            Random random = new Random();

            for (int i = 0; i < deckName.Length; i++)
            {
                deckName[i] = i + 1;
            }

            for (int i = 0; i < deckName.Length; i++)
            {
                int randomNumber = random.Next(i, 52);
                (deckName[i], deckName[randomNumber]) = (deckName[randomNumber], deckName[i]);
            }

            for (int i = 0; i < deckScore.Length; i++)
            {
                deckScore[i] = Score(deckName[i]);
            }
            return deckName;
        }

        static void Main(string[] args)
        {

            //1 -> 13 : heart (1 : A / 11 : J, 12 : Q, 13 : K)
            //14 -> 26 : diamond
            //27 -> 39 : clover
            //40 -> 52 : spade

            int[] deckScore = new int[52];
            int[] deckName = new int[52];

            MakeDeck(deckScore, deckName);

            Print(deckScore, deckName);

        }
    }
}
