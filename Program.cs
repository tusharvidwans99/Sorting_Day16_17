namespace MergeSort_Day16_17
{

    /// <summary>
    /// this is the driver method in which i'm calling the merge method.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {

            int[] ints = new int[] { 55, 76, 23, 98, 32, 1, 0, 43, 56 };
            MergeSort1 mergeSort = new MergeSort1();

            Console.WriteLine("Before Merge Sort: ");
            mergeSort.printArray(ints);
            int[] sorted= mergeSort.mergeSort(ints);
            Console.WriteLine("After Merger sort");
            mergeSort.printArray(sorted);
        }

        
    }
}