using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookeStore
{
    public partial class Form1 : Form
    {
        //cerates a list of books
        Library L1 = new Library();

        int BookID = 0;
        

        int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            //starter book to show in driver program
            Book book1 = new Book("The Hobbit", "J. R. R. Tolkien", "Fantasy", 13, 1937, BookID, 10);
            BookID++;
            Book book2 = new Book("The Silmarillion", "J. R. R. Tolkien", "Fantasy", 13, 1977, BookID, 10);
            BookID++;

            //wouldnt let me add outside of the method
            L1.LibraryBooks1.Add(book1);
            L1.LibraryBooks1.Add(book2);

            //shows first book in list
            titleBox.Text = L1.LibraryBooks1[0].Title1;
            authorBox.Text = L1.LibraryBooks1[0].Author1;
            genreBox.Text = L1.LibraryBooks1[0].Genre1;
            ageRatingBox.Text = L1.LibraryBooks1[0].AgeRating1.ToString();
            yearReleasedBox.Text = L1.LibraryBooks1[0].YearReleased1.ToString();
            BookIDNumberBox.Text = L1.LibraryBooks1[0].BookID1.ToString();
            quantityBox.Text = L1.LibraryBooks1[0].Quantity1.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createBookButton_Click(object sender, EventArgs e)
        {

            String tempTitle = titleBox.Text;
            String tempAuthor = authorBox.Text;
            String tempGenre = genreBox.Text;
            int tempAge = Int32.Parse(ageRatingBox.Text);
            int tempYear = Int32.Parse(yearReleasedBox.Text);
            int bookID = BookID;
            BookID++;

            Book Temp = new Book(tempTitle, tempAuthor, tempGenre, tempAge, tempYear, bookID, 10);
            L1.createNewBook(Temp);

        }

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            L1.LibraryBooks1[currentIndex].Title1 = titleBox.Text;
            L1.LibraryBooks1[currentIndex].Author1 = authorBox.Text;
            L1.LibraryBooks1[currentIndex].Genre1 = genreBox.Text;
            L1.LibraryBooks1[currentIndex].AgeRating1 = Int32.Parse(ageRatingBox.Text);
            L1.LibraryBooks1[currentIndex].YearReleased1 = Int32.Parse(yearReleasedBox.Text);

            //Restocking by updating quantity
            L1.LibraryBooks1[currentIndex].Quantity1 = Int32.Parse(quantityBox.Text);
        }

        private void nextBookButton_Click(object sender, EventArgs e)
        {
            //incrimenting the index of book list
            currentIndex++;
            Console.WriteLine("Next Index start:" + currentIndex);
            //Starts back at the beginning if at end of list
            if (currentIndex >= L1.LibraryBooks1.Count)
            {
                currentIndex = 0;
            }
            else if(currentIndex < 0)
            {
                currentIndex = 1;
            }
            //getting the next book info for form
            Book Temp = L1.LibraryBooks1[currentIndex];

            Console.WriteLine("Next Index end:" + currentIndex);
            //grabing property values from book object
            titleBox.Text = Temp.Title1;
            authorBox.Text = Temp.Author1;
            genreBox.Text = Temp.Genre1;
            ageRatingBox.Text = Temp.AgeRating1.ToString();
            yearReleasedBox.Text = Temp.YearReleased1.ToString();
            BookIDNumberBox.Text = Temp.BookID1.ToString();
            quantityBox.Text = Temp.Quantity1.ToString();

        }

        private void previousBookButton_Click(object sender, EventArgs e)
        {
            //decrimenting the index of book list
            currentIndex--;
            //Starts back at the end if at beginning of list
            if (currentIndex < 0 )
            {
                currentIndex = L1.LibraryBooks1.Count-1;
            }
            else if(currentIndex >= L1.LibraryBooks1.Count)
            {
                currentIndex = L1.LibraryBooks1.Count - 2;
            }
            //getting the next book info for form
            Book Temp = L1.LibraryBooks1[currentIndex];

            //grabing property values from book object
            titleBox.Text = Temp.Title1;
            authorBox.Text = Temp.Author1;
            genreBox.Text = Temp.Genre1;
            ageRatingBox.Text = Temp.AgeRating1.ToString();
            yearReleasedBox.Text = Temp.YearReleased1.ToString();
            BookIDNumberBox.Text = Temp.BookID1.ToString();
            quantityBox.Text = Temp.Quantity1.ToString();
        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            //Clears fields and sets counter back to 0
            titleBox.Text = "";
            authorBox.Text = "";
            genreBox.Text = "";
            ageRatingBox.Text = "";
            yearReleasedBox.Text = "";
            BookIDNumberBox.Text = "";
            quantityBox.Text = "";

            currentIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book temp = L1.LibraryBooks1[currentIndex];
            L1.removeBook(temp);
        }

        private void SeachBookButton_Click(object sender, EventArgs e)
        {
            int BookIDSearch;
            try
            {
                BookIDSearch = Int32.Parse(SearchBookIDNumberBox.Text);
            }
            catch
            {
                BookIDSearch = -2;
            }
            
            String TitleSearch = SearchTitleBox.Text;
            Book BSearch = L1.searchBook(TitleSearch, BookIDSearch);
            if(BSearch == null)
            {
                //clears fields if no book is found
                titleBox.Text = "";
                authorBox.Text = "";
                genreBox.Text = "";
                ageRatingBox.Text = "";
                yearReleasedBox.Text = "";
                BookIDNumberBox.Text = "";
                quantityBox.Text = "";

                currentIndex = -1;
                MessageBox.Show("No book found");
            }
            else
            {
                //populates fields if book is found
                titleBox.Text = BSearch.Title1;
                authorBox.Text = BSearch.Author1;
                genreBox.Text = BSearch.Genre1;
                ageRatingBox.Text = BSearch.AgeRating1.ToString();
                yearReleasedBox.Text = BSearch.YearReleased1.ToString();
                BookIDNumberBox.Text = BSearch.BookID1.ToString();
                quantityBox.Text = BSearch.Quantity1.ToString();
            }


        }
    }
}
