using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your name?");
            var nameOfUsers = Console.ReadLine();
            Console.WriteLine($"Excellent, thanks for that, {nameOfUsers}");            
        }
    }
}
