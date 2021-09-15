using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
	public class Product
	{
		double price = 0;
		string name = "";
		public Product(double price, string name)
		{
			this.price = price;
			this.name = name;
			Console.WriteLine("In this little store of mine we sell wigs, tiaras and lipsticks. Everything for that Extravaganza evening.");
			Console.WriteLine("The prices are :"); //Ska det kanske finnas möjlighet att klicka sig till det man vill ha? 
			Console.WriteLine("Wigs - 299SEK");
			Console.WriteLine("Tiara - 799SEK");
			Console.WriteLine("Lipstick - 49SEK");
			Console.WriteLine("Write Wig to add wig to your cart, write Tiara to add tiara to your cart and add lipstick to add lipstick to your cart."); //Hur göra för att kunna lägga till större antal produkter samtidigt?

			//Skapa en lista där kunde kan add stuff to it. 
			//En lista för produkter och en lista för totalkostnad? Se metoder
			List<string> stroller = new List<string>(); //Lista med produkter personen valt.
			List<double> totalCost = new List<double>(); //Total kostnad för alla produkter som personen valt. 

			AddAndShowCart(stroller);
			ProductsAndCosts(double);
			
		}

		public static void AddAndShowCart(List<string> stroller)
		{
			string customerChoice = Console.ReadLine();

			while(true){//Osäker på denna men jag vill kunna välja mer än endast en. Därmed loopa igenom den?
				switch (customerChoice)
				{
					case "Wig":
						stroller.Add("Wig");
						break;
					case "Tiara":
						stroller.Add("Tiara");
						break;
					case "Lipstick":
						stroller.Add("Lipstick");
						break;
					//If done, press xx. annars fortsätt, hur?
					default:
						break;
				}

				Console.WriteLine("In your stroller, there are : " customerChoice.Count);//Här vill jag rabbla upp hur mycket saker som är i kundvagnen av vardera produkt. 
			}
		}
		public static void ProductsAndCosts(List<double> stroller)
        {

			switch (totalCost) //Borde denna vara i samma metod som ovan? Enklare, om wig, lägg till en xx lista och lägg samtidigt till kostnaden i yy lista. 
			{
				case "Wig":
					totalCost.Add(299);
					break;
				case "Tiara":
					totalCost.Add(799);
					break;
				case "Lipstick":
					totalCost.Add(49);
					break;
				//På något sätt skriva om färdig gör xx. 
				default:
					break;
			}
			Console.WriteLine("Totalcost of stuff in stroller: " + totalCost.Sum());
		}

	}
}