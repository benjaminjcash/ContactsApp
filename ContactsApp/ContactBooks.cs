using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    class ContactBooks
    {
        public ContactBooks()
        {
            Books = new List<ContactBook>();
        }

        public void AddContactBook(ContactBook book)
        {
            Books.Add(book);
        }

        public ContactBook ChooseContactBook()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i, Books[i].Name);
                Console.WriteLine("---------------------------------------------------------------------");
            }
            string selection = Console.ReadLine();
            return Books[Int32.Parse(selection)];

        }

        public List<ContactBook> Books { get; }
    }
}
