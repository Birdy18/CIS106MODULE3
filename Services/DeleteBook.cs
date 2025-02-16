using CIS106MODULE3.Models;
namespace CIS106MODULE3.Services
{
    static class DeleteBook
    {
        /// <summary>
        /// This function deletes the book from the list.
        /// </summary>
        /// <param name="inventory"></param>
        public static void DeleteBookFromInventory(List<Book> inventory)
        {
            List<Book> books = new List<Book>();
            Console.WriteLine("Please type in the ID of the book you want to delete");
            int ID = Convert.ToInt16(Console.ReadLine());
            foreach(Book book in inventory)
            {
                if(ID != book.bookID)
                {
                    Console.WriteLine("Wrong book, please try again");
                    break;
                } else {
                    books.Remove(book);
                    Console.WriteLine(books.Contains(book)); 
                }
            }
        }
    }
}