using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            //intsiaalid lõpevad punkiga
            // nt: Harry Potter ---> H. P.
            Console.WriteLine("Please enter your firstname:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine($"Greetings {firstname[0]}. {lastname[0]}.");


           
        }
    }
}
