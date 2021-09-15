using System;

namespace Labb2
{
    class Store
    {
        static void Main(string[] args)
        {
            Product product = new Product(10, "wig");



            //Gör en metod av detta nedanför. 
            Console.WriteLine("What do you want to do? Pick a number.");
            Console.WriteLine("1. Register new customer.");
            Console.WriteLine("2. Login.");

            string userInput = Console.ReadLine(); //Här sparar vi användarens val. 

            switch (userInput) //Här skriver du det som userInput kan välja/trycka. 
            {
                case "1":
                    Console.WriteLine("Welcome new customer!");
                    break;
                case "2":
                    Console.WriteLine("Welcome back!");
                    break;
                default:
                    Console.WriteLine("You have to choose something");
                    break; 
            }
            //Gör en metod av detta nedanför. 
            Console.WriteLine("Next step is to choose what you want to do. Do you want to: ");
            Console.WriteLine("A. Do some shopping.");
            Console.WriteLine("B. Watch you shopping cart.");
            Console.WriteLine("C. Head to the cashier.");

            string menu2 = Console.ReadLine().ToUpper(); //Här gör vi så att om användaren skriver in små bokstäver så väljer den ändå rätt.

            switch (menu2)
            {
                case "A":
                    Console.WriteLine("Let's go to the mall, Today!");
                    break;
                case "B":
                    Console.WriteLine("This is what you've got so far:");
                    break;
                case "C":
                    Console.WriteLine("Bitch better have some money");
                    break;
                default:
                    Console.WriteLine("You have to choose a letter between A, B and C."); //Hur göra för att inte hamna ur konsolen om jag trycker för snabbt? For-loop?
                    break;

            }


        }
       
    }
    
}
