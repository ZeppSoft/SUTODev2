using _1_Operators;
using System;

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

            using (var dis = new MyDisposable())
            {
                dis.DoSomething();
                //throw new Exception();
            }
            

            #endregion


            #region Common
            Console.WriteLine("Hit any key to continue...");
            Console.ReadKey();
            #endregion
        }
    }
}
