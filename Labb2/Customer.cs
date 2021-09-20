using System;

public class Customer
{
	string name = "";
	long wallet; 
	public Customer(string name, long wallet)
	{
		this.name = name;
		this.wallet = wallet; //Förtydling på this. saken.  
	}

	public string Name { get { return name; } } //Förtydling på vad dessa gör och varför vi inte skriver set någonstans? Kolla hans beskrivning.Står inte likadant. 
	public long Wallet { get { return wallet; } } 
}
