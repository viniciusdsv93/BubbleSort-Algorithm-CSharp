using collections.Helper;

namespace collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayOperations helper = new ArrayOperations();
            int[] array = new int[] { 85, 74, 20, 36, 2, 96, 14 };

            System.Console.WriteLine("Original Array:");
            helper.PrintArray(array);
            helper.BubbleSortArray(ref array);
            System.Console.WriteLine("Sorted Array:");
            helper.PrintArray(array);
        }
    }
}