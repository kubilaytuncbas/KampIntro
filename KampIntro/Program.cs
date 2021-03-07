using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] kurslar = new string[] { "yazılım geliştirici", "programlamaya başlangıç", "java", "pyhton", "c#" };
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
