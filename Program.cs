using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what's your name?");
            var nameOfUsers = Console.ReadLine();
            Console.WriteLine($"Excellent, thanks for that. From now on I'll call you {nameOfUsers}");            
            Console.WriteLine("Is there anything I can help you with?");
            var whatTheUserWouldLikeHelpWith = Console.ReadLine();
        }
    }
}
