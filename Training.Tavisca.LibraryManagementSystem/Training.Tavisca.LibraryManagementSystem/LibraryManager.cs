using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Tavisca.LibraryManagementSystem
{
    public class LibraryManager
    {

        List<Book> books;
        public LibraryManager()
        {
            books = new List<Book>();

        }
        public void IssueBook(Book Bible)
        {
            books.Add(Bible);

        }
        public int NumberOfBookIssued()
        {
            int count = books.Count();
            return count;
        }
        public List<Book> ListOfBookIssued()
        {
            return books;
        }
       public  Book CheckBookIsPresent(string name)
        {
            foreach(Book book  in books)
            {
                if (book.Name == name)
                    return book;
            }


            return null;



        }
        public void RemoveBook(Book name)
        {
            books.Remove(name);





        }






    }
}
