using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Database
    {
        //Insert Username och password. Hit ska den komma efter att kunde gjort något av val 1 eller 2. 
        //Om användaren valt alt. 1 gör xx.
        //Om användaren valt alt.2 så ska vi kolla ifall den matchar någon av våra existerande kunder. 
        //Här använder vi get,set?

        //klassen "Customer"/"Kund"/"User" ska representera EN kund
        static Customer Knatte = new Customer("Knatte", 12, 500); //Finns 3 olika + en helt ny. 
        static Customer Fnatte = new Customer("Fnatte", 28, 12000);
        static Customer Tjatte = new Customer("Tjatte", 65, 1045293);

        List<Customer> customers = new List<Customer>(); //Här har vi en lista med kunderna sedan och kan lägga till nya och hitta gamla. 

        public static void RegisterNewCustomer()
        {
            //Skapa användarnamn och lösenord. Spara för användning senare. 
            Console.WriteLine("Please enter a username");
            string userName = Console.ReadLine(); //Den här måste vara case sensitive och sparas någonstans på något sätt. Och jämföras? Eller är det overkill? 

            Console.WriteLine("Welcome " + userName + "Now create a password. It must contain both numbers (0-9) and characters (such as !,.?)");
            string password = Console.ReadLine();
            char[] userPassword = password.ToCharArray();

            char[] numbersInPassword = { '0', '1' , '2', '3', '4', '5' , '6', '7', '8' ,'9' };
            //char[] charachtersInPassword = { '!', ',', '.', '?' };

            if (userPassword != (numbersInPassword))//  password.IndexOfAny(charachtersInPassword))//Förklaring av IndexOf.
            {
                Console.WriteLine("The password has to contain a number or charachter.");
            }
            /*else if (password != (charachtersInPassword))
            {
                Console.WriteLine("The password must containe a number or a charachter.";
            }*/
            else
            {
                Console.WriteLine("Great! Now you have a password! Now what do you want to do?");
                //AfterYouveLoggedIn(); //Här vill ju jag gå vidare/ tillbaka till meny 2. 
            }
        }

      //public static void LoginMenu()
      //{
      //    Console.WriteLine("Welcome, please enter your username.");
      //    string username = Console.ReadLine();
      //
      //    Console.WriteLine("Hello, " + username + " Now please enter your password");
      //    string password = Console.ReadLine(); 
      //}
    }
        

}
