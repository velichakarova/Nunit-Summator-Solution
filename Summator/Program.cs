namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Summator.Sum(new int[] { 1, 2, 3, 4, 5, 6, });
           if(result == 2)
            {
                Console.WriteLine("Test Pass!");
            }else
            {
                Console.WriteLine("Test Fail!");
            }
        }
    }
}