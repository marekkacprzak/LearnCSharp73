using System; 
using System.Drawing; 
using Learn73.Expression_variables_in_new_contexts;
using Learn73.stackallocTest;
using Learn73.Tuple_equality;
using Learn73.Unmanaged__delegate_and_enum_type_constraints;

namespace Learn73
{
    public static class StartPoint
    {  
          static void Main()
        {
            //2
            var testConstructorInitializers = new ConstructorInitializers("2");
            var testFieldInitializers = new FieldInitializers().ObjectIsPositiveNumber;
            new QueryClauses().Test();
            //3
            Ref_local_re_assignment.RefLocalReAssignment.Example();
            //4
            var testUnsafe=new StackallocRef72();
            testUnsafe.M(40);
            testUnsafe.UnsafeTest();
            //5
            var testTuple = new TupleEquality();
            testTuple.Test();
            testTuple.Test2();
            //6
            new DelegateConstaints().Test();

            foreach (var colour in EnumConstraints.GetValues<KnownColor>())
            {
                Console.WriteLine($"kolor: {colour}");
            }
        }
         
    }
}