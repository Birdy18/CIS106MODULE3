using CIS106MODULE3.Models;
namespace CIS106MODULE3.Services
{
    static class Book_Manager
    {
        public static void CreateInventoryList(List<Book> inventory)
        {
            foreach(Book parameters in inventory)
            {
                Console.WriteLine($"Title: {parameters.bookTitle}");
                Console.WriteLine($"Author: {parameters.authorName}");
                Console.WriteLine($"Genre: {parameters.bookGenre}");
                Console.WriteLine($"ID: {parameters.bookID}");
                break;
            }
        }

        public static void AddToInventoryList(List<Book> inventory)
        {
            Console.WriteLine("What is the name of the book?");
            string? title = Console.ReadLine();
            Console.WriteLine("What is the author's name?");
            string? author = Console.ReadLine();
            Console.WriteLine("What is the book's genre?");
            string? genre = Console.ReadLine();
            Console.WriteLine("What is the book's ID?");
            int ID = Convert.ToInt16(Console.ReadLine());
            Book addBook = new Book
            {
                bookTitle = title,
                authorName = author,
                bookGenre = genre,
                bookID = ID
            };
            inventory.Add(addBook);
        }

        public static void DeleteBookFromInventory(List<Book> inventory)
        {
            Console.WriteLine("Please type in the ID of the book you want to delete");
            int ID = Convert.ToInt16(Console.ReadLine());
            foreach(Book book in inventory)
            {
                if(ID != book.bookID)
                {
                    Console.WriteLine("Wrong book, please try again");
                    break;
                } else {
                    inventory.Remove(book);
                    Console.WriteLine(inventory.Contains(book)); 
                }
            }
        }

        public static void ViewInventoryByID(List<Book> inventory)
        {
            Console.WriteLine("Please type in the ID of the book you need: ");
            int ID = Convert.ToInt16(Console.ReadLine());
            foreach(Book book in inventory)
            {
                if(ID != book.bookID)
                {
                    Console.WriteLine("Wrong book, please try again");
                    break;
                } else {
                    Console.WriteLine($"ID: {book.bookID}");
                    Console.WriteLine($"Title: {book.bookTitle}");
                    Console.WriteLine($"Author: {book.authorName}");
                    Console.WriteLine($"Genre: {book.bookGenre}");
                    break;
                }
            }
        }
    }
}