﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ContactsApp
{
	class Program
	{
		static void Main(string[] args)
		{
            ContactBooks shelf = new ContactBooks();
            Menu.MainMenu(shelf);
        }
	}
}
