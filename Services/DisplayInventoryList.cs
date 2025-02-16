using CIS106MODULE3.Models;
namespace CIS106MODULE3.Services
{
    static class DisplayInventory
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
    }
}