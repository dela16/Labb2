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
        static Customer knatte = new Customer("Knatte","123", 500); //Finns 3 olika + en helt ny. 
        static Customer fnatte = new Customer("Fnatte","321", 12000);
        static Customer tjatte = new Customer("Tjatte", "213", 1045293); //Varför lägger vi inte dessa i store classen också om alla metoder ska kunna nå den också? 

        static List<Customer> customers = new List<Customer>(); //Här har vi en lista med kunderna sedan och kan lägga till nya och hitta gamla. 

        public Database()
        {
            customers.Add(knatte);
            customers.Add(fnatte);
            customers.Add(tjatte);
        }
         public bool ValidateCredientials(string username, string password) //En sant/falskt metod.
        {
            foreach(Customer customer in customers)
            {
                if (customer.UserName == username && customer.Password == password) //username kommer från readline i store, hittar den en knatte så hoppar den in i nästa if. Där kollar den efter rätt lösen också.
                {
                    return true; 
                }
            }
            return false; 
        }

        public void RegisterNewCustomer(string username, string password, long wallet) 
        {
            Customer newCustomer = new Customer(username, password, wallet); //Här registreras kunden till databasen. Se store classen för koppling. 
            customers.Add(newCustomer);
            Console.WriteLine("Registration successfull.");
        }

        public Customer GetCustomer(string username) //Första Customer betyder vad du returnerar. Bool på rad 29 betyder att du returnerar den. 
        {
            foreach (Customer customer in customers)
            {
                if (customer.UserName == username) 
                {
                    return customer;
                }
            }
            return null;
        }
    }
}
