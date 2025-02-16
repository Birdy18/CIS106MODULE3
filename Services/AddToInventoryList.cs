using CIS106MODULE3.Models;
namespace CIS106MODULE3.Services
{
    static class AddInventory
    {
        /// <summary>
        /// This function adds books to the list of books currently in the system.
        /// </summary>
        /// <param name="bookList"></param>
        public static void AddToInventoryList(List<Book> bookList)
        {
            List<Book> books = new List<Book>();
            Console.WriteLine("What is the name of the book?");
            string? title = Console.ReadLine();
            Console.WriteLine("What is the author's name?");
            string? author = Console.ReadLine();
            Console.WriteLine("What is the book's genre?");
            string? genre = Console.ReadLine();
            Console.WriteLine("What is the book's ID?");
            int ID = Convert.ToInt16(Console.ReadLine());
            Book newBook = new Book
            {
                bookTitle = title,
                authorName = author,
                bookGenre = genre,
                bookID = ID,
            };
            books.Add(newBook);
        }
    }
}