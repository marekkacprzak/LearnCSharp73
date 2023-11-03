using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn73.Expression_variables_in_new_contexts
{
    public class QueryClauses
    {
        public void Test()
        {
            var enumerable = new List<string>{"-3", "2"};
            // Works:
            var result= from str in enumerable
                where int.TryParse(str, out var number) && number > 0
                select str;

                Console.WriteLine(string.Join(" ",result.ToArray()));
// Doesn't work:
            // var b=  from str in enumerable
            //     where int.TryParse(str, out var number) && number > 0
            //     select new 
            //     {
            //         A = str, 
            //         B = number // "number" is not available in this scope
            //     };
        }
    }
}