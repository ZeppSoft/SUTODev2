using System;

namespace _1_Operators
{
    public static class Operators
    {
        public static void ArrayTest()
        {
            int[] arr = { 3, 2, 1 };

            Console.WriteLine(arr[0]);

            arr = null;
            Console.WriteLine(arr?[0]);

           var t = arr?.GetEnumerator();
        }
        public static void GetArrayLastElement()
        {

            int[] arr = { 1, 2, 3, 4 };


            Console.WriteLine(arr[^1]);
        }
    }
}
