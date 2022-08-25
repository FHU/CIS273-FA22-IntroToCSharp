using System;

namespace IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "";

            Console.WriteLine("Enter your name: " );
            //name = Console.ReadLine();

            Console.WriteLine($"Hello {name}!");

            //Console.WriteLine("my favorite class is CIS 273!");

            Console.WriteLine();

            int i = 10;
            foo(ref i);
            Console.WriteLine(i);

            string s = "kenan casey";
            bar(ref s);
            Console.WriteLine(s);

            Student student = new Student();


        }

        static void foo(ref int a)
        {
            a = a * 2;
        }

        static void bar(ref string s)
        {
            s = s.Replace(" ", "");
        }
    }
}
