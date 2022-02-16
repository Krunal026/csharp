//example of passing array to method

using System;

namespace passing
{
    class @passingarray
    {
        static void Main()
        {
            int[] created = new int[4];
            created[0] = 1;
            created[1] = 2;
            created[2] = 3;
            created[3] = 4;

            CreateArray(created);

        }

        static void CreateArray(int[] array)
        {
            for (int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[2]);

            }
        }
    }
}
