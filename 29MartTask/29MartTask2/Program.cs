using System;

namespace _29MartTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student student = new Student("A203", "Seymur Mustafayev");
            Console.WriteLine(student.Fullname);
        }
    }
}
