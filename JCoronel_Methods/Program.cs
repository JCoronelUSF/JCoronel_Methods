namespace JCoronel_Methods
{
    internal class Program
    {
        static int[] rand_array(int array_len)
        {
            Random rand = new Random();
            int[] array = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                array[i] = rand.Next(10, 50);
            }
            return array;
        }
        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer number between 5 and 15");
                int input = int.Parse(Console.ReadLine());
                if(input >= 5 && input <= 15)
                {
                    int[] array = rand_array(input);
                    Console.Write("The elements in the random array are: ");
                    foreach (int i in array)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is : " + sum(array));
                }
                else
                {
                    Console.WriteLine("Please enter an integer number between 5 and 15");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid input");
            }
           
        }
    }
}