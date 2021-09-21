using System;

public class Customer
{
	private string _userName = "";//Eller är det de här som ska vara fält?
	private string _password = "";
	private long _wallet; 
	public Customer(string userName, string password, long wallet)//Det här är en metod med en konstruktor som inte returnerar något. 
	{
		_userName = userName;
		_password = password; 
		_wallet = wallet; //Förtydling på this. saken.  This används för att urskilja fält och varibler.
	}

	//Här har niklas satt en property. En propfull. Hans upplägg ser också annorlunda ut än den nedan. 17min in i filmen. 
	public string UserName {get { return _userName; } } //Förtydling på vad dessa gör och varför vi inte skriver set någonstans? Kolla hans beskrivning.Står inte likadant. 
	//I filmen 18.46 så går han igenom en som jag typ fattar men inte kan applicera. 
	public string Password { get { return _password; } }//Jag har nu gjort dessa till fält. Varför? Product funkade bra utan fält? 
	public long Wallet { get { return _wallet; } set { _wallet = value; } } //I filmen på 21 min så säger han att det här underlättar för att jag inte behöver ändra på
																			//flera ställen utan det räcker med det här stället så ändras överallt automatiskt. (Ex.istället för lång if-sats)
	//Här vill han ha in en ToString() som skriver ut namn, lösenord och kundvagn. Men jag har inte kundvagnen här. I en override? 
}	