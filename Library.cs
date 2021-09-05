using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookeStore
{
    class Library
    {
        private List<Book> LibraryBooks;

        public Library(List<Book> libraryBooks)
        {
            LibraryBooks = libraryBooks;
        }

        public Library()
        {
            LibraryBooks = new List<Book>();
        }

        internal List<Book> LibraryBooks1 { get => LibraryBooks; set => LibraryBooks = value; }

        public void createNewBook(Book B1)
        {
            this.LibraryBooks1.Add(B1);
        }

        public void removeBook(Book B1)
        {
            this.LibraryBooks1.Remove(B1);
        }

        public Book searchBook(String Title, int BookID)
        {
            foreach(Book B in this.LibraryBooks)
            {
                if(B.BookID1 == BookID)
                {
                    //Search by book ID, return found book
                    return B;
                }else if(B.Title1 == Title)
                {
                    //Search by title, return found book
                    return B;
                }
            }
            //return null if no books are found
            return null;
        }
    }
}
