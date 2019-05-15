using System;

namespace ConsoleApp5
{
    enum Colors { red, orange, yellow, green, blue, indigo, violet };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("And your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Welcome, {firstName} {lastName}.");

            Console.WriteLine($"Now, {firstName}, how old are you?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            if(age >=0)
            {
                
            }
            
            Console.WriteLine($"And what month where you born in, {firstName}?");

            Console.WriteLine($"Moving on, what is your favorite color? ROYGBIV only, please");
            string color = Console.ReadLine();

            Console.WriteLine($"Now then, {firstName}, I will use my otherworldly powers to divine your future!");
            Console.WriteLine($"\nplaceholder");
            

        }
    }
}
