using System;
namespace Labb2
{
	public class Customer
	{
		private string _userName = "";
		private string _password = "";
		private long _wallet;
		public Customer(string userName, string password, long wallet)
		{
			_userName = userName;
			_password = password;
			_wallet = wallet; 
		}

		public string UserName { get { return _userName; } } 

		public string Password { get { return _password; } }
		public long Wallet { get { return _wallet; } set { _wallet = value; } }

		public override string ToString()
		{
			return $"Username: {_userName} \nPassword: {_password} \nIn your cart:  {Store.GetStroller()} .";
		}
	}
}