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

        static Product wig = new Product(299, "Wig"); //Här blir Product en datatyp (som string) men är en class. I classfilen så står vad som behöver finnas med i konstruktorn. 
                                                      //I classen product har du skrivit att den ska ha ett pris och ett namn. Fyll i den i den ordningen. 
                                                      //Vi hade detta som en lista innan men ändrade om för just nu, this made more sence. 
        static Product tiara = new Product(799, "Tiara");
        static Product lipstick = new Product(49, "Lipstick");
        static List<Product> stroller = new List<Product>(); //Lista med produkter personen valt. Den här lägger vi här uppe för att den behöver nås av alla metoder. 
        //Varför skriver vi static?
        //Alla kunder finns i classen Database. Snyggare med mindre kod. 
        

        static void Main(string[] args)
        {
            //Product product = new Product(10, "wig");
            LoginChoices(); //Här gör jag en metod för switchen nedanför. Val 1. 
            AfterYouveLoggedin(); //Metod för menyval 2. Kom på ett bättre namn. 
           

        }
        static void LoginChoices()
        {
            Console.WriteLine("What do you want to do? Pick a number.");
            Console.WriteLine("1. Register new customer.");
            Console.WriteLine("2. Login.");

            string userInput = Console.ReadLine(); //Här sparar vi användarens val. 

            switch (userInput) //Här skriver du det som userInput kan välja/trycka. 
            {
                case "1":
                    Console.WriteLine("Welcome new customer!");
                    RegisterNewCustomer();
                    break;
                case "2":
                    Console.WriteLine("Welcome back!");
                    LoginMenu();
                    break;
                default:
                    Console.WriteLine("You have to choose something");
                    break;
            }
        }

        private static void AfterYouveLoggedin()
        {
           // Console.Clear(); //Vi clearar consolen för att få kortare kod. Funkar ej. 
            Console.WriteLine("Next step is to choose what you want to do. Do you want to: ");
            Console.WriteLine("A. Do some shopping.");
            Console.WriteLine("B. Watch you shopping cart.");
            Console.WriteLine("C. Head to the cashier.");

            string menu2 = Console.ReadLine().ToUpper(); //Här gör vi så att om användaren skriver in små bokstäver så väljer den ändå rätt.

            switch (menu2)
            {
                case "A":
                    Console.WriteLine("Let's go to the mall, Today!");
                    ShoppingTime();
                    break;
                case "B":
                    Console.WriteLine("This is what you've got so far:");
                    WatchCart();
                    break;
                case "C":
                    Console.WriteLine("Bitch better have some money");
                    CheckOut(); 
                    break;
                default:
                    Console.WriteLine("You have to choose a letter between A, B and C."); //Hur göra för att inte hamna ur konsolen om jag trycker för snabbt? For-loop?
                    break;

            }

        }

        private static void ShoppingTime()
        {
            Console.WriteLine("In this little store of mine we sell wigs, tiaras and lipsticks. Everything for that Extravaganza evening.");
            Console.WriteLine("The prices are :"); //Ska det kanske finnas möjlighet att klicka sig till det man vill ha? 
            Console.WriteLine("Wigs - 299SEK");
            Console.WriteLine("Tiara - 799SEK");
            Console.WriteLine("Lipstick - 49SEK");
            //Hur göra för att kunna lägga till större antal produkter samtidigt?


            //Skapa en lista där kunde kan add stuff to it. 
            //Borde det vara en int för varje produkt. Int wigCosts = 299; So when you add it you can concat. 
            //Detsamma vid produkter, enklare att concatinera? 
            //"You've added " + produkt + "to the shopping cart. Your total sum is increased with " + productCost + "SEK." 
            //Men hur göra? 
            //En lista för produkter och en lista för totalkostnad? Se metoder. INgen lista för totalkostnad. Du vill ha en summa, inte alla. 

            AddToCart();

        }
        private static void AddToCart()
        {

            Console.WriteLine("For wig, choose 1. For tiara, choose 2. For Lipstick, choose 3. Press enter to stop shopping");
            string customerChoice = Console.ReadLine();


            //Osäker på denna men jag vill kunna välja mer än endast en. Därmed loopa igenom den?
                switch (customerChoice)
                {
                    case "1":
                        stroller.Add(wig);
                        //totalCost.Add(wigCost); Den här behöver inte vara med här eftersom totalkostnaden endast behöver visas i kundvagnen. 
                        Console.WriteLine("You've added a wig to your shopping cart.");
                        AddToCart(); //Med hjälp av denna kör vi vidare i shoppingrundan tills vi trycker enter en sista gång.
                        break;
                    case "2":
                        stroller.Add(tiara);
                        //totalCost.Add(tiaraCost);
                        Console.WriteLine("You've added a tiara to your shopping cart.");
                        AddToCart();
                        break;
                    case "3":
                        stroller.Add(lipstick);
                        //totalCost.Add(lipstickCost);
                        Console.WriteLine("You've added a lipstick to your shopping cart.");
                        AddToCart();
                        break;
                    default:
                    Console.WriteLine("Great, You'll find all the products, costs and total costs in your shoppingcart.");
                    AfterYouveLoggedin();
                    break;
                }
            


        }

        private static double GetTotalCost() //Bort med void för vi returnerar. När vet jag att jag ska returnera något? 
        {
            double totalCost = 0;
            foreach (Product product in stroller)
            {
                totalCost += product.Price;
            }
            return totalCost;
        }
        private static void WatchCart()
        {
            
            foreach (Product product in stroller)
            {
                Console.WriteLine(product.Name + " Which costs "  + product.Price + " SEK."); 
            }
            Console.WriteLine("The total cost of it all is " + GetTotalCost()); //Vi sätter den utanför loopen för jag vill endast skriva ut det slutgiltiga värdet. 

            Console.WriteLine("Do you want to keep on shopping or go back to menu? Press 1 for shopping and 2 for menu. ");
            string customerMenuChoice = Console.ReadLine();
            if (customerMenuChoice == "1")
            {
                ShoppingTime();
            }
            else if (customerMenuChoice == "2")
            {
                AfterYouveLoggedin();
            }

            AfterYouveLoggedin();
            //Jag måste kunna gå tillbaka till kassan och meny2 igen. 
            //Det du kan göra sen är att få datorn att skriva ut antalet på en rad än flera rader med en produkt. Ex. 3 wigs. 
        }

        private static void CheckOut()
        {
            double bitcoinConverter = GetTotalCost()/ 314000;
            double shibacoinConverter = (float)GetTotalCost() / 0.00006678F;

            Console.WriteLine("You've bought for " + GetTotalCost() + "SEK, which is also " + bitcoinConverter + " Bitcoins and " + shibacoinConverter + " Shibacoins. ");
            Console.WriteLine("");

        }

        //Vad hända efter kassan? Skapa plånboksvariabel som drar pengar?
    }

}
