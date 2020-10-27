using _1_Operators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SUTODev2
{
    public class MyDisposable : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose completed.");
        }

        public void DoSomething()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            #region 1_Operators
            //Operators.ArrayTest();
            //Operators.GetArrayLastElement();
            #endregion
            #region 4_Intefaces
            /*var dis = new MyDisposable();

            try
            {
                dis.DoSomething();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                dis.Dispose();
            }*/

            //Correct approach
            /*
            using (var dis = new MyDisposable())
            {
                dis.DoSomething();
                //throw new Exception();
            }*/


            #endregion

            #region 5_InternalCollections

            /*var l = new List<int>() { 4, 5, 6 };
            var i = l as IEnumerable<int>;

            var enumerator = i.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }*/

            /*
            //Comparing of two equal arrays by content
            var arr = new int[]{1,2,9};
            var arr2 = new int[] { 1, 2, 9 };

            Console.WriteLine(arr.SequenceEqual(arr2));*/

            //Can we resize the regular array?

            var arr = new int[10];
            arr[0] = 1;
            arr[1] = 2;
            Console.WriteLine(arr.Length);
            Array.Resize(ref arr, 15);
            Console.WriteLine(arr.Length);





            #endregion


            #region Common
            Console.WriteLine("Hit any key to continue...");
            Console.ReadKey();
            #endregion
        }
    }
}
