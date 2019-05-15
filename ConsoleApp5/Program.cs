using System;

namespace ConsoleApp5
{
    enum Colors { red, orange, yellow, green, blue, indigo, violet };
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 30);

            Console.WriteLine("Hello. What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("And your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Welcome, {firstName} {lastName}.");

            Console.WriteLine($"Now, {firstName}, how old are you?");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            if(age <=0)
            {
                Console.WriteLine("I don't think that's right. Try again.");
            }
            
            
            Console.WriteLine($"And what month were you born in, {firstName}? Please use the number of the month (i.e. 1-12)");
            string monthInput = Console.ReadLine();
            int month = Convert.ToInt32(monthInput);

            Console.WriteLine($"Moving on, what is your favorite color? ROYGBIV only, please (if you are unsure, type \"help\"");
            string answer = Console.ReadLine();
            if (answer) { }
            string color = Console.ReadLine();

            Console.WriteLine("And finally, how many siblings do you have?");
            string siblingInput = Console.ReadLine();
            int siblingCount = Convert.ToInt32(siblingInput);

            Console.WriteLine($"Now then, {firstName}, I will use my otherworldly powers to divine your future!\n");
            if (age % 2 == 0)
            {
                Console.WriteLine("I see that you will retire comfortably in 15 years!");
            }else{
                Console.WriteLine("You will never be able to retire, I'm afraid.");
            }
            Console.WriteLine("\n");

            if (siblingCount == 0)
            {
                Console.WriteLine("You will have a nice vacation home in Aspen.");
            }
            if (siblingCount == 1)
            {
                Console.WriteLine("You will own a lovely summer cottage on the Isle of Wight.");
            }
            if (siblingCount == 2) {
                Console.WriteLine("You will purchase a lavish beach house in Los Angeles!");
            }
            if (siblingCount == 3) 
            {
                Console.WriteLine("The only summer home you'll be able to afford is a shack just off the New Jersey Turnpike");
            }
            if (siblingCount >= 4)
            {
                Console.WriteLine("You won't need a summer home as you'll be living in Honolulu!");
            }
            if (siblingCount <= 0)
            {
                Console.WriteLine("You'll be banished to Siberia for your insolence!");
            }


        }
    }
}