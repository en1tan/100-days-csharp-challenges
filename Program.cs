using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray();

            int[] arrayCheck = { 1, 2, 3, 5, 6 };
            Console.WriteLine(myArray.FindMissingNumber(arrayCheck));

        }
    }
}
