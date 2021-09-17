using System;

namespace _5._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);
        }

        static void Echo(string phrase, int deep)
        {
            string modife = phrase;
            if (modife.Length > 2)
            {
                modife = modife.Remove(0,2);
            }

            Console.WriteLine("... " + modife);

            if (deep > 1)
            {
                Echo(modife, deep - 1);
            }
        }
    }
}
