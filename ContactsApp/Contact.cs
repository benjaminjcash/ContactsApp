using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
	public class Contact
	{
		string name;
		string phoneNumber;
		string address;

		public Contact(string name, string phoneNumber, string address)
		{
			this.name = name;
			this.phoneNumber = phoneNumber;
			this.address = address;
		}

		public string Name
		{
			get => name;
			set => Name = value;
		}

		public string PhoneNumber
		{
			get => phoneNumber;
			set => phoneNumber = value;
		}
		
		public string Address
		{
			get => address;
			set => address = value;
		}
	}
}
