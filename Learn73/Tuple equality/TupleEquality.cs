using System;

namespace Learn73.Tuple_equality
{
    public class TupleEquality
    {
        public void Test()
        {
            var tuple1 = (name: "Jason", isEmployee: false);
            var tuple2 = (name: "Jason", isEmployee: false);
// Before C# 7.3
            if (tuple1.name == tuple2.name && tuple1.isEmployee == tuple2.isEmployee)
            {
                // ...
            }
// With C# 7.3
            if (tuple1 == tuple2)
            {
                // ...
            }
        }

        public void Test2()
        {
            (int a, int b) = (10, 20);
           
            int x = 15;
            int y = 21;
            if ((x, y) == (a, b))
            {
                Console.WriteLine("The tuples are equal.");
            }
            else
            {
                Console.WriteLine("The tuples are not equal.");
            }
        }
    }
}