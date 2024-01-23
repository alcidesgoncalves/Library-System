namespace Library
{
    public class Author
    {
        public string Name {get; set;} 
        public string? Nationality {get; set;} 
        public DateTime Birthdate {get; set;}  
        public List<Book> Books {get; set;} 
         
        public Author(string name, string? nationality, DateTime birthDate)
        {
            Name = name;
            Nationality = nationality;
            Birthdate = birthDate;
            
            Books = new List<Book>();
        }

        public override string ToString()
        {
            return $"{Name}, {Nationality}, {Birthdate}";
        }

        public void AddBook(string title, int isbn, bool status)
        {
            var book = new Book(title, this, isbn, status);
            Books.Add(book);
        }
    }
}