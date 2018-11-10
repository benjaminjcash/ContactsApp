﻿using System;
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

        static public void AddContactBook(ContactBook book)
        {
            string name = book.Name;
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
            try
            {
                string connStr = "server=localhost;user=root;database=contacts;port=3306;password=root";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string sql = "SELECT * FROM contact_books;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("{0}. {1}", rdr.GetInt32(0), rdr.GetString(1));
                    Console.WriteLine("---------------------------------------------------------------------");
                }
                rdr.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }

            int selection = Convert.ToInt32(Console.ReadLine());
            return selection; 
        }

    }
}
