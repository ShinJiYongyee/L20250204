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
            int[] newArray=new int[8];

            Random random = new Random();

            //Fisher-Yates shuffle
            for (int i = 0; i < newArray.Length; i++)
            {
                int randomIndex=random.Next(i,array.Length);
                newArray[i] = array[randomIndex];

                int temp=array[randomIndex];
                array[randomIndex]=array[i];
                array[i]=temp;
            }

            //print
            for (int i = 0;i < 8; i++)
            {
                Console.WriteLine($"{newArray[i]}");
            }
        }
    }
}
