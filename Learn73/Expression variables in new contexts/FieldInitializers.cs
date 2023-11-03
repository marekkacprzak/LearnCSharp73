using System;

namespace Learn73.Expression_variables_in_new_contexts
{
    public class FieldInitializers
    {
        public bool InputIsPositiveNumber = int.TryParse(ReadString(), out var input) && input > 0;
        public bool ObjectIsPositiveNumber { get; } = ReadObject() is string str
                                                      && int.TryParse(str, out var input)
                                                      && input > 0;
        public static string ReadString() => Console.ReadLine();
        public static object ReadObject() => Console.ReadLine();
    }
}