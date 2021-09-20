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


    }
        

}
