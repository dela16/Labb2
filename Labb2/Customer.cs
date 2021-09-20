using System;

public class Customer
{
	string name;
	int age;
	long wallet; 
	public Customer(string name, int age, long wallet)
	{
		this.name = name;
		this.age = age;
		this.wallet = wallet; //Förtydling på this. saken.  
	}
}
