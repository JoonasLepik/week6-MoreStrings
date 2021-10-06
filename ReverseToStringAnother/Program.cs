using System;

namespace ReverseToStringAnother
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm kuvab lausest "Hello, World" targurpidi
            string HelloW = "Hello, World!";
            for (int i = HelloW.Length - 1; i >= 0; i--)
            {
               Console.Write(HelloW[i]); 
            }
            
        }
    }
}
