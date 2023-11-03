using System;

namespace Learn73.Unmanaged__delegate_and_enum_type_constraints
{
    public class DelegateConstaints
    {
        public static TDelegate Combine<TDelegate>(TDelegate source, TDelegate target)
            where TDelegate : Delegate
        {
            return (TDelegate)Delegate.Combine(source, target);
        }

        public void Test()
        {
            // Example 1
            void Hello() => Console.WriteLine("Hello");
            Action world = () => Console.WriteLine("World");
            var helloWorld = Combine(Hello, world);
        }
    }
}