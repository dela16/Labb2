using System;
using System.Collections.Generic;

namespace Labb2 
{ 

    class Store
    {

        static Product wig = new Product(299, "Wig");
                                                     
        static Product tiara = new Product(799, "Tiara");
        static Product lipstick = new Product(49, "Lipstick");

        static List<Product> stroller = new List<Product>();  

        static Database database = new Database();
        static Customer currentCustomer; 

        static void Main(string[] args)
        {
            LoginChoices(); 
            ShowLoggedInMenu(); 


        }
        static void LoginChoices()
        {
            Console.WriteLine("What do you want to do? Pick a number.");
            Console.WriteLine("1. Register new customer.");
            Console.WriteLine("2. Login.");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Welcome new customer!");
                    RegisterNewCustomer();
                    break;
                case "2":
                    LoginMenu();
                    break;
                default:
                    Console.WriteLine("You have to choose something");
                    break;
            }
        }
        public static void RegisterNewCustomer()
        {
            Console.WriteLine("Please enter a username");
            string userName = Console.ReadLine();

            Console.WriteLine("Welcome " + userName + " Now create a password. ");
            string password = Console.ReadLine();
            
            Console.WriteLine("How much money do you have in your wallet?");
            long wallet = long.Parse(Console.ReadLine());

            database.RegisterNewCustomer(userName, password, wallet);

        }

        private static void LoginMenu()
                                       //Här vill han att endast lösen ska skrivas om, spelar det roll? Egen metod för lösen?
        { 
            Console.WriteLine("Welcome, please enter your username.");
            string username = Console.ReadLine();

            Console.WriteLine("Hello, " + username + " Now please enter your password");
            string password = Console.ReadLine();


            bool doesTheUserExist = database.ValidateCredientials(username, password);
            if (doesTheUserExist == true)
            {
                currentCustomer = database.GetCustomer(username);
                ShowLoggedInMenu();
            }

            Console.WriteLine("Wrong login information. If you do not have an account, please register as a new customer.");
            LoginChoices();
        }


        private static void ShowLoggedInMenu()
        {
            Console.WriteLine("What do you want to do?");
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
                    Console.WriteLine("You have to choose a letter between A, B and C.");
                    break;
            }

        }

        private static void ShoppingTime()
        {
            Console.WriteLine("In this little store of mine we sell wigs, tiaras and lipsticks. Everything for that Extravaganza evening.");
            Console.WriteLine("The prices are :"); 
            Console.WriteLine("Wigs - 299SEK");
            Console.WriteLine("Tiara - 799SEK");
            Console.WriteLine("Lipstick - 49SEK");

            AddToCart();

        }
        private static void AddToCart()
        {

            Console.WriteLine("For wig, choose 1. For tiara, choose 2. For Lipstick, choose 3. Press 4 to stop shopping");
            string customerChoice = Console.ReadLine();

                switch (customerChoice)
                {
                    case "1":
                        stroller.Add(wig);
                        Console.WriteLine("You've added a wig to your shopping cart.");
                        AddToCart(); 
                        break;
                    case "2":
                        stroller.Add(tiara);
                        Console.WriteLine("You've added a tiara to your shopping cart.");
                        AddToCart();
                        break;
                    case "3":
                        stroller.Add(lipstick);
                        Console.WriteLine("You've added a lipstick to your shopping cart.");
                        AddToCart();
                        break;
                    default:
                    Console.WriteLine("Great, You'll find all the products, costs and total costs in your shoppingcart.");
                    ShowLoggedInMenu();
                    break;
                }

        }

        private static double GetTotalCost()
        {
            double totalCost = 0;
            foreach (Product product in stroller)
            {
                totalCost += product._Price;
            }
            return totalCost;
        }
        private static void WatchCart()
        {
            
            foreach (Product product in stroller)
            {
                Console.WriteLine(product._Name + " Which costs "  + product._Price + " SEK."); 
            }
            Console.Write("The total cost of it all is ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(GetTotalCost()); //Vi sätter den utanför loopen för jag vill endast skriva ut det slutgiltiga värdet. 
            Console.ResetColor(); 

            Console.WriteLine("\nDo you want to continue shopping or go back to menu? Press 1 for shopping and 2 for menu. ");
            string customerMenuChoice = Console.ReadLine();
            if (customerMenuChoice == "1")
            {
                ShoppingTime();
            }
            else if (customerMenuChoice == "2")
            {
                ShowLoggedInMenu();
            }
            ShowLoggedInMenu();
        }

        public static string GetStroller()
        {
            string productString = "";
            foreach (Product product in stroller)
            {
                productString += " "+ product._Name;
            }
            return productString;
        }

        private static void CheckOut()
        {
            double bitcoinConverter = GetTotalCost()/ 314000;
            double shibacoinConverter = (float)GetTotalCost() / 0.00006678F;
            long customerWallet = currentCustomer.Wallet; 

            Console.WriteLine("You've bought for " + GetTotalCost() + "SEK, which is also " + bitcoinConverter + " Bitcoins and " + shibacoinConverter + " Shibacoins. ");
            Console.WriteLine("Time to pay!");


            Console.WriteLine("You have " + (customerWallet - GetTotalCost()) + " SEK left. ");
            Console.WriteLine("Do you want to continue shopping, watch your ToString() or log out? Press 1 for shopping, 2 for ToString() or 3 for logging out.");

            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                ShowLoggedInMenu();
            }
            else if( userInput== "2")
            {
                Console.WriteLine(currentCustomer.ToString());
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Thank you, come back again");
                LoginChoices();
            }


        }

    }

}
