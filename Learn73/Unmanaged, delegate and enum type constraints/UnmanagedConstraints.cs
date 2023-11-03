using System;

namespace Learn73.Unmanaged__delegate_and_enum_type_constraints
{
    public class UnmanagedConstraints
    {
        public class MyList<T> where T : unmanaged
        {
            public void Copy(T[] source, T[] destination)
            {
                unsafe
                {
                    fixed (T* src = source, dst = destination)
                    {
                        Buffer.MemoryCopy(src, dst, sizeof(T) * source.Length, sizeof(T) * source.Length);
                    }
                }
            }
        }
    }
}