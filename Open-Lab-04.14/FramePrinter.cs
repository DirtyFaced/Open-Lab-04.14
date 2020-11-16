using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int maxdlzka = 0;
            int nowdlzka = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length > maxdlzka)
                {
                    maxdlzka = strings[i].Length;
                }
            }
            for (int ii = 0; ii < maxdlzka + 3; ii++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
            for (int iii = 0; iii < strings.Length; iii++)
            {
                nowdlzka = maxdlzka - strings[iii].Length;
                Console.Write("* " + strings[iii]);
                for (int iiii = 0; iiii < nowdlzka; iiii++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" *");
            }
            for (int ii = 0; ii < maxdlzka + 3; ii++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
}