using System;

namespace first.assignment
{
    public class Book
    {
        public string title;
        public string author;
        public string ISBN;


        public void ReadBook()
        {
            Console.WriteLine("This book is readable. ");
        }

        public void ShelveBook()
        {
            Console.WriteLine("This book has been shelved ");
        }
    }



    public class Program
    {
       public static void Main()
        {
            Book _book = new Book();

            _book.title = "How you can be led by the Holy spirit";
            _book.author = "Kenneth Hagin";
            _book.ISBN = "F978-0-448-48423-6";

            _book.ReadBook();
            Console.WriteLine("Title: {0}\nAuthor: {1}\nISBN: {2}", _book.title, _book.author, _book.ISBN);

          

            Book _book2 = new Book();

            _book2.title = "The theory about C#";
            _book2.author = "Obafemi Damilare";
            _book2.ISBN = "D124-422-4323-2";

            _book.ShelveBook();
            Console.WriteLine("Title: {0}\nAuthor: {1}\nISBN: {2}", _book2.title, _book2.author, _book2.ISBN);
        }
    }
}
