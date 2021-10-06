using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisetada eesnime
            //programm küsib kasutajal sisetada perekonnanime
            //programm kuvab, mitu "a" tähte kasutaja eesnimjes ja perekonnanimess kokku on
            int Counter = 0;
            // "a"
            Console.WriteLine("Enter firstname:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter lastname:");
            string lastName = Console.ReadLine();
            string fullName = $"{firstName}{lastName}".ToLower();
            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'a')
                {
                    Counter++; //counter = counter + 1
                }

            }
            if (Counter == 1)
            {
                Console.WriteLine($"You have {Counter} 'a' letter in your name");
            }
            else
            {
                Console.WriteLine($"You have {Counter} 'a' letters in your name");
            }
        }
    }
}
