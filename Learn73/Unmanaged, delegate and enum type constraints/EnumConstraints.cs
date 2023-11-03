using System;
using System.Collections.Generic;

namespace Learn73.Unmanaged__delegate_and_enum_type_constraints
{
    public class EnumConstraints
    {
        public static IEnumerable<string> GetValues<T>()
            where T : struct, System.Enum
        {
            var enumType = typeof(T);
            var items = Enum.GetValues(enumType);
            foreach (var item in items)
            {
                yield return Enum.GetName(enumType, item);
            }
        }
    }
}