
namespace CIS106MODULE3.Models {
    /// <summary>
    /// Class for Books, regarding their parameters and functions
    /// </summary>
    class Book
    {
        public string? bookTitle{get; set;}
        public string? authorName{get; set;}
        public string? bookGenre{get; set;} 
        public int bookID{get; set;}

        internal Book ToString(string? title)
        {
            throw new NotImplementedException();
        }
    }
}