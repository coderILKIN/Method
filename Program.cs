using System;

namespace new_task3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 10, 4, 8, 20, 32, 2 };

            Console.WriteLine(Max(arr));
        }



        public static int Max(int [] arr)
        {
            
            int maxnumber = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (maxnumber < arr[i])
                {
                    maxnumber = arr[i];

                }
                
            }
            
            return maxnumber;
        }
    }
}
