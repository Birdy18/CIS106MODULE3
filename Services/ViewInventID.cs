using CIS106MODULE3.Models;
namespace CIS106MODULE3.Services
{
    static class IDInventory
    {
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