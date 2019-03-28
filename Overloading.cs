using System;
namespace Overloading
{
    public class overloadingExample
    {
        public int Add(int a)
        {
            return a + 3;
        }
        public int Add(out int a)
        {
            a = 30;
            return a + 3;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int[,] Add(int[,] a, int[,] b)
        {
            int[,] temp = new int[2, 2];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    temp[i, j] = a[i, j] + b[i, j];
            return temp;
        }
        public string Add(int a, int b, string msg)
        {
            return "a * b is " + (a + b) + " " + msg;
        }
        public static void Main()
        {
            overloadingExample obj = new overloadingExample();
            int a = 10, b = 2;
            int[,] mat1 = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] mat2 = new int[,] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("Addition of a and 3 is: {0}", obj.Add(a));
            Console.WriteLine("Addition of a and 3 is(out): {0}", obj.Add(out a));
            Console.WriteLine("Addition of a and b is: {0}", obj.Add(a, b));
            int[,] mat3 = new int[2, 2];
            mat3 = obj.Add(mat1, mat2);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(mat3[i, j] + " ");


            Console.WriteLine("Addition with Message is: {0}", obj.Add(a, b, "Append Last"));
        }
    }
}