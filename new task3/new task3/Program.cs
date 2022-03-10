using System;

namespace new_task3
{
    class Program
    {
        static void Main(string[] args)
        {


            
            
        }



          static void Max(string[] ary)
        {
            int[] arr = { 10, 4, 8, 20, 32, 2 };
            int maxnumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>maxnumber)
                {
                    maxnumber = arr[i];

                }

            }

            Console.WriteLine(maxnumber);
        }
    }
}
