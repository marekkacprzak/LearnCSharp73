using System;

namespace Learn73.stackallocTest
{
    public class StackallocRef72
    {
        public void M(int size)
        {
            var span = size <= 128 ? stackalloc byte[size] : new byte[size];
            // ...
            span = stackalloc byte[128];
        }

        public void UnsafeTest()
        {
            unsafe
            {
                int* pArr = stackalloc int[5] {1, 4, 9, 16, 25};
                int* pArr2 = stackalloc int[] {1, 2, 4, 8};
                float* pArr3 = stackalloc float[] {1.1F, 3.2F, 43.7F};
            }
        }
    }
}