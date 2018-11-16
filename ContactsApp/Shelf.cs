using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ContactsApp
{
    static class Shelf
    {

        static public void AddContactBook()
        {
			Console.WriteLine("Please write a name for the contact book:");
			string name = Console.ReadLine();
            try
            {
                string connStr = "server=localhost;user=root;database=contacts;port=3306;password=root";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO contact_books (name) VALUE ('" + name + "');";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
        }

        static public int ChooseContactBook()
        {
			Console.WriteLine("Which book would you like to open?");
			Console.WriteLine("=====================================================================");

			try
            {
                string connStr = "server=localhost;user=root;database=contacts;port=3306;password=root";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
				MySqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "SELECT * FROM contact_books;";
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("{0}. {1}", rdr.GetInt32(0), rdr.GetString(1));
                    Console.WriteLine("---------------------------------------------------------------------");
                }
                rdr.Close();
				conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }

			string input = Console.ReadLine();
            int selection = Convert.ToInt32(input);
            return selection; 
        }

    }
}
