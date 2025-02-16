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
        AddInventory.AddToInventoryList(bookList);
        DisplayInventory.CreateInventoryList(bookList);
        break;
    case 2:
        DisplayInventory.CreateInventoryList(bookList);
        break;
    case 3:
        IDInventory.ViewInventoryByID(bookList);
        break;
    case 4:
        DeleteBook.DeleteBookFromInventory(bookList);
        DisplayInventory.CreateInventoryList(bookList);
        break;
    case 5:
        Console.WriteLine("Have a good day!");
        break;
    default:
        Console.WriteLine("That is not an option, please try again!");
        break;
}