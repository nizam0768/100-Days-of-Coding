class Program
{
    static void Main(string[] args)
    {
        int n = 9;
        int temp = 0;
        int[] permutationArray = new int[n];
        for(int i = 0; i < n; i++)
        {
            permutationArray[i] = ++temp;
            //Console.WriteLine(permutationArray[i]);
        }
        
        
        int[] arr = { 1, 2, 3, 5, 4, 7, 8, 9 };
        Array.Sort(arr);
        for(int i = 0; i < n; i++)
        {
           bool found = false;
            for(int j = 0; j < arr.Length; j++)
            {
                if (permutationArray[i] == arr[j])
                {
                    found = true;
                    break;
                }
            }        
            if(!found) 
            {
                Console.WriteLine(permutationArray[i]);
            }
        }
        
       
    }
}