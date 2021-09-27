using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Database
    {

        static Customer knatte = new Customer("Knatte","123", 500);
        static Customer fnatte = new Customer("Fnatte","321", 12000);
        static Customer tjatte = new Customer("Tjatte", "213", 1045293); 

        static List<Customer> customers = new List<Customer>(); 

        public Database()
        {
            customers.Add(knatte);
            customers.Add(fnatte);
            customers.Add(tjatte);
        }
         public bool ValidateCredientials(string username, string password) 
        {
            foreach(Customer customer in customers)
            {
                if (customer.UserName == username && customer.Password == password) //username kommer från readline i store, hittar den en knatte så hoppar den in i if-satsen. Där kollar den efter rätt lösen också.
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

        public Customer GetCustomer(string username)
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
