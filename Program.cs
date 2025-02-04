namespace L20250204
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new();

            //확률 10퍼센트 가챠 메커니즘
            for (int i = 0; i < 10; i++) 
            {
                int gacha=random.Next(0,100);

                if (gacha <= 9)
                {
                    Console.WriteLine("픽업 성공");
                }
                else 
                {
                    Console.WriteLine("꽝");
                }
            }

        }
    }
}
