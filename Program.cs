using System;

namespace InverseHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(reverseString("Hello World!"));

            System.Console.ReadKey();
        }

        static string reverseString(string original)
        {
            int cnt = (int)(original.Length / 2);
            char[] array = original.ToCharArray();

            for (int i = 0; i < cnt; i++)
            {
                int j = original.Length - 1 - i;
                char temp = array[i];

                array[i] = array[j];
                array[j] = temp;
            }

            original = new string(array);
            System.Console.WriteLine(cnt);
            return original;       
            
            
        }
    }
}
