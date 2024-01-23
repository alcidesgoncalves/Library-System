
namespace Library
{
    public class Book
    {
        public required string Title {get; set;}
        public required string Author;
        public int Isbn;
        public bool Status;

        public Book(string title, string  author, int isbn, bool status)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Title}, {Author}, {Isbn}, {Status}";
        }

        //Métodos Emprestar livro, Devolver livro e Reservar livro.
    }
}