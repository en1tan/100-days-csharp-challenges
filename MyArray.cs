using System;

namespace Learning
{
    class MyArray
    {
        public int FindMissingNumber(int[] arrayValue)
        {
            int total = (arrayValue.Length + 1) * (arrayValue.Length + 2) / 2;

            for (int i = 0; i < arrayValue.Length; i++)
            {
                total -= arrayValue[i];
            }
            return total;
        }
    }
}