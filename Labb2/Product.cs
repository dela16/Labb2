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
			
		}
		public double _Price { get { return price; }} 
		public string _Name { get { return name; }}
	}
}