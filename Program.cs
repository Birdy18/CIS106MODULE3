using CIS106MODULE3.Models;
using CIS106MODULE3.Services;

List<Book> bookList = new List<Book>
{
    new() 
    {
        bookTitle = "C & B Torture",
        authorName = "Charmy Bee",
        bookGenre = "Education",
        bookID = 2233
    },

    new()
    {
        bookTitle = "How to Date a Skyscraper",
        authorName = "Horn E. Mann",
        bookGenre = "Romance/Slasher",
        bookID = 5432
    }
};

Console.WriteLine("Welcome to the Library, how can we help you?");
Console.WriteLine("[1] Add a Book");
Console.WriteLine("[2] View All Inventory");
Console.WriteLine("[3] View Book by ID");
Console.WriteLine("[4] Delete Book by ID");
Console.WriteLine("[5] Exit");
int choice;
choice = Convert.ToInt16(Console.ReadLine());
switch(choice)
{
    case 1:
        Book_Manager.AddToInventoryList(bookList);
        Book_Manager.CreateInventoryList(bookList);
        break;
    case 2:
        Book_Manager.CreateInventoryList(bookList);
        break;
    case 3:
        Book_Manager.ViewInventoryByID(bookList);
        break;
    case 4:
        Book_Manager.DeleteBookFromInventory(bookList);
        Book_Manager.CreateInventoryList(bookList);
        break;
    case 5:
        Console.WriteLine("Have a good day!");
        break;
    default:
        Console.WriteLine("That is not an option, please try again!");
        break;
}