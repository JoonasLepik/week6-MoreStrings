using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kuvab mitu h, o ja l on lauses "Hello, World!"
            string helloW = "Hello, World!".ToLower();
            int counter = 0;
            int counter2 = 0;
            int counter3 = 0;
            for (int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == 'h')
                {
                    counter++;
                }
                else if (helloW[i] == 'o')
                {
                    counter2++;
                }
                else if (helloW[i] == 'l')
                {
                    counter3++;
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine($"{helloW} has {counter} 'h' , {counter2} 'o' and {counter3} 'l'");
            Console.ReadLine();
        }
    }
}
