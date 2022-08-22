using System;

namespace arraytest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 45, 56, 2, 8, 9, 46, 90,898 };
            int temp= arr[0];
            int t2=0;
            for (int i = 1; i < arr.Length; i++)
            {
                if ( arr[i] > temp )
                {
                    if ( temp> t2 )
                    {
                        t2 = temp;
                    }
                   
                    temp = arr[i];
                }
            }
            Console.WriteLine("second largest number: {0}", t2);
            Console.ReadLine();

        }
    }
}
