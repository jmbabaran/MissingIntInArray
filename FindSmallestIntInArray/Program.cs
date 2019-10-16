using System;

namespace FindSmallestIntInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 3, 6, 4, 0, 2}; //output 5

            //int[] a = { 0, 10, 2,-10, -20 }; // output 1
            //int[] a = { 2, 3, -7, 6, 8, 1, -10, 15 }; // output 4
            int[] a = { 1, 1, 0, -1, -2 };// Outputt 2
            int result = 100000; //get max input 10000
            bool isInArray;
            for (var i = 0; i < a.Length; i++)
            {
                var temp = a[i] + 1;
                isInArray = false;
                for (var j = 0; j < a.Length; j++)
                {
                    if (temp == a[j])
                    {
                        isInArray = true;
                        break;
                    }
                }

                if (!isInArray && temp > 0 && temp < result)
                {
                    result = temp;
                }


            }
 

            Console.WriteLine("Result: " + result);
        }
    }
}
