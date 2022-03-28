using System;

namespace _29MartTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = "hello world";
             Console.WriteLine(str.ToCapitalize());
            foreach (var item in str.GetValueIndexes('l'))
            {
                Console.WriteLine(item);
            }
        }
    }
}
