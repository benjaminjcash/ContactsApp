using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ContactsApp
{
    static class Menu
    {
        static public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to CONTACTS-LIST Application! What would you like to do?");
            Console.WriteLine("=====================================================================");
            Console.WriteLine("0. Home");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("1. Create a new book");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("2. Open an existing book");
            Console.WriteLine("---------------------------------------------------------------------");

            string selection = Console.ReadLine();
            switch (selection)
            {
                case "0":
                    MainMenu();
                    return;
                case "1":
                    Console.Clear();
                    Shelf.AddContactBook();
                    break;
                case "2":
					Console.Clear();
					int selectionId = Shelf.ChooseContactBook();
					BookMenu(selectionId);
					return;
            }
            Console.Clear();
            MainMenu();
        }

		static public void BookMenu(int selectionId)
		{
			// query database with id to locate chosen book, obtain name
			string bookName = "";
			string connStr = "server=localhost;user=root;database=contacts;port=3306;password=root";
			MySqlConnection conn = new MySqlConnection(connStr);
			conn.Open();
			MySqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT name FROM contact_books WHERE id=" + selectionId;
			MySqlDataReader rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{
				Console.WriteLine("Name: " + rdr.GetString(0)); // should be name of chosen contact book
				bookName = rdr.GetString(0);
			}
			rdr.Close();
			conn.Close();

			// display menu for chosen contact book
			Console.Clear();
			Console.WriteLine("Welcome to the book menu for {0}! What would you like to do?", bookName);
			Console.WriteLine("=====================================================================");
			Console.WriteLine("0. Home");
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("1. List Contacts");
			Console.WriteLine("---------------------------------------------------------------------");
			Console.WriteLine("2. Add a Contact");
			Console.WriteLine("---------------------------------------------------------------------");

			string selection = Console.ReadLine();
			switch (selection)
			{
				case "0":
					MainMenu();
					return;
				case "1":
					Console.Clear();
					ContactBook.PrintContacts(selectionId);
					Console.WriteLine("Press enter to continue..");
					Console.ReadLine();
					break;
				case "2":
					Console.Clear();
					ContactBook.AddContact(selectionId);
					break;
			}
		}
	}
}
