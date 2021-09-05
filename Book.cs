using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookeStore
{
    class Book
    {

        private String Title;
        private String Author;
        private String Genre;
        private int AgeRating;
        private int YearReleased;
        private int BookID;
        private int Quantity;

        public Book(string title, string author, string genre, int ageRating, int yearReleased, int bookID, int quantity)
        {
            Title1 = title;
            Author1 = author;
            Genre1 = genre;
            AgeRating1 = ageRating;
            YearReleased1 = yearReleased;
            BookID1 = bookID;
            Quantity1 = quantity;
        }

        public string Title1 { get => Title; set => Title = value; }
        public string Author1 { get => Author; set => Author = value; }
        public string Genre1 { get => Genre; set => Genre = value; }
        public int AgeRating1 { get => AgeRating; set => AgeRating = value; }
        public int YearReleased1 { get => YearReleased; set => YearReleased = value; }
        public int BookID1 { get => BookID; set => BookID = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
    }
}
