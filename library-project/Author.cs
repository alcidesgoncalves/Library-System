namespace Library
{
    public class Author
    {
        public string Name {get; set;} 
        public string? Nationality {get; set;}  
        public List<Book> Books {get; set;} 
         
        public Author(string name, string? nationality)
        {
            Name = name;
            Nationality = nationality;
            
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return $"{Name}, {Nationality}";
        }

        public void AddWrittenBook(string title, long isbn, EStatus status)
        {
            var book = new Book(title, this, isbn, status);
            Books.Add(book);
        }
    }
}