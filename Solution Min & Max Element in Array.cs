class Program
{
    static void Main(string[] args)
    {
       
        
        int[] arr = { 5, 9, 2, 1, 3 };
        int min = arr[0];
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            
            int currElement = arr[i];
            if (arr[i] < min)
            {
                swap(ref min, ref currElement);
            }
            if (arr[i] > max)
            {
                swap(ref max, ref currElement);
            }

        }
        Console.WriteLine( min);
        Console.WriteLine(max);
        void swap(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }
        
       
    }
}