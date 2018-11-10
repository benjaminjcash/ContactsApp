using System;
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

            try
            {
                // creates tables
                string connStr = "server=localhost;user=root;database=contacts;port=3306;password=root";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS contact_books (ID INTEGER NOT NULL AUTO_INCREMENT,name TEXT NOT NULL,PRIMARY KEY(ID));CREATE TABLE IF NOT EXISTS contacts(ID INTEGER NOT NULL AUTO_INCREMENT,name TEXT NOT NULL,phone_number TEXT NOT NULL,books_id INTEGER NOT NULL,PRIMARY KEY (ID),FOREIGN KEY (books_id) REFERENCES contact_books(ID));";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }

            Menu.MainMenu();
        }
	}
}
