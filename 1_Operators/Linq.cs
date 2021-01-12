using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Operators
{
    public static class Linq
    {
        public static void SimpleFrom()
        {
            var array = new int []  {1,2,3,4 };

            //first variant pure LINQ
            // var query = from arrElement in array where arrElement % 2 == 0 select arrElement;

            //second variant: Extention method
            //var query = array.Where(x => x % 2 == 0);


            //1st variant
            //var query = array.OrderBy(x => x);
            //var query = array.OrderByDescending(x => x);

            //2nd variant
            //var query = from el in array orderby el select el; 


            var query = array.Skip(3).Take(2);


            Console.WriteLine(string.Join(", ",query.ToArray()));
        }
    }
}
