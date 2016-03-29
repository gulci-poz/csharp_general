using System;

namespace csharp_lang
{
    class Program_02
    {
        static int Main_02(string[] args)
        {
            // przechwytujemy kod wyjścia w osobnym pliku .bat po wyjściu z programu

            Console.WriteLine("returning exit code -1");
            Console.ReadLine();
            return -1;
        }
    }
}
