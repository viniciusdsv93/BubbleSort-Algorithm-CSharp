namespace collections.Helper
{
    public class ArrayOperations
    {
        public void PrintArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }

        public void BubbleSortArray(ref int[] array)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                // for to sort the array
                for (var i = 0; i < array.Length - 1; i++)
                {
                    if (array[i + 1] < array[i])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }

                isSorted = true;
                // for to check if the array is sorted
                for (var i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        isSorted = false;
                    }
                }
            }
        }
    }
}