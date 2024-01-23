namespace Library
{
    public class Author
    {
        public  string Name {get; set;} 
        public string? Nacionality {get; set;} 
        public DateTime Birthdate {get; set;}  
        public  List<string> PublishedBooks {get; set;} 
         
        public Author(string name, string? nacionality, DateTime birthDate, List<string> publishedBooks)
        {
            Name = name;
            Nacionality = nacionality;
            Birthdate = birthDate;
            PublishedBooks = publishedBooks;
        }

        public override string ToString()
        {
            string books = "Livros Publicados: ";
            foreach (var book in PublishedBooks)
        {
            books += book + ", ";
        }

        // Remove a última vírgula e espaço
        books = books.TrimEnd(',', ' ');
            return $"{Name}, {Nacionality}, {Birthdate}, {books}";
        }

        public void AddBook(string bookName)
        {
            PublishedBooks.Add(bookName);
        }

        public void RemoveBook()
        {
            var array = PublishedBooks.Count;
            PublishedBooks.RemoveAt(array-1);
        }
    }
}