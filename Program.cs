using System;

namespace MultipleGreetings
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user how many times they want to be greeted
            Console.WriteLine("How many times would you like to be greeted?");
            var numGreets = Int32.Parse(Console.ReadLine());
            
            //Use while conditional to display the message the amount of time user chooses until it reaches 0. 
            while (numGreets > 0) {
                Console.WriteLine("Hello!");
                numGreets --;
            }
        }
    }
}
