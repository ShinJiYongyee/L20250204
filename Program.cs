namespace L20250204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int[52];
            for(int i=0; i<array.Length; i++)
            {
                array[i] = i+1;
            }

            Random random = new();

            //Fisher-Yates shuffle
            for (int i = 0; i < 8; i++)
            {
                int randomIndex=random.Next(i,array.Length);
                //tuple을 이용한 swap
                (array[i], array[randomIndex]) = (array[randomIndex], array[i]);
                Console.WriteLine($"{array[i]}");

            }


        }
    }
}
