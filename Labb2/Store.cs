using System;
using System.Collections.Generic;

namespace Labb2
{
    //class Database //Det här ska vara en egen fil. vill att en klass ska vara typ som en metod vilket är fel. 
    //{
    //    List<Customer> customerList = new List<Customer>;
    //
    //    public void AddCustomer(Customer customer)
    //    {
    //        customerlist.Add(customer);
    //    }
    //}
    class Store
    {
       /* static void RegisterNewCustomer()
        {
           // Database database = new Database();
           // Console.WriteLine("Whats your name?");
           // string name = Console.ReadLine();
           // Console.WriteLine("Whats your age?");
           // string age = Console.ReadLine();
           //
           // Customer customer = new Customer(name, int.Parse(age));
           //
           // database.AddCustomer(customer);

        }*/
        static void Main(string[] args)
        {
            //Product product = new Product(10, "wig");
            loginChoices(); //Här gör jag en metod för switchen nedanför. Val 1. 
            afterYouveLoggedin(); //Metod för menyval 2. Kom på ett bättre namn. 
            shoppingTime(); 
        }
        static void loginChoices()
        {
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
        }

        private static void afterYouveLoggedin()
        {
            Console.Clear(); //Vi clearar consolen för att få kortare kod. Funkar ej. 
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

        private static void shoppingTime()
        {
            Console.WriteLine("In this little store of mine we sell wigs, tiaras and lipsticks. Everything for that Extravaganza evening.");
            Console.WriteLine("The prices are :"); //Ska det kanske finnas möjlighet att klicka sig till det man vill ha? 
            Console.WriteLine("Wigs - 299SEK");
            Console.WriteLine("Tiara - 799SEK");
            Console.WriteLine("Lipstick - 49SEK");
            Console.WriteLine("Write Wig to add wig to your cart, write Tiara to add tiara to your cart and add lipstick to add lipstick to your cart."); //Hur göra för att kunna lägga till större antal produkter samtidigt?

            Product wig = new Product(299, "Wig"); //Här blir Product en datatyp (som string) men är en class. I classfilen så står vad som behöver finnas med i konstruktorn. 
                                                   //I classen product har du skrivit att den ska ha ett pris och ett namn. 
            Product tiara = new Product(799, "Tiara");
            Product lipstick = new Product(49, "Lipstick");




            //Skapa en lista där kunde kan add stuff to it. 
            //Borde det vara en int för varje produkt. Int wigCosts = 299; So when you add it you can concat. 
            //Detsamma vid produkter, enklare att concatinera? 
            //"You've added " + produkt + "to the shopping cart. Your total sum is increased with " + productCost + "SEK." 
            //Men hur göra? 
            //En lista för produkter och en lista för totalkostnad? Se metoder
            List<Product> stroller = new List<Product>(); //Lista med produkter personen valt.
            List<double> totalCost = new List<double>(); //Total kostnad för alla produkter som personen valt. 

            AddAndShowCart(stroller);


        }
        private static void AddAndShowCart(List<string> stroller)
        {
            double totalCost = 0;

            Console.WriteLine("For wig, choose 1. For tiara, choose 2. For Lipstick, choose 3");
            string customerChoice = Console.ReadLine();

            while (true)
            {//Osäker på denna men jag vill kunna välja mer än endast en. Därmed loopa igenom den?
                switch (customerChoice)
                {
                    case "1":
                        stroller.Add("Wig");
                        totalCost.Add(wigCost); 
                        Console.WriteLine("You've added a wig to your shopping cart. Your total sum is increased with " + wigCost + "SEK.");
                        break;
                    case "2":
                        stroller.Add("Tiara");
                        totalCost.Add(tiaraCost);
                        Console.WriteLine("You've added a tiara to your shopping cart. Your total sum is increased with " + wigCost + "SEK.");
                        break;
                    case "3":
                        stroller.Add("Lipstick");
                        totalCost.Add(lipstickCost);
                        Console.WriteLine("You've added a lipstick to your shopping cart. Your total sum is increased with " + lipstickCost + "SEK.");
                        break;
                    //If done, press xx. annars fortsätt, hur?
                    default:
                        break;
                }

                Console.WriteLine("In your stroller, there are : " customerChoice.Count);//Här vill jag rabbla upp hur mycket saker som är i kundvagnen av vardera produkt. 
            }
        }

    }

}
