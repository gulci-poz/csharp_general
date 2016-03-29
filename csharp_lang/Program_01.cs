using System;
using System.Diagnostics;

namespace csharp_lang
{
    class Program_01
    {
        // zwracanie int lub void, argument args lub bez argumentu
        // void return - zwracany jest kod 0

        static void Main_01(string[] args)
        {
            Console.WriteLine("Hello, World! From C#.");

            // dostęp do kodu wyjścia uruchomionego procesu
            // w Windows kod wyjścia aplikacji jest przechowywany w zmiennej %ERRORLEVEL%
            // programistycznie korzystamy z klasy Process w System.Diagnostics (właściwość ExitCode)

            Process notepad = Process.Start("notepad.exe");

            do
            {
                Console.WriteLine("notepad running");
            }
            while (!notepad.WaitForExit(1000));

            Console.WriteLine("notepad exit code: " + notepad.ExitCode);

            Console.ReadLine();
        }
    }
}
