﻿namespace Methods
{
    class Program
    {
        private static string GetGreetingMessage(string name, double salary)
        {
            return "Hello, " + name + ", your salary is " + (int)Math.Ceiling(salary);
        }
        public static void Main()
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
        }
    }
}

   